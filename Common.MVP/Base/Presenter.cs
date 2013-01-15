namespace Common.MVP.Base
{
    public class Presenter<TView> where TView: IView
    {
        public TView View { get; private set; }

        public virtual void SetView(IView view)
        {
            View = (TView) view;
        }

        public virtual void ViewInitializing(){}
        public virtual void ViewInitialized() { }
        public virtual void ViewLoading() { }
        public virtual void ViewLoaded() { }
        public virtual void ViewPreRendering() { }
        public virtual void ViewPreRendered() { }
    }
}
