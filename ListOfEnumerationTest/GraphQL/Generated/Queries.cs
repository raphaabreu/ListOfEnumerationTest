using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace ListOfEnumerationTest
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class Queries
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
            57,
            56,
            56,
            100,
            56,
            51,
            55,
            57,
            55,
            55,
            48,
            97,
            48,
            99,
            55,
            102,
            98,
            102,
            53,
            52,
            57,
            98,
            99,
            57,
            50,
            53,
            57,
            57,
            53,
            97,
            49,
            55
        };
        private readonly byte[] _content = new byte[]
        {
            113,
            117,
            101,
            114,
            121,
            32,
            83,
            105,
            109,
            112,
            108,
            101,
            81,
            117,
            101,
            114,
            121,
            32,
            123,
            32,
            100,
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
            125
        };

        public ReadOnlySpan<byte> HashName => _hashName;

        public ReadOnlySpan<byte> Hash => _hash;

        public ReadOnlySpan<byte> Content => _content;

        public static Queries Default { get; } = new Queries();

        public override string ToString() => 
            @"query SimpleQuery {
              daysOfWeek
            }";
    }
}
