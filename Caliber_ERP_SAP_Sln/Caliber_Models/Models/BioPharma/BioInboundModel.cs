using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Caliber_Models.Models.BioPharma
{
    public class BioInboundModel
    {
        [Key]
        [Required(ErrorMessage = "The Inspection Receipt ID is required.")]

        public int InspReceiptID { get; set; }

        [Required (ErrorMessage = "The Inspection Lot is required.")]
        public string InspectionLot { get; set; } = string.Empty;

        [JsonPropertyName("ManufactureDate")]
        public DateTime BatchManufactureDate { get; set; }

        public DateTime ExpiryDate { get; set; }

        public string CustomerName { get; set; } = string.Empty;

        public string CustomerNo { get; set; } = string.Empty;

        public DateTime GRNDate { get; set; }

        public string GRNNo { get; set; } = string.Empty;

        public decimal GRNQty { get; set; }

        [Required(ErrorMessage = "The Item Description is required.")]
        public string ItemDesc { get; set; } = string.Empty;

        [Required (ErrorMessage ="The Item Code is required.")]
        public string Itemcode { get; set; } = string.Empty;

        public string ManufactureName { get; set; } = string.Empty;

        [JsonPropertyName("ManufacturerNo")]
        public string ManufactureCode { get; set; } = string.Empty;
        [JsonPropertyName("VendorName")]
        public string SupplierName { get; set; } = string.Empty;

        [JsonPropertyName("VendorNo")]
        public string SupplierCode { get; set; } = string.Empty;

        [JsonPropertyName("NoOfContainers")]
        public int TotalNoOfContainers { get; set; } 

        [JsonPropertyName("Quantity")]
        public decimal BatchQuantity { get; set; }

        [JsonPropertyName("UOM")]
        public string BatchUOM { get; set; } = string.Empty;

        public string VendorLotNo { get; set; } = string.Empty;

        public string BatchNo { get; set; } = string.Empty;

        [JsonPropertyName("RetestPeriod")]
        public string NextInspInterval { get; set; } = string.Empty;

        public int RetestFlag { get; set; }



    }

    public class BiopharmaInboundResponseModel
    {
        /// <summary>
        /// Gets or sets the return status.
        /// </summary>
        public int ReturnStatus { get; set; }

        /// <summary>
        /// Gets or sets the key field.
        /// </summary>
        public string KeyField { get; set; } = string.Empty;
    }
}
