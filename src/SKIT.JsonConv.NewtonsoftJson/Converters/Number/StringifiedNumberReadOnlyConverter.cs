namespace SKIT.JsonConv.NewtonsoftJson.Converters
{
    /// <summary>
    /// 一个 JSON 转换器，可针对指定适配类型做如下形式的对象转换。与 <seealso cref="StringifiedNumberConverter"/> 类似，但转换过程是单向只读的。
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
    public sealed class StringifiedNumberReadOnlyConverter : JsonConverter
    {
        private static readonly JsonConverter _converter = new StringifiedNumberConverter();

        public override bool CanRead
        {
            get { return true; }
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override bool CanConvert(Type objectType)
        {
            return _converter.CanConvert(objectType);
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            return _converter.ReadJson(reader, objectType, existingValue, serializer);
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            throw new NotSupportedException();
        }
    }
}
