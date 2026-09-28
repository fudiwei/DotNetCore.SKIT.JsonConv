namespace SKIT.JsonConv.UnitTests.TestCases
{
    public class TestCase_DynamicObjectConverterTest
    {
        private sealed class MockObject
        {
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.DynamicObjectConverter))]
            public dynamic? NullProperty { get; set; }

            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.DynamicObjectConverter))]
            public dynamic? BooleanProperty { get; set; }

            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.DynamicObjectConverter))]
            public dynamic? NumberProperty { get; set; }

            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.DynamicObjectConverter))]
            public dynamic? StringProperty { get; set; }

            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.DynamicObjectConverter))]
            public dynamic? GuidProperty { get; set; }

            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.DynamicObjectConverter))]
            public dynamic? ArrayProperty { get; set; }

            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.DynamicObjectConverter))]
            public dynamic? ListProperty { get; set; }

            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.DynamicObjectConverter))]
            public dynamic? DictionaryProperty { get; set; }

            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.DynamicObjectConverter))]
            public dynamic? AnonymousObjectProperty { get; set; }

            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.DynamicObjectConverter))]
            public dynamic? ObjectWithCustomConverterProperty { get; set; }
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
                    NullProperty = null,
                    BooleanProperty = true,
                    NumberProperty = 123456,
                    StringProperty = "abc",
                    GuidProperty = Guid.Parse("11112222-3333-4444-5555-666677778888"),
                    ArrayProperty = new object?[] { null, true, 123456, "abc" },
                    ListProperty = new List<object?>() { null, true, 123456, "abc" },
                    DictionaryProperty = new Dictionary<string, object?>() { { "k0", null }, { "k1", true }, { "k2", 123456 }, { "k3", "abc" } },
                    AnonymousObjectProperty = new { k0 = default(object), k1 = true, k2 = 123456, k3 = "abc" },
                    ObjectWithCustomConverterProperty = new MockNestedObject()
                    {
                        BooleanProperty = true,
                        BooleanPropertyWithConverter = true
                    }
                };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Contains("{\"BooleanProperty\":true,\"BooleanPropertyWithConverter\":1}", actualJson);

                Assert.Null((object?)actualObj.NullProperty);
                Assert.Equal((object)true, (object?)actualObj.BooleanProperty);
                Assert.Equal(123456, Convert.ToInt64(actualObj.NumberProperty));
                Assert.Equal((object)"abc", (object?)actualObj.StringProperty);
                Assert.Equal((object)"11112222-3333-4444-5555-666677778888", (object?)actualObj.GuidProperty);
                Assert.NotNull(actualObj.ArrayProperty);
                Assert.NotNull(actualObj.ListProperty);
                Assert.NotNull(actualObj.DictionaryProperty);
                Assert.NotNull(actualObj.AnonymousObjectProperty);
                Assert.NotNull(actualObj.ObjectWithCustomConverterProperty);
            });
        }

        [Fact(DisplayName = "测试用例：自定义 Newtosoft.Json.JsonConverter 之 DynamicObjectConverter")]
        public void TestNewtosoftJsonConverter()
        {
            var jsonSettings = NewtonsoftJsonSerializer.GetDefaultSerializerSettings();
            jsonSettings.Formatting = Newtonsoft.Json.Formatting.None;
            jsonSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;

            TestCustomJsonConverter(new NewtonsoftJsonSerializer(jsonSettings));
        }

        [Fact(DisplayName = "测试用例：自定义 System.Text.Json.Serialization.JsonConverter 之 DynamicObjectConverter")]
        public void TestSystemTextJsonConverter()
        {
            var jsonOptions = SystemTextJsonSerializer.GetDefaultSerializerOptions();
            jsonOptions.WriteIndented = false;
            jsonOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;

            TestCustomJsonConverter(new SystemTextJsonSerializer(jsonOptions));
        }
    }
}
