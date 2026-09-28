namespace SKIT.JsonConv.NewtonsoftJson.Converters
{
    /// <summary>
    /// 一个 JSON 转换器，可针对指定适配类型做如下形式的对象转换。
    /// <code>
    ///   .NET → DateTimeOffset Foo { get; } = new DateTimeOffset(2000, 1, 1, 23, 59, 59);
    ///   JSON → { "Foo": "20000101235959" }
    /// </code>
    /// 
    /// 适配类型：
    /// <see cref="DateTimeOffset">DateTimeOffset</see>,
    /// <see cref="DateTimeOffset">Nullable&lt;DateTimeOffset&gt;</see>
    /// </summary>
    public sealed class ISO8601CompactDateTimeOffsetConverter : FormattableDateTimeOffsetConverterBase
    {
        protected override string FormatString
        {
            get { return "yyyyMMddHHmmss"; }
        }
    }
}
