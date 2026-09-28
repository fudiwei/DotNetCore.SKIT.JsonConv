#if NET5_0_OR_GREATER
namespace SKIT.JsonConv.NewtonsoftJson.Converters
{
    /// <summary>
    /// 一个 JSON 转换器，可针对指定适配类型做如下形式的对象转换。
    /// <code>
    ///   .NET → TimeOnly Foo { get; } = new TimeOnly(23, 59, 59);
    ///   JSON → { "Foo": "235959" }
    /// </code>
    /// 
    /// 适配类型：
    /// <see cref="TimeOnly">TimeOnly</see>
    /// <see cref="TimeOnly">Nullable&lt;TimeOnly&gt;</see>
    /// </summary>
    public sealed class ISO8601CompactTimeOnlyConverter : FormattableTimeOnlyConverterBase
    {
        protected override string FormatString
        {
            get { return "HHmmss"; }
        }
    }
}
#endif
