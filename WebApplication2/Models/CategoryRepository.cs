using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class CategoryRepository
    {
        private static List<Category> categories = null;

        static CategoryRepository()
        {
            categories = new List<Category>()
            {
                new Category(){Id=1, Name="Müzeler", Cat="Museums"},
                new Category(){Id=2, Name="Tarihi Yerler", Cat="Historical"},
                new Category(){Id=3, Name="Dini Yapılar", Cat="Religious"},
                new Category(){Id=4, Name="Sosyal Tesisler",Cat="SF"},
                new Category(){Id=5, Name="Mesire Alanları", Cat="PA" },
                new Category(){Id=6, Name="Parklar", Cat="Park"}
            };
        }
        public static List<Category> Categories
        {
            get { return categories; }
        }
        public static void AddCategory(Category category)
        {
            categories.Add(category);
        }
    }
}
