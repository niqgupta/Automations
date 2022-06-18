using CsvHelper.Configuration.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace UPBhulekh.Data_Contract
{
    public class Khata
    {
        [JsonProperty("khata_number")]
        public string Number { get; set; } = string.Empty;

        [JsonProperty("name")]
        public string Owner { get; set; } = string.Empty;

        [JsonProperty("father")]
        public string FatherName { get; set; } = string.Empty;
    }
}
