using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StoreApp.Pages
{
    public class DemoModel : PageModel
    {
    
        public String? FullName => HttpContext?.Session?.GetString("name") ?? "NoName";

       

        public void OnGet()
        {
            
        }

       public void OnPost([FromForm]string name)
       {



            //FullName = name;
            HttpContext.Session.SetString("name",name);


       }
    }
}