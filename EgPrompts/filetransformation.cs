// file transformation from csv to JSON/XML

using System;
using System.Collections.Generic;
using System.Xml.Linq;
using CsvHelper;
using Newtonsoft.Json;
using System.IO
namespace CsvLibrary
{
    public class CsvParser : IParser
    {
        private static void Main(string[] args)
        {
            var config = new CsvParser();
            config.Parse(args);
            config.Run();
            Console.ReadLine(
                "
                Press any key to exit.";
            );


        }
    }
}