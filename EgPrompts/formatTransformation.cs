using System;
using System.IO;
using System.Text;

public static void FormatTransformation(string csvFilePath, string outputFormat)
{
    // Read the CSV file
    var lines = File.ReadAllLines(csvFilePath);

    // Create a StringBuilder to store the output
    var sb = new StringBuilder();

    // Check the output format
    if (outputFormat == "JSON")
    {
        // Add the opening bracket for JSON
        sb.Append("[");

        // Iterate through each line in the CSV file
        foreach (var line in lines)
        {
            // Split the line into an array of strings
            var values = line.Split(',');

            // Append the opening brace for the object
            sb.Append("{");

            // Iterate through each value in the line
            for (int i = 0; i < values.Length; i++)
            {
                // Append the key-value pair
                sb.Append($"\"{i}\": \"{values[i]}\"");

                // If this is not the last value, append a comma
                if (i != values.Length - 1)
                    sb.Append(",");
            }

            // Append the closing brace for the object
            sb.Append("},");
        }

        // Remove the trailing comma
        sb.Remove(sb.Length - 1, 1);

        // Add the closing bracket for JSON
        sb.Append("]");
    }
    else if (outputFormat == "XML")
    {
        // Add the opening tag for XML
        sb.Append("<root>");

        // Iterate through each line in the CSV file
        foreach (var line in lines)
        {
            // Split the line into an array of strings
            var values = line.Split(',');

            // Append the opening tag for the object
            sb.Append("<object>");

            // Iterate through each value in the line
            for (int i = 0; i < values.Length; i++)
            {
                // Append the key-value pair
                sb.Append($"<key name=\"{i}\">{values[i]}</key>");
            }

            // Append the closing tag for the object
            sb.Append("</object>");
        }

        // Add the closing tag for XML
        sb.Append("</root>");
    }

    // Write the output to a file
    File.WriteAllText("output.txt", sb.ToString());
}