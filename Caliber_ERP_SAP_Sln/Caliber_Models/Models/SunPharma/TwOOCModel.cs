using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliber_Models.Models.SunPharma
{
    public enum OosOotOocType
    {
        OOS,
        OOT,
        OOC
    }
    public class TwOOCModel
    {
        /// <summary>
        /// Unique identifier for the investigation.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Value.")]
        public string InvestigationNumber { get; set; }

        /// <summary>
        /// Code for identifying the plant where the issue was discovered.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Value.")]
        public string PlantCode { get; set; }

        /// <summary>
        /// Date when Investigation L-1 Submitted.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Value.")]
        public DateTime DateOfDiscovery { get; set; }

        /// <summary>
        /// Classification of the Investigation Type (OOS, OOT, OOC).
        /// </summary>
        public OosOotOocType OosOotOoc { get; set; }

        /// <summary>
        /// Corrsponding Instrument Caliberation Date.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Value.")]
        public DateTime DateOfOccurance { get; set; }

        /// <summary>
        /// LIMS AR number associated with the investigation.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Value.")]
        public string LIMSARNo { get; set; }

        /// <summary>
        /// Corrsponding Sample Batch Number.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Value.")]
        public string BatchNum { get; set; }

        /// <summary>
        /// Code identifying the test performed.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Value.")]
        public string TestCode { get; set; }
        /// <summary>
        /// Instrument Category
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Value.")]
        public string InsType { get; set; }

        /// <summary>
        /// Instrument Description
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Value.")]
        public string InsDesc { get; set; }

        /// <summary>
        /// Instrumnet Name
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Provide Value.")]
        public string InsName { get; set; }

        /// <summary>
        /// Instrument Unique Code.
        /// </summary>
        public string InsCode { get; set; }

        /// <summary>
        /// Identity Number
        /// </summary>
        public string IdentityNUmber { get; set; }
    }
}
