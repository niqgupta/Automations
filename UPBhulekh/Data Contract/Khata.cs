using Newtonsoft.Json;

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
