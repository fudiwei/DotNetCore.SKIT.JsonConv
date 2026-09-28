namespace SKIT.JsonConv.SystemTextJson.Converters
{
    /// <summary>
    /// 一个 JSON 转换器，可针对指定适配类型做如下形式的对象转换。
    /// <code>
    ///   .NET → IList&lt;string&gt; Foo { get; } = new List&lt;string&gt;() { "a", "b" };
    ///   JSON → { "Foo": "a;b" }
    /// </code>
    /// 
    /// 适配类型：
    /// <see cref="IList{string}">IList&lt;string&gt;</see>
    /// </summary>
    public sealed class StringifiedStringListWithSemicolonSplitConverter : StringifiedStringListWithSplitConverterBase
    {
        protected override string Separator
        {
            get { return ";"; }
        }
    }
}
