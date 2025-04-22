using Caliber_Components.Autherization;
using Caliber_Components.DBComponents;
using Caliber_Models.Models.BioPharma;
using Microsoft.AspNetCore.Mvc;
using System.Data;


namespace Caliber_API.Controllers.BioPharma
{
    [Route("[controller]")]
    [ApiController]
    [ServiceFilter(typeof(AuthFilter))]
    public class BioInboundRequestController : ControllerBase
    {
        private readonly IDBAccess dbAccess;
        public BioInboundRequestController(IDBAccess _dbAccess)
        {
            dbAccess = _dbAccess;
        }

        [HttpPost("LotRequest")]
        [ServiceFilter(typeof(PreInsert))]
        public async Task<IActionResult> SAPTransferLot([FromBody] BioInboundModel requestModel)
        {
            if (ModelState.IsValid)
            {
                var response = await dbAccess.WriteDataAsync(CommandType.StoredProcedure, "STP_SAP_ADD_LOT", requestModel, new BiopharmaInboundResponseModel());


                if (response.OutputParams is BiopharmaInboundResponseModel InboundResponseModel && ((BiopharmaInboundResponseModel)response.OutputParams).ReturnStatus > 0)
                {
                    return new JsonResult(new { Message = "Transfered Successfully", InspectionLot = requestModel.InspectionLot }) { StatusCode = 202 };
                }
                else if (((BiopharmaInboundResponseModel)response.OutputParams).ReturnStatus == 0)
                {
                    return new JsonResult(new { Message = ((BiopharmaInboundResponseModel)response.OutputParams).KeyField ?? "Database Issue.", InspectionLot = requestModel.InspectionLot }) { StatusCode = 403 };
                }
                else
                {
                    return new JsonResult(new { Message = ((BiopharmaInboundResponseModel)response.OutputParams).KeyField ?? "Database Issue.", InspectionLot = requestModel.InspectionLot }) { StatusCode = 500 };
                }

            }
            else
            {
                return await Task.Run(() => BadRequest());
            }
        }


    }
}
