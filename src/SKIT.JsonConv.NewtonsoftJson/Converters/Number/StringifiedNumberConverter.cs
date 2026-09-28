namespace SKIT.JsonConv.NewtonsoftJson.Converters
{
    /// <summary>
    /// 一个 JSON 转换器，可针对指定适配类型做如下形式的对象转换。
    /// <code>
    ///   .NET → int Foo { get; } = 1;
    ///   JSON → { "Foo": "1" }
    /// </code>
    /// 
    /// 适配类型：
    /// <see cref="sbyte">SByte</see>,
    /// <see cref="sbyte">Nullable&lt;SByte&gt;</see>,
    /// <see cref="byte">Byte</see>,
    /// <see cref="byte">Nullable&lt;Byte&gt;</see>,
    /// <see cref="ushort">UInt16</see>,
    /// <see cref="ushort">Nullable&lt;UInt16&gt;</see>,
    /// <see cref="short">Int16</see>,
    /// <see cref="short">Nullable&lt;Int16&gt;</see>,
    /// <see cref="uint">UInt32</see>,
    /// <see cref="uint">Nullable&lt;UInt32&gt;</see>,
    /// <see cref="int">Int32</see>,
    /// <see cref="int">Nullable&lt;Int32&gt;</see>,
    /// <see cref="ulong">UInt64</see>,
    /// <see cref="ulong">Nullable&lt;UInt64&gt;</see>,
    /// <see cref="long">Int64</see>,
    /// <see cref="long">Nullable&lt;Int64&gt;</see>,
    /// <see cref="float">Single</see>,
    /// <see cref="float">Nullable&lt;Single&gt;</see>,
    /// <see cref="double">Double</see>,
    /// <see cref="double">Nullable&lt;Double&gt;</see>,
    /// <see cref="decimal">Decimal</see>,
    /// <see cref="decimal">Nullable&lt;Decimal&gt;</see>
    /// </summary>
    public sealed partial class StringifiedNumberConverter : JsonConverter
    {
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
            return TypeHelper.IsNumberType(objectType);
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return existingValue;
            }
            else if (reader.TokenType == JsonToken.Integer ||
                     reader.TokenType == JsonToken.Float ||
                     reader.TokenType == JsonToken.String)
            {
                if (reader.TokenType == JsonToken.String)
                {
                    string? str = serializer.Deserialize<string>(reader);
                    if (string.IsNullOrEmpty(str))
                        return default;
                }

                Type convertType = Nullable.GetUnderlyingType(objectType) ?? objectType;
                switch (Type.GetTypeCode(convertType))
                {
                    case TypeCode.SByte:
                        return serializer.Deserialize<sbyte>(reader);

                    case TypeCode.Byte:
                        return serializer.Deserialize<byte>(reader);

                    case TypeCode.Int16:
                        return serializer.Deserialize<short>(reader);

                    case TypeCode.UInt16:
                        return serializer.Deserialize<ushort>(reader);

                    case TypeCode.Int32:
                        return serializer.Deserialize<int>(reader);

                    case TypeCode.UInt32:
                        return serializer.Deserialize<uint>(reader);

                    case TypeCode.Int64:
                        return serializer.Deserialize<long>(reader);

                    case TypeCode.UInt64:
                        return serializer.Deserialize<ulong>(reader);

                    case TypeCode.Single:
                        return serializer.Deserialize<float>(reader);

                    case TypeCode.Double:
                        return serializer.Deserialize<double>(reader);

                    case TypeCode.Decimal:
                        return serializer.Deserialize<decimal>(reader);

                    default:
                        throw new NotSupportedException($"Could not convert type '{convertType}' to a number.");
                }
            }

            throw new JsonSerializationException($"Unexpected token type '{reader.TokenType}' when deserializing. Path '{reader.Path}'.");
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value is null)
                writer.WriteNull();
            else
                writer.WriteValue(value.ToString());
        }
    }
}
