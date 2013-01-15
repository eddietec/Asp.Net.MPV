using Common.MVP.Presenters;
using Common.MVP.Views;
using NUnit.Framework;
using Rhino.Mocks;

namespace Common.MVP.Tests.Presenters
{
    [TestFixture]
    public class DefaultPresenterTest
    {
        private DefaultPresenter _presenter;
        private IDefault _view;

        [SetUp]
        public void SetUp()
        {
            _view = MockRepository.GenerateMock<IDefault>();
            _presenter = new DefaultPresenter();
            _presenter.SetView(_view);
        }

        [Test]
        public void ViewLoading_SetMessage_MessageSetOnView()
        {
            const string messageToSet = "Hello World!";
            _view.Expect(v => v.Message).PropertyBehavior();
            _presenter.ViewLoading();

            Assert.AreEqual(messageToSet, _view.Message);
        }

        [Test]
        public void ViewLoading_SetMessageAndDataBind_MessageIsDisplay()
        {
            _view.Expect(v => v.DataBind()).Repeat.Once();
            _presenter.ViewLoading();

            _view.VerifyAllExpectations();
        }
    }
}
