using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace LibraryManagementSystem.DAL.Interface
{
    public interface ILibrary
    {
        public Task<int> AddCategory(Category addcategory);
        public Task<int> AddAuthor(Author addauthor);

        public Task<int> AddPublisher(AddPublisher addpublisher);
        public Task<int> AddMember(Member addmember);
        public Task<int> AddBook(book addbook);
        public Task<int> Addissuebook(issuebook addissuebook);
        public Task<int> DelMember(int Id);
		public Task<int> DelCategory(int categoryId);
		public Task<int> DelAuthor(int authorId);
		public Task<int> DelPublisher(int id);
		public Task<int> DelBook(int bookId);
		public Task<int> DelIssuebook(int Id);
		public Task<book> GetBookDetail(int bookId);
        public Task<IEnumerable<issuebook>> GetissueBookDetail();
        public Task<IEnumerable<bookAll>> GetAllBookDetail();
        public Task<IEnumerable<CategoryAll>> GetAllCategoryDetail();
        public Task<IEnumerable<AllPublisher>> GetAllPublisher();
        public Task<IEnumerable<AuthorAll>> GetAllAuthor();

        public Task<IEnumerable<AllMember>> GetAllMemberDetail();
    }
}
