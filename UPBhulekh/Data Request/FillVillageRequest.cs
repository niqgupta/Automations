using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPBhulekh.Common;
using UPBhulekh.Data_Contract;

namespace UPBhulekh.Data_Request
{
    public class FillVillageRequest : Request
    {
        public FillVillageRequest(string districtCode, string tehsilCode)
        {
            _Parameters.Add(Constants.ACT, Constants.ACT_FILLVILLAGE);
            _Parameters.Add(Constants.DISTRICT_CODE, districtCode);
            _Parameters.Add(Constants.TEHSIL_CODE, tehsilCode);
        }

        public new List<Village> ?Execute()
        { 
            base.Execute();

            if (_Response.Content == null)
                return null;

            return JsonConvert.DeserializeObject<List<Village>>(_Response.Content);
        }
    }
}
