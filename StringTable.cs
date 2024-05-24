using static Program;

namespace Meat_Cleaver
{
    static public class StringTable
    {
        public static List<string> Table(int count)
        {
            List<string> table = [];

            for (int i = 0; i < count; i++)
                table.Add(NullTerminatedString());
            return table;
        }

        static string NullTerminatedString()
        {
            char[] fileName = [];
            char readchar = (char)1;
            while (readchar > 0)
            {
                readchar = br.ReadChar();
                Array.Resize(ref fileName, fileName.Length + 1);
                fileName[^1] = readchar;
            }
            Array.Resize(ref fileName, fileName.Length - 1);
            return new(fileName);
        }
    }
}
