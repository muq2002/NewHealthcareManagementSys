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
            try
            {
                return JObject.Parse(jsonString);
            }catch(Exception ex)
            {
                return JObject.Parse("");
            }
            
        }
        public static string convertJsonToString(JObject json)
        {

            return json.ToString();
        }
    }
}
