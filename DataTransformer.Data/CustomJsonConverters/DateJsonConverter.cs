﻿using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataTransformer.Data.Json
{
    public class DateJsonConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options) =>
                DateTime.ParseExact(reader.GetString()!,
                    "yyyy-MM-dd", CultureInfo.InvariantCulture);

        public override void Write(
            Utf8JsonWriter writer,
            DateTime dateTimeValue,
            JsonSerializerOptions options) =>
                writer.WriteStringValue(dateTimeValue.ToString(
                    "yyyy-MM-dd", CultureInfo.InvariantCulture));
    }
}
