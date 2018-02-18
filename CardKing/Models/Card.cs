using System;
namespace CardKing.Models
{
    public class Card
    {
        public Card()
        {
        }

		public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string FileName { get; set; }
        public DateTime Date { get; set; }
    }
}
