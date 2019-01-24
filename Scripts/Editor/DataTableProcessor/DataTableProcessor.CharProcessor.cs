﻿using System.IO;

namespace UnityGameFramework.Editor.DataTableTools
{
    public sealed partial class DataTableProcessor
    {
        private sealed class CharProcessor : GenericDataProcessor<char>
        {
            public override string LanguageKeyword
            {
                get
                {
                    return "char";
                }
            }

            public override string TypeName
            {
                get
                {
                    return "Char";
                }
            }

            public override string[] GetTypeStrings()
            {
                return new string[]
                {
                    "char",
                    "system.char"
                };
            }

            public override char Parse(string value)
            {
                return char.Parse(value);
            }

            public override void WriteToStream(BinaryWriter stream, string value)
            {
                stream.Write(Parse(value));
            }
        }
    }
}
