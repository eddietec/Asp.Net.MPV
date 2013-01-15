using Common.MVP.Presenters;
using Common.MVP.Views;
using Common.MVP.Web;

namespace Demo.MVP.UI
{
    public partial class _default : PageBase<DefaultPresenter, IDefault>, IDefault
    {
        public string Message
        {
            get; set;
        }
    }
}