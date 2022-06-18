using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace UPBhulekh.Data_Contract
{
    public class KhataNameFather
    {
        [Index(0)]
        public string? khata_number { get; set; }
        [Index(1)]
        public string? name { get; set; }
        [Index(2)]
        public string? father { get; set; }
    }
}
