using System;
using System.IO;

namespace ReadingAFiile
{
    class Program
    {
        static void Main(string[] args)
        {
            //***********Reading From a text File*********
            //**********1st Method************************
            string[] fileText = File.ReadAllLines(@"C:\Users\Snehil\source\repos\ReadingAFiile\log.txt");
            foreach (string line in fileText)
            {
                Console.WriteLine(line);
            }


            //**********2nd Method************************
            /*
            using StreamReader file = new StreamReader(@"C:\Users\Snehil\source\repos\ReadingAFiile\log.txt");
            int countLines = 0;
            string line;
            while((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                countLines++;
            }
            file.Close();
            Console.WriteLine("No. Of Lines in txt file : "+countLines);
            */



            //**********Writing To Text  File************************
            //**********1st Method************************
            string[] text = { "This a line", "This is another Line" };
            File.WriteAllLines(@"C:\Users\Snehil\source\repos\ReadingAFiile\log.txt", text);
            File.AppendAllLines(@"C:\Users\Snehil\source\repos\ReadingAFiile\log.txt", text);


            //**********2nd Method************************
            //using StreamWriter writer = new StreamWriter(@"C:\Users\Snehil\source\repos\ReadingAFiile\log.txt", true); //true if want to append to existing text
            //writer.WriteLine("This is a Line");
            //writer.WriteLine("This is a Line");
            //writer.WriteLine("This is a Line");
        }
    }
}
