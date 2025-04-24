using Caliber_Components.Autherization;
using Caliber_Components.DBComponents;
using Caliber_Models.Models;
using Caliber_Models.Models.Torrent;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Caliber_API.Controllers.Torrent
{
    [Route("Torrent/[controller]")]
    [ApiController]
    [ServiceFilter(typeof(AuthFilter))]
    public class InboundReqController : ControllerBase
    {
        private readonly IDBAccess dbAccess;
        public InboundReqController(IDBAccess _dbAccess)
        {
            dbAccess = _dbAccess;
        }

        [HttpPost("LotRequest")]
        [ServiceFilter(typeof(PreInsert))]
        public async Task<IActionResult> SAPTransferLot([FromBody] InboundReqModel requestModel)
        {
            if (ModelState.IsValid)
            {
                var response = await dbAccess.WriteDataAsync(CommandType.StoredProcedure, "STP_SAP_ADD_LOT", requestModel, new ResponseModel());


                if (response.OutputParams is ResponseModel InboundResponseModel && ((ResponseModel)response.OutputParams).ReturnStatus > 0)
                {
                    return new JsonResult(new { Message = "Transfered Successfully", InspectionLot = requestModel.InspectionLot }) { StatusCode = 202 };
                }
                else if (((ResponseModel)response.OutputParams).ReturnStatus == 0)
                {
                    return new JsonResult(new { Message = ((ResponseModel)response.OutputParams).KeyField ?? "Database Issue: "+response.ExceptionMsg, InspectionLot = requestModel.InspectionLot }) { StatusCode = 403 };
                }
                else
                {
                    return new JsonResult(new { Message = ((ResponseModel)response.OutputParams).KeyField ?? "Database Issue: " + response.ExceptionMsg, InspectionLot = requestModel.InspectionLot }) { StatusCode = 500 };
                }

            }
            else
            {
                return await Task.Run(() => BadRequest());
            }
        }
    }
}
