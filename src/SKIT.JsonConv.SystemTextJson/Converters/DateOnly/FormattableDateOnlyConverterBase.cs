using System.Globalization;

namespace SKIT.JsonConv.SystemTextJson.Converters
{
    /// <summary>
    /// 一个 JSON 转换器基类，可针对指定适配类型做特定形式的对象转换。
    /// <br />
    /// 适配类型：
    /// <see cref="DateOnly">DateOnly</see>
    /// <see cref="DateOnly">Nullable&lt;DateOnly&gt;</see>
    /// </summary>
    public abstract partial class FormattableDateOnlyConverterBase : JsonConverterFactory
    {
        protected abstract string FormatString { get; }

        public override bool CanConvert(Type typeToConvert)
        {
            return
#if NET5_0_OR_GREATER
                   typeof(DateOnly) == typeToConvert ||
                   typeof(DateOnly?) == typeToConvert ||
#endif
                   typeof(DateTimeOffset) == typeToConvert ||
                   typeof(DateTimeOffset?) == typeToConvert;
        }

        public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
#if NET5_0_OR_GREATER
            if (typeof(DateOnly) == typeToConvert)
                return new InternalFormattableDateOnlyConverter(FormatString);
            if (typeof(DateOnly?) == typeToConvert)
                return new InternalFormattableNullableDateOnlyConverter(FormatString);
#endif
            if (typeof(DateTimeOffset) == typeToConvert)
                return new InternalFormattableDateTimeOffsetConverter(FormatString);
            if (typeof(DateTimeOffset?) == typeToConvert)
                return new InternalFormattableNullableDateTimeOffsetConverter(FormatString);

            throw new NotSupportedException();
        }
    }

    partial class FormattableDateOnlyConverterBase
    {
#if NET5_0_OR_GREATER
        private sealed class InternalFormattableNullableDateOnlyConverter : JsonConverter<DateOnly?>
        {
            private readonly string _dateFormat;

            public InternalFormattableNullableDateOnlyConverter(string dateFormat)
            {
                _dateFormat = dateFormat;
            }

            public override DateOnly? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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

                    DateOnly result;
                    if (DateOnly.TryParseExact(value, _dateFormat, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out result))
                        return result;
                    if (DateOnly.TryParse(value, out result))
                        return result;

                    throw new JsonException($"Could not parse String '{value}' to DateOnly.");
                }

                throw new JsonException($"Unexpected JSON token type '{reader.TokenType}' when reading.");
            }

            public override void Write(Utf8JsonWriter writer, DateOnly? value, JsonSerializerOptions options)
            {
                if (value is null)
                    writer.WriteNullValue();
                else
                    writer.WriteStringValue(value.Value.ToString(_dateFormat, DateTimeFormatInfo.InvariantInfo));
            }
        }

        private sealed class InternalFormattableDateOnlyConverter : JsonConverter<DateOnly>
        {
            private readonly JsonConverter<DateOnly?> _converter;

            public InternalFormattableDateOnlyConverter(string dateFormat)
            {
                _converter = new InternalFormattableNullableDateOnlyConverter(dateFormat);
            }

            public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                DateOnly? result = _converter.Read(ref reader, typeToConvert, options);
                return result.GetValueOrDefault();
            }

            public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
            {
                _converter.Write(writer, value, options);
            }
        }
#endif

        private sealed class InternalFormattableNullableDateTimeOffsetConverter : JsonConverter<DateTimeOffset?>
        {
            private readonly string _dateFormat;

            public InternalFormattableNullableDateTimeOffsetConverter(string dateFormat)
            {
                _dateFormat = dateFormat;
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
                    if (DateTimeOffset.TryParseExact(value, _dateFormat, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out result))
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
                    writer.WriteStringValue(value.Value.ToString(_dateFormat, DateTimeFormatInfo.InvariantInfo));
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
