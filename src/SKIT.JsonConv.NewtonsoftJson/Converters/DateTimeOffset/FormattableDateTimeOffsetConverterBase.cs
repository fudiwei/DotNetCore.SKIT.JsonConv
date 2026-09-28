using System.Globalization;

namespace SKIT.JsonConv.NewtonsoftJson.Converters
{
    /// <summary>
    /// 一个 JSON 转换器基类，可针对指定适配类型做特定形式的对象转换。
    /// <br />
    /// 适配类型：
    /// <see cref="DateTimeOffset">DateTimeOffset</see>,
    /// <see cref="DateTimeOffset">Nullable&lt;DateTimeOffset&gt;</see>
    /// </summary>
    public abstract partial class FormattableDateTimeOffsetConverterBase : JsonConverter
    {
        protected abstract string FormatString { get; }

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return true; }
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(DateTimeOffset) == objectType ||
                   typeof(DateTimeOffset?) == objectType;
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            JsonConverter<DateTimeOffset?> converter = new InternalFormattableDateTimeOffsetConverter(FormatString);
            DateTimeOffset? result = converter.ReadJson(reader, objectType, (DateTimeOffset?)existingValue, (DateTimeOffset?)existingValue is not null, serializer);
            if (objectType == typeof(DateTimeOffset))
                return result.GetValueOrDefault();
            return result;
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            JsonConverter<DateTimeOffset?> converter = new InternalFormattableDateTimeOffsetConverter(FormatString);
            converter.WriteJson(writer, (DateTimeOffset?)value, serializer);
        }
    }

    partial class FormattableDateTimeOffsetConverterBase
    {
        private sealed class InternalFormattableDateTimeOffsetConverter : JsonConverter<DateTimeOffset?>
        {
            private readonly string _formatString;

            public override bool CanRead
            {
                get { return true; }
            }

            public override bool CanWrite
            {
                get { return true; }
            }

            public InternalFormattableDateTimeOffsetConverter(string formatString)
            {
                _formatString = formatString;
            }

            public override DateTimeOffset? ReadJson(JsonReader reader, Type objectType, DateTimeOffset? existingValue, bool hasExistingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null)
                {
                    return existingValue;
                }
                else if (reader.TokenType == JsonToken.String)
                {
                    string? value = serializer.Deserialize<string>(reader);
                    if (string.IsNullOrEmpty(value))
                        return existingValue;

                    DateTimeOffset result;
                    if (DateTimeOffset.TryParseExact(value, _formatString, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out result))
                        return result;
                    if (DateTimeOffset.TryParse(value, out result))
                        return result;

                    throw new JsonSerializationException($"Could not parse String '{value}' to DateTimeOffset.");
                }
                else if (reader.TokenType == JsonToken.Date)
                {
                    reader.DateFormatString = _formatString;
                    return serializer.Deserialize<DateTimeOffset>(reader);
                }

                throw new JsonSerializationException($"Unexpected token type '{reader.TokenType}' when deserializing. Path '{reader.Path}'.");
            }

            public override void WriteJson(JsonWriter writer, DateTimeOffset? value, JsonSerializer serializer)
            {
                if (value is null)
                    writer.WriteNull();
                else
                    writer.WriteValue(value.Value.ToString(_formatString, DateTimeFormatInfo.InvariantInfo));
            }
        }
    }
}
