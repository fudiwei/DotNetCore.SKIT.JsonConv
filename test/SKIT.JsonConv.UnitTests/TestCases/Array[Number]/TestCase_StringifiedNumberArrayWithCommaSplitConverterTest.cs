namespace SKIT.JsonConv.UnitTests.TestCases
{
    public class TestCase_StringifiedNumberArrayWithCommaSplitConverterTest
    {
        private sealed class MockObject
        {
            [Newtonsoft.Json.JsonProperty(Order = 101)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(101)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            public byte[]? PropertyAsByte { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 102)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(102)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            public sbyte[]? PropertyAsSByte { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 103)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(103)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            public short[]? PropertyAsInt16 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 104)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(104)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            public ushort[]? PropertyAsUInt16 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 105)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(105)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            public int[]? PropertyAsInt32 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 106)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(106)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            public uint[]? PropertyAsUInt32 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 107)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(107)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            public long[]? PropertyAsInt64 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 108)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(108)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            public ulong[]? PropertyAsUInt64 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 109)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(109)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            public float[]? PropertyAsFloat { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 110)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(110)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            public double[]? PropertyAsDouble { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 111)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(111)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            public decimal[]? PropertyAsDecimal { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 201)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(201)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            public byte?[]? PropertyAsNullableByte { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 202)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(202)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            public sbyte?[]? PropertyAsNullableSByte { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 203)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(203)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            public short?[]? PropertyAsNullableInt16 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 204)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(204)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            public ushort?[]? PropertyAsNullableUInt16 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 205)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(205)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            public int?[]? PropertyAsNullableInt32 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 206)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(206)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            public uint?[]? PropertyAsNullableUInt32 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 207)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(207)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            public long?[]? PropertyAsNullableInt64 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 208)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(208)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            public ulong?[]? PropertyAsNullableUInt64 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 209)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(209)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            public float?[]? PropertyAsNullableFloat { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 210)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(210)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            public double?[]? PropertyAsNullableDouble { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 211)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(211)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberArrayWithCommaSplitConverter))]
            public decimal?[]? PropertyAsNullableDecimal { get; set; }
        }

        private static void TestCustomJsonConverter(IJsonSerializer jsonSerializer)
        {
            Assert.Multiple(() =>
            {
                var expectObj = new MockObject()
                {
                    PropertyAsByte = new byte[] { byte.MinValue, byte.MaxValue },
                    PropertyAsSByte = new sbyte[] { sbyte.MinValue, sbyte.MaxValue },
                    PropertyAsInt16 = new short[] { short.MinValue, short.MaxValue },
                    PropertyAsUInt16 = new ushort[] { ushort.MinValue, ushort.MaxValue },
                    PropertyAsInt32 = new int[] { int.MinValue, int.MaxValue },
                    PropertyAsUInt32 = new uint[] { uint.MinValue, uint.MaxValue },
                    PropertyAsInt64 = new long[] { long.MinValue, long.MaxValue },
                    PropertyAsUInt64 = new ulong[] { ulong.MinValue, ulong.MaxValue },
                    PropertyAsFloat = new float[] { -1.23F, 1.23F },
                    PropertyAsDouble = new double[] { -1.23D, 1.23D },
                    PropertyAsDecimal = new decimal[] { -1.23M, 1.23M }
                };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Contains("\"PropertyAsByte\":\"0,255\"", actualJson);
                Assert.Contains("\"PropertyAsSByte\":\"-128,127\"", actualJson);
                Assert.Contains("\"PropertyAsInt16\":\"-32768,32767\"", actualJson);
                Assert.Contains("\"PropertyAsUInt16\":\"0,65535\"", actualJson);
                Assert.Contains("\"PropertyAsInt32\":\"-2147483648,2147483647\"", actualJson);
                Assert.Contains("\"PropertyAsUInt32\":\"0,4294967295\"", actualJson);
                Assert.Contains("\"PropertyAsInt64\":\"-9223372036854775808,9223372036854775807\"", actualJson);
                Assert.Contains("\"PropertyAsUInt64\":\"0,18446744073709551615\"", actualJson);
                Assert.Contains("\"PropertyAsDecimal\":\"-1.23,1.23\"", actualJson);

                Assert.Equal(expectObj.PropertyAsByte, actualObj.PropertyAsByte);
                Assert.Equal(expectObj.PropertyAsSByte, actualObj.PropertyAsSByte);
                Assert.Equal(expectObj.PropertyAsInt16, actualObj.PropertyAsInt16);
                Assert.Equal(expectObj.PropertyAsUInt16, actualObj.PropertyAsUInt16);
                Assert.Equal(expectObj.PropertyAsInt32, actualObj.PropertyAsInt32);
                Assert.Equal(expectObj.PropertyAsUInt32, actualObj.PropertyAsUInt32);
                Assert.Equal(expectObj.PropertyAsInt64, actualObj.PropertyAsInt64);
                Assert.Equal(expectObj.PropertyAsUInt64, actualObj.PropertyAsUInt64);
                Assert.Equal(expectObj.PropertyAsFloat, actualObj.PropertyAsFloat);
                Assert.Equal(expectObj.PropertyAsDouble, actualObj.PropertyAsDouble);
                Assert.Equal(expectObj.PropertyAsDecimal, actualObj.PropertyAsDecimal);
                Assert.Equal(expectObj.PropertyAsNullableByte, actualObj.PropertyAsNullableByte);
                Assert.Equal(expectObj.PropertyAsNullableSByte, actualObj.PropertyAsNullableSByte);
                Assert.Equal(expectObj.PropertyAsNullableInt16, actualObj.PropertyAsNullableInt16);
                Assert.Equal(expectObj.PropertyAsNullableUInt16, actualObj.PropertyAsNullableUInt16);
                Assert.Equal(expectObj.PropertyAsNullableInt32, actualObj.PropertyAsNullableInt32);
                Assert.Equal(expectObj.PropertyAsNullableUInt32, actualObj.PropertyAsNullableUInt32);
                Assert.Equal(expectObj.PropertyAsNullableInt64, actualObj.PropertyAsNullableInt64);
                Assert.Equal(expectObj.PropertyAsNullableUInt64, actualObj.PropertyAsNullableUInt64);
                Assert.Equal(expectObj.PropertyAsNullableFloat, actualObj.PropertyAsNullableFloat);
                Assert.Equal(expectObj.PropertyAsNullableDouble, actualObj.PropertyAsNullableDouble);
                Assert.Equal(expectObj.PropertyAsNullableDecimal, actualObj.PropertyAsNullableDecimal);
            });

            Assert.Multiple(() =>
            {
                var expectObj = new MockObject()
                {
                    PropertyAsNullableByte = new byte?[] { null, byte.MinValue, byte.MaxValue },
                    PropertyAsNullableSByte = new sbyte?[] { null, sbyte.MinValue, sbyte.MaxValue },
                    PropertyAsNullableInt16 = new short?[] { null, short.MinValue, short.MaxValue },
                    PropertyAsNullableUInt16 = new ushort?[] { null, ushort.MinValue, ushort.MaxValue },
                    PropertyAsNullableInt32 = new int?[] { null, int.MinValue, int.MaxValue },
                    PropertyAsNullableUInt32 = new uint?[] { null, uint.MinValue, uint.MaxValue },
                    PropertyAsNullableInt64 = new long?[] { null, long.MinValue, long.MaxValue },
                    PropertyAsNullableUInt64 = new ulong?[] { null, ulong.MinValue, ulong.MaxValue },
                    PropertyAsNullableFloat = new float?[] { null, -1.23F, 1.23F, float.NaN, float.PositiveInfinity, float.NegativeInfinity },
                    PropertyAsNullableDouble = new double?[] { null, -1.23D, 1.23D, double.NaN, double.PositiveInfinity, double.NegativeInfinity },
                    PropertyAsNullableDecimal = new decimal?[] { null, -1.23M, 1.23M }
                };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Contains("\"PropertyAsNullableByte\":\",0,255\"", actualJson);
                Assert.Contains("\"PropertyAsNullableSByte\":\",-128,127\"", actualJson);
                Assert.Contains("\"PropertyAsNullableInt16\":\",-32768,32767\"", actualJson);
                Assert.Contains("\"PropertyAsNullableUInt16\":\",0,65535\"", actualJson);
                Assert.Contains("\"PropertyAsNullableInt32\":\",-2147483648,2147483647\"", actualJson);
                Assert.Contains("\"PropertyAsNullableUInt32\":\",0,4294967295\"", actualJson);
                Assert.Contains("\"PropertyAsNullableInt64\":\",-9223372036854775808,9223372036854775807\"", actualJson);
                Assert.Contains("\"PropertyAsNullableUInt64\":\",0,18446744073709551615\"", actualJson);
                Assert.Contains("\"PropertyAsNullableDecimal\":\",-1.23,1.23\"", actualJson);

                Assert.Equal(expectObj.PropertyAsByte, actualObj.PropertyAsByte);
                Assert.Equal(expectObj.PropertyAsSByte, actualObj.PropertyAsSByte);
                Assert.Equal(expectObj.PropertyAsInt16, actualObj.PropertyAsInt16);
                Assert.Equal(expectObj.PropertyAsUInt16, actualObj.PropertyAsUInt16);
                Assert.Equal(expectObj.PropertyAsInt32, actualObj.PropertyAsInt32);
                Assert.Equal(expectObj.PropertyAsUInt32, actualObj.PropertyAsUInt32);
                Assert.Equal(expectObj.PropertyAsInt64, actualObj.PropertyAsInt64);
                Assert.Equal(expectObj.PropertyAsUInt64, actualObj.PropertyAsUInt64);
                Assert.Equal(expectObj.PropertyAsFloat, actualObj.PropertyAsFloat);
                Assert.Equal(expectObj.PropertyAsDouble, actualObj.PropertyAsDouble);
                Assert.Equal(expectObj.PropertyAsDecimal, actualObj.PropertyAsDecimal);
                Assert.Equal(expectObj.PropertyAsNullableByte, actualObj.PropertyAsNullableByte);
                Assert.Equal(expectObj.PropertyAsNullableSByte, actualObj.PropertyAsNullableSByte);
                Assert.Equal(expectObj.PropertyAsNullableInt16, actualObj.PropertyAsNullableInt16);
                Assert.Equal(expectObj.PropertyAsNullableUInt16, actualObj.PropertyAsNullableUInt16);
                Assert.Equal(expectObj.PropertyAsNullableInt32, actualObj.PropertyAsNullableInt32);
                Assert.Equal(expectObj.PropertyAsNullableUInt32, actualObj.PropertyAsNullableUInt32);
                Assert.Equal(expectObj.PropertyAsNullableInt64, actualObj.PropertyAsNullableInt64);
                Assert.Equal(expectObj.PropertyAsNullableUInt64, actualObj.PropertyAsNullableUInt64);
                Assert.Equal(expectObj.PropertyAsNullableFloat, actualObj.PropertyAsNullableFloat);
                Assert.Equal(expectObj.PropertyAsNullableDouble, actualObj.PropertyAsNullableDouble);
                Assert.Equal(expectObj.PropertyAsNullableDecimal, actualObj.PropertyAsNullableDecimal);
            });
        }

        [Fact(DisplayName = "测试用例：自定义 Newtosoft.Json.JsonConverter 之 StringifiedNumberArrayWithCommaSplitConverter")]
        public void TestNewtosoftJsonConverter()
        {
            var jsonSettings = NewtonsoftJsonSerializer.GetDefaultSerializerSettings();
            jsonSettings.Formatting = Newtonsoft.Json.Formatting.None;
            jsonSettings.FloatFormatHandling = Newtonsoft.Json.FloatFormatHandling.String;

            TestCustomJsonConverter(new NewtonsoftJsonSerializer(jsonSettings));
        }

        [Fact(DisplayName = "测试用例：自定义 System.Text.Json.Serialization.JsonConverter 之 StringifiedNumberArrayWithCommaSplitConverter")]
        public void TestSystemTextJsonConverter()
        {
            var jsonOptions = SystemTextJsonSerializer.GetDefaultSerializerOptions();
            jsonOptions.WriteIndented = false;
            jsonOptions.NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowNamedFloatingPointLiterals;

            TestCustomJsonConverter(new SystemTextJsonSerializer(jsonOptions));
        }
    }
}
