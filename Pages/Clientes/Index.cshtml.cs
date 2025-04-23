using appweb1.Data;
using appweb1.Models;
using appweb1.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {   
        private readonly AppDbContext _ctx;

        public IndexModel(AppDbContext ctx)
        {
            _ctx=ctx;
        }

        public List<Cliente> Clientes {get;set;}
        public void OnGet() //Se ejecuta al cargar la pagina   
        {
            Clientes = _ctx.Clientes.ToList();
        }
    }
}
