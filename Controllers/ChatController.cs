namespace DotNet._04.TP3.MVC.Controllers;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DotNet._04.TP3.MVC.Models;

public class ChatController : Controller
{
    private static List <ChatViewModel> meuteDeChats = ChatViewModel.GetMeuteDeChats();
    // GET: ChatController
    public ActionResult Index()
    {
        return View(meuteDeChats);
    }

    // GET: ChatController/Details/5
    public ActionResult Details(int id)
    {
        // var meuteDeChats = ChatViewModel.GetMeuteDeChats();

        return this.View(meuteDeChats.Where(chat => chat.Id == id).FirstOrDefault());
    }

    // GET: ChatController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: ChatController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(ChatViewModel chat)
    {
        try
        {/*
            meuteDeChats.Add(new ChatViewModel(chat.Id, chat.Nom, chat.Age, chat.Couleur));*/
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: ChatController/Edit/5
    public ActionResult Edit(int id)
    {
        return View((meuteDeChats.FirstOrDefault(chat => chat.Id == id)));
    }

    // POST: ChatController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, ChatViewModel chat)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: ChatController/Delete/5
    public ActionResult Delete(int id)
    {
        // var meuteDeChats = ChatViewModel.GetMeuteDeChats();
        return this.View(meuteDeChats.Where(chat => chat.Id == id).FirstOrDefault());
    }

    // POST: ChatController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            // var meuteDeChats = ChatViewModel.GetMeuteDeChats();
            meuteDeChats.Remove(meuteDeChats.FirstOrDefault(chat => chat.Id == id));
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}
