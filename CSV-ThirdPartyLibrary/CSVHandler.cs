using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace ThirdPartyLibraryLive
{
    class CSVHandler
    {
      
        public static void ImplementReadWriteCSVFile()
        {
            string inputFilePath = @"C:\Users\Snehil\source\repos\ThirdPartyLibraryLive\Utility\address.csv";
            string exportFilePath = @"C:\Users\Snehil\source\repos\ThirdPartyLibraryLive\Utility\export.csv";
           // string exportFilePath = @"C:\Users\Snehil\source\repos\ThirdPartyLibraryLive\Utility\address.json";
            using(var reader = new StreamReader(inputFilePath))
            using(var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                ////Reading and Printing a CSV file
                //Console.WriteLine("Read inputFilepath Successfully");
                //foreach(AddressData obj in records)
                //{
                //    Console.WriteLine(obj.Name);
                //    Console.WriteLine(obj.Email);
                //    Console.WriteLine(obj.Country);
                //}

                //Reading from one csv and writing to other
                //Console.WriteLine("importing data from one csv to another csv");
                //using (var writer = new StreamWriter(exportFilePath))
                //using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                //{
                //    csvExport.WriteRecords(records);
                //}

            }
        }

        public static void ImplementCSVtoJSON()
        {
            //json
            string inputFilePath = @"C:\Users\Snehil\source\repos\ThirdPartyLibraryLive\Utility\address.csv";
            string exportFilePath = @"C:\Users\Snehil\source\repos\ThirdPartyLibraryLive\Utility\address.json";
            var csv = new List<string[]>();
            var lines = File.ReadAllLines(inputFilePath);
            foreach (string line in lines)
            {
                csv.Add(line.Split(','));
            }
            var properties = lines[0].Split(',');
            var listObjResult = new List<Dictionary<string, string>>();

            for (int i = 1; i < lines.Length; i++)
            {
                var objResult = new Dictionary<string, string>();
                for (int j = 0; j < properties.Length; j++)
                    objResult.Add(properties[j], csv[i][j]);

                listObjResult.Add(objResult);
            }

            string jsonData = JsonConvert.SerializeObject(listObjResult);
            Console.WriteLine(jsonData);

            File.WriteAllText(exportFilePath, jsonData);
        }
        
        public static void Deseialization()
        {
            string inputPath = @"C:\Users\Snehil\source\repos\ThirdPartyLibraryLive\Utility\address.json";
            string outPath = @"C:\Users\Snehil\source\repos\ThirdPartyLibraryLive\Utility\address.csv";
            IList<AddressData> list = JsonConvert.DeserializeObject<IList<AddressData>>(File.ReadAllText(inputPath));
            using (var writer = new StreamWriter(outPath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(list);
            }
        }
    }
}
