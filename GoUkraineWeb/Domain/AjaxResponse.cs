using System.Collections.Generic;

namespace Domain
{
    public class AjaxResponse<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public Dictionary<string, string[]> ValidationMessages { get; set; }
    }
}