

using OpenQA.Selenium;
using PageObjectModelTest.Driver;
using System.Transactions;

namespace PageObjectModelTest.Page
{
    public class Practiceform
    {
        private IWebDriver driver = Webdriver.Instance;

        public IWebElement FirstName => driver.FindElement(By.Id("firstName"));
        public IWebElement LastName => driver.FindElement(By.Id("lastName"));
        public IWebElement Email => driver.FindElement(By.Id("userEmail"));
        public IWebElement Gender => driver.FindElement(By.Id("gender-radio-1"));
        public IWebElement PhoneNumber => driver.FindElement(By.Id("userNumber"));
        public IWebElement Subject => driver.FindElement(By.Id("subjectsContainer"));
        public IWebElement Hobbis => driver.FindElement(By.Id("hobbies-checkbox-1"));
        public IWebElement Button => driver.FindElement(By.Id("submit"));

        public void EnterName(string name)
        {
            FirstName.SendKeys(name);
        }
        public void EnterLastName(string name)
        {
            LastName.SendKeys(name);
        }
        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
        }
        public void SelectGender(string gender)
        {
            Gender.Click();
        }
        public void EnterPhone(string number)
        {
            PhoneNumber.SendKeys(number);
        }

        public void EnterSubject(string sub)
        {
            Subject.SendKeys(sub);
        }

        public void SelectHobbis()
        {
            Hobbis.Click();
        }

        public void PressButton()
        {
            Button.Click();
        }
    }
}
