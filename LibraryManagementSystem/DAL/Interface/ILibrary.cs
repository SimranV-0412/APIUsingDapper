using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace LibraryManagementSystem.DAL.Interface
{
    public interface ILibrary
    {
        public Task<int> AddCategory(Category addcategory);
        public Task<int> AddAuthor(Author addauthor);

        public Task<int> AddPublisher(Publisher addpublisher);
        public Task<int> AddMember(Member addmember);
        public Task<int> AddBook(book addbook);
        public Task<int> Addissuebook(issuebook addissuebook);
        public Task<int> DelMember(int Id);
        public Task<book> GetBookDetail(int bookId);
        public Task<issuebook> GetissueBookDetail(int Id);

    }
}
