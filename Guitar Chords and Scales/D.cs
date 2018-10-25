using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace NotesToChords
{
    public class D
    {
        public string major { get; set; }
        public string major6 { get; set; }
        public string major7 { get; set; }
        public string major9 { get; set; }
        public string major11 { get; set; }
        public string add9 { get; set; }
        public string madd9 { get; set; }
        public string minor { get; set; }
        public string minor7 { get; set; }
        public string minor6 { get; set; }
        public string minor9 { get; set; }
        public string sus2 { get; set; }
        public string sus4 { get; set; }
        [JsonProperty("7sus4")]
        public string sevensus4 { get; set; }
        [JsonProperty("9sus4")]
        public string ninesus4 { get; set; }
        public string dominant7th { get; set; }
        public string dominant9th { get; set; }
        public string JimiHendrix { get; set; }
    }
}
