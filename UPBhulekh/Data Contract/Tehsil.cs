using Newtonsoft.Json;

namespace UPBhulekh.Data_Contract
{
    public class Tehsil
    {
        [JsonProperty("tehsil_name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("tehsil_code_census")]
        public string Code { get; set; } = string.Empty;

        [JsonProperty("tehsil_name_english")]
        public string NameInEnglish { get; set; } = string.Empty;
    }
}
