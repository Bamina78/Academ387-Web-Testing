using AminaTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;

namespace AminaTest
{
    [TestClass]
    public class AminaTest
    {
        [TestInitialize]
        public void Init()
        {
            TestArguments parameters = new TestArguments();

            int a = int.Parse(parameters.browser);
            Driver.Initialize(a);
        }
        [TestMethod]
        public void TestMethod1()
        {
            string subject = "",
                     body = "";

            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);

            string pretragaMessage = GoogleSearch.SearchParameter("Academy387");

            string predavaèMessage = GoogleSearch.Lecturer("Nemanja Pušara");

            string dogaðajiMessage = GoogleSearch.Events();

            string klijentiMessage = GoogleSearch.Clients();

            string kontaktMessage = GoogleSearch.Contacts();

            if (!pretragaMessage.Contains("ERROR") && (!predavaèMessage.Contains("ERROR")) && (!dogaðajiMessage.Contains("ERROR")) && (!klijentiMessage.Contains("ERROR")) && (!kontaktMessage.Contains("ERROR")))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + pretragaMessage + predavaèMessage + dogaðajiMessage + klijentiMessage + kontaktMessage;
            }
            else
            {
                subject = "Failed!!! " + subject;
                body = pretragaMessage + predavaèMessage + dogaðajiMessage + klijentiMessage + kontaktMessage;
            }


            Functions.SendEmailAttachment(subject, body);

            //Assert.IsTrue(subject.Contains("Passed"));
            //Assert.IsFalse(subject.Contains("Failed"));

        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}