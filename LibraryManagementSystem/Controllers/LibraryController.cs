using APIUsingDapper.Controllers;
using APIUsingDapper.Models;
using LibraryManagementSystem.DAL.Interface;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mysqlx;
using System.Security.Policy;

namespace LibraryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
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

        public async Task<IActionResult> AddPublisher(AddPublisher addpublisher)
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
        /// Delete Category 
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
		[HttpDelete]
		[Route("DeleteCategory")]
		public async Task<IActionResult> DelCategory(int categoryId)
		{
			int result = 0;
			try
			{
				result = await _library.DelCategory(categoryId);
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
        /// Delete Author
        /// </summary>
        /// <param name="authorId"></param>
        /// <returns></returns>
		[HttpDelete]
		[Route("DeleteAuthor")]
		public async Task<IActionResult> DelAuthor(int authorId)
		{
			int result = 0;
			try
			{
				result = await _library.DelCategory(authorId);
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
        /// Delete Publisher
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
		[HttpDelete]
		[Route("DeletePublisher")]
		public async Task<IActionResult> DelPublisher(int id)
		{
			int result = 0;
			try
			{
				result = await _library.DelPublisher(id);
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
        /// Delete Book
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
		[HttpDelete]
		[Route("DeleteBook")]
		public async Task<IActionResult> DelBook(int bookId)
		{
			int result = 0;
			try
			{
				result = await _library.DelBook(bookId);
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
        /// Delete issue book
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
		[HttpDelete]
		[Route("DeleteIssueBook")]
		public async Task<IActionResult> DelIssuebook(int Id)
		{
			int result = 0;
			try
			{
				result = await _library.DelIssuebook(Id);
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
        /// <returns></returns>
        [HttpGet]
        [Route("GetissueBookDetail")]
        public async Task<IActionResult> GetissueBookDetail()
        {
            IEnumerable<issuebook> obj = null;
            try
            {
                obj = await _library.GetissueBookDetail();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(obj);
        }

        /// <summary>
        /// Get All books detail
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("GetAllBookDetail")]

        public async Task<IActionResult> GetAllBookDetail()
        {
            IEnumerable<bookAll> obj = null;
            try
            {
                obj = await _library.GetAllBookDetail();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(obj);
        }
        /// <summary>
        /// Get All Category
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllCategory")]

        public async Task<IActionResult> GetAllCategoryDetail()
        {
            IEnumerable<CategoryAll> obj = null;
            try
            {
                obj = await _library.GetAllCategoryDetail();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(obj);
        }
        /// <summary>
        /// Get All Publisher
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllPublisher")]

        public async Task<IActionResult> GetAllPublisher()
        {
            IEnumerable<AllPublisher> obj = null;
            try
            {
                obj = await _library.GetAllPublisher();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(obj);
        }
        /// <summary>
        /// Get All Author
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllAuthor")]

        public async Task<IActionResult> GetAllAuthor()
        {
            IEnumerable<AuthorAll> obj = null;
            try
            {
                obj = await _library.GetAllAuthor();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(obj);
        }
        /// <summary>
        /// Get All Member
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllMemberDetail")]

        public async Task<IActionResult> GetAllMemberDetail()
        {
            IEnumerable<AllMember> obj = null;
            try
            {
                obj = await _library.GetAllMemberDetail();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(obj);
        }

        ///// <summary>
        ///// checking password
        ///// </summary>
        ///// <param name="loginAdmin"></param>
        ///// <returns></returns>
        //[HttpPost]
        //[Route("loginAdmin")]
        //public async Task<IActionResult> LoginAdmin(loginAdmin loginAdmin)
        //{
        //    int result;
        //    try
        //    {
        //        result = await _library.LoginAdmin(loginAdmin);
        //        if (result == 1)
        //        {
        //            return Ok("Values are inserted");
        //        }
        //        else
        //        {
        //            return BadRequest("Something went wrong");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result = 0;
        //        return BadRequest(ex.Message);
        //    }

        //}

        //public async Task<IActionResult> LoginAdmin(loginAdmin loginAdmin)
        //{
        //    TokenModel tokenModel = new TokenModel();
        //    //int result;
        //    try
        //    {
        //        tokenModel = await _library.LoginAdmin(loginAdmin);
        //    }
        //    catch (Exception ex)
        //    {
        //        //result = 0;
        //        return BadRequest(ex.Message);
        //    }
        //    return Ok(tokenModel);
        //}

    }
}
