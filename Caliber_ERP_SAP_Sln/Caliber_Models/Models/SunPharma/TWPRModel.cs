using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliber_Models.Models.SunPharma
{
    public class TWPRModel
    {
        public int TW_PR_ID { get; set; }
        public string TW_PR_STATUS { get; set; } = "";
        public string LIMSInvestigationNo { get; set; } = "";
        public string TestName { get; set; } = "";
        public string LIMSARNO { get; set; } = "";
        public string BatchNumber { get; set; } = "";
    }
    public class TWPRIdListRequest : IValidatableObject
    {
        [Required(ErrorMessage = "TWPRIds is required.")]
        public List<int> PRIds { get; set; }

        [Required(ErrorMessage = "PlantCode is required.")]
        public string PlantCode { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (PRIds != null && PRIds.Any(id => id <= 0))
            {
                yield return new ValidationResult("PRIds must contain only positive integers.", new[] { nameof(PRIds) });
            }
        }
    }
}
