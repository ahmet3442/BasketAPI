using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace System
{
    public static class Extentions
    {
        public static string JsonSerialize(this object o, Formatting formatting = Formatting.None)
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            return JsonConvert.SerializeObject(o, formatting, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
        }

        public static T JsonDeserialize<T>(this string s)
        {
            return (T)JsonConvert.DeserializeObject(s, typeof(T));
        }

        public static bool IsNullOrEmpty(this string str)
        {
            if (string.IsNullOrEmpty(str) || str == " ")
            {
                return true;
            }
            return false;
        }

        public static bool CheckGuid(this string str)
        {
            Guid guidOutput;
            return Guid.TryParse(str, out guidOutput);
        }


    }
}