using HelloAngularjs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloAngularjs.Controllers.api
{
    public class PhoneController : ApiController
    {
        public object Get()
        {
            var model = new PhoneModel[] { new PhoneModel { Name = "三星", Code = "001" }, new PhoneModel { Name = "摩托罗拉", Code = "002" } };
            return model;
        }
    }
}
