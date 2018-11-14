namespace MorrowindLib
{
    using System.Collections.Generic;
    using System.IO;

    public class ESM
    {
        public List<Record> Records { get; }

        public ESM(string esmPath)
        {
            Records = new List<Record>();

            var f = new FileInfo(esmPath);
            using (var br = new BinaryReader(f.OpenRead()))
            {
                while (br.BaseStream.Position <= br.BaseStream.Length)
                {
                    var record = RecordReader.ReadRecord(br);
                    Records.Add(record);
                }
            }
        }
    }
}