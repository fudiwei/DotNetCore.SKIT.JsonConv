namespace SKIT.JsonConv.UnitTests.TestCases
{
    public class TestCase_StringifiedNumberArrayConverterTest
    {
        private sealed class MockObject
        {
            [Newtonsoft.Json.JsonProperty(Order = 101)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayConverter))]
            public byte[]? PropertyAsByte { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 102)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayConverter))]
            public sbyte[]? PropertyAsSByte { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 103)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayConverter))]
            public short[]? PropertyAsInt16 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 104)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayConverter))]
            public ushort[]? PropertyAsUInt16 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 105)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayConverter))]
            public int[]? PropertyAsInt32 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 106)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayConverter))]
            public uint[]? PropertyAsUInt32 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 107)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayConverter))]
            public long[]? PropertyAsInt64 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 108)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayConverter))]
            public ulong[]? PropertyAsUInt64 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 109)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayConverter))]
            public float[]? PropertyAsFloat { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 110)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayConverter))]
            public double[]? PropertyAsDouble { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 111)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayConverter))]
            public decimal[]? PropertyAsDecimal { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 201)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayConverter))]
            public byte?[]? PropertyAsNullableByte { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 202)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayConverter))]
            public sbyte?[]? PropertyAsNullableSByte { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 203)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayConverter))]
            public short?[]? PropertyAsNullableInt16 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 204)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayConverter))]
            public ushort?[]? PropertyAsNullableUInt16 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 205)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayConverter))]
            public int?[]? PropertyAsNullableInt32 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 206)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayConverter))]
            public uint?[]? PropertyAsNullableUInt32 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 207)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayConverter))]
            public long?[]? PropertyAsNullableInt64 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 208)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayConverter))]
            public ulong?[]? PropertyAsNullableUInt64 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 209)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayConverter))]
            public float?[]? PropertyAsNullableFloat { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 210)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayConverter))]
            public double?[]? PropertyAsNullableDouble { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 211)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberArrayConverter))]
            public decimal?[]? PropertyAsNullableDecimal { get; set; }
        }

        private static void TestCustomJsonConverter(IJsonSerializer jsonSerializer)
        {
            Assert.Multiple(() =>
            {
                var expectObj = new MockObject()
                {
                    PropertyAsByte = new byte[] { byte.MaxValue },
                    PropertyAsSByte = new sbyte[] { sbyte.MaxValue },
                    PropertyAsInt16 = new short[] { short.MaxValue },
                    PropertyAsUInt16 = new ushort[] { ushort.MaxValue },
                    PropertyAsInt32 = new int[] { int.MaxValue },
                    PropertyAsUInt32 = new uint[] { uint.MaxValue },
                    PropertyAsInt64 = new long[] { long.MaxValue },
                    PropertyAsUInt64 = new ulong[] { ulong.MaxValue },
                    PropertyAsFloat = new float[] { 1.23F },
                    PropertyAsDouble = new double[] { 1.23D },
                    PropertyAsDecimal = new decimal[] { 1.23M }
                };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Contains("\"PropertyAsByte\":[\"255\"]", actualJson);
                Assert.Contains("\"PropertyAsSByte\":[\"127\"]", actualJson);
                Assert.Contains("\"PropertyAsInt16\":[\"32767\"]", actualJson);
                Assert.Contains("\"PropertyAsUInt16\":[\"65535\"]", actualJson);
                Assert.Contains("\"PropertyAsInt32\":[\"2147483647\"]", actualJson);
                Assert.Contains("\"PropertyAsUInt32\":[\"4294967295\"]", actualJson);
                Assert.Contains("\"PropertyAsInt64\":[\"9223372036854775807\"]", actualJson);
                Assert.Contains("\"PropertyAsUInt64\":[\"18446744073709551615\"]", actualJson);
                Assert.Contains("\"PropertyAsDecimal\":[\"1.23\"]", actualJson);

                Assert.Equal(expectObj.PropertyAsByte, actualObj.PropertyAsByte);
                Assert.Equal(expectObj.PropertyAsByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsByte\":[\"255\"]}").PropertyAsByte);
                Assert.Equal(expectObj.PropertyAsByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsByte\":[255]}").PropertyAsByte);

                Assert.Equal(expectObj.PropertyAsSByte, actualObj.PropertyAsSByte);
                Assert.Equal(expectObj.PropertyAsSByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsSByte\":[\"127\"]}").PropertyAsSByte);
                Assert.Equal(expectObj.PropertyAsSByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsSByte\":[127]}").PropertyAsSByte);

                Assert.Equal(expectObj.PropertyAsInt16, actualObj.PropertyAsInt16);
                Assert.Equal(expectObj.PropertyAsInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt16\":[\"32767\"]}").PropertyAsInt16);
                Assert.Equal(expectObj.PropertyAsInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt16\":[32767]}").PropertyAsInt16);

                Assert.Equal(expectObj.PropertyAsUInt16, actualObj.PropertyAsUInt16);
                Assert.Equal(expectObj.PropertyAsUInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt16\":[\"65535\"]}").PropertyAsUInt16);
                Assert.Equal(expectObj.PropertyAsUInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt16\":[65535]}").PropertyAsUInt16);

                Assert.Equal(expectObj.PropertyAsInt32, actualObj.PropertyAsInt32);
                Assert.Equal(expectObj.PropertyAsInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt32\":[\"2147483647\"]}").PropertyAsInt32);
                Assert.Equal(expectObj.PropertyAsInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt32\":[2147483647]}").PropertyAsInt32);

                Assert.Equal(expectObj.PropertyAsUInt32, actualObj.PropertyAsUInt32);
                Assert.Equal(expectObj.PropertyAsUInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt32\":[\"4294967295\"]}").PropertyAsUInt32);
                Assert.Equal(expectObj.PropertyAsUInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt32\":[4294967295]}").PropertyAsUInt32);

                Assert.Equal(expectObj.PropertyAsInt64, actualObj.PropertyAsInt64);
                Assert.Equal(expectObj.PropertyAsInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt64\":[\"9223372036854775807\"]}").PropertyAsInt64);
                Assert.Equal(expectObj.PropertyAsInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt64\":[9223372036854775807]}").PropertyAsInt64);

                Assert.Equal(expectObj.PropertyAsUInt64, actualObj.PropertyAsUInt64);
                Assert.Equal(expectObj.PropertyAsUInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt64\":[\"18446744073709551615\"]}").PropertyAsUInt64);
                Assert.Equal(expectObj.PropertyAsUInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt64\":[18446744073709551615]}").PropertyAsUInt64);

                Assert.Equal(expectObj.PropertyAsFloat, actualObj.PropertyAsFloat);
                Assert.Equal(expectObj.PropertyAsFloat, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsFloat\":[\"1.23\"]}").PropertyAsFloat);
                Assert.Equal(expectObj.PropertyAsFloat, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsFloat\":[1.23]}").PropertyAsFloat);

                Assert.Equal(expectObj.PropertyAsDouble, actualObj.PropertyAsDouble);
                Assert.Equal(expectObj.PropertyAsDouble, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsDouble\":[\"1.23\"]}").PropertyAsDouble);
                Assert.Equal(expectObj.PropertyAsDouble, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsDouble\":[1.23]}").PropertyAsDouble);

                Assert.Equal(expectObj.PropertyAsDecimal, actualObj.PropertyAsDecimal);
                Assert.Equal(expectObj.PropertyAsDecimal, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsDecimal\":[\"1.23\"]}").PropertyAsDecimal);
                Assert.Equal(expectObj.PropertyAsDecimal, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsDecimal\":[1.23]}").PropertyAsDecimal);
            });

            Assert.Multiple(() =>
            {
                var expectObj = new MockObject()
                {
                    PropertyAsNullableByte = new byte?[] { null, byte.MaxValue },
                    PropertyAsNullableSByte = new sbyte?[] { null, sbyte.MaxValue },
                    PropertyAsNullableInt16 = new short?[] { null, short.MaxValue },
                    PropertyAsNullableUInt16 = new ushort?[] { null, ushort.MaxValue },
                    PropertyAsNullableInt32 = new int?[] { null, int.MaxValue },
                    PropertyAsNullableUInt32 = new uint?[] { null, uint.MaxValue },
                    PropertyAsNullableInt64 = new long?[] { null, long.MaxValue },
                    PropertyAsNullableUInt64 = new ulong?[] { null, ulong.MaxValue },
                    PropertyAsNullableFloat = new float?[] { null, 1.23F, float.NaN, float.PositiveInfinity, float.NegativeInfinity },
                    PropertyAsNullableDouble = new double?[] { null, 1.23D, double.NaN, double.PositiveInfinity, double.NegativeInfinity },
                    PropertyAsNullableDecimal = new decimal?[] { null, 1.23M }
                };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Contains("\"PropertyAsNullableByte\":[null,\"255\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableSByte\":[null,\"127\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableInt16\":[null,\"32767\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableUInt16\":[null,\"65535\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableInt32\":[null,\"2147483647\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableUInt32\":[null,\"4294967295\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableInt64\":[null,\"9223372036854775807\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableUInt64\":[null,\"18446744073709551615\"]", actualJson);
                Assert.Contains("\"PropertyAsNullableDecimal\":[null,\"1.23\"]", actualJson);

                Assert.Equal(expectObj.PropertyAsNullableByte, actualObj.PropertyAsNullableByte);
                Assert.Equal(expectObj.PropertyAsNullableByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableByte\":[\"\",\"255\"]}").PropertyAsNullableByte);
                Assert.Equal(expectObj.PropertyAsNullableByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableByte\":[null,255]}").PropertyAsNullableByte);

                Assert.Equal(expectObj.PropertyAsNullableSByte, actualObj.PropertyAsNullableSByte);
                Assert.Equal(expectObj.PropertyAsNullableSByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableSByte\":[\"\",\"127\"]}").PropertyAsNullableSByte);
                Assert.Equal(expectObj.PropertyAsNullableSByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableSByte\":[null,127]}").PropertyAsNullableSByte);

                Assert.Equal(expectObj.PropertyAsNullableInt16, actualObj.PropertyAsNullableInt16);
                Assert.Equal(expectObj.PropertyAsNullableInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt16\":[\"\",\"32767\"]}").PropertyAsNullableInt16);
                Assert.Equal(expectObj.PropertyAsNullableInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt16\":[null,32767]}").PropertyAsNullableInt16);

                Assert.Equal(expectObj.PropertyAsNullableUInt16, actualObj.PropertyAsNullableUInt16);
                Assert.Equal(expectObj.PropertyAsNullableUInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt16\":[\"\",\"65535\"]}").PropertyAsNullableUInt16);
                Assert.Equal(expectObj.PropertyAsNullableUInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt16\":[null,65535]}").PropertyAsNullableUInt16);

                Assert.Equal(expectObj.PropertyAsNullableInt32, actualObj.PropertyAsNullableInt32);
                Assert.Equal(expectObj.PropertyAsNullableInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt32\":[\"\",\"2147483647\"]}").PropertyAsNullableInt32);
                Assert.Equal(expectObj.PropertyAsNullableInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt32\":[null,2147483647]}").PropertyAsNullableInt32);

                Assert.Equal(expectObj.PropertyAsNullableUInt32, actualObj.PropertyAsNullableUInt32);
                Assert.Equal(expectObj.PropertyAsNullableUInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt32\":[\"\",\"4294967295\"]}").PropertyAsNullableUInt32);
                Assert.Equal(expectObj.PropertyAsNullableUInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt32\":[null,4294967295]}").PropertyAsNullableUInt32);

                Assert.Equal(expectObj.PropertyAsNullableInt64, actualObj.PropertyAsNullableInt64);
                Assert.Equal(expectObj.PropertyAsNullableInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt64\":[\"\",\"9223372036854775807\"]}").PropertyAsNullableInt64);
                Assert.Equal(expectObj.PropertyAsNullableInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt64\":[null,9223372036854775807]}").PropertyAsNullableInt64);

                Assert.Equal(expectObj.PropertyAsNullableUInt64, actualObj.PropertyAsNullableUInt64);
                Assert.Equal(expectObj.PropertyAsNullableUInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt64\":[\"\",\"18446744073709551615\"]}").PropertyAsNullableUInt64);
                Assert.Equal(expectObj.PropertyAsNullableUInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt64\":[null,18446744073709551615]}").PropertyAsNullableUInt64);

                Assert.Equal(expectObj.PropertyAsNullableFloat, actualObj.PropertyAsNullableFloat);
                Assert.Equal(expectObj.PropertyAsNullableFloat, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableFloat\":[\"\",\"1.23\",\"NaN\",\"Infinity\",\"-Infinity\"]}").PropertyAsNullableFloat);
                Assert.Equal(expectObj.PropertyAsNullableFloat, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableFloat\":[null,1.23,\"NaN\",\"Infinity\",\"-Infinity\"]}").PropertyAsNullableFloat);

                Assert.Equal(expectObj.PropertyAsNullableDouble, actualObj.PropertyAsNullableDouble);
                Assert.Equal(expectObj.PropertyAsNullableDouble, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableDouble\":[\"\",\"1.23\",\"NaN\",\"Infinity\",\"-Infinity\"]}").PropertyAsNullableDouble);
                Assert.Equal(expectObj.PropertyAsNullableDouble, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableDouble\":[null,1.23,\"NaN\",\"Infinity\",\"-Infinity\"]}").PropertyAsNullableDouble);

                Assert.Equal(expectObj.PropertyAsNullableDecimal, actualObj.PropertyAsNullableDecimal);
                Assert.Equal(expectObj.PropertyAsNullableDecimal, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableDecimal\":[\"\",\"1.23\"]}").PropertyAsNullableDecimal);
                Assert.Equal(expectObj.PropertyAsNullableDecimal, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableDecimal\":[null,1.23]}").PropertyAsNullableDecimal);
            });
        }

        [Fact(DisplayName = "测试用例：自定义 Newtosoft.Json.JsonConverter 之 StringifiedNumberArrayConverter")]
        public void TestNewtosoftJsonConverter()
        {
            var jsonSettings = NewtonsoftJsonSerializer.GetDefaultSerializerSettings();
            jsonSettings.Formatting = Newtonsoft.Json.Formatting.None;
            jsonSettings.FloatFormatHandling = Newtonsoft.Json.FloatFormatHandling.String;

            TestCustomJsonConverter(new NewtonsoftJsonSerializer(jsonSettings));
        }
    }
}
