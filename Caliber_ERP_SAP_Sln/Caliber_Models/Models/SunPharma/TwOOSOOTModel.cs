using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliber_Models.Models.SunPharma
{
    public class TwOOSOOTModel
    {
        /// <summary>
        /// Unique identifier for the investigation.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Value.")]
        public string InvestigationNumber { get; set; } = string.Empty;

        /// <summary>
        /// Code for identifying the plant where the issue was discovered.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Value.")]
        public string PlantCode { get; set; } = string.Empty;

        /// <summary>
        /// Date when Investigation L-1 Submitted.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Value.")]
        public DateTime DateOfDiscovery { get; set; }

        /// <summary>
        /// Classification of the Investigation Type (OOS, OOT, OOC).
        /// </summary>
        public OosOotOocType OosOot { get; set; }


        /// <summary>
        /// Date on which the analysis was performed.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Value.")]
        public DateTime DateOfAnalysis { get; set; }

        /// <summary>
        /// Name of the analyst who performed the test.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Value.")]
        public string AnalystName { get; set; } = string.Empty;

        /// <summary>
        /// TestName for the investigation to Performed.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Value.")]
        public string TestName { get; set; } = string.Empty;

        /// <summary>
        /// Associated specification number.
        /// </summary>
        public string SpecificationId { get; set; } = string.Empty;

        /// <summary>
        /// TestMethod of Test which is the Investigation.
        /// </summary>
        public string TestMethod { get; set; } = string.Empty;


        /// <summary>
        /// LIMS AR number associated with the investigation.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Value.")]
        public string LIMSARNO { get; set; } = string.Empty;

        /// <summary>
        /// Code identifying the test performed.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Value.")]
        public string TestCode { get; set; } = string.Empty;

        /// <summary>
        /// Product Unique Code.
        /// </summary>
        public string PrdCode { get; set; } = string.Empty;

        /// <summary>
        /// Product Description.
        /// </summary>
        public string PrdDesc { get; set; } = string.Empty;

        /// <summary>
        /// Corrsponding Sample Batch Number.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Value.")]
        public string BatchNum { get; set; } = string.Empty;

        /// <summary>
        /// Corrsponding Sample Manufacturing Date.
        /// </summary>
        public DateTime MfgDate { get; set; }

        /// <summary>
        /// Corrsponding Sample Expiary Date.
        /// </summary>
        public DateTime ExpDate { get; set; }

        /// <summary>
        /// Test Specification Pass Limits.
        /// </summary>
        public string SpecificationLimits { get; set; } = string.Empty;

        /// <summary>
        /// Corrsponding Test Result Like Pass or Fail.
        /// </summary>
        public string Result { get; set; } = string.Empty;

        /// <summary>
        /// Corrsponding Sample Sample Type.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Value.")]
        public string SampleType { get; set; } = string.Empty;
    }
}
