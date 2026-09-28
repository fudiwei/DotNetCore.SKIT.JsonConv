namespace SKIT.JsonConv.NewtonsoftJson.Converters
{
    /// <summary>
    /// 一个 JSON 转换器，可针对指定适配类型做如下形式的对象转换。
    /// <code>
    ///   .NET → IList&lt;int&gt; Foo { get; } = new List&lt;int&gt;() { 1, 2 };
    ///   JSON → { "Foo": "1;2" }
    /// </code>
    /// 
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
    public sealed class StringifiedNumberListWithSemicolonSplitConverter : StringifiedNumberListWithSplitConverterBase
    {
        protected override string Separator { get { return ";"; } }
    }
}
