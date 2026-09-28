namespace SKIT.JsonConv.NewtonsoftJson.Converters
{
    /// <summary>
    /// 一个 JSON 转换器基类，可针对指定适配类型做特定形式的对象转换。
    /// <br />
    /// 适配类型：
    /// <see cref="IList{string}">IList&lt;string&gt;</see>
    /// </summary>
    public abstract partial class StringifiedStringListWithSplitConverterBase : JsonConverter
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
            return objectType.IsGenericType &&
                   typeof(IList<>).IsAssignableFrom(objectType.GetGenericTypeDefinition()) &&
                   typeof(string) == objectType.GetGenericArguments()[0];
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            JsonConverter<IList<string>?> converter = new InternalStringifiedStringListWithSplitConverter(Separator);
            return converter.ReadJson(reader, objectType, (IList<string>?)existingValue, (IList<string>?)existingValue is not null, serializer);
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            JsonConverter<IList<string>?> converter = new InternalStringifiedStringListWithSplitConverter(Separator);
            converter.WriteJson(writer, (IList<string>?)value, serializer);
        }
    }

    partial class StringifiedStringListWithSplitConverterBase
    {
        private sealed class InternalStringifiedStringArrayWithSplitConverter : StringifiedStringArrayWithSplitConverterBase
        {
            protected override string Separator { get; }

            public InternalStringifiedStringArrayWithSplitConverter(string separator)
            {
                Separator = separator;
            }

            public override string[]? ReadJson(JsonReader reader, Type objectType, string[]? existingValue, bool hasExistingValue, JsonSerializer serializer)
            {
                return base.ReadJson(reader, objectType, existingValue, hasExistingValue, serializer);
            }

            public override void WriteJson(JsonWriter writer, string[]? value, JsonSerializer serializer)
            {
                base.WriteJson(writer, value, serializer);
            }
        }

        private sealed class InternalStringifiedStringListWithSplitConverter : JsonConverter<IList<string>?>
        {
            private readonly JsonConverter<string[]?> _converter;

            public InternalStringifiedStringListWithSplitConverter(string separator)
            {
                _converter = new InternalStringifiedStringArrayWithSplitConverter(separator);
            }

            public override IList<string>? ReadJson(JsonReader reader, Type objectType, IList<string>? existingValue, bool hasExistingValue, JsonSerializer serializer)
            {
                return _converter.ReadJson(reader, typeof(string[]), existingValue?.ToArray(), hasExistingValue, serializer);
            }

            public override void WriteJson(JsonWriter writer, IList<string>? value, JsonSerializer serializer)
            {
                _converter.WriteJson(writer, value?.ToArray(), serializer);
            }
        }
    }
}
