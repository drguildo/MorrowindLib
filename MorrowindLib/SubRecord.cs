namespace MorrowindLib
{
    public class SubRecord : BaseRecord
    {
        public SubRecord(string name, byte[] blob) : base(name, blob.Length)
        {
        }
    }
}