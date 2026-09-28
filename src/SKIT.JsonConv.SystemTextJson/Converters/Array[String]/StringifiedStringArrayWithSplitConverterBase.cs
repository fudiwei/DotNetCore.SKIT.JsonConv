namespace SKIT.JsonConv.SystemTextJson.Converters
{
    /// <summary>
    /// 一个 JSON 转换器基类，可针对指定适配类型做特定形式的对象转换。
    /// <br />
    /// 适配类型：
    /// <see cref="string">string[]</see>
    /// </summary>
    public abstract class StringifiedStringArrayWithSplitConverterBase : JsonConverter<string[]?>
    {
        protected abstract string Separator { get; }

        public override string[]? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }
            else if (reader.TokenType == JsonTokenType.String)
            {
                string? value = reader.GetString();
                if (value is null)
                    return null;
                if (value == string.Empty)
                    return Array.Empty<string>();

#if NET5_0_OR_GREATER
                return value.Split(Separator);
#else
                return value.Split(new string[] { Separator }, StringSplitOptions.None);
#endif
            }

            throw new JsonException($"Unexpected JSON token type '{reader.TokenType}' when reading.");
        }

        public override void Write(Utf8JsonWriter writer, string[]? value, JsonSerializerOptions options)
        {
            if (value is null)
                writer.WriteNullValue();
            else
                writer.WriteStringValue(string.Join(Separator, value));
        }
    }
}
