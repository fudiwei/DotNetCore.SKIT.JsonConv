#if NET5_0_OR_GREATER
using System.Globalization;

namespace SKIT.JsonConv.SystemTextJson.Converters
{
    /// <summary>
    /// 一个 JSON 转换器基类，可针对指定适配类型做特定形式的对象转换。
    /// <br />
    /// 适配类型：
    /// <see cref="TimeOnly">TimeOnly</see>
    /// <see cref="TimeOnly">Nullable&lt;TimeOnly&gt;</see>
    /// </summary>
    public abstract partial class FormattableTimeOnlyConverterBase : JsonConverterFactory
    {
        protected abstract string FormatString { get; }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(TimeOnly) == typeToConvert ||
                   typeof(TimeOnly?) == typeToConvert;
        }

        public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            if (typeof(TimeOnly) == typeToConvert)
                return new InternalFormattableTimeOnlyConverter(FormatString);
            if (typeof(TimeOnly?) == typeToConvert)
                return new InternalFormattableNullableTimeOnlyConverter(FormatString);

            throw new NotSupportedException();
        }
    }

    partial class FormattableTimeOnlyConverterBase
    {
        private sealed class InternalFormattableNullableTimeOnlyConverter : JsonConverter<TimeOnly?>
        {
            private readonly string _dateFormat;

            public InternalFormattableNullableTimeOnlyConverter(string dateFormat)
            {
                _dateFormat = dateFormat;
            }

            public override TimeOnly? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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

                    TimeOnly result;
                    if (TimeOnly.TryParseExact(value, _dateFormat, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out result))
                        return result;
                    if (TimeOnly.TryParse(value, out result))
                        return result;

                    throw new JsonException($"Could not parse String '{value}' to TimeOnly.");
                }

                throw new JsonException($"Unexpected JSON token type '{reader.TokenType}' when reading.");
            }

            public override void Write(Utf8JsonWriter writer, TimeOnly? value, JsonSerializerOptions options)
            {
                if (value is null)
                    writer.WriteNullValue();
                else
                    writer.WriteStringValue(value.Value.ToString(_dateFormat, DateTimeFormatInfo.InvariantInfo));
            }
        }

        private sealed class InternalFormattableTimeOnlyConverter : JsonConverter<TimeOnly>
        {
            private readonly JsonConverter<TimeOnly?> _converter;

            public InternalFormattableTimeOnlyConverter(string dateFormat)
            {
                _converter = new InternalFormattableNullableTimeOnlyConverter(dateFormat);
            }

            public override TimeOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                TimeOnly? result = _converter.Read(ref reader, typeToConvert, options);
                return result.GetValueOrDefault();
            }

            public override void Write(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options)
            {
                _converter.Write(writer, value, options);
            }
        }
    }
}
#endif
