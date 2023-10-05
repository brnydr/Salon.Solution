using Microsoft.AspNetCore.Mvc;
using Salon.Models; 
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

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
      List<Client> model = _db.Clients
        .Include(client => client.Stylist)
        .ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      ViewBag.PageTitle = "Add a Client";
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      if (client.StylistId == 0)
      {
        return RedirectToAction("Create");
      }
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      ViewBag.PageTitle = "Client Details";
      Client thisClient = _db.Clients
        .Include(client => client.Stylist)
        .FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }

    public ActionResult Edit(int id)
    {
      ViewBag.PageTitle = "Edit Client";
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "Name");
      Client thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }

    [HttpPost]
     public ActionResult Edit(Client client)
     {
      if (client.StylistId == 0)
      {
        return RedirectToAction("Edit");
      }
      _db.Update(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
     }

     public ActionResult Delete(int id)
     {
        ViewBag.PageTitle = "Delete this Client?:";
        Client thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
        return View(thisClient);
     }

      [HttpPost, ActionName("Delete")]
      public ActionResult DeleteConfirmed(int id)
      {
        Client thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
        _db.Clients.Remove(thisClient);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
  }
}