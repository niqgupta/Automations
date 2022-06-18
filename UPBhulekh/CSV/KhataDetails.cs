using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPBhulekh.CSV
{
    public class KhataDetails
    {
        [Index(0)]
        public string Number { get; set; } = string.Empty;

        [Index(1)]
        public string Owner { get; set; } = string.Empty;

        [Index(2)]
        public string FatherName { get; set; } = string.Empty;

        [Index(3)]
        public string VillageName { get; set; } = string.Empty;

        [Index(4)]
        public string VillageCode { get; set; } = string.Empty;

        [Index(5)]
        public string ParganaName { get; set; } = string.Empty;

        [Index(6)]
        public string ParganaCode { get; set; } = string.Empty;
    }
}
