using Domain;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Linq;

namespace Web.Helpers
{
    public static class AjaxResponseHelper
    {
        public static AjaxResponse<T> AjaxGetWrapper<T>(Func<T> method)
        {
            return RequestWrapper((AjaxResponse<T> r) =>
            {
                r.Data = method();
                return r;
            });
        }
        public static AjaxResponse<string> AjaxPostWrapper(Action method, ModelStateDictionary modelState)
        {
            var responce = new AjaxResponse<string>();
            if (modelState.IsValid)
            {
                responce = RequestWrapper((AjaxResponse<string> r) =>
                {
                    method();
                    r.Data = Constants.Messages.Success.SUCCESS_REQUEST;
                    return r;
                });
            }
            else
            {
                responce.ErrorMessage = Constants.Messages.Error.FAILED_VALIDATION_ERROR_MESSAGE;
                responce.ValidationMessages = modelState.Where(x => x.Value.Errors.Count > 0)
                .ToDictionary(
                    kvp => kvp.Key,
                    kvp => kvp.Value.Errors.Select(e => e.ErrorMessage).ToArray()
                );
            }
            return responce;
        }
        public static AjaxResponse<string> AjaxDeleteWrapper(Action method)
        {
            return RequestWrapper((AjaxResponse<string> r) =>
            {
                method();
                r.Data = Constants.Messages.Success.SUCCESS_REQUEST;
                return r;
            });
        }
        private static AjaxResponse<T> RequestWrapper<T>(Func<AjaxResponse<T>, AjaxResponse<T>> func)
        {
            var responce = new AjaxResponse<T>();
            try
            {
                func(responce);
                responce.Success = true;
            }
            catch (Exception e)
            {
                //Logger.LogError(e.Message);
                responce.ErrorMessage = Constants.Messages.Error.GENERAL_ERROR_MESSAGE;
            }
            return responce;
        }
    }
}