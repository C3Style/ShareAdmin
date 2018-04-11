using Abp.Web.Mvc.Views;

namespace ShareAdmin.Web.Views
{
    public abstract class ShareAdminWebViewPageBase : ShareAdminWebViewPageBase<dynamic>
    {

    }

    public abstract class ShareAdminWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ShareAdminWebViewPageBase()
        {
            LocalizationSourceName = ShareAdminConsts.LocalizationSourceName;
        }
    }
}