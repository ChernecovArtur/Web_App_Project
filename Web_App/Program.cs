using System;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace excel
{
    class Program
    {
        static void ReadExcel(string path)
        {
            ISheet sheet;
            using (var stream = new FileStream(path, FileMode.Open))
            {
                stream.Position = 0;
                XSSFWorkbook xssWorkbook = new XSSFWorkbook(stream);

                sheet = xssWorkbook.GetSheetAt(0);

                for (int i = sheet.FirstRowNum; i <= sheet.LastRowNum; i++)
                {
                    Console.Write('\n');

                    IRow row = sheet.GetRow(i);
                    for (int j = row.FirstCellNum; j < row.LastCellNum; j++)
                    {
                        if (row.GetCell(j) != null && row.GetCell(j).ToString() != null)
                        {
                            Console.Write(row.GetCell(j).ToString() + ' ');
                        }
                    }
                }
            }
        }

        static void Main()
        {
            ReadExcel("test.xlsx");
        }
    }
}