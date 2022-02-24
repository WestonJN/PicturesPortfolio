using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class Picture
    {
        public string Id { get; set; }

        public string Description { get; set; }

        [JsonPropertyName("image-url")]
        public string Image { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Picture>(this);

    }
}
