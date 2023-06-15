using System;
using System.Net;
using System.IO;

string fileName = "myFile.txt";
string filePath = @"C:\myFolder\myFile.txt";
string sharepointUrl = "https://example.sharepoint.com/sites/mysite/Shared%20Documents/";

// Create a PUT Web request to upload the file
HttpWebRequest request = (HttpWebRequest)WebRequest.Create(sharepointUrl + fileName);
request.Method = "PUT";
request.ContentType = "application/octet-stream";

// Read the file data and write it to the request stream
byte[] buffer = new byte[4096];
int bytesRead = 0;

using (FileStream fs = File.OpenRead(filePath))
{
    using (Stream requestStream = request.GetRequestStream())
    {
        while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) != 0)
        {
            requestStream.Write(buffer, 0, bytesRead);
        }
    }
}

// Get the response from SharePoint
HttpWebResponse response = (HttpWebResponse)request.GetResponse();