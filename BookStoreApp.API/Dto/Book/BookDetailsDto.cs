namespace BookStoreApp.API.Dto.Book
{
    public class BookDetailsDto : BaseDto
    {
        public string? Tilte { get; set; }

        public int? Year { get; set; }

        public string Isbn { get; set; } = null!;

        public string? Summary { get; set; }

        public string? Image { get; set; }

        public decimal? Price { get; set; }

        public int AuthorId { get; set; }

        public int AuthorName { get; set; }
    }
}
