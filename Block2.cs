using static Program;

namespace Meat_Cleaver
{
    public class Block2
    {
        public readonly int start = br.ReadInt32();
        public readonly int size = br.ReadInt32();
        readonly int parentFolder = br.ReadInt32();
        public static List<Block2> ReadBlock2()
        {
            List<Block2> blocks = [];
            int size = br.ReadInt32();
            for (int i = 0; i < size; i++)
                blocks.Add(new Block2());

            return blocks;
        }
    }
}