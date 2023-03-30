using Dapper;
using LibraryManagementSystem.DAL.Interface;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Security.Policy;

namespace LibraryManagementSystem.DAL
{
    public class LibraryRepo : ILibrary
    {
        private readonly string _connectionString;
        private readonly IConfiguration _config;


        public LibraryRepo(IConfiguration configuration)
        {
            _config = configuration;
            _connectionString = _config.GetConnectionString("ConString");
        }

        /// <summary>
        /// Adding category
        /// </summary>
        /// <param name="addcategory"></param>
        /// <returns></returns>
        public async Task<int> AddCategory(Category addcategory)
        {
            int result = 0;
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    var procedure = "AddCategory";
                    var values = new
                    {
                        catName = addcategory.catName,
                        catstatus = addcategory.catstatus,
                    };
                    result = connection.QueryFirst<int>(procedure, values, commandType: CommandType.StoredProcedure);
                }
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        /// <summary>
        /// Adding author
        /// </summary>
        /// <param name="addauthor"></param>
        /// <returns></returns>
        public async Task<int> AddAuthor(Author addauthor)
        {
            int result = 0;
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    var procedure = "AddAuthor";
                    var values = new
                    {
                        authorName = addauthor.authorName,
                        address = addauthor.address,
                        phone = addauthor.phone,
                    };
                    result = connection.QueryFirst<int>(procedure, values, commandType: CommandType.StoredProcedure);
                }
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        /// <summary>
        /// Adding publisher
        /// </summary>
        /// <param name="addpublisher"></param>
        /// <returns></returns>

        public async Task<int> AddPublisher(AddPublisher addpublisher)
        {
            int result = 0;
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    var procedure = "AddPublisher";
                    var values = new
                    {
                        publisherName = addpublisher.publisherName,
                        address = addpublisher.address,
                        phone = addpublisher.phone,
                    };
                    result = connection.QueryFirst<int>(procedure, values, commandType: CommandType.StoredProcedure);
                }
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        /// <summary>
        /// Adding member
        /// </summary>
        /// <param name="addmember"></param>
        /// <returns></returns>

        public async Task<int> AddMember(Member addmember)
        {
            int result = 0;
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    var procedure = "AddMember";
                    var values = new
                    {
                        memberName = addmember.memberName,
                        address = addmember.address,
                        phone = addmember.phone,
                    };
                    result = connection.QueryFirst<int>(procedure, values, commandType: CommandType.StoredProcedure);
                }
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
        /// <summary>
        /// Adding book
        /// </summary>
        /// <param name="addbook"></param>
        /// <returns></returns>
        public async Task<int> AddBook(book addbook)
        {
            int result = 0;
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    var procedure = "AddBook";
                    var values = new
                    {
                        bookName = addbook.bookName,
                        edition= addbook.edition,
                        categoryId = addbook.categoryId,
                        authorId = addbook.authorId,
                        publisherId = addbook.publisherId,
                    };
                    result = connection.QueryFirst<int>(procedure, values, commandType: CommandType.StoredProcedure);
                }
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        /// <summary>
        /// Adding issue book detail
        /// </summary>
        /// <param name="addissuebook"></param>
        /// <returns></returns>

        public async Task<int> Addissuebook(issuebook addissuebook)
        {
            int result = 0;
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    var procedure = "AddIssueBook";
                    var values = new
                    {
                        memberId = addissuebook.memberId,
                        bookId = addissuebook.bookId,
                        Rdate = addissuebook.Rdate,
                    };
                    result = connection.QueryFirst<int>(procedure, values, commandType: CommandType.StoredProcedure);
                }
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        
        /// <summary>
        /// Delete member
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>

        public async Task<int> DelMember(int Id)
        {
            int result = 0;
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    var procedure = "DeleteMember";
                    var values = new
                    {
                        Id = Id
                    };
                    result = connection.QueryFirst<int>(procedure, values, commandType: CommandType.StoredProcedure);
                }
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        /// <summary>
        /// Delete Author
        /// </summary>
        /// <param name="authorId"></param>
        /// <returns></returns>
		public async Task<int> DelAuthor(int authorId)
		{
			int result = 0;
			try
			{
				using (var connection = new MySqlConnection(_connectionString))
				{
					var procedure = "DeleteAuthor";
					var values = new
					{
						authorId = authorId
					};
					result = connection.QueryFirst<int>(procedure, values, commandType: CommandType.StoredProcedure);
				}
				return result;
			}
			catch (Exception ex)
			{
				return 0;
			}
		}
        /// <summary>
        /// Deleting publisher
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
		public async Task<int> DelPublisher(int id)
		{
			int result = 0;
			try
			{
				using (var connection = new MySqlConnection(_connectionString))
				{
					var procedure = "DeletePublisher";
					var values = new
					{
						id = id
					};
					result = connection.QueryFirst<int>(procedure, values, commandType: CommandType.StoredProcedure);
				}
				return result;
			}
			catch (Exception ex)
			{
				return 0;
			}
		}
		/// <summary>
		/// Delete Category
		/// </summary>
		/// <param name="categoryId"></param>
		/// <returns></returns>
		public async Task<int> DelCategory(int categoryId)
		{
			int result = 0;
			try
			{
				using (var connection = new MySqlConnection(_connectionString))
				{
					var procedure = "DeleteCategory";
					var values = new
					{
						categoryId = categoryId
					};
					result = connection.QueryFirst<int>(procedure, values, commandType: CommandType.StoredProcedure);
				}
				return result;
			}
			catch (Exception ex)
			{
				return 0;
			}
		}
        /// <summary>
        /// Delete Book
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
		public async Task<int> DelBook(int bookId)
		{
			int result = 0;
			try
			{
				using (var connection = new MySqlConnection(_connectionString))
				{
					var procedure = "DeleteBook";
					var values = new
					{
						bookId = bookId
					};
					result = connection.QueryFirst<int>(procedure, values, commandType: CommandType.StoredProcedure);
				}
				return result;
			}
			catch (Exception ex)
			{
				return 0;
			}
		}
        /// <summary>
        /// Delete issue book
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
		public async Task<int> DelIssuebook(int Id)
		{
			int result = 0;
			try
			{
				using (var connection = new MySqlConnection(_connectionString))
				{
					var procedure = "DeleteIssuebook";
					var values = new
					{
						Id = Id
					};
					result = connection.QueryFirst<int>(procedure, values, commandType: CommandType.StoredProcedure);
				}
				return result;
			}
			catch (Exception ex)
			{
				return 0;
			}
		}
		/// <summary>
		/// Get Book Detail
		/// </summary>
		/// <param name="bookId"></param>
		/// <returns></returns>
		public async Task<book> GetBookDetail(int bookId)
        {
            
            book objbook = new book();
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    var procedure = "GetBook";
                    var values = new
                    {
                        bookId = bookId
                    };
                    objbook = connection.QueryFirst<book>(procedure, values, commandType: CommandType.StoredProcedure);
                }
                return objbook;
            }
            catch (Exception ex)
            {
                return objbook;
            }
        }
        /// <summary>
        /// Get Issue Book Detail
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<issuebook>> GetissueBookDetail()
        {
            IEnumerable<issuebook> obj = null;
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    var procedure = "GetBookIssue";
                    obj = await connection.QueryAsync<issuebook>(procedure, null, commandType: CommandType.StoredProcedure);
                }
                return obj.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        /// <summary>
        /// Get All Books detail
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<bookAll>> GetAllBookDetail()
        {
            IEnumerable<bookAll> obj = null;
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    var procedure = "GetAllBook";
                    obj = await connection.QueryAsync<bookAll>(procedure, null, commandType: CommandType.StoredProcedure);
                }
                return obj.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        /// <summary>
        /// Get All Publisher
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<AllPublisher>> GetAllPublisher()
        {
            IEnumerable<AllPublisher> obj = null;
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    var procedure = "GetAllPublisher";
                    obj = await connection.QueryAsync<AllPublisher>(procedure, null, commandType: CommandType.StoredProcedure);
                }
                return obj.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        /// <summary>
        /// Get All Category 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<CategoryAll>> GetAllCategoryDetail()
        {
            IEnumerable<CategoryAll> obj = null;
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    var procedure = "GetAllCategory";
                    obj = await connection.QueryAsync<CategoryAll>(procedure, null, commandType: CommandType.StoredProcedure);
                }
                return obj.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        /// <summary>
        /// Get All Author
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<AuthorAll>> GetAllAuthor()
        {
            IEnumerable<AuthorAll> obj = null;
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    var procedure = "GetAllAuthor";
                    obj = await connection.QueryAsync<AuthorAll>(procedure, null, commandType: CommandType.StoredProcedure);
                }
                return obj.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        /// <summary>
        /// Get All Member Detail
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<AllMember>> GetAllMemberDetail()
        {
            IEnumerable<AllMember> obj = null;
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    var procedure = "GetAllMember";
                    obj = await connection.QueryAsync<AllMember>(procedure, null, commandType: CommandType.StoredProcedure);
                }
                return obj.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
