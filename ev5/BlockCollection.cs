using System.Collections.Generic;

namespace ev5
{
    sealed class BlockCollection
    {
        private List<Block> collection;
        
        public List<Block> Collection
        {
            get { return collection; }
        }

        public string Compile()
        {
            string command = "#";

            foreach (Block block in collection)
            {
                command += block;
            }

            command += "%";

            return command;
        }

        public void AddBlock(Block block)
        {
            collection.Add(block);
        }

        public BlockCollection()
        {
            collection = new List<Block>();
        }
    }
}
