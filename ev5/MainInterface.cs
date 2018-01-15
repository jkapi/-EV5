using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ev5
{
    public partial class MainInterface : Form
    {
        bool draggingBlock;
        Block dragBlock;
        Point dragStartPosition;
        Point blockOffset = new Point(-1, -1);
        Point blockStartOffset = new Point(-1, -1);
        bool blockOffsetDrag = false;

        File_handling file = new File_handling();
        RP6Connection rp6 = new RP6Connection();

        List<Block> blockList = new List<Block>();

        string username = "";

        [DllImport("user32.dll")]
        private static extern long LockWindowUpdate(IntPtr Handle);

        public MainInterface()
        {
            InitializeComponent();

            // Fullscreen 
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            // Force double buffering on EVERYTHING
            CreateParams handleParam = base.CreateParams;
            handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED

            UpdateStyles();
        }

        public MainInterface(string username)
        {
            InitializeComponent();

            // Fullscreen 
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            // Force double buffering on EVERYTHING
            CreateParams handleParam = base.CreateParams;
            handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED

            UpdateStyles();

            this.username = username;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Suspend layout, makes moving everything a little less laggy
            panelWorkspace.SuspendLayout();
            // Lock window to stop paint events from happening in function.
            // Removes /Some/ graphical artifacts, not perfect though
            LockWindowUpdate(this.Handle);
            if (draggingBlock == true)
            {
                // Only drag if moved a bit, not just for clicking.
                if (distanceBetweenPoints(Cursor.Position, dragStartPosition) > 10)
                {
                    dragBlock.Location = Cursor.Position;
                    dragBlock.BringToFront(); // Bring to top
                    dragBlock.Invalidate();
                    if (MouseButtons != MouseButtons.Left) // If mouse up
                    {
                        if (dragBlock.Location.Y < Size.Height - 320)
                        {
                            draggingBlock = false;
                            bool moveOver = false;
                            // Sort all blocks on X location ascending
                            List<Block> SortedList = blockList.OrderBy(o => o.Location.X).ToList();
                            int lastX = 0;
                            foreach (Block block in SortedList)
                            {
                                if (block != dragBlock)
                                {
                                    // If between 2 blocks, start moving over all blocks after this one
                                    if (dragBlock.Location.X <= block.Location.X + 60 && dragBlock.Location.X >= block.Location.X - 59)
                                    {
                                        moveOver = true;
                                        lastX = block.Location.X;
                                    }
                                    if (moveOver)
                                    {
                                        if (block.Location.X <= lastX + 120)
                                        {
                                            block.Location = new Point(block.Location.X + 120, block.Location.Y);
                                            lastX = block.Location.X;
                                        }
                                    }
                                }
                            }
                            // Put block on location
                            int blockFixOffsetX = blockOffset.X % 120;
                            int blockFixOffsetY = blockOffset.Y;
                            dragBlock.Location = new Point((int)(Math.Round(((double)dragBlock.Location.X - blockFixOffsetX) / 120.0) * 120.0) + blockFixOffsetX, 320 + blockFixOffsetY);
                            // Add to the workspace
                            if (!blockList.Contains(dragBlock))
                            {
                                dragBlock.MouseDown += Block_MouseDown;
                                blockList.Add(dragBlock);
                                Controls.Remove(dragBlock);
                                panelWorkspace.Controls.Add(dragBlock);

                            }
                        }
                        else // Not inside workspace
                        {
                            panelWorkspace.Controls.Remove(dragBlock);
                            if (blockList.Contains(dragBlock))
                            {
                                blockList.Remove(dragBlock);
                            }
                            dragBlock.Dispose();
                        }
                    }
                }
            }
            if (MouseButtons == MouseButtons.Right)
            {
                if (blockOffsetDrag == false)
                {
                    dragStartPosition = Cursor.Position;
                    blockStartOffset = blockOffset;
                    blockOffsetDrag = true;
                }
                Point offset = new Point(Cursor.Position.X - dragStartPosition.X, Cursor.Position.Y - dragStartPosition.Y);
                Point oldBlockOffset = blockOffset;
                // Move all blocks to new offset position, while keeping it between Y boundaries
                blockOffset = new Point(blockStartOffset.X + offset.X, Math.Max(Math.Min(blockStartOffset.Y + offset.Y, Size.Height - 800), -321));
                foreach (Block block in blockList)
                {
                    block.Location = new Point(block.Location.X - oldBlockOffset.X + blockOffset.X, block.Location.Y - oldBlockOffset.Y + blockOffset.Y);
                }
            }
            else
            {
                blockOffsetDrag = false;
            }
            // Unlock window and resume
            LockWindowUpdate(IntPtr.Zero);
            panelWorkspace.ResumeLayout();
            Compiler.SetGlobalVariables(blockList);
        }

        private void Block_MouseDown(object sender, MouseEventArgs e)
        {
            dragStartPosition = Cursor.Position;
            dragBlock = ((Block)sender);
            draggingBlock = true;
        }

        private int distanceBetweenPoints(Point p1, Point p2)
        {
            int dX = p1.X - p2.X;
            int dY = p1.Y - p2.Y;
            return (int)Math.Sqrt(dX * dX + dY * dY);
        }

        private void MainInterface_Load(object sender, EventArgs e)
        {
            // Zet alles op z'n plaats
            panelWorkspace.Size = new Size(Size.Width, Size.Height - 320);
            panelUI.Location = new Point(0, Size.Height - 320);
            panelUI.Size = new Size(Size.Width, 320);
            tabControlBlocks.Size = new Size(Size.Width, 220);
            pictureBoxEV5.Location = new Point(Size.Width - 97, 222);

            // onderhoudt constant de rp6 connectie zonder de rest van de form controls in de weg te zitten
            Thread connectionthread = new Thread(new ThreadStart(rp6.Setup));
            connectionthread.IsBackground = true;
            connectionthread.Start();
        }

        private void blockChoose_MouseDown(object sender, MouseEventArgs e)
        {
            dragStartPosition = Cursor.Position;
            dragBlock = new Block(((Block)sender).Type);
            Controls.Add(dragBlock);
            draggingBlock = true;
        }

        private void MainInterface_KeyDown(object sender, KeyEventArgs e)
        {
            // shortcut keys
            //
            //  Ctrl + S: save file
            //  Ctrl + Shift + S: save as
            //  Ctrl + O: open file
            //  Ctrl + N: new file
            //  Ctrl + C: Compile
            if (e.KeyCode == Keys.S && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                file.SaveFile(Compiler.CompileFile(blockList));
            }
            if (e.KeyCode == Keys.O && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                buttonFileOpen_Click();
            }
            if (e.KeyCode == Keys.N && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                NewWorkspace();

                file.Currentfile = "";
            }
            if (e.KeyCode == Keys.C && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                buttonCompile_Click();
            }
            if ((ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                if ((ModifierKeys & Keys.Control) == Keys.Control)
                {
                    if (e.KeyCode == Keys.S)
                    {
                        file.SaveAs(Compiler.CompileFile(blockList));
                    }
                }
            }

        }

        private void NewWorkspace()
        {
            // Remove all blocks from everywhere
            foreach (Block block in blockList)
            {
                if (Controls.Contains(block)) { Controls.Remove(block); }
                if (panelWorkspace.Controls.Contains(block)) { panelWorkspace.Controls.Remove(block); }
            }
            blockList.Clear();

            // Reset workspace offset
            blockOffset = new Point(-1, -1);
            blockStartOffset = new Point(-1, -1);
        }

        private void buttonFileNew_Click(object sender, EventArgs e)
        {
            NewWorkspace();
            file.Currentfile = "";
        }

        private void buttonFileSave_Click(object sender, EventArgs e)
        {
            file.SaveFile(Compiler.CompileFile(blockList));
        }

        private void buttonFileOpen_Click(object sender = null, object e = null)
        {
            NewWorkspace();
            try
            {
                blockList = Compiler.DecompileFile(file.OpenFile());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (Block block in blockList)
            {
                panelWorkspace.Controls.Add(block);
            }
        }

        private void buttonCompile_Click(object sender = null, object e = null)
        {
            try
            {
                string data = Compiler.CompileCode(blockList);
                while (data.Length > 0)
                {
                    string part = data.Substring(0, Math.Min(16, data.Length));
                    rp6.sPort.Write(part);
                    Thread.Sleep(150);
                    data = data.Substring(Math.Min(data.Length, 16));
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Rp6 not connected.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFileSaveAs_Click(object sender, EventArgs e)
        {
            file.SaveAs(Compiler.CompileFile(blockList));
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            Downloadpage dlPage = new Downloadpage();
            dlPage.SelectedProject += DlPage_SelectedProject;
        }

        private void DlPage_SelectedProject(object sender, UserProject e)
        {
            NewWorkspace();
            try
            {
                blockList = Compiler.DecompileFile(e.Content);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (Block block in blockList)
            {
                panelWorkspace.Controls.Add(block);
            }
        }
    }
}
