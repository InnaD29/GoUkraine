using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using Web.Helpers;

namespace Web.Controllers.Base
{
    public class BaseAjaxController : Controller
    {
        private readonly ILogger<BaseAjaxController> _logger;
        public BaseAjaxController(ILogger<BaseAjaxController> logger)
        {
            _logger = logger;
        }
        public JsonResult ExecGetAjax<T>(Func<T> method)
        {
            var responce = AjaxResponseHelper.AjaxGetWrapper(() => { return method(); });
            return Json(responce);
        }
        public JsonResult ExecPostAjax(Action method)
        {
            var responce = AjaxResponseHelper.AjaxPostWrapper(() => { method(); }, ModelState);
            return Json(responce);
        }
        public JsonResult ExecDeleteAjax(Action method)
        {
            var responce = AjaxResponseHelper.AjaxDeleteWrapper(() => { method(); });
            return Json(responce);
        }
    }
}