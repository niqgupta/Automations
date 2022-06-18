using Newtonsoft.Json;
using UPBhulekh.Common;
using UPBhulekh.Data_Contract;

namespace UPBhulekh.Data_Request
{
    public class FillTehsilRequest : Request
    {
        public FillTehsilRequest(string districtCode)
        {
            _Parameters.Add(Constants.ACT, Constants.ACT_FILLTEHSIL);
            _Parameters.Add(Constants.DISTRICT_CODE, districtCode);
        }

        public new List<Tehsil>? Execute()
        {
            base.Execute();

            if (_Response.Content == null)
                return null;

            return JsonConvert.DeserializeObject<List<Tehsil>>(_Response.Content);
        }
    }
}
