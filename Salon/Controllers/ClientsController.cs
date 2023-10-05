using Microsoft.AspNetCore.Mvc;
using Salon.Models; 
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Salon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly SalonContext _db;
    public ClientsController(SalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.PageTitle = "All Clients";
      List<Client> model = _db.Clients.ToList();
      return View(model);
    }
  }
}