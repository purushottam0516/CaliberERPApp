using System;
using System.Collections.Generic;
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
}
