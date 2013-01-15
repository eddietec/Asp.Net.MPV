using System;
using System.Web.UI;
using Common.MVP.Base;

namespace Common.MVP.Web
{
    public class PageBase<TPresenter, TView> : Page, IView
        where TView : IView
        where TPresenter : Presenter<TView>, new()
    {
        protected TPresenter Presenter { get; set; }

        protected override void OnInit(EventArgs e)
        {
            Presenter = new TPresenter();
            Presenter.SetView(this);
            Presenter.ViewInitializing();
            base.OnInit(e);
            Presenter.ViewInitialized();
        }

        protected override void OnLoad(EventArgs e)
        {
            Presenter.ViewLoading();
            base.OnLoad(e);
            Presenter.ViewLoaded();
        }

        protected override void OnPreRender(EventArgs e)
        {
            Presenter.ViewPreRendering();
            base.OnPreRender(e);
            Presenter.ViewPreRendered();
        }
    }
}
