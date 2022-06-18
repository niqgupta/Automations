using Newtonsoft.Json;
using UPBhulekh.Common;
using UPBhulekh.Data_Contract;

namespace UPBhulekh.Data_Request
{
    public class SBNameRequest : Request
    {
        public SBNameRequest(string villageCode, string name)
        {
            _Parameters.Add(Constants.ACT, Constants.ACT_SBNAME);
            _Parameters.Add(Constants.FASLI_CODE_VALUE, Constants.FCV_999);
            _Parameters.Add(Constants.FASLI_NAME_VALUE, Constants.FNV_VF);
            _Parameters.Add(Constants.VCC, villageCode);
            _Parameters.Add(Constants.NAME, name);
        }

        public new List<Khata>? Execute()
        {
            base.Execute();

            if (_Response.Content == null)
                return null;

            return JsonConvert.DeserializeObject<List<Khata>>(_Response.Content);
        }
    }
}
