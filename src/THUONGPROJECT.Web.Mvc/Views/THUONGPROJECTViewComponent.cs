using Abp.AspNetCore.Mvc.ViewComponents;

namespace THUONGPROJECT.Web.Views
{
    public abstract class THUONGPROJECTViewComponent : AbpViewComponent
    {
        protected THUONGPROJECTViewComponent()
        {
            LocalizationSourceName = THUONGPROJECTConsts.LocalizationSourceName;
        }
    }
}
