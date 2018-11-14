namespace MorrowindLib
{
    using System;
    using System.Collections.Generic;

    public class Record : BaseRecord
    {
        public bool Blocked { get; }
        public bool Persistent { get; }

        public List<SubRecord> SubRecords { get; }

        public Record(string name, Int32 flags, byte[] blob) : base(name, blob.Length)
        {
            this.SubRecords = new List<SubRecord>();
            this.Blocked = (flags & 0x00002000) != 0;
            this.Persistent = (flags & 0x00000400) != 0;
        }
    }
}