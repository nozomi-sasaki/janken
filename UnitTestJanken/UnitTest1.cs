using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System.Collections.Generic;

namespace UnitTestJanken
{
    [TestClass]
    public class UnitTest1

    {
        [TestMethod()]
        public void MainTest()
        {
            TestOutPutEqual("Input.txt", "Output.txt", "Outputmodel.txt");
        }

        public void TestOutPutEqual(string inputFileName, string outputFileName, string outputmodelFileName)
        {
            string inputFilepath = Path.Combine(@"C:\Users\nozomi.sasaki\source\repos\UnitTestJanken\bin\Debug\Input.txt");
            string outputFilepath = Path.Combine(@"C:\Users\nozomi.sasaki\source\repos\UnitTestJanken\bin\Debug\Output.txt");
            string outputmodelFilepath = Path.Combine(@"C:\Users\nozomi.sasaki\source\repos\UnitTestJanken\bin\Debug\Outputmodel.txt");

            using (FileStream fileStream = new FileStream(outputFileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {

                using (StreamReader input = new StreamReader(inputFileName))
                {
                    Console.SetIn(input);

                    Program.Main();

                    //Console.WriteLine(FileCompare(outputFileName, outputmodelFileName));
                }

            }
        }


        //private bool FileCompare(string file1, string file2)
        //{
        //    if (file1 == file2)
        //    {
        //        return true;
        //    }

        //    FileStream fs1 = new FileStream(file1, FileMode.Open);
        //    FileStream fs2 = new FileStream(file2, FileMode.Open);

        //    bool ret = false;

        //    if (fs1.Length == fs2.Length)
        //    {

        //        int byte1 = fs1.ReadByte();
        //        int byte2 = fs2.ReadByte();

        //        while ((byte1 == byte2) && (byte1 != -1))
        //        {
        //            if (byte1 == byte2)
        //                ret = true;
        //        }
        //    }

        //    fs1.Close();
        //    fs2.Close();

        //    return ret;
        //}
    }
}



