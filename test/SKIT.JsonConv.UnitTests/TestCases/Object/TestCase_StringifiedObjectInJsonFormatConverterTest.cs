namespace SKIT.JsonConv.UnitTests.TestCases
{
    public class TestCase_StringifiedObjectInJsonFormatConverterTest
    {
        private sealed class MockObject
        {
            [Newtonsoft.Json.JsonProperty(nameof(PlainObject), Order = 1)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedObjectInJsonFormatConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(1)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedObjectInJsonFormatConverter))]
            public MockNestedObject? PlainObject { get; set; }

            [Newtonsoft.Json.JsonProperty(nameof(CollectionObject), Order = 2)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedObjectInJsonFormatConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(2)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedObjectInJsonFormatConverter))]
            public List<string>? CollectionObject { get; set; }

            [Newtonsoft.Json.JsonProperty(nameof(GenericPlainObject), Order = 3)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedObjectInJsonFormatConverter<MockNestedObject>))]
            [System.Text.Json.Serialization.JsonPropertyOrder(3)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedObjectInJsonFormatConverter<MockNestedObject>))]
            public MockNestedObject? GenericPlainObject { get; set; }

            [Newtonsoft.Json.JsonProperty(nameof(GenericCollectionObject), Order = 4)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedObjectInJsonFormatConverter<IList<string>>))]
            [System.Text.Json.Serialization.JsonPropertyOrder(4)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedObjectInJsonFormatConverter<IList<string>>))]
            public List<string>? GenericCollectionObject { get; set; }
        }

        private sealed class MockNestedObject
        {
            [Newtonsoft.Json.JsonProperty(nameof(BooleanProperty), Order = 1)]
            [System.Text.Json.Serialization.JsonPropertyOrder(1)]
            public bool BooleanProperty { get; set; }

            [Newtonsoft.Json.JsonProperty(nameof(BooleanPropertyWithConverter), Order = 1)]
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanConverter))]
            [System.Text.Json.Serialization.JsonPropertyOrder(1)]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
            public bool BooleanPropertyWithConverter { get; set; }
        }

        private static void TestCustomJsonConverter(IJsonSerializer jsonSerializer)
        {
            Assert.Multiple(() =>
            {
                var expectObj = new MockObject()
                {
                    PlainObject = new MockNestedObject()
                    {
                        BooleanProperty = true,
                        BooleanPropertyWithConverter = true
                    },
                    CollectionObject = new List<string>() { "hello" },
                    GenericPlainObject = new MockNestedObject()
                    {
                        BooleanProperty = false,
                        BooleanPropertyWithConverter = false
                    },
                    GenericCollectionObject = new List<string>() { "world" }
                };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Equal("{\"PlainObject\":\"{\\\"BooleanProperty\\\":true,\\\"BooleanPropertyWithConverter\\\":1}\",\"CollectionObject\":\"[\\\"hello\\\"]\",\"GenericPlainObject\":\"{\\\"BooleanProperty\\\":false,\\\"BooleanPropertyWithConverter\\\":0}\",\"GenericCollectionObject\":\"[\\\"world\\\"]\"}", actualJson);

                Assert.Equal(expectObj.PlainObject!.BooleanProperty, actualObj.PlainObject?.BooleanProperty);
                Assert.Equal(expectObj.PlainObject!.BooleanPropertyWithConverter, actualObj.PlainObject?.BooleanPropertyWithConverter);
                Assert.Equal(expectObj.CollectionObject, actualObj.CollectionObject);

                Assert.Equal(expectObj.GenericPlainObject!.BooleanProperty, actualObj.GenericPlainObject?.BooleanProperty);
                Assert.Equal(expectObj.GenericPlainObject!.BooleanPropertyWithConverter, actualObj.GenericPlainObject?.BooleanPropertyWithConverter);
                Assert.Equal(expectObj.GenericCollectionObject, actualObj.GenericCollectionObject);
            });
        }

        [Fact(DisplayName = "测试用例：自定义 Newtosoft.Json.JsonConverter 之 StringifiedObjectInJsonFormatConverter")]
        public void TestNewtosoftJsonConverter()
        {
            var jsonSettings = NewtonsoftJsonSerializer.GetDefaultSerializerSettings();
            jsonSettings.Formatting = Newtonsoft.Json.Formatting.None;

            TestCustomJsonConverter(new NewtonsoftJsonSerializer(jsonSettings));
        }

        [Fact(DisplayName = "测试用例：自定义 System.Text.Json.Serialization.JsonConverter 之 StringifiedObjectInJsonFormatConverter")]
        public void TestSystemTextJsonConverter()
        {
            var jsonOptions = SystemTextJsonSerializer.GetDefaultSerializerOptions();
            jsonOptions.WriteIndented = false;

            TestCustomJsonConverter(new SystemTextJsonSerializer(jsonOptions));
        }
    }
}
