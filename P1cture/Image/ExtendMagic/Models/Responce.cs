namespace P1cture.Image.ExtendMagic
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using P1cture.Image.ExtendMagic;
    public partial class Responce
    {
        [JsonProperty("job_id")]
        public long JobId { get; set; }

        [JsonProperty("output")]
        public object Output { get; set; }

        [JsonProperty("output_url")]
        public Uri OutputUrl { get; set; }
    }

}
