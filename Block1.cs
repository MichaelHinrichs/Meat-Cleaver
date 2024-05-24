using static Program;

namespace Meat_Cleaver
{
    public class Block1
    {
        readonly int entryNumber = br.ReadInt32();
        readonly int fileCount = br.ReadInt32();
        public static List<Block1> ReadBlock1()
        {
            List<Block1> blocks = [];
            int size = br.ReadInt32();
            for (int i = 0; i < size; i++)
                blocks.Add(new Block1());

            return blocks;
        }
    }
}
