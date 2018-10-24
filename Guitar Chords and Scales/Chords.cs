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
                if (Asharp.major != null)
                {
                    sb.Append("A major: " + A.major + Environment.NewLine);
                }
                if (A.major6 != null)
                {
                    sb.Append("A major6: " + A.major6 + Environment.NewLine);
                }
                if (A.major7 != null)
                {
                    sb.Append("A major7: " + A.major7 + Environment.NewLine);
                }
                if (A.major9 != null)
                {
                    sb.Append("A major9: " + A.major9 + Environment.NewLine);
                }
                if (A.major11 != null)
                {
                    sb.Append("A major11: " + A.major11 + Environment.NewLine);
                }
                if (A.add9 != null)
                {
                    sb.Append("A add9: " + A.add9 + Environment.NewLine);
                }
                if (A.madd9 != null)
                {
                    sb.Append("A madd9: " + A.madd9 + Environment.NewLine);
                }
                if (A.minor != null)
                {
                    sb.Append("A minor: " + A.minor + Environment.NewLine);
                }
                if (A.minor7 != null)
                {
                    sb.Append("A minor7: " + A.minor7 + Environment.NewLine);
                }
                if (A.minor9 != null)
                {
                    sb.Append("A minor9: " + A.minor9 + Environment.NewLine);
                }
                if (A.sus2 != null)
                {
                    sb.Append("A sus2: " + A.sus2 + Environment.NewLine);
                }
                if (A.sus4 != null)
                {
                    sb.Append("A sus4: " + A.sus4 + Environment.NewLine);
                }
                if (A.sevensus4 != null)
                {
                    sb.Append("A 7sus4: " + A.sevensus4 + Environment.NewLine);
                }
                if (A.ninesus4 != null)
                {
                    sb.Append("A 9sus4: " + A.ninesus4 + Environment.NewLine);
                }
                if (A.dominant7th != null)
                {
                    sb.Append("A dominant7th: " + A.dominant7th + Environment.NewLine);
                }
                if (A.dominant9th != null)
                {
                    sb.Append("A dominant9th: " + A.dominant9th + Environment.NewLine);
                }
                if (A.JimiHendrix != null)
                {
                    sb.Append("A JimiHendrix: " + A.JimiHendrix + Environment.NewLine);
                }
                else
                {
                    Console.WriteLine("");
                }

            }
            if (Asharp != null)
            {
                if (Asharp.major != null)
                {
                    sb.Append("A# major: " + Asharp.major + Environment.NewLine);
                }
                if (Asharp.major6 != null)
                {
                    sb.Append("A# major6: " + Asharp.major6 + Environment.NewLine);
                }
                if (Asharp.major7 != null)
                {
                    sb.Append("A# major7: " + Asharp.major7 + Environment.NewLine);
                }
                if (Asharp.major9 != null)
                {
                    sb.Append("A# major9: " + Asharp.major9 + Environment.NewLine);
                }
                if (Asharp.major11 != null)
                {
                    sb.Append("A# major11: " + Asharp.major11 + Environment.NewLine);
                }
                if (Asharp.add9 != null)
                {
                    sb.Append("A# add9: " + Asharp.add9 + Environment.NewLine);
                }
                if (Asharp.madd9 != null)
                {
                    sb.Append("A# madd9: " + Asharp.madd9 + Environment.NewLine);
                }
                if (Asharp.minor != null)
                {
                    sb.Append("A# minor: " + Asharp.minor + Environment.NewLine);
                }
                if (Asharp.minor7 != null)
                {
                    sb.Append("A# minor7: " + Asharp.minor7 + Environment.NewLine);
                }
                if (Asharp.minor9 != null)
                {
                    sb.Append("A# minor9: " + Asharp.minor9 + Environment.NewLine);
                }
                if (Asharp.sus2 != null)
                {
                    sb.Append("A# sus2: " + Asharp.sus2 + Environment.NewLine);
                }
                if (Asharp.sus4 != null)
                {
                    sb.Append("A# sus4: " + Asharp.sus4 + Environment.NewLine);
                }
                if (Asharp.sevensus4 != null)
                {
                    sb.Append("A# 7sus4: " + Asharp.sevensus4 + Environment.NewLine);
                }
                if (Asharp.ninesus4 != null)
                {
                    sb.Append("A# 9sus4: " + Asharp.ninesus4 + Environment.NewLine);
                }
                if (Asharp.dominant7th != null)
                {
                    sb.Append("A# dominant7th: " + Asharp.dominant7th + Environment.NewLine);
                }
                if (Asharp.dominant9th != null)
                {
                    sb.Append("A# dominant9th: " + Asharp.dominant9th + Environment.NewLine);
                }
                if (Asharp.JimiHendrix != null)
                {
                    sb.Append("A# JimiHendrix: " + Asharp.JimiHendrix + Environment.NewLine);
                }
                else
                {
                    Console.WriteLine("");
                }

            }
            if (B != null)
            {
                if (B.major != null)
                {
                    sb.Append("B major: " + B.major + Environment.NewLine);
                }
                if (B.major6 != null)
                {
                    sb.Append("B major6: " + B.major6 + Environment.NewLine);
                }
                if (B.major7 != null)
                {
                    sb.Append("B major7: " + B.major7 + Environment.NewLine);
                }
                if (B.major9 != null)
                {
                    sb.Append("B major9: " + B.major9 + Environment.NewLine);
                }
                if (B.major11 != null)
                {
                    sb.Append("B major11: " + B.major11 + Environment.NewLine);
                }
                if (B.add9 != null)
                {
                    sb.Append("B add9: " + B.add9 + Environment.NewLine);
                }
                if (B.madd9 != null)
                {
                    sb.Append("B madd9: " + B.madd9 + Environment.NewLine);
                }
                if (B.minor != null)
                {
                    sb.Append("B minor: " + B.minor + Environment.NewLine);
                }
                if (B.minor7 != null)
                {
                    sb.Append("B minor7: " + B.minor7 + Environment.NewLine);
                }
                if (B.minor9 != null)
                {
                    sb.Append("B minor9: " + B.minor9 + Environment.NewLine);
                }
                if (B.sus2 != null)
                {
                    sb.Append("B sus2: " + B.sus2 + Environment.NewLine);
                }
                if (B.sus4 != null)
                {
                    sb.Append("B sus4: " + B.sus4 + Environment.NewLine);
                }
                if (B.sevensus4 != null)
                {
                    sb.Append("B 7sus4: " + B.sevensus4 + Environment.NewLine);
                }
                if (B.ninesus4 != null)
                {
                    sb.Append("B 9sus4: " + B.ninesus4 + Environment.NewLine);
                }
                if (B.dominant7th != null)
                {
                    sb.Append("B dominant7th: " + B.dominant7th + Environment.NewLine);
                }
                if (B.dominant9th != null)
                {
                    sb.Append("B dominant9th: " + B.dominant9th + Environment.NewLine);
                }
                if (B.JimiHendrix != null)
                {
                    sb.Append("B JimiHendrix: " + B.JimiHendrix + Environment.NewLine);
                }
                else
                {
                    Console.WriteLine("");
                }

            }
            if (C != null)
            {
                if (C.major != null)
                {
                    sb.Append("C major: " + C.major + Environment.NewLine);
                }
                if (C.major6 != null)
                {
                    sb.Append("C major6: " + C.major6 + Environment.NewLine);
                }
                if (C.major7 != null)
                {
                    sb.Append("C major7: " + C.major7 + Environment.NewLine);
                }
                if (C.major9 != null)
                {
                    sb.Append("C major9: " + C.major9 + Environment.NewLine);
                }
                if (C.major11 != null)
                {
                    sb.Append("C major11: " + C.major11 + Environment.NewLine);
                }
                if (C.add9 != null)
                {
                    sb.Append("C add9: " + C.add9 + Environment.NewLine);
                }
                if (C.madd9 != null)
                {
                    sb.Append("C madd9: " + C.madd9 + Environment.NewLine);
                }
                if (C.minor != null)
                {
                    sb.Append("C minor: " + C.minor + Environment.NewLine);
                }
                if (C.minor7 != null)
                {
                    sb.Append("C minor7: " + C.minor7 + Environment.NewLine);
                }
                if (C.minor9 != null)
                {
                    sb.Append("C minor9: " + C.minor9 + Environment.NewLine);
                }
                if (C.sus2 != null)
                {
                    sb.Append("C sus2: " + C.sus2 + Environment.NewLine);
                }
                if (C.sus4 != null)
                {
                    sb.Append("C sus4: " + C.sus4 + Environment.NewLine);
                }
                if (C.sevensus4 != null)
                {
                    sb.Append("C 7sus4: " + C.sevensus4 + Environment.NewLine);
                }
                if (C.ninesus4 != null)
                {
                    sb.Append("C 9sus4: " + C.ninesus4 + Environment.NewLine);
                }
                if (C.dominant7th != null)
                {
                    sb.Append("C dominant7th: " + C.dominant7th + Environment.NewLine);
                }
                if (C.dominant9th != null)
                {
                    sb.Append("C dominant9th: " + C.dominant9th + Environment.NewLine);
                }
                if (C.JimiHendrix != null)
                {
                    sb.Append("C JimiHendrix: " + C.JimiHendrix + Environment.NewLine);
                }
                else
                {
                    Console.WriteLine("");
                }

            }
            if (Csharp != null)
            {
                if (Csharp.major != null)
                {
                    sb.Append("C# major: " + Csharp.major + Environment.NewLine);
                }
                if (Csharp.major6 != null)
                {
                    sb.Append("C# major6: " + Csharp.major6 + Environment.NewLine);
                }
                if (Csharp.major7 != null)
                {
                    sb.Append("C# major7: " + Csharp.major7 + Environment.NewLine);
                }
                if (Csharp.major9 != null)
                {
                    sb.Append("C# major9: " + Csharp.major9 + Environment.NewLine);
                }
                if (Csharp.major11 != null)
                {
                    sb.Append("C# major11: " + Csharp.major11 + Environment.NewLine);
                }
                if (Csharp.add9 != null)
                {
                    sb.Append("C# add9: " + Csharp.add9 + Environment.NewLine);
                }
                if (Csharp.madd9 != null)
                {
                    sb.Append("C# madd9: " + Csharp.madd9 + Environment.NewLine);
                }
                if (Csharp.minor != null)
                {
                    sb.Append("C# minor: " + Csharp.minor + Environment.NewLine);
                }
                if (Csharp.minor7 != null)
                {
                    sb.Append("C# minor7: " + Csharp.minor7 + Environment.NewLine);
                }
                if (Csharp.minor9 != null)
                {
                    sb.Append("C# minor9: " + Csharp.minor9 + Environment.NewLine);
                }
                if (Csharp.sus2 != null)
                {
                    sb.Append("C# sus2: " + Csharp.sus2 + Environment.NewLine);
                }
                if (Csharp.sus4 != null)
                {
                    sb.Append("C# sus4: " + Csharp.sus4 + Environment.NewLine);
                }
                if (Csharp.sevensus4 != null)
                {
                    sb.Append("C# 7sus4: " + Csharp.sevensus4 + Environment.NewLine);
                }
                if (Csharp.ninesus4 != null)
                {
                    sb.Append("C# 9sus4: " + Csharp.ninesus4 + Environment.NewLine);
                }
                if (Csharp.dominant7th != null)
                {
                    sb.Append("C# dominant7th: " + Csharp.dominant7th + Environment.NewLine);
                }
                if (Csharp.dominant9th != null)
                {
                    sb.Append("C# dominant9th: " + Csharp.dominant9th + Environment.NewLine);
                }
                if (Csharp.JimiHendrix != null)
                {
                    sb.Append("C# JimiHendrix: " + Csharp.JimiHendrix + Environment.NewLine);
                }
                else
                {
                    Console.WriteLine("");
                }

            }
            if (D != null)
            {
                if (D.major != null)
                {
                    sb.Append("D major: " + D.major + Environment.NewLine);
                }
                if (D.major6 != null)
                {
                    sb.Append("D major6: " + D.major6 + Environment.NewLine);
                }
                if (D.major7 != null)
                {
                    sb.Append("D major7: " + D.major7 + Environment.NewLine);
                }
                if (D.major9 != null)
                {
                    sb.Append("D major9: " + D.major9 + Environment.NewLine);
                }
                if (D.major11 != null)
                {
                    sb.Append("D major11: " + D.major11 + Environment.NewLine);
                }
                if (D.add9 != null)
                {
                    sb.Append("D add9: " + D.add9 + Environment.NewLine);
                }
                if (D.madd9 != null)
                {
                    sb.Append("D madd9: " + D.madd9 + Environment.NewLine);
                }
                if (D.minor != null)
                {
                    sb.Append("D minor: " + D.minor + Environment.NewLine);
                }
                if (D.minor7 != null)
                {
                    sb.Append("D minor7: " + D.minor7 + Environment.NewLine);
                }
                if (D.minor9 != null)
                {
                    sb.Append("D minor9: " + D.minor9 + Environment.NewLine);
                }
                if (D.sus2 != null)
                {
                    sb.Append("D sus2: " + D.sus2 + Environment.NewLine);
                }
                if (D.sus4 != null)
                {
                    sb.Append("D sus4: " + D.sus4 + Environment.NewLine);
                }
                if (D.sevensus4 != null)
                {
                    sb.Append("D 7sus4: " + D.sevensus4 + Environment.NewLine);
                }
                if (D.ninesus4 != null)
                {
                    sb.Append("D 9sus4: " + D.ninesus4 + Environment.NewLine);
                }
                if (D.dominant7th != null)
                {
                    sb.Append("D dominant7th: " + D.dominant7th + Environment.NewLine);
                }
                if (D.dominant9th != null)
                {
                    sb.Append("D dominant9th: " + D.dominant9th + Environment.NewLine);
                }
                if (D.JimiHendrix != null)
                {
                    sb.Append("D JimiHendrix: " + D.JimiHendrix + Environment.NewLine);
                }
                else
                {
                    Console.WriteLine("");
                }

            }
            if (Dsharp != null)
            {
                if (Dsharp.major != null)
                {
                    sb.Append("D# major: " + Dsharp.major + Environment.NewLine);
                }
                if (Dsharp.major6 != null)
                {
                    sb.Append("D# major6: " + Dsharp.major6 + Environment.NewLine);
                }
                if (Dsharp.major7 != null)
                {
                    sb.Append("D# major7: " + Dsharp.major7 + Environment.NewLine);
                }
                if (Dsharp.major9 != null)
                {
                    sb.Append("D# major9: " + Dsharp.major9 + Environment.NewLine);
                }
                if (Dsharp.major11 != null)
                {
                    sb.Append("D# major11: " + Dsharp.major11 + Environment.NewLine);
                }
                if (Dsharp.add9 != null)
                {
                    sb.Append("D# add9: " + Dsharp.add9 + Environment.NewLine);
                }
                if (Dsharp.madd9 != null)
                {
                    sb.Append("D# madd9: " + Dsharp.madd9 + Environment.NewLine);
                }
                if (Dsharp.minor != null)
                {
                    sb.Append("D# minor: " + Dsharp.minor + Environment.NewLine);
                }
                if (Dsharp.minor7 != null)
                {
                    sb.Append("D# minor7: " + Dsharp.minor7 + Environment.NewLine);
                }
                if (Dsharp.minor9 != null)
                {
                    sb.Append("D# minor9: " + Dsharp.minor9 + Environment.NewLine);
                }
                if (Dsharp.sus2 != null)
                {
                    sb.Append("D# sus2: " + Dsharp.sus2 + Environment.NewLine);
                }
                if (Dsharp.sus4 != null)
                {
                    sb.Append("D# sus4: " + Dsharp.sus4 + Environment.NewLine);
                }
                if (Dsharp.sevensus4 != null)
                {
                    sb.Append("D# 7sus4: " + Dsharp.sevensus4 + Environment.NewLine);
                }
                if (Dsharp.ninesus4 != null)
                {
                    sb.Append("D# 9sus4: " + Dsharp.ninesus4 + Environment.NewLine);
                }
                if (Dsharp.dominant7th != null)
                {
                    sb.Append("D# dominant7th: " + Dsharp.dominant7th + Environment.NewLine);
                }
                if (Dsharp.dominant9th != null)
                {
                    sb.Append("D# dominant9th: " + Dsharp.dominant9th + Environment.NewLine);
                }
                if (Dsharp.JimiHendrix != null)
                {
                    sb.Append("D# JimiHendrix: " + Dsharp.JimiHendrix + Environment.NewLine);
                }
                else
                {
                    Console.WriteLine("");
                }

            }
            if (E != null)
            {
                if (E.major != null)
                {
                    sb.Append("E major: " + E.major + Environment.NewLine);
                }
                if (E.major6 != null)
                {
                    sb.Append("E major6: " + E.major6 + Environment.NewLine);
                }
                if (E.major7 != null)
                {
                    sb.Append("E major7: " + E.major7 + Environment.NewLine);
                }
                if (E.major9 != null)
                {
                    sb.Append("E major9: " + E.major9 + Environment.NewLine);
                }
                if (E.major11 != null)
                {
                    sb.Append("E major11: " + E.major11 + Environment.NewLine);
                }
                if (E.add9 != null)
                {
                    sb.Append("E add9: " + E.add9 + Environment.NewLine);
                }
                if (E.madd9 != null)
                {
                    sb.Append("E madd9: " + E.madd9 + Environment.NewLine);
                }
                if (E.minor != null)
                {
                    sb.Append("E minor: " + E.minor + Environment.NewLine);
                }
                if (E.minor7 != null)
                {
                    sb.Append("E minor7: " + E.minor7 + Environment.NewLine);
                }
                if (E.minor9 != null)
                {
                    sb.Append("E minor9: " + E.minor9 + Environment.NewLine);
                }
                if (E.sus2 != null)
                {
                    sb.Append("E sus2: " + E.sus2 + Environment.NewLine);
                }
                if (E.sus4 != null)
                {
                    sb.Append("E sus4: " + E.sus4 + Environment.NewLine);
                }
                if (E.sevensus4 != null)
                {
                    sb.Append("E 7sus4: " + E.sevensus4 + Environment.NewLine);
                }
                if (E.ninesus4 != null)
                {
                    sb.Append("E 9sus4: " + E.ninesus4 + Environment.NewLine);
                }
                if (E.dominant7th != null)
                {
                    sb.Append("E dominant7th: " + E.dominant7th + Environment.NewLine);
                }
                if (E.dominant9th != null)
                {
                    sb.Append("E dominant9th: " + E.dominant9th + Environment.NewLine);
                }
                if (E.JimiHendrix != null)
                {
                    sb.Append("E JimiHendrix: " + E.JimiHendrix + Environment.NewLine);
                }
                else
                {
                    Console.WriteLine("");
                }

            }
            if (F != null)
            {
                if (F.major != null)
                {
                    sb.Append("F major: " + F.major + Environment.NewLine);
                }
                if (F.major6 != null)
                {
                    sb.Append("F major6: " + F.major6 + Environment.NewLine);
                }
                if (F.major7 != null)
                {
                    sb.Append("F major7: " + F.major7 + Environment.NewLine);
                }
                if (F.major9 != null)
                {
                    sb.Append("F major9: " + F.major9 + Environment.NewLine);
                }
                if (F.major11 != null)
                {
                    sb.Append("F major11: " + F.major11 + Environment.NewLine);
                }
                if (F.add9 != null)
                {
                    sb.Append("F add9: " + F.add9 + Environment.NewLine);
                }
                if (F.madd9 != null)
                {
                    sb.Append("F madd9: " + F.madd9 + Environment.NewLine);
                }
                if (F.minor != null)
                {
                    sb.Append("F minor: " + F.minor + Environment.NewLine);
                }
                if (F.minor7 != null)
                {
                    sb.Append("F minor7: " + F.minor7 + Environment.NewLine);
                }
                if (F.minor9 != null)
                {
                    sb.Append("F minor9: " + F.minor9 + Environment.NewLine);
                }
                if (F.sus2 != null)
                {
                    sb.Append("F sus2: " + F.sus2 + Environment.NewLine);
                }
                if (F.sus4 != null)
                {
                    sb.Append("F sus4: " + F.sus4 + Environment.NewLine);
                }
                if (F.sevensus4 != null)
                {
                    sb.Append("F 7sus4: " + F.sevensus4 + Environment.NewLine);
                }
                if (F.ninesus4 != null)
                {
                    sb.Append("F 9sus4: " + F.ninesus4 + Environment.NewLine);
                }
                if (F.dominant7th != null)
                {
                    sb.Append("F dominant7th: " + F.dominant7th + Environment.NewLine);
                }
                if (F.dominant9th != null)
                {
                    sb.Append("F dominant9th: " + F.dominant9th + Environment.NewLine);
                }
                if (F.JimiHendrix != null)
                {
                    sb.Append("F JimiHendrix: " + F.JimiHendrix + Environment.NewLine);
                }
                else
                {
                    Console.WriteLine("");
                }

            }
            if (Fsharp != null)
            {
                if (Fsharp.major != null)
                {
                    sb.Append("F# major: " + Fsharp.major + Environment.NewLine);
                }
                if (Fsharp.major6 != null)
                {
                    sb.Append("F# major6: " + Fsharp.major6 + Environment.NewLine);
                }
                if (Fsharp.major7 != null)
                {
                    sb.Append("F# major7: " + Fsharp.major7 + Environment.NewLine);
                }
                if (Fsharp.major9 != null)
                {
                    sb.Append("F# major9: " + Fsharp.major9 + Environment.NewLine);
                }
                if (Fsharp.major11 != null)
                {
                    sb.Append("F# major11: " + Fsharp.major11 + Environment.NewLine);
                }
                if (Fsharp.add9 != null)
                {
                    sb.Append("F# add9: " + Fsharp.add9 + Environment.NewLine);
                }
                if (Fsharp.madd9 != null)
                {
                    sb.Append("F# madd9: " + Fsharp.madd9 + Environment.NewLine);
                }
                if (Fsharp.minor != null)
                {
                    sb.Append("F# minor: " + Fsharp.minor + Environment.NewLine);
                }
                if (Fsharp.minor7 != null)
                {
                    sb.Append("F# minor7: " + Fsharp.minor7 + Environment.NewLine);
                }
                if (Fsharp.minor9 != null)
                {
                    sb.Append("F# minor9: " + Fsharp.minor9 + Environment.NewLine);
                }
                if (Fsharp.sus2 != null)
                {
                    sb.Append("F# sus2: " + Fsharp.sus2 + Environment.NewLine);
                }
                if (Fsharp.sus4 != null)
                {
                    sb.Append("F# sus4: " + Fsharp.sus4 + Environment.NewLine);
                }
                if (Fsharp.sevensus4 != null)
                {
                    sb.Append("F# 7sus4: " + Fsharp.sevensus4 + Environment.NewLine);
                }
                if (Fsharp.ninesus4 != null)
                {
                    sb.Append("F# 9sus4: " + Fsharp.ninesus4 + Environment.NewLine);
                }
                if (Fsharp.dominant7th != null)
                {
                    sb.Append("F# dominant7th: " + Fsharp.dominant7th + Environment.NewLine);
                }
                if (Fsharp.dominant9th != null)
                {
                    sb.Append("F# dominant9th: " + Fsharp.dominant9th + Environment.NewLine);
                }
                if (Fsharp.JimiHendrix != null)
                {
                    sb.Append("F# JimiHendrix: " + Fsharp.JimiHendrix + Environment.NewLine);
                }
                else
                {
                    Console.WriteLine("");
                }

            }
            if (G != null)
            {
                if (G.major != null)
                {
                    sb.Append("G major: " + G.major + Environment.NewLine);
                }
                if (G.major6 != null)
                {
                    sb.Append("G major6: " + G.major6 + Environment.NewLine);
                }
                if (G.major7 != null)
                {
                    sb.Append("G major7: " + G.major7 + Environment.NewLine);
                }
                if (G.major9 != null)
                {
                    sb.Append("G major9: " + G.major9 + Environment.NewLine);
                }
                if (G.major11 != null)
                {
                    sb.Append("G major11: " + G.major11 + Environment.NewLine);
                }
                if (G.add9 != null)
                {
                    sb.Append("G add9: " + G.add9 + Environment.NewLine);
                }
                if (G.madd9 != null)
                {
                    sb.Append("G madd9: " + G.madd9 + Environment.NewLine);
                }
                if (G.minor != null)
                {
                    sb.Append("G minor: " + G.minor + Environment.NewLine);
                }
                if (G.minor7 != null)
                {
                    sb.Append("G minor7: " + G.minor7 + Environment.NewLine);
                }
                if (G.minor9 != null)
                {
                    sb.Append("G minor9: " + G.minor9 + Environment.NewLine);
                }
                if (G.sus2 != null)
                {
                    sb.Append("G sus2: " + G.sus2 + Environment.NewLine);
                }
                if (G.sus4 != null)
                {
                    sb.Append("G sus4: " + G.sus4 + Environment.NewLine);
                }
                if (G.sevensus4 != null)
                {
                    sb.Append("G 7sus4: " + G.sevensus4 + Environment.NewLine);
                }
                if (G.ninesus4 != null)
                {
                    sb.Append("G 9sus4: " + G.ninesus4 + Environment.NewLine);
                }
                if (G.dominant7th != null)
                {
                    sb.Append("G dominant7th: " + G.dominant7th + Environment.NewLine);
                }
                if (G.dominant9th != null)
                {
                    sb.Append("G dominant9th: " + G.dominant9th + Environment.NewLine);
                }
                if (G.JimiHendrix != null)
                {
                    sb.Append("G JimiHendrix: " + G.JimiHendrix + Environment.NewLine);
                }
                else
                {
                    Console.WriteLine("");
                }

            }
            if (Gsharp != null)
            {
                if (Gsharp.major != null)
                {
                    sb.Append("G# major: " + Gsharp.major + Environment.NewLine);
                }
                if (Gsharp.major6 != null)
                {
                    sb.Append("G# major6: " + Gsharp.major6 + Environment.NewLine);
                }
                if (Gsharp.major7 != null)
                {
                    sb.Append("G# major7: " + Gsharp.major7 + Environment.NewLine);
                }
                if (Gsharp.major9 != null)
                {
                    sb.Append("G# major9: " + Gsharp.major9 + Environment.NewLine);
                }
                if (Gsharp.major11 != null)
                {
                    sb.Append("G# major11: " + Gsharp.major11 + Environment.NewLine);
                }
                if (Gsharp.add9 != null)
                {
                    sb.Append("G# add9: " + Gsharp.add9 + Environment.NewLine);
                }
                if (Gsharp.madd9 != null)
                {
                    sb.Append("G# madd9: " + Gsharp.madd9 + Environment.NewLine);
                }
                if (Gsharp.minor != null)
                {
                    sb.Append("G# minor: " + Gsharp.minor + Environment.NewLine);
                }
                if (Gsharp.minor7 != null)
                {
                    sb.Append("G# minor7: " + Gsharp.minor7 + Environment.NewLine);
                }
                if (Gsharp.minor9 != null)
                {
                    sb.Append("G# minor9: " + Gsharp.minor9 + Environment.NewLine);
                }
                if (Gsharp.sus2 != null)
                {
                    sb.Append("G# sus2: " + Gsharp.sus2 + Environment.NewLine);
                }
                if (Gsharp.sus4 != null)
                {
                    sb.Append("G# sus4: " + Gsharp.sus4 + Environment.NewLine);
                }
                if (Gsharp.sevensus4 != null)
                {
                    sb.Append("G# 7sus4: " + Gsharp.sevensus4 + Environment.NewLine);
                }
                if (Gsharp.ninesus4 != null)
                {
                    sb.Append("G# 9sus4: " + Gsharp.ninesus4 + Environment.NewLine);
                }
                if (Gsharp.dominant7th != null)
                {
                    sb.Append("G# dominant7th: " + Gsharp.dominant7th + Environment.NewLine);
                }
                if (Gsharp.dominant9th != null)
                {
                    sb.Append("G# dominant9th: " + Gsharp.dominant9th + Environment.NewLine);
                }
                if (Asharp.JimiHendrix != null)
                {
                    sb.Append("G# JimiHendrix: " + Asharp.JimiHendrix + Environment.NewLine);
                }
                else
                {
                    Console.WriteLine("");
                }

            }


            return sb.ToString();
        }
    }
}
