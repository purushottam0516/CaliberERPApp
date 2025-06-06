using Caliber_Components.DBComponents;
using Caliber_Components.GlobalVariables;
using Caliber_Models.Models.SunPharma;
using Caliber_Models.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Caliber_API.Controllers.SunPharma
{
    [Route("sLIMSTWApi")]
    [ApiController]
    public class sLIMSTTWController : ControllerBase
    {
        private readonly IDBAccess dbAccess;
        public sLIMSTTWController(IDBAccess _dbAccess)
        {
            dbAccess = _dbAccess;
        }
        [HttpPost("TWOOSOOTReq")]
        public async Task<IActionResult> NewTWOOSReq([FromBody] TwOOSOOTModel Data)
        {
            if (ModelState.IsValid)
            {
                var response = dbAccess.ExtWriteDataAsync(ConnectionStrings.GetConnectionString("TW"), System.Data.CommandType.StoredProcedure, "STP_LMS_TW_OOS_OOT_Req", Data, new ResponseModel());

                return await Task.Run(() => Ok(new { Message = "Successfull Completed.", KeyField = Data.InvestigationNumber }));
            }
            else
            {
                return await Task.Run(() => BadRequest(ModelState));
            }
        }

        [HttpPost("GetOOSPRDetails")]
        public async Task<IActionResult> GetOOSOOTStatus(string LIMSArno, string TestCode, string InevstigationNumber, string? Plantcode)
        {
            var response = await dbAccess.ExtReadData<TWPRModel>(ConnectionStrings.GetConnectionString("TW"),
                                                System.Data.CommandType.StoredProcedure, "STP_TW_READ_PR_DATA",
                                                new { InvestigationNum = InevstigationNumber, TestCode = TestCode, LIMSARNO = LIMSArno, Plantcode = Plantcode });
            return response != null ? Ok(response) : NotFound();
        }

        [HttpGet("ReadAllTWPR")]
        public async Task<IActionResult> GetAllTWPr(string? PlantCode)
        {
            var response = await dbAccess.ExtReadDataList<TWPRModel>(ConnectionStrings.GetConnectionString("TW"),
                                                System.Data.CommandType.StoredProcedure, "STP_TW_READ_TW_PR",
                                                new { Plantcode = PlantCode });
            return response != null ? Ok(response) : NotFound();
        }
    }
}
