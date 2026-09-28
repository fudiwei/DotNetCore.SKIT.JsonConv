namespace SKIT.JsonConv.UnitTests.TestCases
{
    public class TestCase_NumericBooleanReadOnlyConverterTest
    {
        private sealed class MockObject
        {
            [Newtonsoft.Json.JsonProperty(Order = 1)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanReadOnlyConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(1)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanReadOnlyConverter))]
            public bool Property { get; set; }

            [Newtonsoft.Json.JsonProperty(Order = 2)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanReadOnlyConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(2)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanReadOnlyConverter))]
            public bool? NullableProperty { get; set; }
        }

        private static void TestCustomJsonConverter(IJsonSerializer jsonSerializer)
        {
            Assert.Multiple(() =>
            {
                var expectObj = new MockObject() { NullableProperty = null };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Equal("{\"Property\":false}", actualJson);

                Assert.Equal(expectObj.Property, actualObj.Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":0}").Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{}").Property);

                Assert.Equal(expectObj.NullableProperty, actualObj.NullableProperty);
                Assert.Equal(expectObj.NullableProperty, jsonSerializer.Deserialize<MockObject>("{\"NullableProperty\":null}").NullableProperty);
                Assert.Equal(expectObj.NullableProperty, jsonSerializer.Deserialize<MockObject>("{}").NullableProperty);
            });

            Assert.Multiple(() =>
            {
                var expectObj = new MockObject() { Property = false, NullableProperty = false };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Equal("{\"Property\":false,\"NullableProperty\":false}", actualJson);

                Assert.Equal(expectObj.Property, actualObj.Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":0}").Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":\"0\"}").Property);

                Assert.Equal(expectObj.NullableProperty, actualObj.NullableProperty);
                Assert.Equal(expectObj.NullableProperty, jsonSerializer.Deserialize<MockObject>("{\"NullableProperty\":0}").NullableProperty);
                Assert.Equal(expectObj.NullableProperty, jsonSerializer.Deserialize<MockObject>("{\"NullableProperty\":\"0\"}").NullableProperty);
            });

            Assert.Multiple(() =>
            {
                var expectObj = new MockObject() { Property = true, NullableProperty = true };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Equal("{\"Property\":true,\"NullableProperty\":true}", actualJson);

                Assert.Equal(expectObj.Property, actualObj.Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":1}").Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":\"1\"}").Property);

                Assert.Equal(expectObj.NullableProperty, actualObj.NullableProperty);
                Assert.Equal(expectObj.NullableProperty, jsonSerializer.Deserialize<MockObject>("{\"NullableProperty\":1}").NullableProperty);
                Assert.Equal(expectObj.NullableProperty, jsonSerializer.Deserialize<MockObject>("{\"NullableProperty\":\"1\"}").NullableProperty);
            });
        }

        [Fact(DisplayName = "测试用例：自定义 Newtosoft.Json.JsonConverter 之 NumericBooleanReadOnlyConverter")]
        public void TestNewtosoftJsonConverter()
        {
            var jsonSettings = NewtonsoftJsonSerializer.GetDefaultSerializerSettings();
            jsonSettings.Formatting = Newtonsoft.Json.Formatting.None;
            jsonSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;

            TestCustomJsonConverter(new NewtonsoftJsonSerializer(jsonSettings));
        }

        [Fact(DisplayName = "测试用例：自定义 System.Text.Json.Serialization.JsonConverter 之 NumericBooleanReadOnlyConverter")]
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
