namespace MorrowindLib
{
    using System.IO;

    static class RecordReader
    {
        public static Record ReadRecord(BinaryReader br)
        {
            var name = new string(br.ReadChars(4));
            var size = br.ReadInt32();
            br.ReadInt32(); // Skip unknown value
            var flags = br.ReadInt32();
            var blob = br.ReadBytes(size);

            return new Record(name, flags, blob);
        }

        public static SubRecord ReadSubRecord(BinaryReader br)
        {
            var name = new string(br.ReadChars(4));
            var size = br.ReadInt32();
            var blob = br.ReadBytes(size);

            return new SubRecord(name, blob);
        }
    }
}
