namespace MedCard.Infrastructure.Models
{
    public class Persen
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronumic { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Anamnez { get; set; }
        public string WorkPlace { get; set; }
        public string Post { get; set; }
        public string Gender { get; set; }
    }
}
