namespace SKIT.JsonConv.UnitTests.TestCases
{
    public class TestCase_StringifiedNumberConverterTest
    {
        private sealed class MockObject
        {
            [Newtonsoft.Json.JsonProperty(Order = 101)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(101)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
            public byte PropertyAsByte { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 102)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(102)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
            public sbyte PropertyAsSByte { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 103)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(103)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
            public short PropertyAsInt16 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 104)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(104)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
            public ushort PropertyAsUInt16 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 105)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(105)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
            public int PropertyAsInt32 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 106)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(106)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
            public uint PropertyAsUInt32 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 107)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(107)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
            public long PropertyAsInt64 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 108)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(108)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
            public ulong PropertyAsUInt64 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 109)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(109)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
            public float PropertyAsFloat { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 110)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(110)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
            public double PropertyAsDouble { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 111)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(111)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
            public decimal PropertyAsDecimal { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 201)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(201)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
            public byte? PropertyAsNullableByte { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 202)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(202)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
            public sbyte? PropertyAsNullableSByte { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 203)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(203)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
            public short? PropertyAsNullableInt16 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 204)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(204)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
            public ushort? PropertyAsNullableUInt16 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 205)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(205)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
            public int? PropertyAsNullableInt32 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 206)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(206)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
            public uint? PropertyAsNullableUInt32 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 207)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(207)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
            public long? PropertyAsNullableInt64 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 208)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(208)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
            public ulong? PropertyAsNullableUInt64 { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 209)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(209)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
            public float? PropertyAsNullableFloat { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 210)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(210)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
            public double? PropertyAsNullableDouble { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 211)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(211)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberConverter))]
            public decimal? PropertyAsNullableDecimal { get; set; }
        }

        private static void TestCustomJsonConverter(IJsonSerializer jsonSerializer)
        {
            Assert.Multiple(() =>
            {
                var expectObj = new MockObject()
                {
                    PropertyAsByte = byte.MaxValue,
                    PropertyAsSByte = sbyte.MaxValue,
                    PropertyAsInt16 = short.MaxValue,
                    PropertyAsUInt16 = ushort.MaxValue,
                    PropertyAsInt32 = int.MaxValue,
                    PropertyAsUInt32 = uint.MaxValue,
                    PropertyAsInt64 = long.MaxValue,
                    PropertyAsUInt64 = ulong.MaxValue,
                    PropertyAsFloat = 1.23F,
                    PropertyAsDouble = 1.23D,
                    PropertyAsDecimal = 1.23M
                };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Contains("\"PropertyAsByte\":\"255\"", actualJson);
                Assert.Contains("\"PropertyAsSByte\":\"127\"", actualJson);
                Assert.Contains("\"PropertyAsInt16\":\"32767\"", actualJson);
                Assert.Contains("\"PropertyAsUInt16\":\"65535\"", actualJson);
                Assert.Contains("\"PropertyAsInt32\":\"2147483647\"", actualJson);
                Assert.Contains("\"PropertyAsUInt32\":\"4294967295\"", actualJson);
                Assert.Contains("\"PropertyAsInt64\":\"9223372036854775807\"", actualJson);
                Assert.Contains("\"PropertyAsUInt64\":\"18446744073709551615\"", actualJson);
                Assert.Contains("\"PropertyAsDecimal\":\"1.23\"", actualJson);

                Assert.Equal(expectObj.PropertyAsByte, actualObj.PropertyAsByte);
                Assert.Equal(expectObj.PropertyAsByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsByte\":255}").PropertyAsByte);
                Assert.Equal(expectObj.PropertyAsByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsByte\":\"255\"}").PropertyAsByte);

                Assert.Equal(expectObj.PropertyAsSByte, actualObj.PropertyAsSByte);
                Assert.Equal(expectObj.PropertyAsSByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsSByte\":127}").PropertyAsSByte);
                Assert.Equal(expectObj.PropertyAsSByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsSByte\":\"127\"}").PropertyAsSByte);

                Assert.Equal(expectObj.PropertyAsInt16, actualObj.PropertyAsInt16);
                Assert.Equal(expectObj.PropertyAsInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt16\":32767}").PropertyAsInt16);
                Assert.Equal(expectObj.PropertyAsInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt16\":\"32767\"}").PropertyAsInt16);

                Assert.Equal(expectObj.PropertyAsUInt16, actualObj.PropertyAsUInt16);
                Assert.Equal(expectObj.PropertyAsUInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt16\":65535}").PropertyAsUInt16);
                Assert.Equal(expectObj.PropertyAsUInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt16\":\"65535\"}").PropertyAsUInt16);

                Assert.Equal(expectObj.PropertyAsInt32, actualObj.PropertyAsInt32);
                Assert.Equal(expectObj.PropertyAsInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt32\":2147483647}").PropertyAsInt32);
                Assert.Equal(expectObj.PropertyAsInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt32\":\"2147483647\"}").PropertyAsInt32);

                Assert.Equal(expectObj.PropertyAsUInt32, actualObj.PropertyAsUInt32);
                Assert.Equal(expectObj.PropertyAsUInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt32\":4294967295}").PropertyAsUInt32);
                Assert.Equal(expectObj.PropertyAsUInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt32\":\"4294967295\"}").PropertyAsUInt32);

                Assert.Equal(expectObj.PropertyAsInt64, actualObj.PropertyAsInt64);
                Assert.Equal(expectObj.PropertyAsInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt64\":9223372036854775807}").PropertyAsInt64);
                Assert.Equal(expectObj.PropertyAsInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt64\":\"9223372036854775807\"}").PropertyAsInt64);

                Assert.Equal(expectObj.PropertyAsUInt64, actualObj.PropertyAsUInt64);
                Assert.Equal(expectObj.PropertyAsUInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt64\":18446744073709551615}").PropertyAsUInt64);
                Assert.Equal(expectObj.PropertyAsUInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt64\":\"18446744073709551615\"}").PropertyAsUInt64);

                Assert.Equal(expectObj.PropertyAsFloat, actualObj.PropertyAsFloat);
                Assert.Equal(expectObj.PropertyAsFloat, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsFloat\":1.23}").PropertyAsFloat);
                Assert.Equal(expectObj.PropertyAsFloat, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsFloat\":\"1.23\"}").PropertyAsFloat);

                Assert.Equal(expectObj.PropertyAsDouble, actualObj.PropertyAsDouble);
                Assert.Equal(expectObj.PropertyAsDouble, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsDouble\":1.23}").PropertyAsDouble);
                Assert.Equal(expectObj.PropertyAsDouble, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsDouble\":\"1.23\"}").PropertyAsDouble);

                Assert.Equal(expectObj.PropertyAsDecimal, actualObj.PropertyAsDecimal);
                Assert.Equal(expectObj.PropertyAsDecimal, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsDecimal\":1.23}").PropertyAsDecimal);
                Assert.Equal(expectObj.PropertyAsDecimal, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsDecimal\":\"1.23\"}").PropertyAsDecimal);

                Assert.Equal(expectObj.PropertyAsNullableByte, actualObj.PropertyAsNullableByte);
                Assert.Equal(expectObj.PropertyAsNullableByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableByte\":null}").PropertyAsNullableByte);
                Assert.Equal(expectObj.PropertyAsNullableByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableByte\":\"\"}").PropertyAsNullableByte);

                Assert.Equal(expectObj.PropertyAsNullableSByte, actualObj.PropertyAsNullableSByte);
                Assert.Equal(expectObj.PropertyAsNullableSByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableSByte\":null}").PropertyAsNullableSByte);
                Assert.Equal(expectObj.PropertyAsNullableSByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableSByte\":\"\"}").PropertyAsNullableSByte);

                Assert.Equal(expectObj.PropertyAsNullableInt16, actualObj.PropertyAsNullableInt16);
                Assert.Equal(expectObj.PropertyAsNullableInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt16\":null}").PropertyAsNullableInt16);
                Assert.Equal(expectObj.PropertyAsNullableInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt16\":\"\"}").PropertyAsNullableInt16);

                Assert.Equal(expectObj.PropertyAsNullableUInt16, actualObj.PropertyAsNullableUInt16);
                Assert.Equal(expectObj.PropertyAsNullableUInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt16\":null}").PropertyAsNullableUInt16);
                Assert.Equal(expectObj.PropertyAsNullableUInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt16\":\"\"}").PropertyAsNullableUInt16);

                Assert.Equal(expectObj.PropertyAsNullableInt32, actualObj.PropertyAsNullableInt32);
                Assert.Equal(expectObj.PropertyAsNullableInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt32\":null}").PropertyAsNullableInt32);
                Assert.Equal(expectObj.PropertyAsNullableInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt32\":\"\"}").PropertyAsNullableInt32);

                Assert.Equal(expectObj.PropertyAsNullableUInt32, actualObj.PropertyAsNullableUInt32);
                Assert.Equal(expectObj.PropertyAsNullableUInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt32\":null}").PropertyAsNullableUInt32);
                Assert.Equal(expectObj.PropertyAsNullableUInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt32\":\"\"}").PropertyAsNullableUInt32);

                Assert.Equal(expectObj.PropertyAsNullableInt64, actualObj.PropertyAsNullableInt64);
                Assert.Equal(expectObj.PropertyAsNullableInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt64\":null}").PropertyAsNullableInt64);
                Assert.Equal(expectObj.PropertyAsNullableInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt64\":\"\"}").PropertyAsNullableInt64);

                Assert.Equal(expectObj.PropertyAsNullableUInt64, actualObj.PropertyAsNullableUInt64);
                Assert.Equal(expectObj.PropertyAsNullableUInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt64\":null}").PropertyAsNullableUInt64);
                Assert.Equal(expectObj.PropertyAsNullableUInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt64\":\"\"}").PropertyAsNullableUInt64);

                Assert.Equal(expectObj.PropertyAsNullableFloat, actualObj.PropertyAsNullableFloat);
                Assert.Equal(expectObj.PropertyAsNullableFloat, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableFloat\":null}").PropertyAsNullableFloat);
                Assert.Equal(expectObj.PropertyAsNullableFloat, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableFloat\":\"\"}").PropertyAsNullableFloat);

                Assert.Equal(expectObj.PropertyAsNullableDouble, actualObj.PropertyAsNullableDouble);
                Assert.Equal(expectObj.PropertyAsNullableDouble, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableDouble\":null}").PropertyAsNullableDouble);
                Assert.Equal(expectObj.PropertyAsNullableDouble, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableDouble\":\"\"}").PropertyAsNullableDouble);

                Assert.Equal(expectObj.PropertyAsNullableDecimal, actualObj.PropertyAsNullableDecimal);
                Assert.Equal(expectObj.PropertyAsNullableDecimal, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableDecimal\":null}").PropertyAsNullableDecimal);
                Assert.Equal(expectObj.PropertyAsNullableDecimal, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableDecimal\":\"\"}").PropertyAsNullableDecimal);
            });

            Assert.Multiple(() =>
            {
                var expectObj = new MockObject()
                {
                    PropertyAsNullableByte = byte.MaxValue,
                    PropertyAsNullableSByte = sbyte.MaxValue,
                    PropertyAsNullableInt16 = short.MaxValue,
                    PropertyAsNullableUInt16 = ushort.MaxValue,
                    PropertyAsNullableInt32 = int.MaxValue,
                    PropertyAsNullableUInt32 = uint.MaxValue,
                    PropertyAsNullableInt64 = long.MaxValue,
                    PropertyAsNullableUInt64 = ulong.MaxValue,
                    PropertyAsNullableFloat = 1.23F,
                    PropertyAsNullableDouble = 1.23D,
                    PropertyAsNullableDecimal = 1.23M
                };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Contains("\"PropertyAsNullableByte\":\"255\"", actualJson);
                Assert.Contains("\"PropertyAsNullableSByte\":\"127\"", actualJson);
                Assert.Contains("\"PropertyAsNullableInt16\":\"32767\"", actualJson);
                Assert.Contains("\"PropertyAsNullableUInt16\":\"65535\"", actualJson);
                Assert.Contains("\"PropertyAsNullableInt32\":\"2147483647\"", actualJson);
                Assert.Contains("\"PropertyAsNullableUInt32\":\"4294967295\"", actualJson);
                Assert.Contains("\"PropertyAsNullableInt64\":\"9223372036854775807\"", actualJson);
                Assert.Contains("\"PropertyAsNullableUInt64\":\"18446744073709551615\"", actualJson);
                Assert.Contains("\"PropertyAsNullableDecimal\":\"1.23\"", actualJson);

                Assert.Equal(expectObj.PropertyAsByte, actualObj.PropertyAsByte);
                Assert.Equal(expectObj.PropertyAsByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsByte\":null}").PropertyAsByte);
                Assert.Equal(expectObj.PropertyAsByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsByte\":\"\"}").PropertyAsByte);

                Assert.Equal(expectObj.PropertyAsSByte, actualObj.PropertyAsSByte);
                Assert.Equal(expectObj.PropertyAsSByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsSByte\":null}").PropertyAsSByte);
                Assert.Equal(expectObj.PropertyAsSByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsSByte\":\"\"}").PropertyAsSByte);

                Assert.Equal(expectObj.PropertyAsInt16, actualObj.PropertyAsInt16);
                Assert.Equal(expectObj.PropertyAsInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt16\":null}").PropertyAsInt16);
                Assert.Equal(expectObj.PropertyAsInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt16\":\"\"}").PropertyAsInt16);

                Assert.Equal(expectObj.PropertyAsUInt16, actualObj.PropertyAsUInt16);
                Assert.Equal(expectObj.PropertyAsUInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt16\":null}").PropertyAsUInt16);
                Assert.Equal(expectObj.PropertyAsUInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt16\":\"\"}").PropertyAsUInt16);

                Assert.Equal(expectObj.PropertyAsInt32, actualObj.PropertyAsInt32);
                Assert.Equal(expectObj.PropertyAsInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt32\":null}").PropertyAsInt32);
                Assert.Equal(expectObj.PropertyAsInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt32\":\"\"}").PropertyAsInt32);

                Assert.Equal(expectObj.PropertyAsUInt32, actualObj.PropertyAsUInt32);
                Assert.Equal(expectObj.PropertyAsUInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt32\":null}").PropertyAsUInt32);
                Assert.Equal(expectObj.PropertyAsUInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt32\":\"\"}").PropertyAsUInt32);

                Assert.Equal(expectObj.PropertyAsInt64, actualObj.PropertyAsInt64);
                Assert.Equal(expectObj.PropertyAsInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt64\":null}").PropertyAsInt64);
                Assert.Equal(expectObj.PropertyAsInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsInt64\":\"\"}").PropertyAsInt64);

                Assert.Equal(expectObj.PropertyAsUInt64, actualObj.PropertyAsUInt64);
                Assert.Equal(expectObj.PropertyAsUInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt64\":null}").PropertyAsUInt64);
                Assert.Equal(expectObj.PropertyAsUInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsUInt64\":\"\"}").PropertyAsUInt64);

                Assert.Equal(expectObj.PropertyAsFloat, actualObj.PropertyAsFloat);
                Assert.Equal(expectObj.PropertyAsFloat, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsFloat\":null}").PropertyAsFloat);
                Assert.Equal(expectObj.PropertyAsFloat, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsFloat\":\"\"}").PropertyAsFloat);

                Assert.Equal(expectObj.PropertyAsDouble, actualObj.PropertyAsDouble);
                Assert.Equal(expectObj.PropertyAsDouble, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsDouble\":null}").PropertyAsDouble);
                Assert.Equal(expectObj.PropertyAsDouble, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsDouble\":\"\"}").PropertyAsDouble);

                Assert.Equal(expectObj.PropertyAsDecimal, actualObj.PropertyAsDecimal);
                Assert.Equal(expectObj.PropertyAsDecimal, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsDecimal\":null}").PropertyAsDecimal);
                Assert.Equal(expectObj.PropertyAsDecimal, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsDecimal\":\"\"}").PropertyAsDecimal);

                Assert.Equal(expectObj.PropertyAsNullableByte, actualObj.PropertyAsNullableByte);
                Assert.Equal(expectObj.PropertyAsNullableByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableByte\":255}").PropertyAsNullableByte);
                Assert.Equal(expectObj.PropertyAsNullableByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableByte\":\"255\"}").PropertyAsNullableByte);

                Assert.Equal(expectObj.PropertyAsNullableSByte, actualObj.PropertyAsNullableSByte);
                Assert.Equal(expectObj.PropertyAsNullableSByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableSByte\":127}").PropertyAsNullableSByte);
                Assert.Equal(expectObj.PropertyAsNullableSByte, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableSByte\":\"127\"}").PropertyAsNullableSByte);

                Assert.Equal(expectObj.PropertyAsNullableInt16, actualObj.PropertyAsNullableInt16);
                Assert.Equal(expectObj.PropertyAsNullableInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt16\":32767}").PropertyAsNullableInt16);
                Assert.Equal(expectObj.PropertyAsNullableInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt16\":\"32767\"}").PropertyAsNullableInt16);

                Assert.Equal(expectObj.PropertyAsNullableUInt16, actualObj.PropertyAsNullableUInt16);
                Assert.Equal(expectObj.PropertyAsNullableUInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt16\":65535}").PropertyAsNullableUInt16);
                Assert.Equal(expectObj.PropertyAsNullableUInt16, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt16\":\"65535\"}").PropertyAsNullableUInt16);

                Assert.Equal(expectObj.PropertyAsNullableInt32, actualObj.PropertyAsNullableInt32);
                Assert.Equal(expectObj.PropertyAsNullableInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt32\":2147483647}").PropertyAsNullableInt32);
                Assert.Equal(expectObj.PropertyAsNullableInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt32\":\"2147483647\"}").PropertyAsNullableInt32);

                Assert.Equal(expectObj.PropertyAsNullableUInt32, actualObj.PropertyAsNullableUInt32);
                Assert.Equal(expectObj.PropertyAsNullableUInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt32\":4294967295}").PropertyAsNullableUInt32);
                Assert.Equal(expectObj.PropertyAsNullableUInt32, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt32\":\"4294967295\"}").PropertyAsNullableUInt32);

                Assert.Equal(expectObj.PropertyAsNullableInt64, actualObj.PropertyAsNullableInt64);
                Assert.Equal(expectObj.PropertyAsNullableInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt64\":9223372036854775807}").PropertyAsNullableInt64);
                Assert.Equal(expectObj.PropertyAsNullableInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableInt64\":\"9223372036854775807\"}").PropertyAsNullableInt64);

                Assert.Equal(expectObj.PropertyAsNullableUInt64, actualObj.PropertyAsNullableUInt64);
                Assert.Equal(expectObj.PropertyAsNullableUInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt64\":18446744073709551615}").PropertyAsNullableUInt64);
                Assert.Equal(expectObj.PropertyAsNullableUInt64, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableUInt64\":\"18446744073709551615\"}").PropertyAsNullableUInt64);

                Assert.Equal(expectObj.PropertyAsNullableFloat, actualObj.PropertyAsNullableFloat);
                Assert.Equal(expectObj.PropertyAsNullableFloat, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableFloat\":1.23}").PropertyAsNullableFloat);
                Assert.Equal(expectObj.PropertyAsNullableFloat, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableFloat\":\"1.23\"}").PropertyAsNullableFloat);

                Assert.Equal(expectObj.PropertyAsNullableDouble, actualObj.PropertyAsNullableDouble);
                Assert.Equal(expectObj.PropertyAsNullableDouble, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableDouble\":1.23}").PropertyAsNullableDouble);
                Assert.Equal(expectObj.PropertyAsNullableDouble, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableDouble\":\"1.23\"}").PropertyAsNullableDouble);

                Assert.Equal(expectObj.PropertyAsNullableDecimal, actualObj.PropertyAsNullableDecimal);
                Assert.Equal(expectObj.PropertyAsNullableDecimal, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableDecimal\":1.23}").PropertyAsNullableDecimal);
                Assert.Equal(expectObj.PropertyAsNullableDecimal, jsonSerializer.Deserialize<MockObject>("{\"PropertyAsNullableDecimal\":\"1.23\"}").PropertyAsNullableDecimal);
            });
        }

        [Fact(DisplayName = "测试用例：自定义 Newtosoft.Json.JsonConverter 之 StringifiedNumberConverter")]
        public void TestNewtosoftJsonConverter()
        {
            var jsonSettings = NewtonsoftJsonSerializer.GetDefaultSerializerSettings();
            jsonSettings.Formatting = Newtonsoft.Json.Formatting.None;
            jsonSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;

            TestCustomJsonConverter(new NewtonsoftJsonSerializer(jsonSettings));
        }

        [Fact(DisplayName = "测试用例：自定义 System.Text.Json.JsonConverter 之 StringifiedNumberConverter")]
        public void TestSystemTextJsonConverter()
        {
            var jsonOptions = SystemTextJsonSerializer.GetDefaultSerializerOptions();
            jsonOptions.WriteIndented = false;
            jsonOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;

            TestCustomJsonConverter(new SystemTextJsonSerializer(jsonOptions));
        }
    }
}
