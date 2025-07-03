using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WebExtension.Json.Converter
{
    public class DateOnlyJsonConverter : JsonConverter<DateOnly>
    {
        private const string Format = "yyyy-MM-dd"; // formato que usará en JSON

        public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            return DateOnly.ParseExact(s: value!, format: Format);
        }

        public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value: value.ToString(format: Format));
        }
    }
}