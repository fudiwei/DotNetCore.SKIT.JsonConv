namespace SKIT.JsonConv.SystemTextJson.Converters
{
    /// <summary>
    /// 一个 JSON 转换器，可针对指定适配类型做如下形式的对象转换。
    /// 与通过 System.Text.Json.Serialization.<see cref="JsonNumberHandling.AllowReadingFromString"/> 参数控制相比，可兼容空字符串等特殊形式。
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
    public class StringifiedNumberConverter : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return TypeHelper.IsNumberType(typeToConvert);
        }

        public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            Type convertType = Nullable.GetUnderlyingType(typeToConvert) ?? typeToConvert;
            bool convertTypeIsNullable = convertType != typeToConvert;

            switch (Type.GetTypeCode(convertType))
            {
                case TypeCode.SByte:
                    return convertTypeIsNullable ? new Internal.StringifiedNullableSByteConverter() : new Internal.StringifiedSByteConverter();

                case TypeCode.Byte:
                    return convertTypeIsNullable ? new Internal.StringifiedNullableByteConverter() : new Internal.StringifiedByteConverter();

                case TypeCode.Int16:
                    return convertTypeIsNullable ? new Internal.StringifiedNullableInt16Converter() : new Internal.StringifiedInt16Converter();

                case TypeCode.UInt16:
                    return convertTypeIsNullable ? new Internal.StringifiedNullableUInt16Converter() : new Internal.StringifiedUInt16Converter();

                case TypeCode.Int32:
                    return convertTypeIsNullable ? new Internal.StringifiedNullableInt32Converter() : new Internal.StringifiedInt32Converter();

                case TypeCode.UInt32:
                    return convertTypeIsNullable ? new Internal.StringifiedNullableUInt32Converter() : new Internal.StringifiedUInt32Converter();

                case TypeCode.Int64:
                    return convertTypeIsNullable ? new Internal.StringifiedNullableInt64Converter() : new Internal.StringifiedInt64Converter();

                case TypeCode.UInt64:
                    return convertTypeIsNullable ? new Internal.StringifiedNullableUInt64Converter() : new Internal.StringifiedUInt64Converter();

                case TypeCode.Single:
                    return convertTypeIsNullable ? new Internal.StringifiedNullableFloatConverter() : new Internal.StringifiedFloatConverter();

                case TypeCode.Double:
                    return convertTypeIsNullable ? new Internal.StringifiedNullableDoubleConverter() : new Internal.StringifiedDoubleConverter();

                case TypeCode.Decimal:
                    return convertTypeIsNullable ? new Internal.StringifiedNullableDecimalConverter() : new Internal.StringifiedDecimalConverter();

                default:
                    throw new NotSupportedException();
            }
        }
    }
}
