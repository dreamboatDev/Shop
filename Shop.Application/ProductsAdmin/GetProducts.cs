using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Application.ProductsAdmin
{
    public class GetProducts
    {
        private ApplicationDbContext _context;

        public GetProducts(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductViewModel> Do() =>
            _context.Products.ToList().Select(x => new ProductViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Value = x.Value
            });

        //2 вариант записи метода Do()

        //public IEnumerable<ProductViewModel> Do()
        //{
        //    return _context.Products.ToList().Select(x => new ProductViewModel
        //    {
        //        Name = x.Name,
        //        Decription = x.Decription,
        //        Value = $"$ {x.Value.ToString("N2")}" //1100.50 => 1,100.50 => $ 1,100.50
        //    }) ;
        //}
        public class ProductViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Value { get; set; }
        }
    }
    
}
