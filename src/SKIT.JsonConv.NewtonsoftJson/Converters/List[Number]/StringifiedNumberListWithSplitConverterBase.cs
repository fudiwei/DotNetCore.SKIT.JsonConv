namespace SKIT.JsonConv.NewtonsoftJson.Converters
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
    public abstract partial class StringifiedNumberListWithSplitConverterBase : JsonConverter
    {
        protected abstract string Separator { get; }

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
            if (!objectType.IsGenericType)
                return false;

            if (!typeof(IList<>).IsAssignableFrom(objectType.GetGenericTypeDefinition()))
                return false;

            Type elementType = objectType.GetGenericArguments()[0];
            return TypeHelper.IsNumberType(elementType);
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            JsonConverter converter = new InternalStringifiedNumberListWithSplitConverter(objectType, Separator);
            return converter.ReadJson(reader, objectType, (IList?)existingValue, serializer);
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value is null)
            {
                writer.WriteNull();
            }
            else
            {
                JsonConverter converter = new InternalStringifiedNumberListWithSplitConverter(value.GetType(), Separator);
                converter.WriteJson(writer, (IList?)value, serializer);
            }
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

        private sealed class InternalStringifiedNumberListWithSplitConverter : JsonConverter
        {
            private readonly Type _convertType;
            private readonly JsonConverter _converter;

            public InternalStringifiedNumberListWithSplitConverter(Type convertType, string separator)
            {
                _convertType = convertType;
                _converter = new InternalStringifiedNumberArrayWithSplitConverter(separator);
            }

            public override bool CanConvert(Type objectType)
            {
                // 实际是否可转换依赖外层转换器，此处不做判断，以提升效率
                return true;
            }

            public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
            {
                Type elementType = _convertType.GetGenericArguments()[0];
                Type arrayType = elementType.MakeArrayType();

                Array? array = (Array?)_converter.ReadJson(reader, arrayType, existingValue, serializer);
                if (array is null)
                    return null;

                return TypeHelper.ConvertNumberArrayToList(array, elementType);
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                if (value is null)
                {
                    writer.WriteNull();
                }
                else
                {
                    Type elementType = _convertType.GetGenericArguments()[0];
                    Array array = TypeHelper.ConvertNumberListToArray((IList)value, elementType);

                    _converter.WriteJson(writer, array, serializer);
                }
            }
        }
    }
}
