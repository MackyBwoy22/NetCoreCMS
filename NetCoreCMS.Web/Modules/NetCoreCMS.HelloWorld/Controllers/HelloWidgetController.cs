﻿using Microsoft.AspNetCore.Mvc;
using NetCoreCMS.Framework.Core.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreCMS.HelloWorld.Controllers
{
    public class HelloWidgetController : NccController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
