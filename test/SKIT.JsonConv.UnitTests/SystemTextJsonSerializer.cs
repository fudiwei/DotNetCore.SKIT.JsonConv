using System.Text.Encodings.Web;
using System.Text.Json.Serialization;

namespace SKIT.JsonConv.UnitTests
{
    internal sealed class SystemTextJsonSerializer : IJsonSerializer
    {
        private readonly JsonSerializerOptions _jsonOptions;

        public SystemTextJsonSerializer()
            : this(GetDefaultSerializerOptions())
        {
        }

        public SystemTextJsonSerializer(JsonSerializerOptions options)
        {
            _jsonOptions = options ?? throw new ArgumentNullException(nameof(options));
        }

        public static JsonSerializerOptions GetDefaultSerializerOptions()
        {
            JsonSerializerOptions options = new JsonSerializerOptions(JsonSerializerOptions.Default);
            options.Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            options.NumberHandling = JsonNumberHandling.AllowReadingFromString;
            options.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
            options.AllowDuplicateProperties = false;
            options.WriteIndented = false;
            options.PropertyNamingPolicy = null;
            options.PropertyNameCaseInsensitive = true;
            return options;
        }

        /// <inheritdoc/>
        public object? Deserialize(string json, Type type)
        {
            return JsonSerializer.Deserialize(json, type, _jsonOptions);
        }

        /// <inheritdoc/>
        public string Serialize(object? obj, Type type)
        {
            return JsonSerializer.Serialize(obj, type, _jsonOptions);
        }
    }
}
