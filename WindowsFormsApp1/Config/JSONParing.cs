using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareManagement.Config
{
    class JSONParing
    {
        public static JObject convertStringToJson(string jsonString)
        {

            return JObject.Parse(jsonString);
        }
        public static string convertJsonToString(JObject json)
        {

            return json.ToString();
        }
    }
}
