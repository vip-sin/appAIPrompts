using System;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Xml.Serialization;

public class Program
{
    public static void Main()
    {
        // Read the CSV file
        string[] lines = File.ReadAllLines("input.csv");

        // Get the headers
        string[] headers = lines[0].Split(',');

        // Create a list of objects
        var records = new List<Dictionary<string, string>>();

        // Iterate over the lines
        for (int i = 1; i < lines.Length; i++)
        {
            string[] values = lines[i].Split(',');
            Dictionary<string, string> record = new Dictionary<string, string>();
            for (int j = 0; j < headers.Length; j++)
            {
                record.Add(headers[j], values[j]);
            }
            records.Add(record);
        }

        // Convert to JSON
        string json = JsonConvert.SerializeObject(records, Formatting.Indented);
        Console.WriteLine(json);

        // Convert to XML
        XmlSerializer serializer = new XmlSerializer(records.GetType());
        using (StringWriter writer = new StringWriter())
        {
            serializer.Serialize(writer, records);
            string xml = writer.ToString();
            Console.WriteLine(xml);
        }
    }
}