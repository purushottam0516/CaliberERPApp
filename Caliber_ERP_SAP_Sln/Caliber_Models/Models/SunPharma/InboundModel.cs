using System.Text.Json.Serialization;

namespace Caliber_Models.Models.SunPharma
{
    public class InboundModel
    {
        // Gets or sets the memo number.
        public string MemoNumber { get; set; } = string.Empty;

        //Gets or sets the memo date.

        [JsonConverter(typeof(DateTimeConverter))] 
        public DateTime? MemoDate { get; set; } 

        //Gets or sets the item description.

        [JsonPropertyName("ItemDesc")]
        public string MaterialDesc { get; set; } = string.Empty;

        //Gets or sets the item code.

        [JsonPropertyName("ItemCode")]
        public string MaterialNum { get; set; } = string.Empty;

        //Gets or sets the manufacture name.

        [JsonPropertyName("ManufactureName")]
        public string ManufactName1 { get; set; } = string.Empty;

        // Gets or sets the manufacture code.
        [JsonPropertyName("ManufactureCode")]
        public string ManufactNum { get; set; } = string.Empty;

        //Gets or sets the supplier name.
        [JsonPropertyName("SupplierName")]
        public string VendorName1 { get; set; } = string.Empty;

        //Gets or sets the supplier code.
        [JsonPropertyName("SupplierCode")]
        public string VendorNum { get; set; } = string.Empty;

        //Gets or sets the batch number.
        [JsonPropertyName("BatchNo")]
        public string BatchNumber { get; set; } = string.Empty;

        //Gets or sets the batch quantity.
        [JsonPropertyName("BatchQuantity")]
        public string InspectionLotQty { get; set; } = string.Empty;

        // Gets or sets the batch unit of measure.
        [JsonPropertyName("BatchUOM")]
        public string InspectionLotUnit { get; set; } = string.Empty;

        //Gets or sets the batch manufacture date.
        [JsonPropertyName("BatchManufactureDate")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? MfgDate { get; set; }

        //Gets or sets the expiry date.
        [JsonPropertyName("ExpiryDate")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? ExpDate { get; set; }

        //Gets or sets the retest date.
        [JsonPropertyName("RetestDate")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? ReTestDate { get; set; } 

        //Gets or sets the ExpiryRetestIndicator.
        [JsonPropertyName("EX_RT_Indicator")]
        public string ExpiryRetestIndicator { get; set; } = string.Empty;

        //Gets or sets the sample number.

        public string SampleNo { get; set; } = string.Empty;

        //Gets or sets the sample quantity.
        [JsonPropertyName("SampleQty")]
        public string InspectionLotSmpSize { get; set; } = string.Empty;

        //Gets or sets the sample quantity unit of measure.
        [JsonPropertyName("SampleQtyUOM")]
        public string SampleSizeUnit { get; set; } = string.Empty;

        //Gets or sets the sampling by.

        public string SamplingBy { get; set; } = string.Empty;

        //Gets or sets the inspection type.

        public string InspectionType { get; set; } = string.Empty;

        //Gets or sets the plant code.
        [JsonPropertyName("PlantCode")]
        public int InspectionLotPlant { get; set; } = 0;

        //Gets or sets the created by.

        public string CreatedBy { get; set; } = string.Empty;

        //Gets or sets the created on date.
        [JsonPropertyName("CreatedOn")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? CreatedDate { get; set; } 

        //Gets or sets the total number of containers.
        [JsonPropertyName("TotalNoOfContainers")]
        public int NoContainers { get; set; } = 0;

        //Gets or sets the vendor batch number.
        [JsonPropertyName("VendorBatchNo")]
        public string VendorBatchNum { get; set; } = string.Empty;

        //Gets or sets the GRN number.
        [JsonPropertyName("GRNNo")]
        public long MaterialDocNum { get; set; } = 0;  //string

        //Gets or sets the GRN date.
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? GRNDate { get; set; } 

        //Gets or sets the GRN unit of measure.
        [JsonPropertyName("GRNUOM")]
        public string GRNUom { get; set; } = string.Empty;

        //Gets or sets the GRN quantity.

        public string GRNQty { get; set; } = string.Empty;


        //public int IsModified { get; set; } = 0;

        //Gets or sets the downloaded on date.
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? DownloadedOn { get; set; } 

        public string Samplinglevel { get; set; } = string.Empty;
       
        [JsonPropertyName("InspectionLot")]
        public string InspectionLotNum { get; set; } = string.Empty;

        public string TRFNo { get; set; } = string.Empty;

        //public DateTime TRDate { get; set; }
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? TRDate { get; set; }

        [JsonPropertyName("AllocatedQuantity")]
        public string AllocatedQty { get; set; } = string.Empty;

        public string CountryMarket { get; set; } = string.Empty;

        public string StorageRoomBin { get; set; } = string.Empty;

        public string Storageconditions { get; set; } = string.Empty;

        [JsonPropertyName("SampleHandlingRemarksIfAny")]
        public string SmpHandlingRemarksIfAny { get; set; } = string.Empty;

        [JsonPropertyName("ChemicalAnalysissamplingQty")]
        public string ChmAnalysisSmpQty { get; set; } = string.Empty;

        [JsonPropertyName("MicrobiologicalAnalysisqty")]
        public string MicroBioAnalysisQty { get; set; } = string.Empty;

        [JsonPropertyName("OtherSample")]
        public string OtherSmp { get; set; } = string.Empty;

        [JsonPropertyName("TotalSampleQty")]
        public string TotalSmpQty { get; set; } = string.Empty;

        //[JsonPropertyName("ReserveSampleqty")]
        //public string ResSmpQty { get; set; }

        [JsonPropertyName("TotalNoofcontainerSampled")]
        public string NoContainersSampled { get; set; }=string.Empty;

        [JsonPropertyName("Sampledon")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? SampledOn { get; set; } 

    }

}
