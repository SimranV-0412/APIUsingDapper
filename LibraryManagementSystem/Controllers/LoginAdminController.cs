using LibraryManagementSystem.DAL.Interface;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginAdminController : ControllerBase
    {
        public readonly ILibrary _library;
        public LoginAdminController(ILibrary library)
        {
            _library = library;
        }
        ///<summary>
        /// checking password
        /// </summary>
        /// <param name="loginAdmin"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("loginAdmin")]
        public async Task<IActionResult> LoginAdmin(loginAdmin loginAdmin)
        {
            TokenModel tokenModel = new TokenModel();
            //int result;
            try
            {
                tokenModel = await _library.LoginAdmin(loginAdmin);
            }
            catch (Exception ex)
            {
                //result = 0;
                return BadRequest(ex.Message);
            }
            return Ok(tokenModel);
        }
    }
}
