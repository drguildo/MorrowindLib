namespace MorrowindLib
{
    using System;

    public class BaseRecord
    {
        public string Name { get; }
        public Int32 Size { get; }

        public BaseRecord(string name, Int32 size)
        {
            if (name.Length != 4)
            {
                throw new ArgumentException($"Record name length is {name.Length}, not 4");
            }

            this.Name = name;
            this.Size = size;
        }

        public override string ToString()
        {
            return $"NAME: {Name}, LENGTH: {Size}";
        }
    }
}