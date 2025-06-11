using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

public class DateTimeConverter : JsonConverter<DateTime?>
{
    private static readonly string[] SupportedFormats = new[]
    {
        "dd-MMM-yyyy", "dd/MM/yyyy", "MM/dd/yyyy",
        "yyyy-MM-dd", "dd-MM-yyyy",
        "yyyy/MM/dd", "MMMM dd, yyyy", "dd MMM yyyy",
        "yyyy-MM-ddTHH:mm:ss", "yyyy-MM-ddTHH:mm:ssZ","yyyyMMdd"
    };

    public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();

        if (string.IsNullOrWhiteSpace(value))
            return null;

        if (DateTime.TryParseExact(value, SupportedFormats, CultureInfo.InvariantCulture,
                                   DateTimeStyles.AssumeLocal, out DateTime parsed))
        {
            return parsed;
        }

        throw new JsonException($"Invalid date format: {value}");
    }

    public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
    {
        if (value.HasValue)
            writer.WriteStringValue(value.Value.ToString("yyyy-MM-ddTHH:mm:ss"));
        else
            writer.WriteNullValue();
    }
}
