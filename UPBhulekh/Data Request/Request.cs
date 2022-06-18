using RestSharp;

namespace UPBhulekh.Data_Request
{
    public class Request
    {
        private string _Uri = "https://upbhulekh.gov.in/public/public_ror/action/public_action.jsp";
        private RestClient _Client;
        private RestRequest _Request;
        protected Dictionary<string, string> _Parameters;
        protected RestResponse _Response;

        public Request()
        { 
            _Client = new RestClient(_Uri);
            InitializeRequest();
            _Parameters = new Dictionary<string, string>();
        }

        private void InitializeRequest()
        { 
            _Request = new RestRequest();
            _Request.AddHeader("Cookie", "JSESSIONID=D6EE2D6A08278F4B4FE79F38461AC232");
            _Request.AlwaysMultipartFormData = true;
            _Request.Method = Method.Post;
        }

        private void AddParameter()
        {
            foreach (string key in _Parameters.Keys)
            { 
                _Request.AddParameter(key, _Parameters[key]);
            }
        }

        public void Execute()
        { 
            AddParameter();
            _Response = _Client.Execute(_Request);
        }
    }
}
