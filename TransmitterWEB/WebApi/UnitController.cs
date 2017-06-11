﻿using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bussines;

namespace TransmitterWEB.WebApi
{
    public class UnitController : BaseGenerikApiController<Unit>
    {
        public UnitController(IUnitService service) : base(service)
        {
            _service = service;
        }
    }
}