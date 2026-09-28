namespace SKIT.JsonConv.UnitTests.TestCases
{
    public class TestCase_NumericStringConverterTest
    {
        private sealed class MockObject
        {
            [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericStringConverter))]
            [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringConverter))]
            public string? Property { get; set; }
        }

        private static void TestCustomJsonConverter(IJsonSerializer jsonSerializer)
        {
            Assert.Multiple(() =>
            {
                var expectObj = new MockObject() { Property = "" };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Equal("{\"Property\":\"\"}", actualJson);

                Assert.Equal(expectObj.Property, actualObj.Property);
            });

            Assert.Multiple(() =>
            {
                var expectObj = new MockObject() { Property = "32767" };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Equal("{\"Property\":32767}", actualJson);

                Assert.Equal(expectObj.Property, actualObj.Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":\"32767\"}").Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":32767}").Property);
            });

            Assert.Multiple(() =>
            {
                var expectObj = new MockObject() { Property = "-32768" };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Equal("{\"Property\":-32768}", actualJson);

                Assert.Equal(expectObj.Property, actualObj.Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":\"-32768\"}").Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":-32768}").Property);
            });

            Assert.Multiple(() =>
            {
                var expectObj = new MockObject() { Property = "2147483647" };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Equal("{\"Property\":2147483647}", actualJson);

                Assert.Equal(expectObj.Property, actualObj.Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":\"2147483647\"}").Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":2147483647}").Property);
            });

            Assert.Multiple(() =>
            {
                var expectObj = new MockObject() { Property = "-2147483648" };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Equal("{\"Property\":-2147483648}", actualJson);

                Assert.Equal(expectObj.Property, actualObj.Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":\"-2147483648\"}").Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":-2147483648}").Property);
            });

            Assert.Multiple(() =>
            {
                var expectObj = new MockObject() { Property = "9223372036854775807" };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Equal("{\"Property\":9223372036854775807}", actualJson);

                Assert.Equal(expectObj.Property, actualObj.Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":\"9223372036854775807\"}").Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":9223372036854775807}").Property);
            });

            Assert.Multiple(() =>
            {
                var expectObj = new MockObject() { Property = "-9223372036854775808" };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Equal("{\"Property\":-9223372036854775808}", actualJson);

                Assert.Equal(expectObj.Property, actualObj.Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":\"-9223372036854775808\"}").Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":-9223372036854775808}").Property);
            });

            Assert.Multiple(() =>
            {
                var expectObj = new MockObject() { Property = "18446744073709551615" };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Equal("{\"Property\":18446744073709551615}", actualJson);

                Assert.Equal(expectObj.Property, actualObj.Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":\"18446744073709551615\"}").Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":18446744073709551615}").Property);
            });

            Assert.Multiple(() =>
            {
                var expectObj = new MockObject() { Property = "1.23" };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Equal("{\"Property\":1.23}", actualJson);

                Assert.Equal(expectObj.Property, actualObj.Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":\"1.23\"}").Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":1.23}").Property);
            });

            Assert.Multiple(() =>
            {
                var expectObj = new MockObject() { Property = "-1.23" };
                var actualJson = jsonSerializer.Serialize(expectObj);
                var actualObj = jsonSerializer.Deserialize<MockObject>(actualJson);

                Assert.Equal("{\"Property\":-1.23}", actualJson);

                Assert.Equal(expectObj.Property, actualObj.Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":\"-1.23\"}").Property);
                Assert.Equal(expectObj.Property, jsonSerializer.Deserialize<MockObject>("{\"Property\":-1.23}").Property);
            });
        }

        [Fact(DisplayName = "测试用例：自定义 Newtosoft.Json.JsonConverter 之 NumericStringConverter")]
        public void TestNewtosoftJsonConverter()
        {
            var jsonSettings = NewtonsoftJsonSerializer.GetDefaultSerializerSettings();
            jsonSettings.Formatting = Newtonsoft.Json.Formatting.None;

            TestCustomJsonConverter(new NewtonsoftJsonSerializer(jsonSettings));
        }

        [Fact(DisplayName = "测试用例：自定义 System.Text.Json.Serialization.JsonConverter 之 NumericStringConverter")]
        public void TestSystemTextJsonConverter()
        {
            var jsonOptions = SystemTextJsonSerializer.GetDefaultSerializerOptions();
            jsonOptions.WriteIndented = false;

            TestCustomJsonConverter(new SystemTextJsonSerializer(jsonOptions));
        }
    }
}
