namespace BookApp.Models
{
    public class Books
    {
        public int Id { get; set; }
        public required string book_title { get; set; } = string.Empty;
        public required string book_desc { get; set; } = string.Empty;
        public required string book_author { get; set; } = string.Empty;
    }
}
