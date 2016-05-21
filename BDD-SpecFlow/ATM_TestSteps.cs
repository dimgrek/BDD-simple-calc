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
            Assert.IsTrue(customer.IsAccountInCredit);
        }
        
        [Given(@"the card is valid")]
        public void GivenTheCardIsValid()
        {
            Assert.IsTrue(customer.IsCardValid);
        }
        
        [Given(@"the dispenser contains cash")]
        public void GivenTheDispenserContainsCash()
        {
            Assert.IsTrue(atm.DoesDispenserContainCash);
        }
        
        [When(@"the customer requests cash")]
        public void WhenTheCustomerRequestsCash()
        {
            Assert.IsTrue(customer.RequestCash());
        }
        
        [Then(@"ensure the account is debited")]
        public void ThenEnsureTheAccountIsDebited()
        {
            Assert.IsTrue(customer.IsAccountDebited);
        }
        
        [Then(@"ensure cash is dispenced")]
        public void ThenEnsureCashIsDispenced()
        {
            Assert.IsTrue(atm.EnsureCashIsDispenced());
        }
        
        [Then(@"ensure card is returned")]
        public void ThenEnsureCardIsReturned()
        {
            Assert.IsTrue(atm.EnsureCardIsReturned());
        }
    }
}
