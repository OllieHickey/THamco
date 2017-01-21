using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThreeAmigos.Store.Models;
using System.Data.Entity;

namespace ThreeAmigos.Store.DAL
{
    public class StoreInitializer : DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var products = new List<ProductViewModel>
            {
                new ProductViewModel { Name = "Chocolate", Description = "Fresh Belguim Chocolate", Price = 4.99M, Active= true},
                new ProductViewModel { Name = "Deodrant", Description = "Fresh Scent Deodrant", Price = 1.99M, Active= true },
                new ProductViewModel { Name = "Soap", Description = "Feel clean with this Fresh Soap", Price = 1.50M, Active= true},
                new ProductViewModel { Name = "Showergel", Description = "Feel clean with this Fresh Showergel", Price = 3.99M, Active= true},
                new ProductViewModel { Name = "Fudge", Description = "Fresh Fudge from Yorkshire Country Side ", Price = 2.99M, Active= true},
                new ProductViewModel { Name = "Cheese", Description = "Fresh Cheese from South of France", Price = 3.99M, Active= true},
                new ProductViewModel { Name = "Crackers", Description = "Crunchy Crackers from England", Price = 0.99M, Active= true},
                new ProductViewModel { Name = "Perfume", Description = "Fresh Scent Perfume", Price = 5.99M, Active= true},
                new ProductViewModel { Name = "Shaving Utensils", Description = "Have a clean shave with our Utensils", Price = 15.99M, Active= true},
                new ProductViewModel { Name = "Honey", Description = "Fresh English Honey", Price = 1.99M, Active= true},
                new ProductViewModel { Name = "Hand Cream", Description = "Keep your hands moisturised", Price = 1.99M, Active= true},
                new ProductViewModel { Name = "Shampoo", Description = "Keep your hair clean with this Shampoo", Price = 1.99M, Active= true},
                new ProductViewModel { Name = "Candy", Description = "Sweet Candy varities, old school favourites", Price = 2.99M, Active= true},
                new ProductViewModel { Name = "Bath Bombs", Description = "Bathe in heaven with these bath bombs ", Price = 1.99M, Active= true},
                new ProductViewModel { Name = "Facial Scrub", Description = "Feel clean with this Facial Scrub", Price = 1.99M, Active= true},
                new ProductViewModel { Name = "Candle", Description = "Light up your life with this raspberry scented candle", Price = 5.99M, Active= true},
                new ProductViewModel { Name = "Make Up", Description = "This makeup is Whimsical, Adventurous, Colourful, Loud and Fun", Price = 3.99M, Active= true},
                new ProductViewModel { Name = "Champagne", Description = "Complete the Party by popping the cork on this Champagne(Must be Over 18)", Price = 15.99M, Active= true},
                new ProductViewModel { Name = "Wine", Description = "Silence the room, when you bring out this bottle(Must Be Over 18)", Price = 6.99M, Active= true},
                new ProductViewModel { Name = "Wine Glass", Description = "Silence the room, when you bring out this bottle(Must Be Over 18)", Price = 1.50M, Active= true},
                new ProductViewModel { Name = "Whiskey", Description = "Add an Edge to the Party(Must Be Over 18)", Price = 8.99M, Active= true},
                new ProductViewModel { Name = "Whiskey glass", Description = "Every Whiskey needs a glass to be poured into", Price = 1.50M, Active= true},
                new ProductViewModel { Name = "Beer", Description = "Have a nice bottle of Beer on us!", Price = 4.99M, Active= true},
                new ProductViewModel { Name = "Stein", Description = "Every Beer needs a glass", Price = 1.50M, Active= true},
                new ProductViewModel { Name = "Jerky", Description = "A perfect partner to Beer", Price = 3.99M, Active= true}
            };

            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();


           

            var selections = new List<SelectionBoxModel>
            {
                new SelectionBoxModel { Name = "Food Compliation Box", Description = "This Box contains Chocolate, Cheese, Crackers, Honey, Jerky and Fudge", Price = 20.89M, Active= true},
                new SelectionBoxModel { Name = "Shower Gift Box", Description = "This Box contains Soap, Showergel, Deodrant and Shampoo", Price = 10.42M, Active= true},
                new SelectionBoxModel { Name = "Boy's Gift Box", Description = "This Box contains Chocolate, Soap, Candy, Fudge, Showergel", Price = 18.11M, Active= true},
                new SelectionBoxModel { Name = "Girl's Gift Box", Description = "This Box contains Chocolate, Candy, Fudge, Bathbomb, Shampoo", Price = 16.45M, Active= true},
                new SelectionBoxModel { Name = "Women's Gift Box", Description = "This Box contains Shampoo, Make-up, Perfume, Bath bomb, Wine", Price = 23.05M, Active= true},
                new SelectionBoxModel { Name = "Men's Gift Box", Description = "This Box Contains Whiskey, Jerky, Beer, Stein and Whiskey Glass ", Price = 23.07M, Active= true},
                new SelectionBoxModel { Name = "Cheese and Wine Gift Box", Description = "This Box contains Cheese, Crackers and Wine", Price = 13.17M, Active= true},
                new SelectionBoxModel { Name = "Beer and Stein Gift Bx", Description = "This Box contains Beer and Stein", Price = 8.22M, Active= true},
                new SelectionBoxModel { Name = "Wine and Wine Glass Gift Box", Description = "This Box contains a Bottle of Wine and Wine Glass", Price = 9.34M, Active= true},
                new SelectionBoxModel { Name = "Chocolote Selection Box", Description = "This Box contains two different Variety boxes of Chocolate", Price = 10.98M, Active= true},
                new SelectionBoxModel { Name = "Shaving Kit Box", Description = "This contains Razor, Blades, Shaving Cream, Aftershave and Shaving Balm", Price = 17.59M, Active= true},
                new SelectionBoxModel { Name = "Honey Compilation Box", Description = "This Box contains four different Pots of Honey", Price = 8.76M, Active= true},
                new SelectionBoxModel { Name = "Beauty Gift Box", Description = "This Box contains Make-Up, Facial Scrub, Hand Cream, Perfume", Price = 15.36M, Active= true},
                new SelectionBoxModel { Name = "Perfume and Make Up", Description = "This Box contains Perfume and Make-up", Price = 10.98M, Active= true},
                new SelectionBoxModel { Name = "Beer and Jerky Gift Box", Description = "This Box contains Two bottles of Beer and Jerky", Price = 15.37M, Active= true},
                new SelectionBoxModel { Name = "Bath Relaxation Gift Box", Description = "This Box contains Wine, Two Candles and Bath Bombs ", Price = 23.06M, Active= true}
               
             };


            selections.ForEach(s => context.SelectionBoxes.Add(s));
            context.SaveChanges();

            var wrappings = new List<GiftWrapModel>
            {
                new GiftWrapModel { Name = "Luxious Gift Wrap", Price = 2.99M, Active= true},
                new GiftWrapModel { Name = "Food Wrapping", Price = 1.99M, Active= true},
                new GiftWrapModel { Name = "Beauty Wrapping", Price = 1.50M, Active= true},
                new GiftWrapModel { Name = "Boy's Wrapping", Price = 1.50M, Active= true},
                new GiftWrapModel { Name = "Girl's Wrapping", Price = 1.50M, Active= true},
                new GiftWrapModel { Name = "Women's Wrapping", Price = 2.00M, Active= true},
                new GiftWrapModel { Name = "Men's Wrapping", Price = 2.00M, Active= true},
                new GiftWrapModel { Name = "Alcohol and Glass ware Wrapping", Price = 2.99M, Active= true},
                new GiftWrapModel { Name = "Shaving Utensils Wrapping", Price = 2.99M, Active= true},
                new GiftWrapModel { Name = "Champagne Wrapping", Price = 2.99M, Active= true}
                


            };

            wrappings.ForEach(s => context.GiftWrap.Add(s));
            context.SaveChanges();


        }
    }
}