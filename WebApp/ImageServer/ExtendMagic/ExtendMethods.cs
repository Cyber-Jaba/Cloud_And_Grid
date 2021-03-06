using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;
using System.Text;

namespace WebApp.Image.ExtendMagic
{


    public partial class Responce
    {
        public static Responce FromJson(string json) => JsonConvert.DeserializeObject<Responce>(json, Converter.Settings);
    }

    public partial class GenerationDetails
    {
        public static GenerationDetails FromJson(string json) => JsonConvert.DeserializeObject<GenerationDetails>(json, Converter.Settings);
    }
    public static class Serialize
    {
        public static string ToJson(this Responce self) => JsonConvert.SerializeObject(self, Converter.Settings);
        public static string ToJson(this GenerationDetails self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
    public static class ByteArray
    {
        public static byte[] ToByteArray(this string self) => Encoding.ASCII.GetBytes(self);
        public static string FromByteArray(this byte[] self) => Encoding.ASCII.GetString(self);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

}
