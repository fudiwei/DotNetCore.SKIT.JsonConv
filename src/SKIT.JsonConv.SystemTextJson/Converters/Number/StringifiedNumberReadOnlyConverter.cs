namespace SKIT.JsonConv.SystemTextJson.Converters
{
    /// <summary>
    /// 一个 JSON 转换器，可针对指定适配类型做如下形式的对象转换。与 <seealso cref="StringifiedNumberConverter"/> 类似，但转换过程是单向只读的。
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
    public sealed partial class StringifiedNumberReadOnlyConverter : JsonConverterFactory
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
                    return convertTypeIsNullable ? new InternalStringifiedNullableSByteReadOnlyConverter() : new InternalStringifiedSByteReadOnlyConverter();

                case TypeCode.Byte:
                    return convertTypeIsNullable ? new InternalStringifiedNullableByteReadOnlyConverter() : new InternalStringifiedByteReadOnlyConverter();

                case TypeCode.Int16:
                    return convertTypeIsNullable ? new InternalStringifiedNullableInt16ReadOnlyConverter() : new InternalStringifiedInt16ReadOnlyConverter();

                case TypeCode.UInt16:
                    return convertTypeIsNullable ? new InternalStringifiedNullableUInt16ReadOnlyConverter() : new InternalStringifiedUInt16ReadOnlyConverter();

                case TypeCode.Int32:
                    return convertTypeIsNullable ? new InternalStringifiedNullableInt32ReadOnlyConverter() : new InternalStringifiedInt32ReadOnlyConverter();

                case TypeCode.UInt32:
                    return convertTypeIsNullable ? new InternalStringifiedNullableUInt32ReadOnlyConverter() : new InternalStringifiedUInt32ReadOnlyConverter();

                case TypeCode.Int64:
                    return convertTypeIsNullable ? new InternalStringifiedNullableInt64ReadOnlyConverter() : new InternalStringifiedInt64ReadOnlyConverter();

                case TypeCode.UInt64:
                    return convertTypeIsNullable ? new InternalStringifiedNullableUInt64ReadOnlyConverter() : new InternalStringifiedUInt64ReadOnlyConverter();

                case TypeCode.Single:
                    return convertTypeIsNullable ? new InternalStringifiedNullableFloatReadOnlyConverter() : new InternalStringifiedFloatReadOnlyConverter();

                case TypeCode.Double:
                    return convertTypeIsNullable ? new InternalStringifiedNullableDoubleReadOnlyConverter() : new InternalStringifiedDoubleReadOnlyConverter();

                case TypeCode.Decimal:
                    return convertTypeIsNullable ? new InternalStringifiedNullableDecimalReadOnlyConverter() : new InternalStringifiedDecimalReadOnlyConverter();

                default:
                    throw new NotSupportedException();
            }
        }
    }

    partial class StringifiedNumberReadOnlyConverter
    {
        #region SByte
        private sealed class InternalStringifiedNullableSByteReadOnlyConverter : JsonConverter<sbyte?>
        {
            private static readonly JsonConverter<sbyte?> _converter = new Internal.StringifiedNullableSByteConverter();
            private static readonly JsonConverter<sbyte?> _fallback = (JsonConverter<sbyte?>)JsonSerializerOptions.Default.GetConverter(typeof(sbyte?));

            public override sbyte? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.Read(ref reader, typeToConvert, options);
            }

            public override void Write(Utf8JsonWriter writer, sbyte? value, JsonSerializerOptions options)
            {
                _fallback.Write(writer, value, options);
            }

            public override sbyte? ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.ReadAsPropertyName(ref reader, typeToConvert, options);
            }

            public override void WriteAsPropertyName(Utf8JsonWriter writer, sbyte? value, JsonSerializerOptions options)
            {
                _fallback.WriteAsPropertyName(writer, value!, options);
            }
        }

        private sealed class InternalStringifiedSByteReadOnlyConverter : JsonConverter<sbyte>
        {
            private readonly JsonConverter<sbyte> _converter = new Internal.StringifiedSByteConverter();
            private readonly JsonConverter<sbyte> _fallback = (JsonConverter<sbyte>)JsonSerializerOptions.Default.GetConverter(typeof(sbyte));

            public override sbyte Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.Read(ref reader, typeToConvert, options);
            }

            public override void Write(Utf8JsonWriter writer, sbyte value, JsonSerializerOptions options)
            {
                _fallback.Write(writer, value, options);
            }

            public override sbyte ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.ReadAsPropertyName(ref reader, typeToConvert, options);
            }

            public override void WriteAsPropertyName(Utf8JsonWriter writer, sbyte value, JsonSerializerOptions options)
            {
                _fallback.WriteAsPropertyName(writer, value, options);
            }
        }
        #endregion

        #region Byte
        private sealed class InternalStringifiedNullableByteReadOnlyConverter : JsonConverter<byte?>
        {
            private static readonly JsonConverter<byte?> _converter = new Internal.StringifiedNullableByteConverter();
            private static readonly JsonConverter<byte?> _fallback = (JsonConverter<byte?>)JsonSerializerOptions.Default.GetConverter(typeof(byte?));

            public override byte? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.Read(ref reader, typeToConvert, options);
            }

            public override void Write(Utf8JsonWriter writer, byte? value, JsonSerializerOptions options)
            {
                _fallback.Write(writer, value, options);
            }

            public override byte? ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.ReadAsPropertyName(ref reader, typeToConvert, options);
            }

            public override void WriteAsPropertyName(Utf8JsonWriter writer, byte? value, JsonSerializerOptions options)
            {
                _fallback.WriteAsPropertyName(writer, value!, options);
            }
        }

        private sealed class InternalStringifiedByteReadOnlyConverter : JsonConverter<byte>
        {
            private static readonly JsonConverter<byte> _converter = new Internal.StringifiedByteConverter();
            private static readonly JsonConverter<byte> _fallback = (JsonConverter<byte>)JsonSerializerOptions.Default.GetConverter(typeof(byte));

            public override byte Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.Read(ref reader, typeToConvert, options);
            }

            public override void Write(Utf8JsonWriter writer, byte value, JsonSerializerOptions options)
            {
                _fallback.Write(writer, value, options);
            }

            public override byte ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.ReadAsPropertyName(ref reader, typeToConvert, options);
            }

            public override void WriteAsPropertyName(Utf8JsonWriter writer, byte value, JsonSerializerOptions options)
            {
                _fallback.WriteAsPropertyName(writer, value, options);
            }
        }
        #endregion

        #region Int16
        private sealed class InternalStringifiedNullableInt16ReadOnlyConverter : JsonConverter<short?>
        {
            private static readonly JsonConverter<short?> _converter = new Internal.StringifiedNullableInt16Converter();
            private static readonly JsonConverter<short?> _fallback = (JsonConverter<short?>)JsonSerializerOptions.Default.GetConverter(typeof(short?));

            public override short? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.Read(ref reader, typeToConvert, options);
            }

            public override void Write(Utf8JsonWriter writer, short? value, JsonSerializerOptions options)
            {
                _fallback.Write(writer, value, options);
            }

            public override short? ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.ReadAsPropertyName(ref reader, typeToConvert, options);
            }

            public override void WriteAsPropertyName(Utf8JsonWriter writer, short? value, JsonSerializerOptions options)
            {
                _fallback.WriteAsPropertyName(writer, value!, options);
            }
        }

        private sealed class InternalStringifiedInt16ReadOnlyConverter : JsonConverter<short>
        {
            private static readonly JsonConverter<short> _converter = new Internal.StringifiedInt16Converter();
            private static readonly JsonConverter<short> _fallback = (JsonConverter<short>)JsonSerializerOptions.Default.GetConverter(typeof(short));

            public override short Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.Read(ref reader, typeToConvert, options);
            }

            public override void Write(Utf8JsonWriter writer, short value, JsonSerializerOptions options)
            {
                _fallback.Write(writer, value, options);
            }

            public override short ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.ReadAsPropertyName(ref reader, typeToConvert, options);
            }

            public override void WriteAsPropertyName(Utf8JsonWriter writer, short value, JsonSerializerOptions options)
            {
                _fallback.WriteAsPropertyName(writer, value, options);
            }
        }
        #endregion

        #region UInt16
        private sealed class InternalStringifiedNullableUInt16ReadOnlyConverter : JsonConverter<ushort?>
        {
            private static readonly JsonConverter<ushort?> _converter = new Internal.StringifiedNullableUInt16Converter();
            private static readonly JsonConverter<ushort?> _fallback = (JsonConverter<ushort?>)JsonSerializerOptions.Default.GetConverter(typeof(ushort?));

            public override ushort? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.Read(ref reader, typeToConvert, options);
            }

            public override void Write(Utf8JsonWriter writer, ushort? value, JsonSerializerOptions options)
            {
                _fallback.Write(writer, value, options);
            }

            public override ushort? ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.ReadAsPropertyName(ref reader, typeToConvert, options);
            }

            public override void WriteAsPropertyName(Utf8JsonWriter writer, ushort? value, JsonSerializerOptions options)
            {
                _fallback.WriteAsPropertyName(writer, value!, options);
            }
        }

        private sealed class InternalStringifiedUInt16ReadOnlyConverter : JsonConverter<ushort>
        {
            private static readonly JsonConverter<ushort> _converter = new Internal.StringifiedUInt16Converter();
            private static readonly JsonConverter<ushort> _fallback = (JsonConverter<ushort>)JsonSerializerOptions.Default.GetConverter(typeof(ushort));

            public override ushort Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.Read(ref reader, typeToConvert, options);
            }

            public override void Write(Utf8JsonWriter writer, ushort value, JsonSerializerOptions options)
            {
                _fallback.Write(writer, value, options);
            }

            public override ushort ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.ReadAsPropertyName(ref reader, typeToConvert, options);
            }

            public override void WriteAsPropertyName(Utf8JsonWriter writer, ushort value, JsonSerializerOptions options)
            {
                _fallback.WriteAsPropertyName(writer, value, options);
            }
        }
        #endregion

        #region Int32
        private sealed class InternalStringifiedNullableInt32ReadOnlyConverter : JsonConverter<int?>
        {
            private static readonly JsonConverter<int?> _converter = new Internal.StringifiedNullableInt32Converter();
            private static readonly JsonConverter<int?> _fallback = (JsonConverter<int?>)JsonSerializerOptions.Default.GetConverter(typeof(int?));

            public override int? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.Read(ref reader, typeToConvert, options);
            }

            public override void Write(Utf8JsonWriter writer, int? value, JsonSerializerOptions options)
            {
                _fallback.Write(writer, value, options);
            }

            public override int? ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.ReadAsPropertyName(ref reader, typeToConvert, options);
            }

            public override void WriteAsPropertyName(Utf8JsonWriter writer, int? value, JsonSerializerOptions options)
            {
                _fallback.WriteAsPropertyName(writer, value!, options);
            }
        }

        private sealed class InternalStringifiedInt32ReadOnlyConverter : JsonConverter<int>
        {
            private static readonly JsonConverter<int> _converter = new Internal.StringifiedInt32Converter();
            private static readonly JsonConverter<int> _fallback = (JsonConverter<int>)JsonSerializerOptions.Default.GetConverter(typeof(int));

            public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.Read(ref reader, typeToConvert, options);
            }

            public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
            {
                _fallback.Write(writer, value, options);
            }

            public override int ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.ReadAsPropertyName(ref reader, typeToConvert, options);
            }

            public override void WriteAsPropertyName(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
            {
                _fallback.WriteAsPropertyName(writer, value, options);
            }
        }
        #endregion

        #region UInt32
        private sealed class InternalStringifiedNullableUInt32ReadOnlyConverter : JsonConverter<uint?>
        {
            private static readonly JsonConverter<uint?> _converter = new Internal.StringifiedNullableUInt32Converter();
            private static readonly JsonConverter<uint?> _fallback = (JsonConverter<uint?>)JsonSerializerOptions.Default.GetConverter(typeof(uint?));

            public override uint? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.Read(ref reader, typeToConvert, options);
            }

            public override void Write(Utf8JsonWriter writer, uint? value, JsonSerializerOptions options)
            {
                _fallback.Write(writer, value, options);
            }

            public override uint? ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.ReadAsPropertyName(ref reader, typeToConvert, options);
            }

            public override void WriteAsPropertyName(Utf8JsonWriter writer, uint? value, JsonSerializerOptions options)
            {
                _fallback.WriteAsPropertyName(writer, value!, options);
            }
        }

        private sealed class InternalStringifiedUInt32ReadOnlyConverter : JsonConverter<uint>
        {
            private static readonly JsonConverter<uint> _converter = new Internal.StringifiedUInt32Converter();
            private static readonly JsonConverter<uint> _fallback = (JsonConverter<uint>)JsonSerializerOptions.Default.GetConverter(typeof(uint));

            public override uint Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.Read(ref reader, typeToConvert, options);
            }

            public override void Write(Utf8JsonWriter writer, uint value, JsonSerializerOptions options)
            {
                _fallback.Write(writer, value, options);
            }

            public override uint ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.ReadAsPropertyName(ref reader, typeToConvert, options);
            }

            public override void WriteAsPropertyName(Utf8JsonWriter writer, uint value, JsonSerializerOptions options)
            {
                _fallback.WriteAsPropertyName(writer, value, options);
            }
        }
        #endregion

        #region Int64
        private sealed class InternalStringifiedNullableInt64ReadOnlyConverter : JsonConverter<long?>
        {
            private static readonly JsonConverter<long?> _converter = new Internal.StringifiedNullableInt64Converter();
            private static readonly JsonConverter<long?> _fallback = (JsonConverter<long?>)JsonSerializerOptions.Default.GetConverter(typeof(long?));

            public override long? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.Read(ref reader, typeToConvert, options);
            }

            public override void Write(Utf8JsonWriter writer, long? value, JsonSerializerOptions options)
            {
                _fallback.Write(writer, value, options);
            }

            public override long? ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.ReadAsPropertyName(ref reader, typeToConvert, options);
            }

            public override void WriteAsPropertyName(Utf8JsonWriter writer, long? value, JsonSerializerOptions options)
            {
                _fallback.WriteAsPropertyName(writer, value!, options);
            }
        }

        private sealed class InternalStringifiedInt64ReadOnlyConverter : JsonConverter<long>
        {
            private static readonly JsonConverter<long> _converter = new Internal.StringifiedInt64Converter();
            private static readonly JsonConverter<long> _fallback = (JsonConverter<long>)JsonSerializerOptions.Default.GetConverter(typeof(long));

            public override long Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.Read(ref reader, typeToConvert, options);
            }

            public override void Write(Utf8JsonWriter writer, long value, JsonSerializerOptions options)
            {
                _fallback.Write(writer, value, options);
            }

            public override long ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.ReadAsPropertyName(ref reader, typeToConvert, options);
            }

            public override void WriteAsPropertyName(Utf8JsonWriter writer, long value, JsonSerializerOptions options)
            {
                _fallback.WriteAsPropertyName(writer, value, options);
            }
        }
        #endregion

        #region UInt64
        private sealed class InternalStringifiedNullableUInt64ReadOnlyConverter : JsonConverter<ulong?>
        {
            private static readonly JsonConverter<ulong?> _converter = new Internal.StringifiedNullableUInt64Converter();
            private static readonly JsonConverter<ulong?> _fallback = (JsonConverter<ulong?>)JsonSerializerOptions.Default.GetConverter(typeof(ulong?));

            public override ulong? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.Read(ref reader, typeToConvert, options);
            }

            public override void Write(Utf8JsonWriter writer, ulong? value, JsonSerializerOptions options)
            {
                _fallback.Write(writer, value, options);
            }

            public override ulong? ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.ReadAsPropertyName(ref reader, typeToConvert, options);
            }

            public override void WriteAsPropertyName(Utf8JsonWriter writer, ulong? value, JsonSerializerOptions options)
            {
                _fallback.WriteAsPropertyName(writer, value!, options);
            }
        }

        private sealed class InternalStringifiedUInt64ReadOnlyConverter : JsonConverter<ulong>
        {
            private static readonly JsonConverter<ulong> _converter = new Internal.StringifiedUInt64Converter();
            private static readonly JsonConverter<ulong> _fallback = (JsonConverter<ulong>)JsonSerializerOptions.Default.GetConverter(typeof(ulong));

            public override ulong Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.Read(ref reader, typeToConvert, options);
            }

            public override void Write(Utf8JsonWriter writer, ulong value, JsonSerializerOptions options)
            {
                _fallback.Write(writer, value, options);
            }

            public override ulong ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.ReadAsPropertyName(ref reader, typeToConvert, options);
            }

            public override void WriteAsPropertyName(Utf8JsonWriter writer, ulong value, JsonSerializerOptions options)
            {
                _fallback.WriteAsPropertyName(writer, value, options);
            }
        }
        #endregion

        #region Float
        private sealed class InternalStringifiedNullableFloatReadOnlyConverter : JsonConverter<float?>
        {
            private static readonly JsonConverter<float?> _converter = new Internal.StringifiedNullableFloatConverter();
            private static readonly JsonConverter<float?> _fallback = (JsonConverter<float?>)JsonSerializerOptions.Default.GetConverter(typeof(float?));

            public override float? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.Read(ref reader, typeToConvert, options);
            }

            public override void Write(Utf8JsonWriter writer, float? value, JsonSerializerOptions options)
            {
                _fallback.Write(writer, value, options);
            }

            public override float? ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.ReadAsPropertyName(ref reader, typeToConvert, options);
            }

            public override void WriteAsPropertyName(Utf8JsonWriter writer, float? value, JsonSerializerOptions options)
            {
                _fallback.WriteAsPropertyName(writer, value!, options);
            }
        }

        private sealed class InternalStringifiedFloatReadOnlyConverter : JsonConverter<float>
        {
            private static readonly JsonConverter<float> _converter = new Internal.StringifiedFloatConverter();
            private static readonly JsonConverter<float> _fallback = (JsonConverter<float>)JsonSerializerOptions.Default.GetConverter(typeof(float));

            public override float Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.Read(ref reader, typeToConvert, options);
            }

            public override void Write(Utf8JsonWriter writer, float value, JsonSerializerOptions options)
            {
                _fallback.Write(writer, value, options);
            }

            public override float ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.ReadAsPropertyName(ref reader, typeToConvert, options);
            }

            public override void WriteAsPropertyName(Utf8JsonWriter writer, float value, JsonSerializerOptions options)
            {
                _fallback.WriteAsPropertyName(writer, value, options);
            }
        }
        #endregion

        #region Double
        private sealed class InternalStringifiedNullableDoubleReadOnlyConverter : JsonConverter<double?>
        {
            private static readonly JsonConverter<double?> _converter = new Internal.StringifiedNullableDoubleConverter();
            private static readonly JsonConverter<double?> _fallback = (JsonConverter<double?>)JsonSerializerOptions.Default.GetConverter(typeof(double?));

            public override double? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.Read(ref reader, typeToConvert, options);
            }

            public override void Write(Utf8JsonWriter writer, double? value, JsonSerializerOptions options)
            {
                _fallback.Write(writer, value, options);
            }

            public override double? ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.ReadAsPropertyName(ref reader, typeToConvert, options);
            }

            public override void WriteAsPropertyName(Utf8JsonWriter writer, double? value, JsonSerializerOptions options)
            {
                _fallback.WriteAsPropertyName(writer, value!, options);
            }
        }

        private sealed class InternalStringifiedDoubleReadOnlyConverter : JsonConverter<double>
        {
            private static readonly JsonConverter<double> _converter = new Internal.StringifiedDoubleConverter();
            private static readonly JsonConverter<double> _fallback = (JsonConverter<double>)JsonSerializerOptions.Default.GetConverter(typeof(double));

            public override double Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.Read(ref reader, typeToConvert, options);
            }

            public override void Write(Utf8JsonWriter writer, double value, JsonSerializerOptions options)
            {
                _fallback.Write(writer, value, options);
            }

            public override double ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.ReadAsPropertyName(ref reader, typeToConvert, options);
            }

            public override void WriteAsPropertyName(Utf8JsonWriter writer, double value, JsonSerializerOptions options)
            {
                _fallback.WriteAsPropertyName(writer, value, options);
            }
        }
        #endregion

        #region Decimal
        private sealed class InternalStringifiedNullableDecimalReadOnlyConverter : JsonConverter<decimal?>
        {
            private static readonly JsonConverter<decimal?> _converter = new Internal.StringifiedNullableDecimalConverter();
            private static readonly JsonConverter<decimal?> _fallback = (JsonConverter<decimal?>)JsonSerializerOptions.Default.GetConverter(typeof(decimal?));

            public override decimal? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.Read(ref reader, typeToConvert, options);
            }

            public override void Write(Utf8JsonWriter writer, decimal? value, JsonSerializerOptions options)
            {
                _fallback.Write(writer, value, options);
            }

            public override decimal? ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.ReadAsPropertyName(ref reader, typeToConvert, options);
            }

            public override void WriteAsPropertyName(Utf8JsonWriter writer, decimal? value, JsonSerializerOptions options)
            {
                _fallback.WriteAsPropertyName(writer, value!, options);
            }
        }

        private sealed class InternalStringifiedDecimalReadOnlyConverter : JsonConverter<decimal>
        {
            private static readonly JsonConverter<decimal> _converter = new Internal.StringifiedDecimalConverter();
            private static readonly JsonConverter<decimal> _fallback = (JsonConverter<decimal>)JsonSerializerOptions.Default.GetConverter(typeof(decimal));

            public override decimal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.Read(ref reader, typeToConvert, options);
            }

            public override void Write(Utf8JsonWriter writer, decimal value, JsonSerializerOptions options)
            {
                _fallback.Write(writer, value, options);
            }

            public override decimal ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter.ReadAsPropertyName(ref reader, typeToConvert, options);
            }

            public override void WriteAsPropertyName(Utf8JsonWriter writer, decimal value, JsonSerializerOptions options)
            {
                _fallback.WriteAsPropertyName(writer, value!, options);
            }
        }
        #endregion
    }
}
