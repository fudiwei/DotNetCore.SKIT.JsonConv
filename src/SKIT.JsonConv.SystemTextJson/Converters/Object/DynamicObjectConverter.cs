using System.Data;
using System.Dynamic;

namespace SKIT.JsonConv.SystemTextJson.Converters
{
    /// <summary>
    /// 一个 JSON 转换器，可针对指定适配类型做如下形式的对象转换。
    /// <code>
    ///   .NET → dynamic Foo { get; } = new { Bar = "baz" };
    ///   JSON → { "Foo": { "Bar": "baz" } }
    /// </code>
    /// 
    /// 适配类型：
    /// <see cref="object" />
    /// <see cref="ExpandoObject" />
    /// <see cref="IDynamicMetaObjectProvider" />
    /// </summary>
    public sealed partial class DynamicObjectConverter : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(object) == typeToConvert ||
                   typeof(ExpandoObject) == typeToConvert ||
                   typeof(IDynamicMetaObjectProvider).IsAssignableFrom(typeToConvert);
        }

        public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            return new InternalDynamicObjectConverter(typeToConvert);
        }
    }

    partial class DynamicObjectConverter
    {
        private sealed class InternalDynamicObjectConverter : JsonConverter<object?>
        {
            private readonly Type _convertType;

            public InternalDynamicObjectConverter(Type convertType)
            {
                _convertType = convertType;
            }

            public override bool CanConvert(Type typeToConvert)
            {
                return _convertType == typeToConvert ||
                       _convertType.IsAssignableFrom(typeToConvert) ||
                       typeToConvert.IsSubclassOf(_convertType);
            }

            public override object? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return ReadValue(ref reader, options);
            }

            public override void Write(Utf8JsonWriter writer, object? value, JsonSerializerOptions options)
            {
                WriteValue(ref writer, value, options);
            }

            private static object? ReadValue(ref Utf8JsonReader reader, JsonSerializerOptions options)
            {
                switch (reader.TokenType)
                {
                    case JsonTokenType.Null:
                        return null;

                    case JsonTokenType.True:
                        return true;

                    case JsonTokenType.False:
                        return false;

                    case JsonTokenType.Number:
                        return reader.TryGetInt64(out long valueAsInt64) ? valueAsInt64 :
                               reader.TryGetUInt64(out ulong valueAsUInt64) ? valueAsUInt64 :
                               reader.TryGetDouble(out double valueAsDouble) ? valueAsDouble :
                               reader.GetDecimal();

                    case JsonTokenType.String:
                        return reader.GetString();

                    case JsonTokenType.StartObject:
                        return ReadObject(ref reader, options);

                    case JsonTokenType.StartArray:
                        return ReadArray(ref reader, options);

                    case JsonTokenType.Comment:
                        {
                            if (options.ReadCommentHandling == JsonCommentHandling.Disallow)
                                throw new JsonException($"JSON comment is disallowed.");

                            return null;
                        }

                    default:
                        return JsonNode.Parse(ref reader, new JsonNodeOptions() { PropertyNameCaseInsensitive = options.PropertyNameCaseInsensitive });
                }
            }

            private static object? ReadObject(ref Utf8JsonReader reader, JsonSerializerOptions options)
            {
                IDictionary<string, object?> expandoObject = new ExpandoObject();

                while (reader.Read())
                {
                    switch (reader.TokenType)
                    {
                        case JsonTokenType.PropertyName:
                            {
                                string key = reader.GetString()!;
                                if (!reader.Read())
                                    throw new JsonException("Unexpected end when reading ExpandoObject.");

                                if (!options.AllowDuplicateProperties && expandoObject.ContainsKey(key))
                                    throw new JsonException($"Duplicate property '{key}' when reading ExpandoObject.");

                                object? value = ReadValue(ref reader, options);
                                expandoObject[key] = value;
                            }
                            break;

                        case JsonTokenType.Comment:
                            {
                                if (options.ReadCommentHandling == JsonCommentHandling.Disallow)
                                    throw new JsonException($"JSON comment is disallowed.");
                            }
                            break;

                        case JsonTokenType.EndObject:
                            return expandoObject;
                    }
                }

                throw new JsonException("Unexpected end when reading ExpandoObject.");
            }

            private static object? ReadArray(ref Utf8JsonReader reader, JsonSerializerOptions options)
            {
                IList<object?> list = new List<object?>(capacity: 8);

                while (reader.Read())
                {
                    switch (reader.TokenType)
                    {
                        case JsonTokenType.EndArray:
                            return list.ToArray();

                        case JsonTokenType.Comment:
                            {
                                if (options.ReadCommentHandling == JsonCommentHandling.Disallow)
                                    throw new JsonException($"JSON comment is disallowed.");
                            }
                            break;

                        default:
                            {
                                object? element = ReadValue(ref reader, options);
                                list.Add(element);
                            }
                            break;
                    }
                }

                throw new JsonException("Unexpected end when reading ExpandoObject.");
            }

            private static void WriteValue(ref Utf8JsonWriter writer, object? value, JsonSerializerOptions options)
            {
                if (value is null || Convert.IsDBNull(value))
                {
                    writer.WriteNullValue();
                }
                else
                {
                    switch (value)
                    {
                        case bool valueAsBool:
                            writer.WriteBooleanValue(valueAsBool);
                            break;

                        case string valueAsString:
                            writer.WriteStringValue(valueAsString);
                            break;

                        case sbyte valueAsSByte:
                            writer.WriteNumberValue(valueAsSByte);
                            break;

                        case byte valueAsByte:
                            writer.WriteNumberValue(valueAsByte);
                            break;

                        case short valueAsInt16:
                            writer.WriteNumberValue(valueAsInt16);
                            break;

                        case ushort valueAsUInt16:
                            writer.WriteNumberValue(valueAsUInt16);
                            break;

                        case int valueAsInt32:
                            writer.WriteNumberValue(valueAsInt32);
                            break;

                        case uint valueAsUInt32:
                            writer.WriteNumberValue(valueAsUInt32);
                            break;

                        case long valueAsInt64:
                            writer.WriteNumberValue(valueAsInt64);
                            break;

                        case ulong valueAsUInt64:
                            writer.WriteNumberValue(valueAsUInt64);
                            break;

                        case float valueAsSingle:
                            writer.WriteNumberValue(valueAsSingle);
                            break;

                        case double valueAsDouble:
                            writer.WriteNumberValue(valueAsDouble);
                            break;

                        case decimal valueAsDecimal:
                            writer.WriteNumberValue(valueAsDecimal);
                            break;

                        case byte[] valueAsBytes:
                            writer.WriteBase64StringValue(valueAsBytes);
                            break;

                        case ExpandoObject valueAsExpando:
                            WriteObject(ref writer, (IDictionary<string, object?>)valueAsExpando, options);
                            break;

                        case IDictionary<string, object?> valueAsDictionary:
                            WriteObject(ref writer, valueAsDictionary, options);
                            break;

                        case IEnumerable<object> valueAsArray:
                            WriteArray(ref writer, valueAsArray, options);
                            break;

                        default:
                            Type convertType = value.GetType();
                            JsonSerializer.Serialize(writer, value, convertType, options);
                            break;
                    }
                }
            }

            private static void WriteObject(ref Utf8JsonWriter writer, IDictionary<string, object?> dict, JsonSerializerOptions options)
            {
                writer.WriteStartObject();
                foreach (KeyValuePair<string, object?> kvp in dict)
                {
                    string key = kvp.Key;
                    if (options.DictionaryKeyPolicy is not null)
                        key = options.DictionaryKeyPolicy.ConvertName(kvp.Key);

                    writer.WritePropertyName(key);
                    WriteValue(ref writer, kvp.Value, options);
                }
                writer.WriteEndObject();
            }

            private static void WriteArray(ref Utf8JsonWriter writer, IEnumerable<object?> list, JsonSerializerOptions options)
            {
                writer.WriteStartArray();
                foreach (object? item in list)
                {
                    WriteValue(ref writer, item, options);
                }
                writer.WriteEndArray();
            }
        }
    }
}
