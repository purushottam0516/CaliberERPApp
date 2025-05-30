using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Caliber_Models.Models.SunPharma
{
    public class ProductModel
    {
        [JsonPropertyName("ProductCode")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Value.")]
        public string PrdUcode { get; set; } = "";

        [JsonPropertyName("ProductDesc")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Value.")]
        public string PrdDesc { get; set; } = "";

        [JsonPropertyName("GenericName")]
        public string PrdGenName { get; set; } = "";

        [JsonPropertyName("ReTestingPeriod")]
        public int RtPeriod { get; set; } = 0;

        [JsonPropertyName("IsModified")]
        public int IsModified { get; set; } = 1;
    }
}
