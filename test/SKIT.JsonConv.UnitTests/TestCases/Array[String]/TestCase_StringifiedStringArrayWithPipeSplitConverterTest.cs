namespace SKIT.JsonConv.UnitTests.TestCases
{
    public class TestCase_StringifiedStringArrayWithPipeSplitConverterTest
    {
        private sealed class MockObject
        {
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedStringArrayWithPipeSplitConverter))]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedStringArrayWithPipeSplitConverter))]
            public string[]? Property { get; set; }
        }

        private static void TestCustomJsonConverter(IJsonSerializer jsonSerializer)
        {
            Assert.Multiple(() =>
            {
                var expectObj = new MockObject() { Property = new string[] { "a", "b", "c" } };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Equal("{\"Property\":\"a|b|c\"}", actualJson);

                Assert.Equal(expectObj.Property, actualObj.Property);
            });
        }

        [Fact(DisplayName = "测试用例：自定义 Newtosoft.Json.JsonConverter 之 StringifiedStringArrayWithPipeSplitConverter")]
        public void TestNewtosoftJsonConverter()
        {
            var jsonSettings = NewtonsoftJsonSerializer.GetDefaultSerializerSettings();
            jsonSettings.Formatting = Newtonsoft.Json.Formatting.None;

            TestCustomJsonConverter(new NewtonsoftJsonSerializer(jsonSettings));
        }

        [Fact(DisplayName = "测试用例：自定义 System.Text.Json.Serialization.JsonConverter 之 StringifiedStringArrayWithPipeSplitConverter")]
        public void TestSystemTextJsonConverter()
        {
            var jsonOptions = SystemTextJsonSerializer.GetDefaultSerializerOptions();
            jsonOptions.WriteIndented = false;

            TestCustomJsonConverter(new SystemTextJsonSerializer(jsonOptions));
        }
    }
}
