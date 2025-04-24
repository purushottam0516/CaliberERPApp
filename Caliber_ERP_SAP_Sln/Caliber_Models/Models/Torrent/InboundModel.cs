using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Caliber_Models.Models.Torrent
{
    /// <summary>
    /// Represents an inspection lot record containing metadata for quality control and logistics.
    /// </summary>
    public class InboundReqModel
    {
        /// <summary>Record type identifier, e.g., "Q40".</summary>
        public string RecordType { get; set; } = string.Empty;

        /// <summary>Unique identifier for the inspection lot.</summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide value.")]
        [JsonPropertyName("InspectionLotNum")]
        public string InspectionLot { get; set; } = "";

        /// <summary>Operation or step number in the process.</summary>
        public string OperationNumber { get; set; } = string.Empty;

        /// <summary>Plant or location where the inspection is performed.</summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide value.")]
        [JsonPropertyName("InspectionLotPlant")]
        public string PlantCode { get; set; } = string.Empty;

        /// <summary>Inspection type code, e.g., "01".</summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide value.")]
        public string InspectionType { get; set; } = string.Empty;

        /// <summary>Origin code for the inspection lot.</summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide value.")]
        public string InspectionLotOrigin { get; set; } = string.Empty;

        /// <summary>Date the inspection lot was created (yyyyMMdd).</summary>
        [JsonPropertyName("CreatedDate")]
        public string CreatedOn { get; set; } = string.Empty;

        /// <summary>User ID who created the inspection lot.</summary>
        public string CreatedBy { get; set; } = string.Empty;

        /// <summary>Inspection start date (yyyyMMdd).</summary>
        public string InspStartDate { get; set; }= string.Empty;

        /// <summary>Inspection end date (yyyyMMdd).</summary>
        public string InspEndDate { get; set; }=string.Empty;

        /// <summary>Customer number associated with the inspection lot.</summary>
        [JsonPropertyName("CustomerNum")]
        public string CustomerNo { get; set; } = string.Empty;

        /// <summary>Name of the customer.</summary>
        public string CustomerName { get; set; } = string.Empty;

        /// <summary>Vendor number associated with the inspection lot.</summary>
        [JsonPropertyName("VendorNum")]
        public string SupplierCode { get; set; } = string.Empty;

        /// <summary>Name of the vendor.</summary>
        [JsonPropertyName("VendorName")]
        public string SupplierName { get; set; } = string.Empty;

        /// <summary>Manufacturer number associated with the inspection lot.</summary>
        [JsonPropertyName("ManufactNum")]
        public string ManufactureCode { get; set; } = string.Empty;

        /// <summary>Name of the manufacturer.</summary>
        [JsonPropertyName("ManufactName")]
        public string ManufactureName { get; set; } = string.Empty;

        /// <summary>Material number or identifier.</summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide value.")]
        [JsonPropertyName("MaterialNum")]
        public string ItemCode { get; set; } = "";

        /// <summary>Description of the material.</summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide value.")]
        [JsonPropertyName("MaterialDesc")]
        public string ItemDesc { get; set; } = "";

        /// <summary>Description of the inspection lot (optional).</summary>
        public string InspectionLotDesc { get; set; } = string.Empty;

        /// <summary>Batch number related to the material.</summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide value.")]
        [JsonPropertyName("BatchNumber")]
        public string BatchNo { get; set; } = "";

        /// <summary>Storage location of the batch.</summary>
        public string BatchStorageLoc { get; set; } = "";

        /// <summary>Quantity of material in the inspection lot.</summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide value.")]
        [JsonPropertyName("InspectionLotQty")]
        public double BatchQuantity { get; set; }=0;

        /// <summary>Unit of measurement for the inspection lot quantity.</summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide value.")]
        [JsonPropertyName("InspectionLotUnit")]
        public string BatchUOM { get; set; }= string.Empty;

        /// <summary>Sample size for inspection.</summary>
        [JsonPropertyName("SamplingSize")]
        public double SampleQty { get; set; }= 0;

        /// <summary>Unit of measurement for the sampling size.</summary>
        [JsonPropertyName("SamplingSizeUnit")]
        public string SampleQtyUOM { get; set; } = "";

        /// <summary>Purchase document number related to the lot.</summary>
        public string PurchaseDocNum { get; set; } = "";

        /// <summary>Material document number related to the lot.</summary>
        [JsonPropertyName("MaterialDocNum")]
        public string GRNNo { get; set; } = "";

        /// <summary>Type of material (e.g., "Raw").</summary>
        public string MaterialType { get; set; } = "";

        /// <summary>Manufacturing date of the material (yyyyMMdd).</summary>
        [JsonPropertyName("MfgDate")]
        public string BatchManufactureDate { get; set; } = "";

        /// <summary>Expiration date of the material (yyyyMMdd).</summary>
        [JsonPropertyName("ExpDate")]
        public string ExpiryDate { get; set; } = "";

        /// <summary>Total number of containers in the lot.</summary>
        [JsonPropertyName("TotalContainers")]
        public int TotalNoOfContainers { get; set; }

        /// <summary>Delivery note identifier.</summary>
        public string DeliveryNote { get; set; } = "";

        /// <summary>Parent batch number, if the lot is derived from another.</summary>
        public string ParentBatchNo { get; set; } = "";

        /// <summary>Size of the packing unit.</summary>
        public string PackingSize { get; set; } = "";

        /// <summary>Indicates whether the lot is eligible for reduced testing.</summary>
        public bool IsReduceTestingLot { get; set; }

        /// <summary>Indicates whether the lot is marked to be skipped in inspection.</summary>
        public bool IsSkipLot { get; set; }

        public int IsModified { get; set; }
    }

}
