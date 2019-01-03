using Abp.Web.Mvc.Views;

namespace abp.test.Web.Views
{
    public abstract class testWebViewPageBase : testWebViewPageBase<dynamic>
    {

    }

    public abstract class testWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected testWebViewPageBase()
        {
            LocalizationSourceName = testConsts.LocalizationSourceName;
        }
    }
}