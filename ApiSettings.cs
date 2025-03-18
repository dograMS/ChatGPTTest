using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTTest
{
    public class ApiSettings
    {
        public string ApiLLMName { get; set; }
        public string ApiUrl { get; set; }
        public string ApiKey { get; set; }
        public string AiModel { get; set; }

        public ApiSettings(string Name , string Url, string Model,string Key ) 
        {
            ApiLLMName = Name;
            ApiUrl = Url;
            ApiKey = Key;
            AiModel = Model;
        }
    }

}
