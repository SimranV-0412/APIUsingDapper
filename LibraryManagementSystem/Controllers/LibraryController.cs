using APIUsingDapper.Controllers;
using APIUsingDapper.Models;
using LibraryManagementSystem.DAL.Interface;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace LibraryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        public readonly ILibrary _library;
        public LibraryController(ILibrary library)
        {

            _library = library;
        }
        /// <summary>
        /// Adding category
        /// </summary>
        /// <param name="addcategory"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddCategory")]
        public async Task<IActionResult> AddCategory(Category addcategory)
        {
            int result = 0;
            try
            {
                result = await _library.AddCategory(addcategory);
                if (result == 1)
                {
                    return Ok("Values are inserted");
                }
                else
                {
                    return BadRequest("Something went wrong");
                }
            }
            catch (Exception ex)
            {
                result = 0;
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Adding author
        /// </summary>
        /// <param name="addauthor"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddAuthor")]
        public async Task<IActionResult> AddAuthor(Author addauthor)
        {
            int result = 0;
            try
            {
                result = await _library.AddAuthor(addauthor);
                if (result == 1)
                {
                    return Ok("Values are inserted");
                }
                else
                {
                    return BadRequest("Something went wrong");
                }
            }
            catch (Exception ex)
            {
                result = 0;
                return BadRequest(ex.Message);
            }

            
        }
        /// <summary>
        /// Adding publisher
        /// </summary>
        /// <param name="addpublisher"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddPublisher")]

        public async Task<IActionResult> AddPublisher(Publisher addpublisher)
        {
            int result = 0;
            try
            {
                result = await _library.AddPublisher(addpublisher);
                if (result == 1)
                {
                    return Ok("Values are inserted");
                }
                else
                {
                    return BadRequest("Something went wrong");
                }
            }
            catch (Exception ex)
            {
                result = 0;
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Adding member
        /// </summary>
        /// <param name="addmember"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddMember")]

        public async Task<IActionResult> AddMember(Member addmember)
        {
            int result = 0;
            try
            {
                result = await _library.AddMember(addmember);
                if (result == 1)
                {
                    return Ok("Values are inserted");
                }
                else
                {
                    return BadRequest("Something went wrong");
                }
            }
            catch (Exception ex)
            {
                result = 0;
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Adding book
        /// </summary>
        /// <param name="addbook"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddBook")]

        public async Task<IActionResult> AddBook(book addbook)
        {
            int result = 0;
            try
            {
                result = await _library.AddBook(addbook);
                if (result == 1)
                {
                    return Ok("Values are inserted");
                }
                else
                {
                    return BadRequest("Something went wrong");
                }
            }
            catch (Exception ex)
            {
                result = 0;
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Adding issuebook data
        /// </summary>
        /// <param name="addissuebook"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Addissuebook")]

        public async Task<IActionResult> Addissuebook(issuebook addissuebook)
        {
            int result = 0;
            try
            {
                result = await _library.Addissuebook(addissuebook);
                if (result == 1)
                {
                    return Ok("Values are inserted");
                }
                else
                {
                    return BadRequest("Something went wrong");
                }
            }
            catch (Exception ex)
            {
                result = 0;
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Delete member data
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteMember")]
        public async Task<IActionResult> DelMember(int Id)
        {
            int result = 0;
            try
            {
                result = await _library.DelMember(Id);
                if (result == 1)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(result);
                }
            }
            catch (Exception ex)
            {
                result = 0;
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Get book detail
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetBookDetail")]

        public async Task<IActionResult> GetBookDetail(int bookId)
        {
            book objbook= new book();
            try
            {
                objbook = await _library.GetBookDetail(bookId);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(objbook);
        }
        /// <summary>
        /// Get Issue Book Detail
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetissueBookDetail")]

        public async Task<IActionResult> GetissueBookDetail(int Id)
        {
            issuebook objissuebook = new issuebook();
            try
            {
                objissuebook = await _library.GetissueBookDetail(Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(objissuebook);
        }

    }
}
