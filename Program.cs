using System;
using ClosedXML.Excel;

namespace excel
{
    class Program
    {
        static void ReadExcel(string path)
        {
            using XLWorkbook workbook = new XLWorkbook(path);
            var sheet = workbook.Worksheet(1);
            for (int i = 1; i < 76; i++)
            {
                for (char charIndex = 'a'; charIndex < 'd'; charIndex++)
                {
                    string index = charIndex + i.ToString();
                    string data = sheet.Cell(index).GetValue<string>();
                    Console.WriteLine(data);
                }
            }
        }

        static void Main()
        {
            ReadExcel("test.xlsx");
        }
    }
}