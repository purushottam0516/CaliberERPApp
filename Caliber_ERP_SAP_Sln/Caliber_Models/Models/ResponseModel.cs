using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliber_Models.Models
{
    public class ResponseModel
    {
        //Gets or sets the return status.

        public int ReturnStatus { get; set; }

        //Gets or sets the key field.

        public string KeyField { get; set; } = string.Empty;
    }
}
