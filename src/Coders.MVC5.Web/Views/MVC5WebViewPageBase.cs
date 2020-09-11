using Abp.Web.Mvc.Views;

namespace Coders.MVC5.Web.Views
{
    public abstract class MVC5WebViewPageBase : MVC5WebViewPageBase<dynamic>
    {

    }

    public abstract class MVC5WebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MVC5WebViewPageBase()
        {
            LocalizationSourceName = MVC5Consts.LocalizationSourceName;
        }
    }
}