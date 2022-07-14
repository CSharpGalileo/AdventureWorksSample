using AdventureWorksNS.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdventureWorksWeb.Pages
{
    public class clientesModel : PageModel
    {
        private AdventureWorksDB db;

        public IEnumerable<Customer> Customers { get; set; }

        public clientesModel(AdventureWorksDB injectedContext)
        {
            db = injectedContext;
        }
        public void OnGet()
        {
            ViewData["Title"] = "Clientes";
        }
    }
}
