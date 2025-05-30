using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliber_Models.Models.Wallace
{
    public class WInboundReqModel
    {
        public WInboundModel InspLotDat { get; set; }

        public List<InspCharModel> InspCharData { get; set; }

        public List<CataLogModel> CataLogData { get; set; }
    }
}
