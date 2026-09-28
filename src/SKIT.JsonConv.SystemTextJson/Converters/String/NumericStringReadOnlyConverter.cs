namespace SKIT.JsonConv.SystemTextJson.Converters
{
    /// <summary>
    /// 一个 JSON 转换器，可针对指定适配类型做如下形式的对象转换。与 <seealso cref="NumericStringConverter"/> 类似，但转换过程是单向只读的。
    /// 与通过 System.Text.Json.Serialization.<see cref="JsonNumberHandling.WriteAsString"/> 参数控制相比，可兼容空字符串等特殊形式。
    /// <code>
    ///   .NET → string Foo { get; } = "1";
    ///   JSON → { "Foo": 1 }
    /// </code>
    /// 
    /// 适配类型：
    /// <see cref="string" />
    /// </summary>
    public class NumericStringReadOnlyConverter : JsonConverter<string?>
    {
        private static readonly JsonConverter<string?> _converter = new NumericStringConverter();
        private static readonly JsonConverter<string?> _fallback = (JsonConverter<string?>)JsonSerializerOptions.Default.GetConverter(typeof(string));

        public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return _converter.Read(ref reader, typeToConvert, options);
        }

        public override void Write(Utf8JsonWriter writer, string? value, JsonSerializerOptions options)
        {
            _fallback.Write(writer, value, options);
        }
    }
}
