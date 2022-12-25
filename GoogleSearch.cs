using AminaTest;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AminaTest
{
    public class GoogleSearch
    {
        public static string SearchParameter(string word)
        {
            string message = "",
            pretragaMessage = "";

            string qa = "qa";
            string priceMin = "50";
            string priceMax = "500";

            try
            {
                var findText = Driver.Instance.FindElement(By.Name("q"));
                findText.SendKeys(word);
                Thread.Sleep(500);

                Actions builder = new Actions(Driver.Instance);
                builder.SendKeys(Keys.Enter).Perform();
                Thread.Sleep(1000);

                var academy387 = Driver.Instance.FindElement(By.CssSelector("#rso div:nth-child(1) div:nth-child(2) .yuRUbf a h3"));
                academy387.Click();
                Thread.Sleep(1000);

                var academy387SearchField = Driver.Instance.FindElement(By.Id("main-search-input"));
                academy387SearchField.SendKeys(qa);
                Thread.Sleep(500);

                builder.SendKeys(Keys.Enter).Perform();
                Thread.Sleep(1000);

                var academy387CategoryIt = Driver.Instance.FindElement(By.CssSelector("#category_id option:nth-child(2)"));
                academy387CategoryIt.Click();
                Thread.Sleep(500);

                var academy387LecturerNemanja = Driver.Instance.FindElement(By.CssSelector("#lecturer_id option:nth-child(206)"));
                academy387LecturerNemanja.Click();
                Thread.Sleep(500);

                var academy387PriceMin = Driver.Instance.FindElement(By.Id("price_min"));
                academy387PriceMin.SendKeys(priceMin);
                Thread.Sleep(500);

                var academy387PriceMax = Driver.Instance.FindElement(By.Id("price_max"));
                academy387PriceMax.SendKeys(priceMax);
                Thread.Sleep(500);

                var academy387Submit = Driver.Instance.FindElement(By.CssSelector("body .page-content .col-xs-12.col-md-3.seach-filters-col input.btn.btn-green.btn-block"));
                academy387Submit.Click();
                Thread.Sleep(500);

            }
            catch (Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }

            message += pretragaMessage;

            return message;
        }

        public static string Contacts()
        {
            string message = "",
                kontaktMessage = "";

            try
            {
                var contacts = Driver.Instance.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 .nav.navbar-nav.navbar-right li:nth-child(3) a"));
                contacts.Click();
                Thread.Sleep(500);

                //var contactsPayment = Driver.Instance.FindElement(By.CssSelector("body div:nth-child(6) a:nth-child(2)"));
                //contactsPayment.Click();
                //Thread.Sleep(500);


            }

            catch (Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }

            message += kontaktMessage;

            return message;
        }

        public static string Clients()
        {
            string message = "",
                klijentiMessage = "";

            try
            {
                var clients = Driver.Instance.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 .nav.navbar-nav.navbar-right li:nth-child(4) a"));
                clients.Click();
                Thread.Sleep(500);

            }

            catch (Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }

            message += klijentiMessage;

            return message;
        }

        public static string Events()
        {
            string message = "",
                događajiMessage = "";

            try
            {
                var events = Driver.Instance.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 .nav.navbar-nav.navbar-right li:nth-child(5) a"));
                events.Click();
                Thread.Sleep(500);

            }

            catch (Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }

            message += događajiMessage;

            return message;
        }

        public static string Lecturer(string lecturer)
        {
            string message = "",
                predavačMessage = "";


            try
            {
                var predavači = Driver.Instance.FindElement(By.CssSelector("#bs-example-navbar-collapse-1 .nav.navbar-nav.navbar-right li:nth-child(2)"));
                predavači.Click();
                Thread.Sleep(500);

                var predavačiSlovo = Driver.Instance.FindElement(By.CssSelector(".page-content div:nth-child(1) .col-xs-12.hidden-xs.hidden-sm li:nth-child(14)"));
                predavačiSlovo.Click();
                Thread.Sleep(500);

                var predavačiSlovoNemanja = Driver.Instance.FindElement(By.CssSelector("#lecturers-container div:nth-child(9) .lecturer-image.text-center "));
                predavačiSlovoNemanja.Click();
                Thread.Sleep(500);

                var academy387SearchField = Driver.Instance.FindElement(By.Id("main-search-input"));
                academy387SearchField.SendKeys(lecturer);
                Thread.Sleep(500);

                Actions builder = new Actions(Driver.Instance);
                builder.SendKeys(Keys.Enter).Perform();
                Thread.Sleep(1000);

            }
            catch (Exception e)
            {
                message += "ERROR!!!" + e.Message;
            }

            message += predavačMessage;

            return message;
        }
    }

}
