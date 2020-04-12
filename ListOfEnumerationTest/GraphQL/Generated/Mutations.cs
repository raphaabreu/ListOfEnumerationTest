using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace ListOfEnumerationTest
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class Mutations
        : global::StrawberryShake.IDocument
    {
        private readonly byte[] _hashName = new byte[]
        {
            109,
            100,
            53,
            72,
            97,
            115,
            104
        };
        private readonly byte[] _hash = new byte[]
        {
            101,
            55,
            48,
            55,
            53,
            99,
            97,
            52,
            52,
            49,
            97,
            55,
            101,
            55,
            54,
            54,
            102,
            99,
            51,
            100,
            53,
            102,
            49,
            57,
            101,
            48,
            56,
            51,
            98,
            101,
            102,
            98
        };
        private readonly byte[] _content = new byte[]
        {
            109,
            117,
            116,
            97,
            116,
            105,
            111,
            110,
            32,
            83,
            101,
            116,
            68,
            97,
            121,
            115,
            79,
            102,
            87,
            101,
            101,
            107,
            32,
            123,
            32,
            115,
            101,
            116,
            68,
            97,
            121,
            115,
            79,
            102,
            87,
            101,
            101,
            107,
            40,
            100,
            97,
            121,
            115,
            58,
            32,
            91,
            32,
            83,
            85,
            78,
            68,
            65,
            89,
            44,
            32,
            84,
            85,
            69,
            83,
            68,
            65,
            89,
            32,
            93,
            41,
            32,
            125
        };

        public ReadOnlySpan<byte> HashName => _hashName;

        public ReadOnlySpan<byte> Hash => _hash;

        public ReadOnlySpan<byte> Content => _content;

        public static Mutations Default { get; } = new Mutations();

        public override string ToString() => 
            @"mutation SetDaysOfWeek {
              setDaysOfWeek(days: [ SUNDAY, TUESDAY ])
            }";
    }
}
