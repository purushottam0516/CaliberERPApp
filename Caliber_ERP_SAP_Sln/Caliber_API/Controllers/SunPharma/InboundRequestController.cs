using System.Data;
using Caliber_Components.Autherization;
using Caliber_Components.DBComponents;
using Caliber_Models.Models;
using Caliber_Models.Models.SunPharma;
using Microsoft.AspNetCore.Mvc;
using Caliber_Components.GlobalVariables;

namespace Caliber_API.Controllers.SunPharma
{
    [Route("[controller]")]
    [ApiController]
    [ServiceFilter(typeof(AuthFilter))]
    public class InboundRequestController : ControllerBase
    {
        private readonly IDBAccess dbAccess;
        public InboundRequestController(IDBAccess _dbAccess)
        {
            dbAccess = _dbAccess;
        }

        [HttpPost("LotRequest")]
        [ServiceFilter(typeof(PreInsert))]
        public async Task<IActionResult> SAPTransferLot([FromBody] InboundModel requestModel)
        {
            if (ModelState.IsValid)
            {
                var response = await dbAccess.WriteDataAsync(CommandType.StoredProcedure, "STP_SAP_ADD_LOT", requestModel, new ResponseModel());


                if (response.OutputParams is ResponseModel InboundResponseModel && ((ResponseModel)response.OutputParams).ReturnStatus > 0)
                {
                    return new JsonResult(new { Message = "Transfered Successfully", InspectionLot = requestModel.MemoNumber }) { StatusCode = 202 };
                }
                else if (((ResponseModel)response.OutputParams).ReturnStatus == 0)
                {
                    return new JsonResult(new { Message = ((ResponseModel)response.OutputParams).KeyField ?? "Database Issue.", InspectionLot = requestModel.MemoNumber }) { StatusCode = 403 };
                }
                else
                {
                    return new JsonResult(new { Message = ((ResponseModel)response.OutputParams).KeyField ?? "Database Issue.", InspectionLot = requestModel.MemoNumber }) { StatusCode = 500 };
                }

            }
            else
            {
                return await Task.Run(() => BadRequest());
            }
        }

        [HttpPost("TransferProduct")]
        public async Task<IActionResult> AddNewPrd([FromBody] ProductModel product)
        {
            if (ModelState.IsValid)
            {
                var responce = await dbAccess.ExtWriteDataAsync(ConnectionStrings.GetConnectionString("MSTR"), CommandType.StoredProcedure, "STP_LMS_BAL_PRD_SAP_TRN", product, new ResponseModel());

                if (responce.OutputParams is ResponseModel InboundResponseModel && ((ResponseModel)responce.OutputParams).ReturnStatus > 0)
                {
                    return new JsonResult(new { Message = "Transfered Successfully", ProductCode = product.PrdUcode }) { StatusCode = 202 };
                }
                else
                {
                    return new JsonResult(new { Message = ((ResponseModel)responce.OutputParams).KeyField ?? "Database Issue. " + responce.ExceptionMsg, ProductCode = product.PrdUcode }) { StatusCode = 400 };

                }
            }
            else
            {
                return (BadRequest(new { ModelState }));
            }
        }


    }
}
