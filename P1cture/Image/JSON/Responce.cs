namespace P1cture.Image.JSON
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Responce
    {
        [JsonProperty("job_id")]
        public long JobId { get; set; }

        [JsonProperty("output")]
        public object Output { get; set; }

        [JsonProperty("output_url")]
        public Uri OutputUrl { get; set; }
    }

    public partial class Responce
    {
        public static Responce FromJson(string json) => JsonConvert.DeserializeObject<Responce>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Responce self) => JsonConvert.SerializeObject(self, Converter.Settings);
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
