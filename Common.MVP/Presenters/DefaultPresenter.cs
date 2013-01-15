using Common.MVP.Base;
using Common.MVP.Views;

namespace Common.MVP.Presenters
{
    public class DefaultPresenter: Presenter<IDefault>
    {

        public override void ViewLoading()
        {
            View.Message = "Hello World!";
            View.DataBind();
        }
    }
}
