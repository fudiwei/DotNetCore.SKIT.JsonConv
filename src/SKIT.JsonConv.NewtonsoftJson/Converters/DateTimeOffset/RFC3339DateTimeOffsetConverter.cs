namespace SKIT.JsonConv.NewtonsoftJson.Converters
{
    /// <summary>
    /// 一个 JSON 转换器，可针对指定适配类型做如下形式的对象转换。
    /// <code>
    ///   .NET → DateTimeOffset Foo { get; } = new DateTimeOffset(2000, 1, 1, 23, 59, 59);
    ///   JSON → { "Foo": "2000-01-01T23:59:59+08:00" }
    /// </code>
    /// 
    /// 适配类型：
    /// <see cref="DateTimeOffset">DateTimeOffset</see>,
    /// <see cref="DateTimeOffset">Nullable&lt;DateTimeOffset&gt;</see>
    /// </summary>
    public sealed class RFC3339DateTimeOffsetConverter : FormattableDateTimeOffsetConverterBase
    {
        protected override string FormatString
        {
            get { return "yyyy-MM-dd'T'HH:mm:sszzz"; }
        }
    }
}
