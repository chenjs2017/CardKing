using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
namespace CardKing.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CardContext (serviceProvider.GetRequiredService<DbContextOptions <CardContext>>()))
            {
                if (context.Cards.Any() ){
                    return;
                }
                context.Cards.Add(new Card
                {
                    Title = "Mr. Zhang",
                    Content = "CEO Tel 12333",
                    Date = DateTime.Now,
                    FileName = "aa"
                });  
                context.SaveChanges();
            }
        }
    }
}
