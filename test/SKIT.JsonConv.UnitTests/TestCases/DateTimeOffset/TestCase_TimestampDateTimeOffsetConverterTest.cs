namespace SKIT.JsonConv.UnitTests.TestCases
{
    public class TestCase_TimestampDateTimeOffsetConverterTest
    {
        private sealed class MockObject
        {
            [Newtonsoft.Json.JsonProperty(Order = 1)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.TimestampDateTimeOffsetConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(1)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.TimestampDateTimeOffsetConverter))]
            public DateTimeOffset Property { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 2)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.TimestampDateTimeOffsetConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(2)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.TimestampDateTimeOffsetConverter))]
            public DateTimeOffset? NullableProperty { get; set; }
        }

        private static void TestCustomJsonConverter(IJsonSerializer jsonSerializer)
        {
            DateTimeOffset DATETIME = new DateTimeOffset(2006, 1, 2, 15, 4, 5, TimeSpan.FromHours(8));

            Assert.Multiple(() =>
            {
                var expectObj = new MockObject() { Property = DATETIME, NullableProperty = null };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Equal("{\"Property\":1136185445}", actualJson);

                Assert.Equal(expectObj.Property, actualObj.Property);
                Assert.Equal(expectObj.NullableProperty, actualObj.NullableProperty);
            });

            Assert.Multiple(() =>
            {
                var expectObj = new MockObject() { Property = DATETIME, NullableProperty = DATETIME };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Equal("{\"Property\":1136185445,\"NullableProperty\":1136185445}", actualJson);

                Assert.Equal(expectObj.Property, actualObj.Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":\"1136185445\"}").Property);

                Assert.Equal(expectObj.NullableProperty, actualObj.NullableProperty);
                Assert.Equal(expectObj.NullableProperty, jsonSerializer.Deserialize<MockObject>("{\"NullableProperty\":\"1136185445\"}").NullableProperty);
            });
        }

        [Fact(DisplayName = "测试用例：自定义 Newtosoft.Json.JsonConverter 之 TimestampDateTimeOffsetConverter")]
        public void TestNewtosoftJsonConverter()
        {
            var jsonSettings = NewtonsoftJsonSerializer.GetDefaultSerializerSettings();
            jsonSettings.Formatting = Newtonsoft.Json.Formatting.None;
            jsonSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;

            TestCustomJsonConverter(new NewtonsoftJsonSerializer(jsonSettings));
        }

        [Fact(DisplayName = "测试用例：自定义 System.Text.Json.Serialization.JsonConverter 之 TimestampDateTimeOffsetConverter")]
        public void TestSystemTextJsonConverter()
        {
            var jsonOptions = SystemTextJsonSerializer.GetDefaultSerializerOptions();
            jsonOptions.WriteIndented = false;
            jsonOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
            jsonOptions.NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString;

            TestCustomJsonConverter(new SystemTextJsonSerializer(jsonOptions));
        }
    }
}
