using System.ComponentModel;

namespace Caliber_Models.Models.SunPharma
{
    public class InboundModel
    {
        // Gets or sets the memo number.
        public string MemoNumber { get; set; } = string.Empty;

        //Gets or sets the memo date.

        public DateTime MemoDate { get; set; }

        //Gets or sets the item description.

        public string ItemDesc { get; set; } = string.Empty;

        //Gets or sets the item code.

        public string ItemCode { get; set; } = string.Empty;

        //Gets or sets the manufacture name.

        public string ManufactureName { get; set; } = string.Empty;

        // Gets or sets the manufacture code.

        public string ManufactureCode { get; set; } = string.Empty;

        //Gets or sets the supplier name.

        public string SupplierName { get; set; } = string.Empty;

        //Gets or sets the supplier code.

        public string SupplierCode { get; set; } = string.Empty;

        //Gets or sets the batch number.

        public string BatchNo { get; set; } = string.Empty;

        //Gets or sets the batch quantity.

        public decimal BatchQuantity { get; set; } = 0;

        // Gets or sets the batch unit of measure.

        public string BatchUOM { get; set; } = string.Empty;

        //Gets or sets the batch manufacture date.

        public DateTime BatchManufactureDate { get; set; }

        //Gets or sets the expiry date.

        public DateTime ExpiryDate { get; set; }

        //Gets or sets the retest date.

        public DateTime RetestDate { get; set; }

        //Gets or sets the ExpiryRetestIndicator.

        public string EX_RT_Indicator { get; set; } = string.Empty;

        //Gets or sets the sample number.

        public string SampleNo { get; set; } = string.Empty;

        //Gets or sets the sample quantity.

        public decimal SampleQty { get; set; } = 0;

        //Gets or sets the sample quantity unit of measure.

        public string SampleQtyUOM { get; set; } = string.Empty;

        //Gets or sets the sampling by.

        public string SamplingBy { get; set; } = string.Empty;

        //Gets or sets the inspection type.

        public string InspectionType { get; set; } = string.Empty;

        //Gets or sets the plant code.

        public string PlantCode { get; set; } = string.Empty;

        //Gets or sets the created by.

        public string CreatedBy { get; set; } = string.Empty;

        //Gets or sets the created on date.

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        //Gets or sets the total number of containers.

        public int TotalNoOfContainers { get; set; } = 0;

        //Gets or sets the vendor batch number.

        public string VendorBatchNo { get; set; } = string.Empty;


        //Gets or sets the GRN number.

        public string GRNNo { get; set; } = string.Empty;

        //Gets or sets the GRN date.

        public DateTime GRNDate { get; set; }

        //Gets or sets the GRN unit of measure.

        public string GRNUOM { get; set; } = string.Empty;

        //Gets or sets the GRN quantity.

        public decimal GRNQty { get; set; }


        public int IsModified { get; set; } = 0;

        //Gets or sets the downloaded on date.

        public DateTime DownloadedOn { get; set; } = DateTime.UtcNow;

       // public int InspectionintervalDays { get; set; }=0;

        public string Samplinglevel { get; set; } = string.Empty;

        //public DateTime VendorRetestdate { get; set; }= DateTime.UtcNow;

        //public string Stage { get; set; }= string.Empty;

       // public string MotherBatchNo { get; set; } = string.Empty;

        public string InspectionLot { get; set; } = string.Empty;

        public string TRFNo { get; set; } = string.Empty;

        public DateTime TRDate { get; set; }=DateTime.UtcNow;

        public decimal AllocatedQuantity { get; set; }

        public string CountryMarket { get; set; } = string.Empty;

        public string StorageRoomBin { get; set; } = string.Empty;

        public string Storageconditions { get; set; } = string.Empty;

        public string SampleHandlingRemarksIfAny { get; set; } = string.Empty;

        public decimal ChemicalAnalysissamplingQty { get; set; }

        public decimal MicrobiologicalAnalysisqty { get; set; }

        public string OtherSample { get; set; } = string.Empty;

        public decimal TotalSampleQty { get; set; }

        public decimal ReserveSampleqty { get; set; }

        public string TotalNoofcontainerSampled { get; set; }=string.Empty; 

        public string Sampledon { get; set; } = string.Empty;

        public DateTime NextInspectionDate { get; set; } = DateTime.UtcNow;

        public DateTime SAPReleaseDate { get; set; }=DateTime.UtcNow;

        public decimal IsReduceTestingLot { get; set; }

    }

}
