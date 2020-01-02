﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EL.Admin.Filters;

namespace EL.Admin.Controllers
{
    [AuthorizeFilter]
    [ExceptionFilter]
    public class BaseController : Controller
    {

    }
}