namespace FlagAcademy.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FlagId { get; set; }
        public Flag Flag { get; set; }
        //fun fact, population, founding
    }
}
