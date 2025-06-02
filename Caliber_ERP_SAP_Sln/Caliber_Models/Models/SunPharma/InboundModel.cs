using System.ComponentModel;
using System.Text.Json.Serialization;

namespace Caliber_Models.Models.SunPharma
{
    public class InboundModel
    {
        // Gets or sets the memo number.
        public string MemoNumber { get; set; } = string.Empty;

        //Gets or sets the memo date.

        public DateTime MemoDate { get; set; }

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
        public decimal InspectionLotQty { get; set; } = 0;

        // Gets or sets the batch unit of measure.
        [JsonPropertyName("BatchUOM")]
        public string InspectionLotUnit { get; set; } = string.Empty;

        //Gets or sets the batch manufacture date.
        [JsonPropertyName("BatchManufactureDate")]
        public DateTime MfgDate { get; set; }

        //Gets or sets the expiry date.
        [JsonPropertyName("ExpiryDate")]
        public DateTime ExpDate { get; set; }

        //Gets or sets the retest date.
        [JsonPropertyName("RetestDate")]
        public DateTime ReTestDate { get; set; }

        //Gets or sets the ExpiryRetestIndicator.
        [JsonPropertyName("EX_RT_Indicator")]
        public string ExpiryRetestIndicator { get; set; } = string.Empty;

        //Gets or sets the sample number.

        public int SampleNo { get; set; } = 0;

        //Gets or sets the sample quantity.
        [JsonPropertyName("SampleQty")]
        public decimal InspectionLotSmpSize { get; set; } = 0;

        //Gets or sets the sample quantity unit of measure.
        [JsonPropertyName("SampleQtyUOM")]
        public string SampleSizeUnit { get; set; } = string.Empty;

        //Gets or sets the sampling by.

        public string SamplingBy { get; set; } = string.Empty;

        //Gets or sets the inspection type.

        public string InspectionType { get; set; } = string.Empty;

        //Gets or sets the plant code.
        [JsonPropertyName("PlantCode")]
        public string InspectionLotPlant { get; set; } = string.Empty;

        //Gets or sets the created by.

        public string CreatedBy { get; set; } = string.Empty;

        //Gets or sets the created on date.
        [JsonPropertyName("CreatedOn")]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        //Gets or sets the total number of containers.
        [JsonPropertyName("TotalNoOfContainers")]
        public int NoContainers { get; set; } = 0;

        //Gets or sets the vendor batch number.
        [JsonPropertyName("VendorBatchNo")]
        public string VendorBatchNum { get; set; } = string.Empty;

        //Gets or sets the GRN number.
        [JsonPropertyName("GRNNo")]
        public string MaterialDocNum { get; set; } = string.Empty;

        //Gets or sets the GRN date.

        public DateTime GRNDate { get; set; }

        //Gets or sets the GRN unit of measure.
        [JsonPropertyName("GRNUOM")]
        public string GRNUom { get; set; } = string.Empty;

        //Gets or sets the GRN quantity.

        public decimal GRNQty { get; set; }


        public int IsModified { get; set; } = 0;

        //Gets or sets the downloaded on date.

        public DateTime DownloadedOn { get; set; } = DateTime.UtcNow;

       // public int InspectionintervalDays { get; set; }=0;

        public string Samplinglevel { get; set; } = string.Empty;

        //[JsonPropertyName("VendorRetestdate")]
        //public DateTime VendorRetestDate { get; set; }= DateTime.UtcNow;

        //public string Stage { get; set; }= string.Empty;

        // public string MotherBatchNo { get; set; } = string.Empty;
        [JsonPropertyName("InspectionLot")]
        public string InspectionLotNum { get; set; } = string.Empty;

        public string TRFNo { get; set; } = string.Empty;

        public DateTime TRDate { get; set; }

        [JsonPropertyName("AllocatedQuantity")]
        public decimal AllocatedQty { get; set; }

        public string CountryMarket { get; set; } = string.Empty;

        public string StorageRoomBin { get; set; } = string.Empty;

        public string Storageconditions { get; set; } = string.Empty;

        [JsonPropertyName("SampleHandlingRemarksIfAny")]
        public string SmpHandlingRemarksIfAny { get; set; } = string.Empty;

        [JsonPropertyName("ChemicalAnalysissamplingQty")]
        public decimal ChmAnalysisSmpQty { get; set; }

        [JsonPropertyName("MicrobiologicalAnalysisqty")]
        public decimal MicroBioAnalysisQty { get; set; }

        [JsonPropertyName("OtherSample")]
        public string OtherSmp { get; set; } = string.Empty;

        [JsonPropertyName("TotalSampleQty")]
        public decimal TotalSmpQty { get; set; }

        [JsonPropertyName("ReserveSampleqty")]
        public decimal ResSmpQty { get; set; }

        [JsonPropertyName("TotalNoofcontainerSampled")]
        public string NoContainersSampled { get; set; }=string.Empty;

        [JsonPropertyName("Sampledon")]
        public DateTime SampledOn { get; set; } 

        [JsonPropertyName("NextInspectionDate")]
        public DateTime NextInspDate { get; set; }

        public DateTime SAPReleaseDate { get; set; }

        [JsonPropertyName("IsReduceTestingLot")]
        public decimal IsReduceTstLot { get; set; }

    }

}
