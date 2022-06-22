// See https://aka.ms/new-console-template for more information
using IronXL;
using System;
using System.IO;
using System.Text;

Console.WriteLine("Starting ..");

WorkBook wb = WorkBook.Load(@"C:\Users\Nikhil\Downloads\Data.xls");
WorkSheet ws = wb.GetWorkSheet("Employees");
var record = File.ReadAllText(@"C:\Users\Nikhil\Downloads\RecordTemplate.xml");
StringBuilder stringBuilder = new StringBuilder();

for (int i=1; i<ws.RowCount; i++)
{
    stringBuilder.Append(string.Format(record,
        ws.Rows[i].Columns[1],
        ws.Rows[i].Columns[2],
        ws.Rows[i].Columns[3],
        ws.Rows[i].Columns[4],
        ws.Rows[i].Columns[5],
        ws.Rows[i].Columns[7],
        ws.Rows[i].Columns[9],
        ws.Rows[i].Columns[11],
        ws.Rows[i].Columns[12],
        ws.Rows[i].Columns[14],
        ws.Rows[i].Columns[15],
        ws.Rows[i].Columns[16],
        ws.Rows[i].Columns[17],
        ws.Rows[i].Columns[18],
        ws.Rows[i].Columns[20],
        ws.Rows[i].Columns[23],
        ws.Rows[i].Columns[25],
        ws.Rows[i].Columns[25],
        ws.Rows[i].Columns[27],
        ws.Rows[i].Columns[28],
        ws.Rows[i].Columns[29],
        ((DateTime)ws.Rows[i].Columns[32].Value).ToString("dd.MM.yyyy"),
        ws.Rows[i].Columns[33],
        ws.Rows[i].Columns[34],
        ws.Rows[i].Columns[49],
        ws.Rows[i].Columns[50],
        ws.Rows[i].Columns[51],
        ws.Rows[i].Columns[61],
        ws.Rows[i].Columns[62],
        ws.Rows[i].Columns[63],
        ws.Rows[i].Columns[64],
        ws.Rows[i].Columns[65],
        ws.Rows[i].Columns[66],
        ws.Rows[i].Columns[67],
        ws.Rows[i].Columns[68],
        ws.Rows[i].Columns[69],
        ws.Rows[i].Columns[77],
        ws.Rows[i].Columns[84],
        ((DateTime)ws.Rows[i].Columns[85].Value).ToString("dd.MM.yyyy"),
        ws.Rows[i].Columns[86],
        ws.Rows[i].Columns[87],
        ws.Rows[i].Columns[88],
        ws.Rows[i].Columns[95],
        ws.Rows[i].Columns[96],
        ws.Rows[i].Columns[97],
        ws.Rows[i].Columns[98],
        ws.Rows[i].Columns[99],
        ws.Rows[i].Columns[100],
        ws.Rows[i].Columns[101],
        ws.Rows[i].Columns[102],
        ws.Rows[i].Columns[103],
        ws.Rows[i].Columns[104],
        ws.Rows[i].Columns[109],
        ws.Rows[i].Columns[110],
        ws.Rows[i].Columns[111],
        ws.Rows[i].Columns[112],
        ws.Rows[i].Columns[113],
        ws.Rows[i].Columns[114],
        ws.Rows[i].Columns[115],
        ws.Rows[i].Columns[147],
        ((DateTime)ws.Rows[i].Columns[148].Value).ToString("dd.MM.yyyy"),
        ws.Rows[i].Columns[149],
        ws.Rows[i].Columns[150],
        ws.Rows[i].Columns[151],
        ws.Rows[i].Columns[153],
        ws.Rows[i].Columns[152]));
}

File.WriteAllText(@"C:\Users\Nikhil\Downloads\Output.xml", stringBuilder.ToString());


Console.WriteLine("Completed !!");
