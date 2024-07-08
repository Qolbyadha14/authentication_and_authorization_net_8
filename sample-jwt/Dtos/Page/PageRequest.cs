namespace sample_jwt.Dtos.Page
{
    public class PageRequest
    {
        public required string? Title { get; set; }
        public required string? Body { get; set; }
        public required string? Author { get; set; }
    }
}
