namespace SKIT.JsonConv.SystemTextJson.Converters
{
    /// <summary>
    /// 一个 JSON 转换器，可针对指定适配类型做如下形式的对象转换。
    /// <code>
    ///   .NET → int[] Foo { get; } = new int[] { 1, 2 };
    ///   JSON → { "Foo": "1|2" }
    /// </code>
    /// 
    /// 适配类型：
    /// <see cref="sbyte">SByte[]</see>,
    /// <see cref="sbyte">Nullable&lt;SByte&gt;[]</see>,
    /// <see cref="byte">Byte[]</see>,
    /// <see cref="byte">Nullable&lt;Byte&gt;[]</see>,
    /// <see cref="ushort">UInt16[]</see>,
    /// <see cref="ushort">Nullable&lt;UInt16&gt;[]</see>,
    /// <see cref="short">Int16[]</see>,
    /// <see cref="short">Nullable&lt;Int16&gt;[]</see>,
    /// <see cref="uint">UInt32[]</see>,
    /// <see cref="uint">Nullable&lt;UInt32&gt;[]</see>,
    /// <see cref="int">Int32[]</see>,
    /// <see cref="int">Nullable&lt;Int32&gt;[]</see>,
    /// <see cref="ulong">UInt64[]</see>,
    /// <see cref="ulong">Nullable&lt;UInt64&gt;[]</see>,
    /// <see cref="long">Int64[]</see>,
    /// <see cref="long">Nullable&lt;Int64&gt;[]</see>,
    /// <see cref="float">Single[]</see>,
    /// <see cref="float">Nullable&lt;Single&gt;[]</see>,
    /// <see cref="double">Double[]</see>,
    /// <see cref="double">Nullable&lt;Double&gt;[]</see>,
    /// <see cref="decimal">Decimal[]</see>,
    /// <see cref="decimal">Nullable&lt;Decimal&gt;[]</see>
    /// </summary>
    public sealed class StringifiedNumberArrayWithPipeSplitConverter : StringifiedNumberArrayWithSplitConverterBase
    {
        protected override string Separator
        {
            get { return "|"; }
        }
    }
}
