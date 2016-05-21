using System;
using TechTalk.SpecFlow;
using Bank;
using NUnit.Framework;

namespace BDD_SpecFlow
{
    [Binding]
    public class ATM_TestSteps
    {
        ATM atm = new ATM();
        Customer customer = new Customer();
        private bool result { get; set; }
        [Given(@"Account is in credit")]
        public void GivenAccountIsInCredit()
        {
            Assert.AreEqual(true, customer.IsAccountInCredit);
        }
        
        [Given(@"the card is valid")]
        public void GivenTheCardIsValid()
        {
            Assert.AreEqual(true, customer.IsCardValid);
        }
        
        [Given(@"the dispenser contains cash")]
        public void GivenTheDispenserContainsCash()
        {
            Assert.AreEqual(true, atm.DoesDispenserContainCash);
        }
        
        [When(@"the customer requests cash")]
        public void WhenTheCustomerRequestsCash()
        {
            Assert.AreEqual(true, customer.RequestCash());
        }
        
        [Then(@"ensure the account is debited")]
        public void ThenEnsureTheAccountIsDebited()
        {
            Assert.AreEqual(true, customer.IsAccountDebited);
        }
        
        [Then(@"ensure cash is dispenced")]
        public void ThenEnsureCashIsDispenced()
        {
            Assert.AreEqual(true, atm.EnsureCashIsDispenced());
        }
        
        [Then(@"ensure card is returned")]
        public void ThenEnsureCardIsReturned()
        {
            Assert.AreEqual(true, atm.EnsureCardIsReturned());
        }
    }
}
