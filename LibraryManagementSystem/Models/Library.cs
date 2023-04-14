using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Category
    {
        public string? catName { get; set; }
        public string? catstatus { get; set; }

    }
    public class CategoryAll
    {
        public int categoryId { get; set; }
        public string? catName { get; set; }
        public string? catstatus { get; set; }

    }
    public class Author
    {
        public string? authorName { get; set; }
        public string? address { get; set; }
        public string? phone { get; set; }
    }
    public class AuthorAll
    {
        public int authorId { get; set; }
        public string? authorName { get; set; }
        public string? address { get; set; }
        public string? phone { get; set; }
    }
    public class AddPublisher
    {
        public string? publisherName { get; set; }
        public string? address { get; set; }
        public string? phone { get; set; }
    }
    public class AllPublisher
    {
        public int id { get; set; }
        public string? publisherName { get; set; }
        public string? address { get; set; }
        public string? phone { get; set; }
    }
    public class Member
    {
        public string? memberName { get; set; }
        public string? address { get; set; }
        public string? phone { get; set; }
    }
    public class AllMember
    {
        public int Id { get; set; }
        public string? memberName { get; set; }
        public string? address { get; set; }
        public string? phone { get; set; }
    }
    public class book
    {
        public string? bookName { get; set; }
        public string? edition { get; set; }
        public int? categoryId { get; set; }
        public int? authorId { get; set; }
        public int? publisherId { get; set; }


    }
    public class bookAll
    {
        public int bookId { get; set; }
        public string? bookName { get; set; }
        public string? edition { get; set; }
        public int? categoryId { get; set; }
        public int? authorId { get; set; }
        public int? publisherId { get; set; }


    }

    public class issuebook
    {
        public int Id { get; set; }
        public int? memberId { get; set; }
        public int? bookId { get; set; }
        public DateTime? Idate { get; set; }
        public DateTime? Rdate { get; set; }

    }
    public class loginAdmin
    {
        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string? email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? adminPassword { get; set; }
    }

    public class TokenModel
    {
        public string? token { get; set; }
        public DateTime? expires { get; set; }
        public string email { get; set; }
    }

}
