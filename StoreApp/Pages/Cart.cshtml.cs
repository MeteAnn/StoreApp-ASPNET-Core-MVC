using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Contracts;

namespace StoreApp.Pages
{
    
    public class CartModel : PageModel
    {
            private readonly IServiceManager _manager;
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
        
    }


}