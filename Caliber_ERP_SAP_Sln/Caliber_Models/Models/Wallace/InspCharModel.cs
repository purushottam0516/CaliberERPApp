using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliber_Models.Models.Wallace
{
    public class InspCharModel
    {
        public string RecordType { get; set; } = string.Empty;

        [Required(ErrorMessage = "ConfirmationNo is Required")]
        public int ConfirmationNo { get; set; }

        public string InspRecordingType { get; set; } = string.Empty;

        public string MasterInspCharPlant { get; set; } = string.Empty;

        public string MasterInspCharVersion { get; set; } = string.Empty;

        [Required(ErrorMessage ="TestName is required")]
        public string TestName { get; set; } = string.Empty;

        public string Formula { get; set; } = string.Empty;

        public string IndCatlogEntry1 { get; set; } = string.Empty;

        public string CatalogType1 { get; set; } = string.Empty;

        public string PlantOfSelSet1 { get; set; } = string.Empty;

        public string CodeGroup1 { get; set; } = string.Empty;

        public string IndCatlogEntry2 { get; set; } = string.Empty;

        public string CatalogType2 { get; set; } = string.Empty;

        public string PlantOfSelSet2 { get; set; } = string.Empty;

        public string CodeGroup2 { get; set; } = string.Empty;

        public string IndCatlogEntry3 { get; set; } = string.Empty;

        public string CatalogType3 { get; set; } = string.Empty;

        public string PlantOfSelSet3 { get; set; } = string.Empty;

        public string CodeGroup3 { get; set; } = string.Empty;

        public string IndCatlogEntry4 { get; set; } = string.Empty;

        public string CatalogType4 { get; set; } = string.Empty;

        public string PlantOfSelSet4 { get; set; } = string.Empty;

        public string CodeGroup4 { get; set; } = string.Empty;

        public string IndCatlogEntry5 { get; set; } = string.Empty;

        public string CatalogType5 { get; set; } = string.Empty;

        public string PlantOfSelSet5 { get; set; } = string.Empty;

        public string CodeGroup5 { get; set; } = string.Empty;

        public string InspectionLot { get; set; } = string.Empty;
    }
}
