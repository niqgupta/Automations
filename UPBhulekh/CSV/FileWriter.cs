using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Text;

namespace UPBhulekh.CSV
{
    public class FileWriter
    {
        private string _FilePath;

        public FileWriter(string filePath)
        {
            _FilePath = filePath;
        }

        public void Write(List<KhataDetails> records)
        {
            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true
            };

            using (var stream = File.Open(_FilePath, FileMode.Append))
            using (var writer = new StreamWriter(stream, Encoding.UTF8))
            using (var csvWriter = new CsvWriter(writer, csvConfig))
                csvWriter.WriteRecords(records);
        }
    }
}
