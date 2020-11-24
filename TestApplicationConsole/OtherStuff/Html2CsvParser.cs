using System;
using System.Collections.Generic;
using HtmlAgilityPack;
using System.IO;

namespace TestApplicationConsole
{
    /// <summary>
    /// BAD code! REFACTOR!
    /// </summary>
    class Html2CsvParser
    {
        public void parseHtmlFile(string filePath = @"D:\Arbeit\BACHELORARBEIT\overview.html")
        {
            List<string> BbNames = new List<string>();
            List<string> covered = new List<string>();
            List<string> uncovered = new List<string>();

            var readerHtmlFile = new StreamReader(filePath);
            var stringHtmlFile = readerHtmlFile.ReadToEnd().ToString() ;
            stringHtmlFile = stringHtmlFile.Replace(System.Environment.NewLine, "").Replace("\t", "");
            
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(stringHtmlFile);

            var htmlNodeCollection = htmlDocument.DocumentNode.SelectNodes("//tbody");

            foreach(var node in htmlNodeCollection)
            {
                if (node.HasChildNodes == true && node.Name == "tbody")
                {
                    var neu = node.ChildNodes;
                    if(neu[0].HasChildNodes == true)
                    {
                        var neu2 = neu[0].ChildNodes;
                        if(neu2[0].HasChildNodes == true && neu2.Count > 2)
                        {
                            BbNames.Add(neu2[0].InnerText);
                            covered.Add(neu2[1].InnerText);
                            uncovered.Add(neu2[2].InnerText);
                        }
                    }
                }
            }
            write2Csv(@"D:\BMED\7._Semester\BACHELORARBEIT\overview.csv", BbNames, covered, uncovered);
        }
        public void write2Csv(string csvFile, List<string> BbNames, List<string> covered, List<string> uncovered)
        {
            StreamWriter swCsvFile = new StreamWriter(csvFile);

            for(int x = 0; x < BbNames.Count; x++) {
                swCsvFile.WriteLine(String.Concat(BbNames[x], ",", covered[x], ",", uncovered[x]));
            }
        }
    }
}
