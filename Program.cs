using Meat_Cleaver;

public static class Program
{
    public static BinaryReader br;
    private static void Main(string[] args)
    {
        br = new BinaryReader(File.OpenRead(args[0]));
        List<Block1> block1 = Block1.ReadBlock1();
        List<Block2> block2 = Block2.ReadBlock2();
        br.ReadInt32();
        br.ReadInt32();
        List<string> table = StringTable.Table(block1.Count + block2.Count);

        for (int i = 0; i < block1.Count; i++)
            Directory.CreateDirectory(Path.GetDirectoryName(args[0]) + "//" + Path.GetFileNameWithoutExtension(args[0]) + "//" + table[i]);

        for (int i = 0; i < block2.Count; i++)
        {
            br.BaseStream.Position = block2[i].start;
            BinaryWriter bw = new(File.Create(Path.GetDirectoryName(args[0]) + "//" + Path.GetFileNameWithoutExtension(args[0]) + "//" + table[i + block1.Count]));
            bw.Write(br.ReadBytes(block2[i].size));
            bw.Close();
        }
    }
}