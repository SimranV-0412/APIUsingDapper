namespace LibraryManagementSystem.Models
{
    public class Category
    {
        public string? catName { get; set; }
        public string? catstatus { get; set; }

    }
    public class Author
    {
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
    public class Member
    {
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

    public class issuebook
    {
        public int? memberId { get; set; }
        public int? bookId { get; set; }
        public DateOnly? issuedate{ get; set; }
        public DateOnly? returndate { get; set; }

    }
}
