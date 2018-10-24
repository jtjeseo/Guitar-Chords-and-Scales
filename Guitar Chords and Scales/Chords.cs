using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar_Chords_and_Scales
{
    [JsonObject("chords")]
    public class Chords
    {
        public A A { get; set; }
        [JsonProperty("A#")]
        public Asharp Asharp { get; set; }
        public B B { get; set; }
        public C C { get; set; }
        [JsonProperty("C#")]
        public Csharp Csharp { get; set; }
        public D D { get; set; }
        [JsonProperty("D#")]
        public Dsharp Dsharp { get; set; }
        public E E { get; set; }
        public F F { get; set; }
        [JsonProperty("F#")]
        public Fsharp Fsharp { get; set; }
        public G G { get; set; }
        [JsonProperty("G#")]
        public Gsharp Gsharp { get; set; }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (A != null)
            {
                sb.Append(A.major)
                    .Append(A.major6)
                    .Append(A.major7)
                    .Append(A.major9)
                    .Append(A.major11);



            }
            return sb.ToString();
        }
    }
}
