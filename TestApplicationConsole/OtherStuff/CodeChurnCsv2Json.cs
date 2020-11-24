using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web.Script.Serialization;
using System.Threading.Tasks;

namespace TestApplicationConsole
{
    /// <summary>
    /// Für BA; CodeChurn.txt (csv) nach CodeChurn.json (json)
    /// </summary>
    class CodeChurnCsv2Json
    {
        public void Run(string radarMetricsShare)
        {
            var csvTypeMetrics = new StreamReader(radarMetricsShare)
                                 .ReadToEnd()
                                 .Replace(Environment.NewLine, ":")
                                 .Split(':');

            csvTypeMetrics = csvTypeMetrics.Skip(1).ToArray();

            var nameSpcMetrics = new List<TypeMetrics>();
            var typeMetricsDict = new List<JsonOutput>();
            string archDomain = string.Empty;

            foreach (var line in csvTypeMetrics)
            {
                var splittedLine = line.Split('|');

                if (archDomain == string.Empty)
                {
                    archDomain = splittedLine[0].Split('.')[0];

                    nameSpcMetrics.Add(FillTypeMetrics(splittedLine));
                }
                else
                {
                    if (archDomain == splittedLine[0].Split('.')[0])
                    {
                        nameSpcMetrics.Add(FillTypeMetrics(splittedLine));
                    }
                    else
                    {
                        typeMetricsDict.Add(new JsonOutput(archDomain, nameSpcMetrics));
                        nameSpcMetrics = new List<TypeMetrics>();

                        archDomain = splittedLine[0].Split('.')[0];

                        nameSpcMetrics.Add(FillTypeMetrics(splittedLine));
                    }
                }
            }

            var outuputDictionary = new Dictionary<string, List<JsonOutput>>();
            outuputDictionary.Add("children", typeMetricsDict);
            var jsonSerialiser = new JavaScriptSerializer();
            var json = jsonSerialiser.Serialize(outuputDictionary);

            json = json.TrimEnd(']').TrimStart('[');

            try
            {
                System.IO.File.WriteAllText(radarMetricsShare.Replace(".txt", ".json"), json);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.StackTrace);
                //Stacktrace ausgeben
            }
        }

        private TypeMetrics FillTypeMetrics(string[] splittedLine)
        {
            TypeMetrics tmpMetrics = new TypeMetrics();

            if (splittedLine[0].IndexOf('.') != -1)
            {
                tmpMetrics.BbName = splittedLine[0].Split('.')[1];

                if (float.TryParse(splittedLine[1], out var value) && !splittedLine[1].Contains("NaN"))
                    tmpMetrics.HotSpot = value;
                else
                    tmpMetrics.HotSpot = 0;

                if (float.TryParse(splittedLine[2], out value) && !splittedLine[2].Contains("NaN"))
                    tmpMetrics.RefIndex = value;
                else
                    tmpMetrics.RefIndex = 0;

                if (float.TryParse(splittedLine[3], out value) && !splittedLine[3].Contains("NaN"))
                    tmpMetrics.LoC = value;
                else
                    tmpMetrics.LoC = 0;

                if (float.TryParse(splittedLine[4], out value) && !splittedLine[4].Contains("NaN"))
                    tmpMetrics.TestedLoC = value;
                else
                    tmpMetrics.TestedLoC = 0;

                if (float.TryParse(splittedLine[5], out value) && !splittedLine[5].Contains("NaN"))
                    tmpMetrics.Types = value;
                else
                    tmpMetrics.Types = 0;

                if (float.TryParse(splittedLine[6], out value) && !splittedLine[6].Contains("NaN"))
                    tmpMetrics.Cc = value;
                else
                    tmpMetrics.Cc = 0;

                if (float.TryParse(splittedLine[7], out value) && !splittedLine[7].Contains("NaN"))
                    tmpMetrics.Ac = value;
                else
                    tmpMetrics.Ac = 0;

                if (float.TryParse(splittedLine[8], out value) && !splittedLine[8].Contains("NaN"))
                    tmpMetrics.Ec = value;
                else
                    tmpMetrics.Ec = 0;

                if (float.TryParse(splittedLine[9], out value) && !splittedLine[9].Contains("NaN"))
                    tmpMetrics.Changes = value;
                else
                    tmpMetrics.Changes = 0;

                if (float.TryParse(splittedLine[10], out value) && !splittedLine[10].Contains("NaN"))
                    tmpMetrics.Defects = value;
                else
                    tmpMetrics.Defects = 0;

                if (float.TryParse(splittedLine[11], out value) && !splittedLine[11].Contains("NaN"))
                    tmpMetrics.WDefects = value;
                else
                    tmpMetrics.WDefects = 0;

                if (float.TryParse(splittedLine[12], out value) && !splittedLine[12].Contains("NaN"))
                    tmpMetrics.Coverage = value;
                else
                    tmpMetrics.Coverage = 0;

                if (float.TryParse(splittedLine[13], out value) && !splittedLine[13].Contains("NaN"))
                    tmpMetrics.TestDev = value;
                else
                    tmpMetrics.TestDev = 0;

                if (float.TryParse(splittedLine[14], out value) && !splittedLine[14].Contains("NaN"))
                    tmpMetrics.CcDev = value;
                else
                    tmpMetrics.CcDev = 0;

                if (float.TryParse(splittedLine[15], out value) && !splittedLine[15].Contains("NaN"))
                    tmpMetrics.ChangeDev = value;
                else
                    tmpMetrics.ChangeDev = 0;

                if (float.TryParse(splittedLine[16], out value) && !splittedLine[16].Contains("NaN"))
                    tmpMetrics.DefDev = value;
                else
                    tmpMetrics.Defects = 0;
            }
            else
            {
                tmpMetrics.BbName = "Error reading bbName";
            }

            return tmpMetrics;
        }
    }

    internal class JsonOutput
    {
        public string ArchDomain { get; set; }

        public List<TypeMetrics> children { get; set; }

        public JsonOutput(string archDomain, List<TypeMetrics> typeMetrics)
        {
            ArchDomain = archDomain;
            children = typeMetrics;
        }
    }

    internal class TypeMetrics
    {
        public string BbName { get; set; }
        public float HotSpot { get; set; }
        public float RefIndex { get; set; }
        public float LoC { get; set; }
        public float TestedLoC { get; set; }
        public float Types { get; set; }
        public float Cc { get; set; }
        public float Ac { get; set; }
        public float Ec { get; set; }
        public float Changes { get; set; }
        public float Defects { get; set; }
        public float WDefects { get; set; }
        public float Coverage { get; set; }
        public float TestDev { get; set; }
        public float CcDev { get; set; }
        public float ChangeDev { get; set; }
        public float DefDev { get; set; }
    }
}