namespace BookApi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; init; } = default!;
        public string Author { get; init; } = default!;
        public string Genre { get; init; } = default!;
        public DateTime PublishedDate { get; init; } = default!;
        public decimal Price { get; init; } = default!;
    }
}
