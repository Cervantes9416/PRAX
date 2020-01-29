using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRAXYS.Client.Helpers
{
    public static class IJSRuntimeHelper
    {

        #region Methods LocalStorage
        public static ValueTask<object> SetInLocalStorage(this IJSRuntime js, string key, string content)
            => js.InvokeAsync<object>("localStorage.setItem", key, content);

        public static ValueTask<string> GetFromLocalStorage(this IJSRuntime js, string key)
            => js.InvokeAsync<string>("localStorage.getItem",key);

        public static ValueTask<object> RemoveItem(this IJSRuntime js, string key)
            => js.InvokeAsync<object>("localStorage.removeItem", key);
        #endregion

        #region Methods Cookie
        public static ValueTask<object> SetInCookie(this IJSRuntime js, string name,string value,string remember)
            => js.InvokeAsync<object>("blazorExtensions.WriteCookie", name,value,remember);

        public static ValueTask<string> GetFromCookie(this IJSRuntime js)
            => js.InvokeAsync<string>("blazorExtensions.GetCookie");
        #endregion

        #region Methods SweetAlert2

        public static ValueTask<object> Message(this IJSRuntime js, string title, string message, string type)
            => js.InvokeAsync<object>("Swal.fire", title, message, type);

        public static ValueTask<bool> ConfirmMessage(this IJSRuntime js, string title, string message)
            => js.InvokeAsync<bool>("ConfirmMessage", title, message);

        #endregion

        #region Methods Input Mask

        #endregion

        #region Methods Menu
        public static ValueTask<object> InitMenu(this IJSRuntime js)
            => js.InvokeAsync<object>("initMenu");
        #endregion

        #region Form Methods

        public static ValueTask<object> RemoveAttribute(this IJSRuntime js, string attribute)
            => js.InvokeAsync<object>("RemoveAttribute", attribute);

        public static ValueTask<object> AddAttribute(this IJSRuntime js, string attribute)
            => js.InvokeAsync<object>("AddAttribute", attribute);

        #endregion

        #region Methods Select2
        
        public static ValueTask<object> Select2Init(this IJSRuntime js)
            => js.InvokeAsync<object>("Select2Init");

        #endregion

        #region Methods DataTable

        public static ValueTask<object> DataTableInit(this IJSRuntime js)
            => js.InvokeAsync<object>("datatableInit");

        #endregion

        public static ValueTask<object> Redirect(this IJSRuntime js, string url)
           => js.InvokeAsync<object>("Redirect", url);

        public static ValueTask<object> RedirectNewTab(this IJSRuntime js, string url)
          => js.InvokeAsync<object>("Redirect_NewTab", url);

        public static ValueTask<object> Reload(this IJSRuntime js)
          => js.InvokeAsync<object>("Reload");
    }
}
