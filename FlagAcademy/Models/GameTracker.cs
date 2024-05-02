namespace FlagAcademy.Models
{
    public class GameTracker
    {
        public int Id { get; set; }
        //will want to change score to an int at somepoint
        public string Score { get; set; }
        public int GameLength { get; set; }
        public int CurrentQuestion { get; set; }
    }
}
