using System;
using System.IO;
using System.Linq;

namespace FileCreator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfGuids;
            int.TryParse(args.FirstOrDefault() ?? "1", out numberOfGuids);
            using (StreamWriter file = new StreamWriter(File.Create("file.txt")))
            {
                for (var i = 0; i < numberOfGuids; i++)
                {
                    file.WriteLine("{0}", Guid.NewGuid());
                }
            }
        }
    }
}
