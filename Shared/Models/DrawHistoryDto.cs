namespace Shared.Models
{
    public record DrawHistoryDto
    {
        public Guid Id { get; set; }

        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int ThirdNumber { get; set; }
        public int FourthNumber { get; set; }
        public int FifthNumber { get; set; }

        public DateTime Created { get; set; }

    }
}