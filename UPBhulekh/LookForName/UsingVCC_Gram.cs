using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPBhulekh.Data_Contract;

namespace UPBhulekh.LookForName
{
    public class UsingVCC_Gram
    {
        private List<KhataNameFather> _KhataDetails;

        public UsingVCC_Gram()
        { 
            _KhataDetails = new List<KhataNameFather>();
        }

        public void Fetch(string name, List<string> vccs)
        {
            var client = new RestClient("https://upbhulekh.gov.in/public/public_ror/action/public_action.jsp");
            List<KhataNameFather> allKhataDetails = new List<KhataNameFather>();

            foreach (string vcc in vccs)
            {
                var request = new RestRequest();
                request.AddHeader("Cookie", "JSESSIONID=D6EE2D6A08278F4B4FE79F38461AC232");
                request.AlwaysMultipartFormData = true;
                request.AddParameter("name", name);
                request.AddParameter("act", "sbname");
                request.AddParameter("vcc", vcc);
                request.AddParameter("fasli-code-value", "999");
                request.AddParameter("fasli-name-value", "वर्तमान+फसली");
                var response = client.Execute(request);
                Console.WriteLine(response.Content);

                if (response.Content == null)
                    return;

                List<KhataNameFather> khataDetails = JsonConvert.DeserializeObject<List<KhataNameFather>>(response.Content);
                if(khataDetails != null)
                    _KhataDetails.AddRange(khataDetails);
            }
        }

        public List<string> LookFather_KhataNo(string father)
        {
            return _KhataDetails.Where(x => x.father != null && x.father.Contains(father)).Select(x => x.khata_number).ToList();
        }

        public List<string> LookName_KhataNo(string name)
        {
            return _KhataDetails.Where(x => x.name != null && x.name.Contains(name)).Select(x => x.khata_number).ToList();
        }

        public void Publish(string file)
        {
            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false
            };

            using (var stream = File.Open(file, FileMode.Append))
            {
                using (var writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    using (var csv = new CsvWriter(writer, csvConfig))
                    {
                        csv.WriteRecords(_KhataDetails);
                    }
                }
            }
        }
    }
}
