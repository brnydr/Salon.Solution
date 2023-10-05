using Microsoft.AspNetCore.Mvc;
using Salon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace Salon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly SalonContext _db;
    public StylistsController(SalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.PageTitle = "All Stylists";
      List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.PageTitle = "Add a Stylist";
      return View();
    }
    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      
      Stylist thisStylist = _db.Stylists
        .Include(stylist => stylist.Clients)
        .FirstOrDefault(stylist => stylist.StylistId == id);
      return View(thisStylist);
    }

    public ActionResult Edit(int id)
    {
      ViewBag.PageTitle = "Edit Stylist";
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      return View(thisStylist);
    }

    [HttpPost]
     public ActionResult Edit(Stylist stylist)
     {
      _db.Update(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
     }

  }
}