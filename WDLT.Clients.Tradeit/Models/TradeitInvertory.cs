using System.Collections.Generic;
using Newtonsoft.Json;
using WDLT.Clients.Base;

namespace WDLT.Clients.Tradeit.Models
{
    public class TradeitInvertory
    {
        [JsonProperty("730")]
        public TradeitInvertoryApp CSGO { get; set; }

        [JsonProperty("252490")]
        public TradeitInvertoryApp Rust { get; set; }
    }

    public class TradeitInvertoryApp
    {
        [JsonProperty("items")]
        public Dictionary<string, TradeitInvertoryItem> Items { get; set; }
    }

    public class TradeitInvertoryItem
    {
        [JsonProperty("p")]
        [JsonConverter(typeof(LongToDoublePriceJsonConverter))]
        public double Price { get; set; }

        [JsonProperty("e")]
        public string Quality { get; set; }

        [JsonProperty("d")]
        public List<TradeitInvertory_D> D { get; set; }
    }

    public class TradeitInvertory_D
    {
        [JsonProperty("f")]
        public decimal? Float { get; set; }

        [JsonProperty("r")]
        public long? TradeLock { get; set; }
    }
}