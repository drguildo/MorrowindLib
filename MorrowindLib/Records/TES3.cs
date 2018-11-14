namespace MorrowindLib.Records
{
    using System;
    using System.IO;

    internal class TES3 : Record
    {
        public TES3(int flags, byte[] blob) : base(nameof(TES3), flags, blob)
        {
        }
    }

    internal class HEDR : SubRecord
    {
        public float Version { get; }
        public string Company { get; }
        public string Description { get; }
        public Int32 NumRecords { get; }

        public HEDR(byte[] blob) : base(nameof(HEDR), blob)
        {
            using (var br = new BinaryReader(new MemoryStream(blob)))
            {
                Version = br.ReadSingle();
                br.ReadInt32(); // Skip unknown value
                Company = new string(br.ReadChars(32));
                Description = new string(br.ReadChars(256));
                NumRecords = br.ReadInt32();
            }
        }
    }
}