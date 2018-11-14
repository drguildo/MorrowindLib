namespace MorrowindConsole
{
    using System;

    using MorrowindLib;

    internal static class Program
    {
        private static void Main()
        {
            var esm = new ESM(@"C:\Program Files (x86)\Steam\SteamApps\common\Morrowind\Data Files\Morrowind.esm");
            Console.WriteLine($"Loaded {esm.Records.Count} records");
            foreach (var record in esm.Records)
            {
                Console.WriteLine($"{record.Name} has {record.SubRecords.Count} sub-records");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}