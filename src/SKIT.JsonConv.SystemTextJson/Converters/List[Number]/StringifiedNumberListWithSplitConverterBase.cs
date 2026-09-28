namespace SKIT.JsonConv.SystemTextJson.Converters
{
    /// <summary>
    /// 一个 JSON 转换器基类，可针对指定适配类型做特定形式的对象转换。
    /// <br />
    /// 适配类型：
    /// <see cref="IList{sbyte}">IList&lt;SByte&gt;</see>,
    /// <see cref="IList{sbyte}">IList&lt;Nullable&lt;SByte&gt;&gt;</see>,
    /// <see cref="IList{byte}">IList&lt;Byte&gt;</see>,
    /// <see cref="IList{byte}">IList&lt;Nullable&lt;Byte&gt;&gt;</see>,
    /// <see cref="IList{ushort}">IList&lt;UInt16&gt;</see>,
    /// <see cref="IList{ushort}">IList&lt;Nullable&lt;UInt16&gt;&gt;</see>,
    /// <see cref="IList{short}">IList&lt;Int16&gt;</see>,
    /// <see cref="IList{short}">IList&lt;Nullable&lt;Int16&gt;&gt;</see>,
    /// <see cref="IList{uint}">IList&lt;UInt32&gt;</see>,
    /// <see cref="IList{uint}">IList&lt;Nullable&lt;UInt32&gt;&gt;</see>,
    /// <see cref="IList{int}">IList&lt;Int32&gt;</see>,
    /// <see cref="IList{int}">IList&lt;Nullable&lt;Int32&gt;&gt;</see>,
    /// <see cref="IList{ulong}">IList&lt;UInt64&gt;</see>,
    /// <see cref="IList{ulong}">IList&lt;Nullable&lt;UInt64&gt;&gt;</see>,
    /// <see cref="IList{long}">IList&lt;Int64&gt;</see>,
    /// <see cref="IList{long}">IList&lt;Nullable&lt;Int64&gt;&gt;</see>,
    /// <see cref="IList{float}">IList&lt;Single&gt;</see>,
    /// <see cref="IList{float}">IList&lt;Nullable&lt;Single&gt;&gt;</see>,
    /// <see cref="IList{double}">IList&lt;Double&gt;</see>,
    /// <see cref="IList{double}">IList&lt;Nullable&lt;Double&gt;&gt;</see>,
    /// <see cref="IList{decimal}">IList&lt;Decimal&gt;</see>,
    /// <see cref="IList{decimal}">IList&lt;Nullable&lt;Decimal&gt;&gt;</see>
    /// </summary>
    public abstract partial class StringifiedNumberListWithSplitConverterBase : JsonConverterFactory
    {
        protected abstract string Separator { get; }

        public override bool CanConvert(Type typeToConvert)
        {
            if (!typeToConvert.IsGenericType)
                return false;

            if (!typeof(IList<>).IsAssignableFrom(typeToConvert.GetGenericTypeDefinition()))
                return false;

            Type elementType = typeToConvert.GetGenericArguments()[0];
            return TypeHelper.IsNumberType(elementType);
        }

        public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            return new InternalStringifiedNumberListWithSplitConverter(typeToConvert, Separator);
        }
    }

    partial class StringifiedNumberListWithSplitConverterBase
    {
        private sealed class InternalStringifiedNumberArrayWithSplitConverter : StringifiedNumberArrayWithSplitConverterBase
        {
            protected override string Separator { get; }

            public InternalStringifiedNumberArrayWithSplitConverter(string separator)
            {
                Separator = separator;
            }
        }

        private sealed class InternalStringifiedNumberListWithSplitConverter : JsonConverter<object?>
        {
            private readonly Type _convertType;
            private readonly JsonConverterFactory _factory;

            public InternalStringifiedNumberListWithSplitConverter(Type convertType, string separator)
            {
                _convertType = convertType;
                _factory = new InternalStringifiedNumberArrayWithSplitConverter(separator);
            }

            public override bool CanConvert(Type typeToConvert)
            {
                // 实际是否可转换依赖外层转换器，此处不做判断，以提升效率
                return true;
            }

            public override object? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                Type elementType = _convertType.GetGenericArguments()[0];
                Type arrayType = elementType.MakeArrayType();

                JsonConverter<object?> converter = (JsonConverter<object?>)_factory.CreateConverter(arrayType, options)!;
                Array? array = (Array?)converter.Read(ref reader, elementType.MakeArrayType(), options);
                if (array is null)
                    return null;

                return TypeHelper.ConvertNumberArrayToList(array, elementType);
            }

            public override void Write(Utf8JsonWriter writer, object? value, JsonSerializerOptions options)
            {
                if (value is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    Type elementType = _convertType.GetGenericArguments()[0];
                    Type arrayType = elementType.MakeArrayType();
                    Array array = TypeHelper.ConvertNumberListToArray((IList)value, elementType);

                    JsonConverter<object?> converter = (JsonConverter<object?>)_factory.CreateConverter(arrayType, options)!;
                    converter.Write(writer, array, options);
                }
            }
        }
    }
}
