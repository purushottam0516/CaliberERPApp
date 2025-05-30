using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Caliber_Models.Models.Wallace
{
    public class WInboundModel
    {
        public string RecordType { get; set; } = string.Empty;

        [Required(ErrorMessage = "The Inspection Lot is required.")]
        [JsonPropertyName(" InspectionLotNum")]
        public string InspectionLot { get; set; } = string.Empty;

        public string OperationSequence { get; set; } = string.Empty;

        public string OperationNumber { get; set; } = string.Empty;

        [JsonPropertyName("InspectionLotPlant")]
        public string PlantCode { get; set; } = string.Empty;

        public string InspectionType { get; set; } = string.Empty;

        public string InspectionLotOrigin { get; set; } = string.Empty;

        public string CreatedBy { get; set; } = string.Empty;

        [JsonPropertyName("CreatedDate")]
        public DateTime CreatedOn { get; set; }

        public string ChangedBy { get; set; } = string.Empty;

        public DateTime ChangedDate { get; set; }

        public string UDCatalogType { get; set; } = string.Empty;

        public string UDPlantSelSet { get; set; } = string.Empty;

        public string UDSelSet { get; set; } = string.Empty;

        [JsonPropertyName("CustomerNum")]
        public string CustomerNo { get; set; } = string.Empty;

        [JsonPropertyName("CustomerName1")]
        public string CustomerName { get; set; } = string.Empty;

        [JsonPropertyName(" VendorNum")]
        public string SupplierCode { get; set; } = string.Empty;

        [JsonPropertyName("VendorName1")]
        public string SupplierName { get; set; } = string.Empty;

        [JsonPropertyName(" ManufactNum")]
        public string ManufactureCode { get; set; } = string.Empty;

        [JsonPropertyName(" ManufactName1")]
        public string ManufactureName { get; set; } = string.Empty;

        [JsonPropertyName("MaterialNum")]
        public string ItemCode { get; set; } = string.Empty;

        [JsonPropertyName("MaterialDesc")]
        public string ItemDesc { get; set; } = string.Empty;

        public string InspectionLotDesc { get; set; } = string.Empty;

        [JsonPropertyName("BatchNumber")]
        public string BatchNo { get; set; } = string.Empty;

        public string BatchStorageLoc { get; set; } = string.Empty;

        public string VendorBatchNo { get; set; } = string.Empty;

        [JsonPropertyName("InspectionLotQty")]
        public decimal BatchQuantity { get; set; } = 0;

        [JsonPropertyName("InspectionLotUnit")]
        public string BatchUOM { get; set; } = string.Empty;

        [JsonPropertyName(" InspectionLotSmpSize")]
        public decimal SampleQty { get; set; } = 0;

        [JsonPropertyName(" SampleSizeUnit")]
        public string SampleQtyUOM { get; set; } = string.Empty;

        public string PurchaseDocNum { get; set; } = string.Empty;

        public string PurchaseDocItemNum { get; set; } = string.Empty;


    }
}
