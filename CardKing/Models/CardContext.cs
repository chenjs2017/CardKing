using System;
using Microsoft.EntityFrameworkCore;
namespace CardKing.Models
{
    public class CardContext:DbContext
    {
        public CardContext(DbContextOptions<CardContext> option) : base (option)
        {
        }
        public DbSet<Card> Cards { get; set; }
    }
}
