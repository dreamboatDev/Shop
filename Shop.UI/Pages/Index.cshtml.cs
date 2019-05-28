﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.Products;
using Shop.Database;

namespace Shop.UI.Pages
{
    public class IndexModel : PageModel
    {
        private ApplicationDbContext _ctx;

        public IndexModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        [BindProperty]
        public ProductViewModel Product { get; set; }
        public class ProductViewModel
        {
            public string Name { get; set; }
            public string Decription { get; set; }
            public decimal Value { get; set; }
        }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            await new CreateProduct(_ctx).Do(Product.Name, Product.Decription, Product.Value);

            return RedirectToPage("Index");
        }
    }
}
