using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace THUONGPROJECT.Web.Views
{
    public abstract class THUONGPROJECTRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected THUONGPROJECTRazorPage()
        {
            LocalizationSourceName = THUONGPROJECTConsts.LocalizationSourceName;
        }
    }
}
