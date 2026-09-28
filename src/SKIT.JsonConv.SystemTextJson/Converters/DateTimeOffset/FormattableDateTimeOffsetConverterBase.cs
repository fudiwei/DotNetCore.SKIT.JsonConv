using System.Globalization;

namespace SKIT.JsonConv.SystemTextJson.Converters
{
    /// <summary>
    /// 一个 JSON 转换器基类，可针对指定适配类型做特定形式的对象转换。
    /// <br />
    /// 适配类型：
    /// <see cref="DateTimeOffset">DateTimeOffset</see>,
    /// <see cref="DateTimeOffset">Nullable&lt;DateTimeOffset&gt;</see>
    /// </summary>
    public abstract partial class FormattableDateTimeOffsetConverterBase : JsonConverterFactory
    {
        protected abstract string FormatString { get; }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(DateTimeOffset) == typeToConvert ||
                   typeof(DateTimeOffset?) == typeToConvert;
        }

        public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            if (typeof(DateTimeOffset) == typeToConvert)
                return new InternalFormattableDateTimeOffsetConverter(FormatString);
            if (typeof(DateTimeOffset?) == typeToConvert)
                return new InternalFormattableNullableDateTimeOffsetConverter(FormatString);

            throw new NotSupportedException();
        }
    }

    partial class FormattableDateTimeOffsetConverterBase
    {
        private sealed class InternalFormattableNullableDateTimeOffsetConverter : JsonConverter<DateTimeOffset?>
        {
            private readonly string _formatString;

            public InternalFormattableNullableDateTimeOffsetConverter(string formatString)
            {
                _formatString = formatString;
            }

            public override DateTimeOffset? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                if (reader.TokenType == JsonTokenType.Null)
                {
                    return null;
                }
                else if (reader.TokenType == JsonTokenType.String)
                {
                    string? value = reader.GetString();
                    if (string.IsNullOrEmpty(value))
                        return null;

                    DateTimeOffset result;
                    if (DateTimeOffset.TryParseExact(value, _formatString, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out result))
                        return result;
                    if (DateTimeOffset.TryParse(value, out result))
                        return result;

                    throw new JsonException($"Could not parse String '{value}' to DateTimeOffset.");
                }

                throw new JsonException($"Unexpected JSON token type '{reader.TokenType}' when reading.");
            }

            public override void Write(Utf8JsonWriter writer, DateTimeOffset? value, JsonSerializerOptions options)
            {
                if (value is null)
                    writer.WriteNullValue();
                else
                    writer.WriteStringValue(value.Value.ToString(_formatString, DateTimeFormatInfo.InvariantInfo));
            }
        }

        private sealed class InternalFormattableDateTimeOffsetConverter : JsonConverter<DateTimeOffset>
        {
            private readonly JsonConverter<DateTimeOffset?> _converter;

            public InternalFormattableDateTimeOffsetConverter(string dateFormat)
            {
                _converter = new InternalFormattableNullableDateTimeOffsetConverter(dateFormat);
            }

            public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                DateTimeOffset? result = _converter.Read(ref reader, typeToConvert, options);
                return result.GetValueOrDefault();
            }

            public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
            {
                _converter.Write(writer, value, options);
            }
        }
    }
}
