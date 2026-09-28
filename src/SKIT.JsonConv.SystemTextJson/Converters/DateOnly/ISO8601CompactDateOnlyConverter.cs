#if NET5_0_OR_GREATER
namespace SKIT.JsonConv.SystemTextJson.Converters
{
    /// <summary>
    /// 一个 JSON 转换器，可针对指定适配类型做如下形式的对象转换。
    /// <code>
    ///   .NET → DateOnly Foo { get; } = new DateOnly(2000, 1, 1);
    ///   JSON → { "Foo": "20000101" }
    /// </code>
    /// 
    /// 适配类型：
    /// <see cref="DateOnly">DateOnly</see>
    /// <see cref="DateOnly">Nullable&lt;DateOnly&gt;</see>
    /// </summary>
    public sealed class ISO8601CompactDateOnlyConverter : FormattableDateOnlyConverterBase
    {
        protected override string FormatString
        {
            get { return "yyyyMMdd"; }
        }
    }
}
#endif
