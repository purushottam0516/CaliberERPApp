using Azure;
using Caliber_Components.Autherization;
using Caliber_Components.DBComponents;
using Caliber_Models.Models;
using Caliber_Models.Models.Wallace;
using Microsoft.AspNetCore.Mvc;
using System.Data;


namespace Caliber_API.Controllers.Wallace
{

    [Route("API[controller]")]
    [ApiController]
    [ServiceFilter(typeof(AuthFilter))]
    public class WInboundRequestController : ControllerBase
    {
        private readonly IDBAccess DBaccess;

        public WInboundRequestController(IDBAccess _DBaccess)
        {
            DBaccess = _DBaccess;
        }

        [HttpPost("WallaceLotReques")]
        [ServiceFilter(typeof(PreInsert))]

        public async Task<IActionResult> SAPLotDataTransfer([FromBody] WInboundReqModel RequestModel)
        {
            if(ModelState.IsValid)
            {
                int inspflag = 0;

                if (RequestModel.InspCharData.Where(C => C.InspectionLot == RequestModel.InspLotDat.InspectionLot).Count()>0)
                {
                    //DownLoad SAP_Basic Table Data
                    var response = await DBaccess.WriteDataAsync(CommandType.StoredProcedure, "STP_SAP_ADD_LOT", RequestModel.InspLotDat, new ResponseModel());

                    // download Inspection table data
                    foreach  (var itemdata in RequestModel.InspCharData)
                    {
                        var response1 = await DBaccess.WriteDataAsync(CommandType.StoredProcedure, "STP_LIMS_ADD_INSP_CHAR", itemdata, new ResponseModel());
                        if (((ResponseModel)response1.OutputParams).ReturnStatus == 1)
                        {
                            inspflag = 1;
                        }
                    }

                    foreach(var item in RequestModel.CataLogData)
                    {
                        var response2 = await DBaccess.WriteDataAsync(CommandType.StoredProcedure, "STP_LIMS_ADD_CAT_CODE", item,new ResponseModel());                       
                    }

                    if (inspflag == 1 )
                    {
                        return new JsonResult(new { Message = "Transfered Successfully"}) { StatusCode = 202 };
                    }

                    else
                    {
                       return new JsonResult(new { Message = ((ResponseModel)response.OutputParams).KeyField ?? "Database Issue."}) { StatusCode = 400 };
                    }

                }
                else
                {
                    return BadRequest(new {Message="Insp char missing.", InspectionLot = RequestModel.InspLotDat.InspectionLot });
                }
                
            }
            else
            {
                return await Task.Run(() => BadRequest());
            }
        }

    }
}
