using System.Buffers;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Contracts;

namespace StoreApp.Pages
{
    
    public class CartModel : PageModel
    {
            private readonly IServiceManager _manager;

          
            public CartModel(IServiceManager manager, Cart cart )
            {

                _manager = manager;
                Cart = cart;

            }



            public Cart Cart {get; set;} //IoC
            public string ReturnUrl {get; set;} = "/";

            public void OnGet(string returnUrl)
            {


                ReturnUrl = returnUrl ?? "/";


            }

            public IActionResult OnPost(int productId, string returnUrl)
            {


                Product? product = _manager.ProductService.GetOneProduct(productId, false);
            
                if (product is not null)
                {

                    Cart.AddItem(product,1);
                    
                }

                return Page();//returnUrl
            }
        
        public IActionResult OnPostRemove(int id, string returnUrl)
        {


            Cart.RemoveLine(Cart.Lines.First(c1 => c1.Product.ProductId.Equals(id)).Product);

            return Page();



        }
    }


}