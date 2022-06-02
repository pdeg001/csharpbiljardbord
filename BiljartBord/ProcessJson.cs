using Newtonsoft.Json;

namespace BiljartBord
{
    internal class ProcessJson
    {
        #region CURRSCORE
        public class CurrScore
        {
            // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
            public class AanStoot
            {
                [JsonProperty("speler")]
                public string Speler { get; set; }
            }

            public class Autoinnings
            {
                [JsonProperty("value")]
                public string Value { get; set; }
            }

            public class Beurten
            {
                [JsonProperty("aantal")]
                public string Aantal { get; set; }
            }

            public class P1
            {
                [JsonProperty("caram")]
                public string Caram { get; set; }

                [JsonProperty("naam")]
                public string Naam { get; set; }

                [JsonProperty("maken")]
                public string Maken { get; set; }
            }

            public class P2
            {
                [JsonProperty("caram")]
                public string Caram { get; set; }

                [JsonProperty("naam")]
                public string Naam { get; set; }

                [JsonProperty("maken")]
                public string Maken { get; set; }
            }

            public class Root
            {
                [JsonProperty("p1")]
                public P1 P1 { get; set; }

                [JsonProperty("p2")]
                public P2 P2 { get; set; }

                [JsonProperty("aan_stoot")]
                public AanStoot AanStoot { get; set; }

                [JsonProperty("spelduur")]
                public Spelduur Spelduur { get; set; }

                [JsonProperty("autoinnings")]
                public Autoinnings Autoinnings { get; set; }

                [JsonProperty("beurten")]
                public Beurten Beurten { get; set; }
            }

            public class Spelduur
            {
                [JsonProperty("tijd")]
                public string Tijd { get; set; }
            }




        }
        #endregion CURRSCORE
    }
}
