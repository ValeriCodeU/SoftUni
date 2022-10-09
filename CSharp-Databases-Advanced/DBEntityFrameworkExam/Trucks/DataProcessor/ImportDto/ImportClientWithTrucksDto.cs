using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Trucks.DataProcessor.ImportDto
{
    public class ImportClientWithTrucksDto
    {
        [Required]
        [MinLength(3)]
        [MaxLength(40)]
        [JsonProperty(nameof(Name))]

        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(40)]
        [JsonProperty(nameof(Nationality))]

        public string Nationality { get; set; }

        [Required]
        [JsonProperty(nameof(Type))]

        public string Type { get; set; }

        [MinLength(1)]

        public int[] Trucks { get; set; }
    }
}
