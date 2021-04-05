using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CrossPlatform_UITest1
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

       // [Test]
        public void CreditCardNumber_TooLong_DisplayErrorMessage()
        {
            app.Repl();
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            AppResult[] results = app.WaitForElement(c => c.Marked("Continue"));
            app.Tap(c => c.Marked("Continue"));

           

           app.WaitForElement(c => c.Marked("CheckBox"));
           app.Tap(c => c.Marked("CheckBox"));

            app.WaitForElement(c => c.Marked("Continue"));
            app.Tap(c => c.Marked("Continue"));

            app.WaitForElement(c => c.Marked("Sign Up for UPS ID"));
            app.Tap(c => c.Marked("Sign Up for UPS ID"));


             Assert.IsTrue(results.Any());
        }
    }
}
