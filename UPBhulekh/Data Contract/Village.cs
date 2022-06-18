using Newtonsoft.Json;

namespace UPBhulekh.Data_Contract
{
    public class Village
    {
        [JsonProperty("vname")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("village_code_census")]
        public string Code { get; set; } = string.Empty;

        [JsonProperty("vname_eng")]
        public string NameInEnglish { get; set; } = string.Empty;

        [JsonProperty("pname")]
        public string ParganaName { get; set; } = string.Empty;

        [JsonProperty("flg_chakbandi")]
        public string InChakbandi { get; set; } = string.Empty;

        [JsonProperty("flg_survey")]
        public string InSurvey { get; set; } = string.Empty;

        [JsonProperty("pargana_code_new")]
        public string ParganaCode { get; set; } = string.Empty;
    }
}
