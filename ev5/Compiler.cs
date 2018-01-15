using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev5
{
    public static class Compiler
    {
        private static string FileHeader = "EV5_1";
        private static char SplitChar = '\n';
        private static List<string> globalvariables;
        public static int BlockCount = 0;
        public static string CompileFile(List<Block> blocks)
        {
            string ret = FileHeader;
            // Sort blocks on X location
            List<Block> sortedBlocks = blocks.OrderBy(o => o.Location.X).ToList();
            foreach (Block block in sortedBlocks)
            {
                // Add all blocks to file
                ret += SplitChar + block.Type.ToString() + SplitChar + block.Parameters[0] + SplitChar + block.Parameters[1];
            }
            return ret;
        }

        public static string CompileCode(List<Block> blocks)
        {
            string ret = "\r";
            List<string> variables = new List<string>();
            // Sort blocks on X location
            List<Block> sortedBlocks = blocks.OrderBy(o => o.Location.X).ToList();
            int i = 0;
            foreach (Block block in sortedBlocks)
            {
                if (block.Type == Blocktype.Disp)
                {
                    // Write first 15 characters
                    ret += "DTT" + block.Parameters[0].Substring(0, Math.Min(15, block.Parameters[0].Length)) + SplitChar;
                }
                if (block.Type == Blocktype.Move)
                {
                    // If parameter is number
                    if (int.TryParse(block.Parameters[0], out int value))
                    {
                        // Keep between limits
                        value = Math.Min(255, Math.Max(value, -255));
                        ret += "MI" + ((value >= 0) ? "+" : "-") + Math.Abs(value) + SplitChar;
                    }
                    else // It could be a variable ;)
                    {
                        string variablename = block.Parameters[0].ToLower().Trim();
                        if (variables.Exists(name => name.Equals(variablename))) // And if it actually is an variable, do as told!
                        {
                            ret += "MV" + variables.FindIndex(x => x.Equals(variablename)) + SplitChar;
                        }
                        else
                        {
                            throw new Exception("Error in block " + i + ": Unknown speed value" + block.Parameters[0]);
                        }
                    }
                }
                if (block.Type == Blocktype.Turn)
                {
                    // Get direction
                    int direction = (block.Parameters[0] == "Links") ? -1 : 1;
                    // If parameter is number
                    if (int.TryParse(block.Parameters[1], out int value))
                    {
                        // Keep between limits
                        value = Math.Min(65530, Math.Max(value, -65530));
                        if (value < 0)
                        {
                            direction *= -1;
                            value = Math.Abs(value);
                        }
                        ret += "TI" + ((direction == 1) ? "R" : "L") + value + SplitChar;
                    }
                    else // It could be a variable ;)
                    {
                        string variablename = block.Parameters[0].ToLower().Trim();
                        if (variables.Exists(name => name.Equals(variablename))) // And if it actually is an variable, do as told!
                        {
                            ret += "TV" + direction + "|" + variables.FindIndex(x => x.Equals(variablename)) + SplitChar;
                        }
                        else
                        {
                            throw new Exception("Error in block " + i + ": Unknown angle value" + block.Parameters[1]);
                        }
                    }
                }
                if (block.Type == Blocktype.Stop)
                {
                    // Just set speed to 0
                    ret += "STP" + SplitChar;
                }
                if (block.Type == Blocktype.Wait)
                {
                    // If parameter is number
                    if (int.TryParse(block.Parameters[0], out int value))
                    {
                        // Keep between limits
                        value = Math.Min(65530, Math.Max(value, -65530));
                        ret += "WIM" + value + SplitChar;
                    }
                    else // It could be a variable ;)
                    {
                        string variablename = block.Parameters[0].ToLower().Trim();
                        if (variables.Exists(name => name.Equals(variablename))) // And if it actually is an variable, do as told!
                        {
                            ret += "WV" + variables.FindIndex(x => x.Equals(variablename)) + SplitChar;
                        }
                        else
                        {
                            throw new Exception("Error in block " + i + ": Unknown delay value " + block.Parameters[0]);
                        }
                    }
                }
                if (block.Type == Blocktype.Beep)
                {
                    if (int.TryParse(block.Parameters[1], out int value))
                    {
                        ret += "BP" + DecodeTone(block.Parameters[0]) + "" + value + SplitChar;
                    }
                    else
                    {
                        throw new Exception("Error in block " + i + ": Unknown delay value " + block.Parameters[1] + ". Keep in mind that parameters are not supported for beep delay");
                    }
                }
                if (block.Type == Blocktype.Var)
                {
                    // If variable doesn't exist yet
                    if (!variables.Exists(name => name.Equals(block.Parameters[0].ToLower())))
                    {
                        variables.Add(block.Parameters[0].ToLower());
                    }
                    if (variables.Count > 32)
                    {
                        throw new Exception("Error in block " + i + ": Trying to use more than 32 variables");
                    }
                    if (int.TryParse(block.Parameters[1], out int value))
                    {
                        ret += "VS" + variables.FindIndex(x => x.Equals(block.Parameters[0].ToLower())) + "|" + value + SplitChar;
                    }
                    else
                    {
                        string variablename = block.Parameters[1].ToLower().Trim();
                        if (variables.Exists(name => name.Equals(variablename))) // And if it actually is an variable, do as told!
                        {
                            ret += "VV" + variables.FindIndex(x => x.Equals(block.Parameters[0])) + "|" + variables.FindIndex(x => x.Equals(variablename)) + SplitChar;
                        }
                        else
                        {
                            throw new Exception("Error in block " + i + ": Tried setting variable to " + variablename + ". Does it even exist?");
                        }
                    }
                }
                i++;
            }
            return ret + "\a";
        }

        public static List<Block> DecompileFile(string file, bool forceParse = false)
        {
            List<Block> ret = new List<Block>();
            // Split file in parts
            List<string> partslist = file.Split(SplitChar).ToList();
            partslist.RemoveAt(partslist.Count - 1);
            string[] parts = partslist.ToArray();
            if (parts.Length > 0) // No need to even read the file if it is empty
            {
                if ((parts.Length - 1) % 3 == 0) // If amount of parts is correct
                {
                    if (parts[0] == FileHeader || forceParse) // Check file header correct
                    {
                        for (int i = 1; i < parts.Length; i += 3)
                        {
                            // Try parse block type
                            if (Enum.TryParse<Blocktype>(parts[i], out Blocktype blocktype))
                            {
                                // Add new block of blocktype blocktype with parameters on correct location to the return list
                                Block block = new Block(blocktype);
                                block.SetParameter(1, parts[i + 1]);
                                block.SetParameter(2, parts[i + 2]);
                                int x = (i - 1) / 3 * 120;
                                block.Location = new System.Drawing.Point(x, 320);
                                ret.Add(block);
                            }
                            else
                            {
                                throw new Exception("Onbekend bloktype gevonden op lijn " + i);
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("File header not correct. Out of date file?");
                    }
                }
                else
                {
                    throw new Exception("File line count is not right. Could not load file");
                }
            }
            return ret;
        }

        public static void SetGlobalVariables(List<Block> blocks)
        {
            globalvariables = new List<string>();
            foreach (Block block in blocks)
            {
                if (block.Type == Blocktype.Var)
                {
                    // If variable doesn't exist yet
                    if (!globalvariables.Exists(name => name.Equals(block.Parameters[0].ToLower())))
                    {
                        globalvariables.Add(block.Parameters[0].ToLower());
                    }
                }
            }
            BlockCount = blocks.Count;
        }

        public static List<string> GetGlobalVariables()
        {
            if (globalvariables != null)
            {
                return globalvariables;
            }
            return new List<string>();
        }

        private static string DecodeTone(string tone)
        {
            switch(tone)
            {
                case "A#": return "a";
                case "C#": return "c";
                case "D#": return "d";
                case "G#": return "g";
            }
            return tone;
        }
    }
}
