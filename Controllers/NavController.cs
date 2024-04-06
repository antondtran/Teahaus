using Microsoft.AspNetCore.Mvc;
using TeahausWebApp.Data;
using TeahausWebApp.Models;

public class NavController : Controller {

    ItemDbContext itemDbContext;

    public NavController(ItemDbContext itemDbContext){
        this.itemDbContext = itemDbContext;
    }

    public IActionResult Home() {
        return View();
    }

    public IActionResult Menu()
{
    var menuItems = itemDbContext.Items.ToList(); // Assuming _context is your DbContext
    return View(menuItems);
}


    public IActionResult About() {
        return View();
    }

    public IActionResult Contact() {
        return View();
    }

    public IActionResult Add() {
        return View();
    }


    [HttpPost]
    public IActionResult Add(Item item) {

        itemDbContext.Items.Add(item);
        itemDbContext.SaveChanges();

        return RedirectToAction("Add");
        
    }


    public IActionResult Delete(Item item){
        itemDbContext.Items.Remove(item);
        itemDbContext.SaveChanges();

        return RedirectToAction("Menu", "Nav");
    }

    public IActionResult Edit(Guid id){

        var item = itemDbContext.Items.Find(id);

        if (item == null)
    {
        return NotFound(); // Or handle the case where the item is not found
    }

    return View(item);


        
    }

    [HttpPost]
    public IActionResult Edit(Item item){
        itemDbContext.Items.Update(item);
        itemDbContext.SaveChanges();

        return RedirectToAction ("Menu", "Nav");
    }



}