using NUnit.Framework;
using SeleniumFramework.Pages.DemoQA;

namespace SeleniumTests.Pages
{
    //[Parallelizable(scope: ParallelScope.All)]
    internal class TextBoxTests : BaseTest 
    {
        [Test]
        public void TextBoxWithValidCredentials()
        {
            string expectedName = "Vardenis Pavardenis";
            string expectedEmail = "pavard@one.lt";
            string expectedCurrentAdress = "Kietaviškių";
            string expectedPermanentAdress = "Elektrėnai";

            TextBox.Open();
            TextBox.EnterFullName(expectedName);
            TextBox.EnterEmail(expectedEmail);
            TextBox.EnterCurrentAddress(expectedCurrentAdress);
            TextBox.EnterPermanentAddress(expectedPermanentAdress);
            TextBox.ClickButtonSubmit();

            Assert.That(TextBox.GetOutputFullName(), Is.EqualTo($"Name:{expectedName}"));
            Assert.That(TextBox.GetOutputEmail(), Is.EqualTo($"Email:{expectedEmail}"));
            Assert.That(TextBox.GetOutputCurrentAddress(), Is.EqualTo($"Current Address :{expectedCurrentAdress}"));
            Assert.That(TextBox.GetOutputPermanentAddress(), Is.EqualTo($"Permananet Address :{expectedPermanentAdress}"));
        }

        [Test]
        public void TextBoxWithInvalidEmail()
        {
            string email = "invalid";
            string expectedClassValue = "field-error";
            string expectedBorderColor = "rgb(255, 0, 0)";

            TextBox.Open();
            TextBox.EnterEmail(email);
            TextBox.ClickButtonSubmit();
            string actualBorderColor = TextBox.GetEmailInputBorderColor();
            string actualClassValue = TextBox.GetEmailInputClassValue();

            Assert.That(actualBorderColor, Is.EqualTo(expectedBorderColor));
            Assert.That(actualClassValue.Contains(expectedClassValue));
            Assert.That(TextBox.EmailOutputExists(), Is.False);
        }

    }
}
