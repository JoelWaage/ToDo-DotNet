﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;


namespace ToDoList.Controllers
{
    public class ItemsController : Controller
    {
        private ToDoListContext db = new ToDoListContext();
        public IActionResult Index()
        {
            return View(db.Items.ToList());
        }
    }
}
