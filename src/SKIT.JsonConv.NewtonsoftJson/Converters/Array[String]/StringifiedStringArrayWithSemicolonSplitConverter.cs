namespace SKIT.JsonConv.NewtonsoftJson.Converters
{
    /// <summary>
    /// 一个 JSON 转换器，可针对指定适配类型做如下形式的对象转换。
    /// <code>
    ///   .NET → string[] Foo { get; } = new string[] { "a", "b" };
    ///   JSON → { "Foo": "a;b" }
    /// </code>
    /// 
    /// 适配类型：
    /// <see cref="string">string[]</see>
    /// </summary>
    public sealed class StringifiedStringArrayWithSemicolonSplitConverter : StringifiedStringArrayWithSplitConverterBase
    {
        protected override string Separator
        {
            get { return ";"; }
        }
    }
}
