using System.ComponentModel.DataAnnotations.Schema;


namespace GobangGame.Models
{
    public class Game
    {
        
        public string ID { get; set; }

        public string PlayerID { get; set; }
        public string PlayerName { get; set; }
    }
}