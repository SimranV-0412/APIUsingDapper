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
                    var procedure = "AddMember";
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
                        issuedate = addissuebook.issuedate,
                        returndate = addissuebook.returndate,
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


        public Task<int> AddPublisher(Publisher addpublisher)
        {
            throw new NotImplementedException();
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
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<issuebook> GetissueBookDetail(int Id)
        {

            issuebook objissuebook = new issuebook();
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    var procedure = "GetBookIssue";
                    var values = new
                    {
                        Id = Id
                    };
                    objissuebook = connection.QueryFirst<issuebook>(procedure, values, commandType: CommandType.StoredProcedure);
                }
                return objissuebook;
            }
            catch (Exception ex)
            {
                return objissuebook;
            }
        }
    }
}
