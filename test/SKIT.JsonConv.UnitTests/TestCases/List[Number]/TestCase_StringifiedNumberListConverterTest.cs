namespace SKIT.JsonConv.UnitTests.TestCases
{
    public class TestCase_StringifiedNumberListConverterTest
    {
        private sealed class MockObject
        {
            [Newtonsoft.Json.JsonProperty(Order = 101)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public List<byte>? PropertyAsByte { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 101)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public IList<byte>? PropertyAsByteI { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 102)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public List<sbyte>? PropertyAsSByte { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 102)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public IList<sbyte>? PropertyAsSByteI { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 103)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public List<short>? PropertyAsInt16 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 103)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public IList<short>? PropertyAsInt16I { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 104)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public List<ushort>? PropertyAsUInt16 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 104)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public IList<ushort>? PropertyAsUInt16I { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 105)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public List<int>? PropertyAsInt32 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 105)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public IList<int>? PropertyAsInt32I { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 106)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public List<uint>? PropertyAsUInt32 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 106)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public IList<uint>? PropertyAsUInt32I { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 107)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public List<long>? PropertyAsInt64 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 107)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public IList<long>? PropertyAsInt64I { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 108)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public List<ulong>? PropertyAsUInt64 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 108)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public IList<ulong>? PropertyAsUInt64I { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 109)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public List<float>? PropertyAsFloat { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 109)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public IList<float>? PropertyAsFloatI { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 110)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public List<double>? PropertyAsDouble { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 110)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public IList<double>? PropertyAsDoubleI { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 111)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public List<decimal>? PropertyAsDecimal { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 111)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public IList<decimal>? PropertyAsDecimalI { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 201)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public List<byte?>? PropertyAsNullableByte { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 201)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public IList<byte?>? PropertyAsNullableByteI { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 202)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public List<sbyte?>? PropertyAsNullableSByte { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 202)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public IList<sbyte?>? PropertyAsNullableSByteI { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 203)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public List<short?>? PropertyAsNullableInt16 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 203)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public IList<short?>? PropertyAsNullableInt16I { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 204)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public List<ushort?>? PropertyAsNullableUInt16 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 204)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public IList<ushort?>? PropertyAsNullableUInt16I { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 205)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public List<int?>? PropertyAsNullableInt32 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 205)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public IList<int?>? PropertyAsNullableInt32I { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 206)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public List<uint?>? PropertyAsNullableUInt32 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 206)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public IList<uint?>? PropertyAsNullableUInt32I { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 207)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public List<long?>? PropertyAsNullableInt64 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 207)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public IList<long?>? PropertyAsNullableInt64I { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 208)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public List<ulong?>? PropertyAsNullableUInt64 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 208)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public IList<ulong?>? PropertyAsNullableUInt64I { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 209)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public List<float?>? PropertyAsNullableFloat { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 209)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public IList<float?>? PropertyAsNullableFloatI { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 210)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public List<double?>? PropertyAsNullableDouble { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 210)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public IList<double?>? PropertyAsNullableDoubleI { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 211)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public List<decimal?>? PropertyAsNullableDecimal { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 211)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListConverter))]
            public IList<decimal?>? PropertyAsNullableDecimalI { get; set; }
        }

        private static void TestCustomJsonConverter(IJsonSerializer jsonSerializer)
        {
            Assert.Multiple(() =>
            {
                var expectObj = new MockObject()
                {
                    PropertyAsByte = new List<byte>() { byte.MaxValue },
                    PropertyAsByteI = new List<byte>() { byte.MaxValue },
                    PropertyAsSByte = new List<sbyte>() { sbyte.MaxValue },
                    PropertyAsSByteI = new List<sbyte>() { sbyte.MaxValue },
                    PropertyAsInt16 = new List<short>() { short.MaxValue },
                    PropertyAsInt16I = new List<short>() { short.MaxValue },
                    PropertyAsUInt16 = new List<ushort>() { ushort.MaxValue },
                    PropertyAsUInt16I = new List<ushort>() { ushort.MaxValue },
                    PropertyAsInt32 = new List<int>() { int.MaxValue },
                    PropertyAsInt32I = new List<int>() { int.MaxValue },
                    PropertyAsUInt32 = new List<uint>() { uint.MaxValue },
                    PropertyAsUInt32I = new List<uint>() { uint.MaxValue },
                    PropertyAsInt64 = new List<long>() { long.MaxValue },
                    PropertyAsInt64I = new List<long>() { long.MaxValue },
                    PropertyAsUInt64 = new List<ulong>() { ulong.MaxValue },
                    PropertyAsUInt64I = new List<ulong>() { ulong.MaxValue },
                    PropertyAsFloat = new List<float>() { 1.23F },
                    PropertyAsFloatI = new List<float>() { 1.23F },
                    PropertyAsDouble = new List<double>() { 1.23D },
                    PropertyAsDoubleI = new List<double>() { 1.23D },
                    PropertyAsDecimal = new List<decimal>() { 1.23M },
                    PropertyAsDecimalI = new List<decimal>() { 1.23M }
                };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Contains("\"PropertyAsByte\":[\"255\"]", actualJson);
                Assert.Contains("\"PropertyAsByteI\":[\"255\"]", actualJson);
                Assert.Contains("\"PropertyAsSByte\":[\"127\"]", actualJson);
                Assert.Contains("\"PropertyAsSByteI\":[\"127\"]", actualJson);
                Assert.Contains("\"PropertyAsInt16\":[\"32767\"]", actualJson);
                Assert.Contains("\"PropertyAsInt16I\":[\"32767\"]", actualJson);
                Assert.Contains("\"PropertyAsUInt16\":[\"65535\"]", actualJson);
                Assert.Contains("\"PropertyAsUInt16I\":[\"65535\"]", actualJson);
                Assert.Contains("\"PropertyAsInt32\":[\"2147483647\"]", actualJson);
                Assert.Contains("\"PropertyAsInt32I\":[\"2147483647\"]", actualJson);
                Assert.Contains("\"PropertyAsUInt32\":[\"4294967295\"]", actualJson);
                Assert.Contains("\"PropertyAsUInt32I\":[\"4294967295\"]", actualJson);
                Assert.Contains("\"PropertyAsInt64\":[\"9223372036854775807\"]", actualJson);
                Assert.Contains("\"PropertyAsInt64I\":[\"9223372036854775807\"]", actualJson);
                Assert.Contains("\"PropertyAsUInt64\":[\"18446744073709551615\"]", actualJson);
                Assert.Contains("\"PropertyAsUInt64I\":[\"18446744073709551615\"]", actualJson);
                Assert.Contains("\"PropertyAsDecimal\":[\"1.23\"]", actualJson);
                Assert.Contains("\"PropertyAsDecimalI\":[\"1.23\"]", actualJson);

                Assert.Equal(expectObj.PropertyAsByte, actualObj.PropertyAsByte);
                Assert.Equal(expectObj.PropertyAsByteI, actualObj.PropertyAsByteI);
                Assert.Equal(expectObj.PropertyAsByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsByte\":[\"255\"]}").PropertyAsByte);
                Assert.Equal(expectObj.PropertyAsByteI, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsByteI\":[\"255\"]}").PropertyAsByteI);
                Assert.Equal(expectObj.PropertyAsByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsByte\":[255]}").PropertyAsByte);
                Assert.Equal(expectObj.PropertyAsByteI, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsByteI\":[255]}").PropertyAsByteI);

                Assert.Equal(expectObj.PropertyAsSByte, actualObj.PropertyAsSByte);
                Assert.Equal(expectObj.PropertyAsSByteI, actualObj.PropertyAsSByteI);
                Assert.Equal(expectObj.PropertyAsSByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsSByte\":[\"127\"]}").PropertyAsSByte);
                Assert.Equal(expectObj.PropertyAsSByteI, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsSByteI\":[\"127\"]}").PropertyAsSByteI);
                Assert.Equal(expectObj.PropertyAsSByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsSByte\":[127]}").PropertyAsSByte);
                Assert.Equal(expectObj.PropertyAsSByteI, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsSByteI\":[127]}").PropertyAsSByteI);

                Assert.Equal(expectObj.PropertyAsInt16, actualObj.PropertyAsInt16);
                Assert.Equal(expectObj.PropertyAsInt16I, actualObj.PropertyAsInt16I);
                Assert.Equal(expectObj.PropertyAsInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt16\":[\"32767\"]}").PropertyAsInt16);
                Assert.Equal(expectObj.PropertyAsInt16I, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt16I\":[\"32767\"]}").PropertyAsInt16I);
                Assert.Equal(expectObj.PropertyAsInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt16\":[32767]}").PropertyAsInt16);
                Assert.Equal(expectObj.PropertyAsInt16I, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt16I\":[32767]}").PropertyAsInt16I);

                Assert.Equal(expectObj.PropertyAsUInt16, actualObj.PropertyAsUInt16);
                Assert.Equal(expectObj.PropertyAsUInt16I, actualObj.PropertyAsUInt16I);
                Assert.Equal(expectObj.PropertyAsUInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt16\":[\"65535\"]}").PropertyAsUInt16);
                Assert.Equal(expectObj.PropertyAsUInt16I, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt16I\":[\"65535\"]}").PropertyAsUInt16I);
                Assert.Equal(expectObj.PropertyAsUInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt16\":[65535]}").PropertyAsUInt16);
                Assert.Equal(expectObj.PropertyAsUInt16I, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt16I\":[65535]}").PropertyAsUInt16I);

                Assert.Equal(expectObj.PropertyAsInt32, actualObj.PropertyAsInt32);
                Assert.Equal(expectObj.PropertyAsInt32I, actualObj.PropertyAsInt32I);
                Assert.Equal(expectObj.PropertyAsInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt32\":[\"2147483647\"]}").PropertyAsInt32);
                Assert.Equal(expectObj.PropertyAsInt32I, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt32I\":[\"2147483647\"]}").PropertyAsInt32I);
                Assert.Equal(expectObj.PropertyAsInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt32\":[2147483647]}").PropertyAsInt32);
                Assert.Equal(expectObj.PropertyAsInt32I, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt32I\":[2147483647]}").PropertyAsInt32I);

                Assert.Equal(expectObj.PropertyAsUInt32, actualObj.PropertyAsUInt32);
                Assert.Equal(expectObj.PropertyAsUInt32I, actualObj.PropertyAsUInt32I);
                Assert.Equal(expectObj.PropertyAsUInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt32\":[\"4294967295\"]}").PropertyAsUInt32);
                Assert.Equal(expectObj.PropertyAsUInt32I, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt32I\":[\"4294967295\"]}").PropertyAsUInt32I);
                Assert.Equal(expectObj.PropertyAsUInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt32\":[4294967295]}").PropertyAsUInt32);
                Assert.Equal(expectObj.PropertyAsUInt32I, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt32I\":[4294967295]}").PropertyAsUInt32I);

                Assert.Equal(expectObj.PropertyAsInt64, actualObj.PropertyAsInt64);
                Assert.Equal(expectObj.PropertyAsInt64I, actualObj.PropertyAsInt64I);
                Assert.Equal(expectObj.PropertyAsInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt64\":[\"9223372036854775807\"]}").PropertyAsInt64);
                Assert.Equal(expectObj.PropertyAsInt64I, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt64I\":[\"9223372036854775807\"]}").PropertyAsInt64I);
                Assert.Equal(expectObj.PropertyAsInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt64\":[9223372036854775807]}").PropertyAsInt64);
                Assert.Equal(expectObj.PropertyAsInt64I, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt64I\":[9223372036854775807]}").PropertyAsInt64I);

                Assert.Equal(expectObj.PropertyAsUInt64, actualObj.PropertyAsUInt64);
                Assert.Equal(expectObj.PropertyAsUInt64I, actualObj.PropertyAsUInt64I);
                Assert.Equal(expectObj.PropertyAsUInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt64\":[\"18446744073709551615\"]}").PropertyAsUInt64);
                Assert.Equal(expectObj.PropertyAsUInt64I, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt64I\":[\"18446744073709551615\"]}").PropertyAsUInt64I);
                Assert.Equal(expectObj.PropertyAsUInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt64\":[18446744073709551615]}").PropertyAsUInt64);
                Assert.Equal(expectObj.PropertyAsUInt64I, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt64I\":[18446744073709551615]}").PropertyAsUInt64I);

                Assert.Equal(expectObj.PropertyAsFloat, actualObj.PropertyAsFloat);
                Assert.Equal(expectObj.PropertyAsFloatI, actualObj.PropertyAsFloatI);
                Assert.Equal(expectObj.PropertyAsFloat, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsFloat\":[\"1.23\"]}").PropertyAsFloat);
                Assert.Equal(expectObj.PropertyAsFloatI, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsFloatI\":[\"1.23\"]}").PropertyAsFloatI);
                Assert.Equal(expectObj.PropertyAsFloat, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsFloat\":[1.23]}").PropertyAsFloat);
                Assert.Equal(expectObj.PropertyAsFloatI, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsFloatI\":[1.23]}").PropertyAsFloatI);

                Assert.Equal(expectObj.PropertyAsDouble, actualObj.PropertyAsDouble);
                Assert.Equal(expectObj.PropertyAsDoubleI, actualObj.PropertyAsDoubleI);
                Assert.Equal(expectObj.PropertyAsDouble, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsDouble\":[\"1.23\"]}").PropertyAsDouble);
                Assert.Equal(expectObj.PropertyAsDoubleI, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsDoubleI\":[\"1.23\"]}").PropertyAsDoubleI);
                Assert.Equal(expectObj.PropertyAsDouble, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsDouble\":[1.23]}").PropertyAsDouble);
                Assert.Equal(expectObj.PropertyAsDoubleI, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsDoubleI\":[1.23]}").PropertyAsDoubleI);

                Assert.Equal(expectObj.PropertyAsDecimal, actualObj.PropertyAsDecimal);
                Assert.Equal(expectObj.PropertyAsDecimalI, actualObj.PropertyAsDecimalI);
                Assert.Equal(expectObj.PropertyAsDecimal, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsDecimal\":[\"1.23\"]}").PropertyAsDecimal);
                Assert.Equal(expectObj.PropertyAsDecimalI, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsDecimalI\":[\"1.23\"]}").PropertyAsDecimalI);
                Assert.Equal(expectObj.PropertyAsDecimal, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsDecimal\":[1.23]}").PropertyAsDecimal);
                Assert.Equal(expectObj.PropertyAsDecimalI, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsDecimalI\":[1.23]}").PropertyAsDecimalI);
            });

            Assert.Multiple(() =>
            {
                var expectObj = new MockObject()
                {
                    PropertyAsNullableByte = new List<byte?>() { null, byte.MaxValue },
                    PropertyAsNullableByteI = new List<byte?>() { null, byte.MaxValue },
                    PropertyAsNullableSByte = new List<sbyte?>() { null, sbyte.MaxValue },
                    PropertyAsNullableSByteI = new List<sbyte?>() { null, sbyte.MaxValue },
                    PropertyAsNullableInt16 = new List<short?>() { null, short.MaxValue },
                    PropertyAsNullableInt16I = new List<short?>() { null, short.MaxValue },
                    PropertyAsNullableUInt16 = new List<ushort?>() { null, ushort.MaxValue },
                    PropertyAsNullableUInt16I = new List<ushort?>() { null, ushort.MaxValue },
                    PropertyAsNullableInt32 = new List<int?>() { null, int.MaxValue },
                    PropertyAsNullableInt32I = new List<int?>() { null, int.MaxValue },
                    PropertyAsNullableUInt32 = new List<uint?>() { null, uint.MaxValue },
                    PropertyAsNullableUInt32I = new List<uint?>() { null, uint.MaxValue },
                    PropertyAsNullableInt64 = new List<long?>() { null, long.MaxValue },
                    PropertyAsNullableInt64I = new List<long?>() { null, long.MaxValue },
                    PropertyAsNullableUInt64 = new List<ulong?>() { null, ulong.MaxValue },
                    PropertyAsNullableUInt64I = new List<ulong?>() { null, ulong.MaxValue },
                    PropertyAsNullableFloat = new List<float?>() { null, 1.23F, float.NaN, float.PositiveInfinity, float.NegativeInfinity },
                    PropertyAsNullableFloatI = new List<float?>() { null, 1.23F, float.NaN, float.PositiveInfinity, float.NegativeInfinity },
                    PropertyAsNullableDouble = new List<double?>() { null, 1.23D, double.NaN, double.PositiveInfinity, double.NegativeInfinity },
                    PropertyAsNullableDoubleI = new List<double?>() { null, 1.23D, double.NaN, double.PositiveInfinity, double.NegativeInfinity },
                    PropertyAsNullableDecimal = new List<decimal?>() { null, 1.23M },
                    PropertyAsNullableDecimalI = new List<decimal?>() { null, 1.23M }
                };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Contains("\"PropertyAsNullableByte\":[null,\"255\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableByteI\":[null,\"255\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableSByte\":[null,\"127\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableSByteI\":[null,\"127\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableInt16\":[null,\"32767\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableInt16I\":[null,\"32767\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableUInt16\":[null,\"65535\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableUInt16I\":[null,\"65535\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableInt32\":[null,\"2147483647\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableInt32I\":[null,\"2147483647\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableUInt32\":[null,\"4294967295\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableUInt32I\":[null,\"4294967295\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableInt64\":[null,\"9223372036854775807\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableInt64I\":[null,\"9223372036854775807\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableUInt64\":[null,\"18446744073709551615\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableUInt64I\":[null,\"18446744073709551615\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableDecimal\":[null,\"1.23\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableDecimalI\":[null,\"1.23\"]", actualJson);

                Assert.Equal(expectObj.PropertyAsNullableByte, actualObj.PropertyAsNullableByte);
                Assert.Equal(expectObj.PropertyAsNullableByteI, actualObj.PropertyAsNullableByteI);
                Assert.Equal(expectObj.PropertyAsNullableByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableByte\":[\"\",\"255\"]}").PropertyAsNullableByte);
                Assert.Equal(expectObj.PropertyAsNullableByteI, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableByteI\":[\"\",\"255\"]}").PropertyAsNullableByteI);
                Assert.Equal(expectObj.PropertyAsNullableByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableByte\":[null,255]}").PropertyAsNullableByte);
                Assert.Equal(expectObj.PropertyAsNullableByteI, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableByteI\":[null,255]}").PropertyAsNullableByteI);

                Assert.Equal(expectObj.PropertyAsNullableSByte, actualObj.PropertyAsNullableSByte);
                Assert.Equal(expectObj.PropertyAsNullableSByteI, actualObj.PropertyAsNullableSByteI);
                Assert.Equal(expectObj.PropertyAsNullableSByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableSByte\":[\"\",\"127\"]}").PropertyAsNullableSByte);
                Assert.Equal(expectObj.PropertyAsNullableSByteI, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableSByteI\":[\"\",\"127\"]}").PropertyAsNullableSByteI);
                Assert.Equal(expectObj.PropertyAsNullableSByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableSByte\":[null,127]}").PropertyAsNullableSByte);
                Assert.Equal(expectObj.PropertyAsNullableSByteI, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableSByteI\":[null,127]}").PropertyAsNullableSByteI);

                Assert.Equal(expectObj.PropertyAsNullableInt16, actualObj.PropertyAsNullableInt16);
                Assert.Equal(expectObj.PropertyAsNullableInt16I, actualObj.PropertyAsNullableInt16I);
                Assert.Equal(expectObj.PropertyAsNullableInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt16\":[\"\",\"32767\"]}").PropertyAsNullableInt16);
                Assert.Equal(expectObj.PropertyAsNullableInt16I, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt16I\":[\"\",\"32767\"]}").PropertyAsNullableInt16I);
                Assert.Equal(expectObj.PropertyAsNullableInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt16\":[null,32767]}").PropertyAsNullableInt16);
                Assert.Equal(expectObj.PropertyAsNullableInt16I, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt16I\":[null,32767]}").PropertyAsNullableInt16I);

                Assert.Equal(expectObj.PropertyAsNullableUInt16, actualObj.PropertyAsNullableUInt16);
                Assert.Equal(expectObj.PropertyAsNullableUInt16I, actualObj.PropertyAsNullableUInt16I);
                Assert.Equal(expectObj.PropertyAsNullableUInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt16\":[\"\",\"65535\"]}").PropertyAsNullableUInt16);
                Assert.Equal(expectObj.PropertyAsNullableUInt16I, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt16I\":[\"\",\"65535\"]}").PropertyAsNullableUInt16I);
                Assert.Equal(expectObj.PropertyAsNullableUInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt16\":[null,65535]}").PropertyAsNullableUInt16);
                Assert.Equal(expectObj.PropertyAsNullableUInt16I, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt16I\":[null,65535]}").PropertyAsNullableUInt16I);

                Assert.Equal(expectObj.PropertyAsNullableInt32, actualObj.PropertyAsNullableInt32);
                Assert.Equal(expectObj.PropertyAsNullableInt32I, actualObj.PropertyAsNullableInt32I);
                Assert.Equal(expectObj.PropertyAsNullableInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt32\":[\"\",\"2147483647\"]}").PropertyAsNullableInt32);
                Assert.Equal(expectObj.PropertyAsNullableInt32I, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt32I\":[\"\",\"2147483647\"]}").PropertyAsNullableInt32I);
                Assert.Equal(expectObj.PropertyAsNullableInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt32\":[null,2147483647]}").PropertyAsNullableInt32);
                Assert.Equal(expectObj.PropertyAsNullableInt32I, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt32I\":[null,2147483647]}").PropertyAsNullableInt32I);

                Assert.Equal(expectObj.PropertyAsNullableUInt32, actualObj.PropertyAsNullableUInt32);
                Assert.Equal(expectObj.PropertyAsNullableUInt32I, actualObj.PropertyAsNullableUInt32I);
                Assert.Equal(expectObj.PropertyAsNullableUInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt32\":[\"\",\"4294967295\"]}").PropertyAsNullableUInt32);
                Assert.Equal(expectObj.PropertyAsNullableUInt32I, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt32I\":[\"\",\"4294967295\"]}").PropertyAsNullableUInt32I);
                Assert.Equal(expectObj.PropertyAsNullableUInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt32\":[null,4294967295]}").PropertyAsNullableUInt32);
                Assert.Equal(expectObj.PropertyAsNullableUInt32I, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt32I\":[null,4294967295]}").PropertyAsNullableUInt32I);

                Assert.Equal(expectObj.PropertyAsNullableInt64, actualObj.PropertyAsNullableInt64);
                Assert.Equal(expectObj.PropertyAsNullableInt64I, actualObj.PropertyAsNullableInt64I);
                Assert.Equal(expectObj.PropertyAsNullableInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt64\":[\"\",\"9223372036854775807\"]}").PropertyAsNullableInt64);
                Assert.Equal(expectObj.PropertyAsNullableInt64I, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt64I\":[\"\",\"9223372036854775807\"]}").PropertyAsNullableInt64I);
                Assert.Equal(expectObj.PropertyAsNullableInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt64\":[null,9223372036854775807]}").PropertyAsNullableInt64);
                Assert.Equal(expectObj.PropertyAsNullableInt64I, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt64I\":[null,9223372036854775807]}").PropertyAsNullableInt64I);

                Assert.Equal(expectObj.PropertyAsNullableUInt64, actualObj.PropertyAsNullableUInt64);
                Assert.Equal(expectObj.PropertyAsNullableUInt64I, actualObj.PropertyAsNullableUInt64I);
                Assert.Equal(expectObj.PropertyAsNullableUInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt64\":[\"\",\"18446744073709551615\"]}").PropertyAsNullableUInt64);
                Assert.Equal(expectObj.PropertyAsNullableUInt64I, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt64I\":[\"\",\"18446744073709551615\"]}").PropertyAsNullableUInt64I);
                Assert.Equal(expectObj.PropertyAsNullableUInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt64\":[null,18446744073709551615]}").PropertyAsNullableUInt64);
                Assert.Equal(expectObj.PropertyAsNullableUInt64I, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt64I\":[null,18446744073709551615]}").PropertyAsNullableUInt64I);

                Assert.Equal(expectObj.PropertyAsNullableFloat, actualObj.PropertyAsNullableFloat);
                Assert.Equal(expectObj.PropertyAsNullableFloatI, actualObj.PropertyAsNullableFloatI);
                Assert.Equal(expectObj.PropertyAsNullableFloat, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableFloat\":[\"\",\"1.23\",\"NaN\",\"Infinity\",\"-Infinity\"]}").PropertyAsNullableFloat);
                Assert.Equal(expectObj.PropertyAsNullableFloatI, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableFloatI\":[\"\",\"1.23\",\"NaN\",\"Infinity\",\"-Infinity\"]}").PropertyAsNullableFloatI);
                Assert.Equal(expectObj.PropertyAsNullableFloat, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableFloat\":[null,1.23,\"NaN\",\"Infinity\",\"-Infinity\"]}").PropertyAsNullableFloat);
                Assert.Equal(expectObj.PropertyAsNullableFloatI, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableFloatI\":[null,1.23,\"NaN\",\"Infinity\",\"-Infinity\"]}").PropertyAsNullableFloatI);

                Assert.Equal(expectObj.PropertyAsNullableDouble, actualObj.PropertyAsNullableDouble);
                Assert.Equal(expectObj.PropertyAsNullableDoubleI, actualObj.PropertyAsNullableDoubleI);
                Assert.Equal(expectObj.PropertyAsNullableDouble, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableDouble\":[\"\",\"1.23\",\"NaN\",\"Infinity\",\"-Infinity\"]}").PropertyAsNullableDouble);
                Assert.Equal(expectObj.PropertyAsNullableDoubleI, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableDoubleI\":[\"\",\"1.23\",\"NaN\",\"Infinity\",\"-Infinity\"]}").PropertyAsNullableDoubleI);
                Assert.Equal(expectObj.PropertyAsNullableDouble, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableDouble\":[null,1.23,\"NaN\",\"Infinity\",\"-Infinity\"]}").PropertyAsNullableDouble);
                Assert.Equal(expectObj.PropertyAsNullableDoubleI, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableDoubleI\":[null,1.23,\"NaN\",\"Infinity\",\"-Infinity\"]}").PropertyAsNullableDoubleI);

                Assert.Equal(expectObj.PropertyAsNullableDecimal, actualObj.PropertyAsNullableDecimal);
                Assert.Equal(expectObj.PropertyAsNullableDecimalI, actualObj.PropertyAsNullableDecimalI);
                Assert.Equal(expectObj.PropertyAsNullableDecimal, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableDecimal\":[\"\",\"1.23\"]}").PropertyAsNullableDecimal);
                Assert.Equal(expectObj.PropertyAsNullableDecimalI, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableDecimalI\":[\"\",\"1.23\"]}").PropertyAsNullableDecimalI);
                Assert.Equal(expectObj.PropertyAsNullableDecimal, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableDecimal\":[null,1.23]}").PropertyAsNullableDecimal);
                Assert.Equal(expectObj.PropertyAsNullableDecimalI, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableDecimalI\":[null,1.23]}").PropertyAsNullableDecimalI);
            });
        }

        [Fact(DisplayName = "测试用例：自定义 Newtosoft.Json.JsonConverter 之 StringifiedNumberListConverter")]
        public void TestNewtosoftJsonConverter()
        {
            var jsonSettings = NewtonsoftJsonSerializer.GetDefaultSerializerSettings();
            jsonSettings.Formatting = Newtonsoft.Json.Formatting.None;
            jsonSettings.FloatFormatHandling = Newtonsoft.Json.FloatFormatHandling.String;

            TestCustomJsonConverter(new NewtonsoftJsonSerializer(jsonSettings));
        }
    }
}
