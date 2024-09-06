// <copyright file="VaultControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>

namespace unitTests
{
    using NUnit.Framework;
    using PayPalRESTAPIs.Standard.Controllers;
    using PayPalRESTAPIs.Standard.Exceptions;
    using PayPalRESTAPIs.Standard.Models;
    using System.Threading.Tasks;

    /// <summary>
    /// VaultControllerTest.
    /// </summary>
    [TestFixture]
    public class VaultControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private VaultController vaultController;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.vaultController = this.Client.VaultController;
        }

        // Returns 400 Response on Create Order 
        [Test]
        public async Task TestCreateSetupToken400()
        {
            SetupTokensCreateInput setupTokensCreateInput = new SetupTokensCreateInput
            {
                PayPalRequestId = "PayPal-Request-Id6",
                Body = new SetupTokenRequest
                {
                    PaymentSource = new SetupTokenRequestPaymentSource
                    {
                    },
                },
            };
            ErrorException exception =
                Assert.Throws<ErrorException>(() => vaultController.SetupTokensCreate(setupTokensCreateInput));
            // Test response code
            Assert.AreEqual(400, exception.ResponseCode, "Status should be 400");
        }

        // Returns 400 Response on Create Order 
        [Test]
        public async Task TestCreatePaymentToken404()
        {
            PaymentTokensCreateInput paymentTokensCreateInput = new PaymentTokensCreateInput
            {
                Body = new PaymentTokenRequest
                {
                    PaymentSource = new PaymentTokenRequestPaymentSource
                    {
                    },
                },
            };
            ErrorException exception =
                Assert.Throws<ErrorException>(() => vaultController.PaymentTokensCreate(paymentTokensCreateInput));
            // Test response code
            Assert.AreEqual(404, exception.ResponseCode, "Status should be 404");
        }

        // Returns 400 Response on Create Order 
        [Test]
        public async Task TestCreatePaymentToken400()
        {
            PaymentTokensCreateInput paymentTokensCreateInput = new PaymentTokensCreateInput
            {
                PayPalRequestId = "",
                Body = new PaymentTokenRequest
                {
                    PaymentSource = new PaymentTokenRequestPaymentSource
                    {
                        Token = new VaultTokenRequest
                        {
                            Id = "1234",
                            Type = TokenType.BILLINGAGREEMENT,
                        },
                    },
                },
            };
            ErrorException exception =
                Assert.Throws<ErrorException>(() => vaultController.PaymentTokensCreate(paymentTokensCreateInput));
            // Test response code
            Assert.AreEqual(400, exception.ResponseCode, "Status should be 400");
        }

        // Returns 400 Response on Create Order 
        [Test]
        public async Task TestGetSetupToken404()
        {
            ErrorException exception =
                Assert.Throws<ErrorException>(() => vaultController.SetupTokensGet("payment-1"));
            // Test response code
            Assert.AreEqual(404, exception.ResponseCode, "Status should be 404");
        }

        // Returns 400 Response on Create Order 
        [Test]
        public async Task TestGetSetupToken400()
        {
            ApiException exception =
                Assert.Throws<ApiException>(() => vaultController.SetupTokensGet("id0"));
            // Test response code
            Assert.AreEqual(400, exception.ResponseCode, "Status should be 400");
        }

        // Returns 400 Response on Create Order 
        [Test]
        public async Task TestGetPaymentToken404()
        {
            ErrorException exception =
                Assert.Throws<ErrorException>(() => vaultController.PaymentTokensGet("id0"));
            // Test response code
            Assert.AreEqual(404, exception.ResponseCode, "Status should be 404");
        }

        // Returns 400 Response on Create Order 
        [Test]
        public async Task TestGetPaymentToken400()
        {
            ApiException exception =
                Assert.Throws<ApiException>(() => vaultController.PaymentTokensGet("'dw"));
            // Test response code
            Assert.AreEqual(400, exception.ResponseCode, "Status should be 400");
        }

        // Returns 400 Response on Create Order 
        [Test]
        public async Task TestGetCustomerPaymentToken404()
        {
            CustomerPaymentTokensGetInput customerPaymentTokensGetInput = new CustomerPaymentTokensGetInput
            {
                CustomerId = "customer_id8",
                TotalRequired = false,
            };
            ApiException exception =
                Assert.Throws<ApiException>(() => vaultController.CustomerPaymentTokensGet(customerPaymentTokensGetInput));
            // Test response code
            Assert.AreEqual(404, exception.ResponseCode, "Status should be 404");
        }

        // Returns 400 Response on Create Order 
        [Test]
        public async Task TestGetCustomerPaymentToken400()
        {
            CustomerPaymentTokensGetInput customerPaymentTokensGetInput = new CustomerPaymentTokensGetInput
            {
                CustomerId = "'dw",
                TotalRequired = false,
            };
            ErrorException exception =
                Assert.Throws<ErrorException>(() => vaultController.CustomerPaymentTokensGet(customerPaymentTokensGetInput));
            // Test response code
            Assert.AreEqual(400, exception.ResponseCode, "Status should be 400");
        }

        // Returns 400 Response on Create Order 
        [Test]
        public async Task TestDeletePaymentToken204()
        {
            await vaultController.PaymentTokensDeleteAsync("id");
            // Test response code
            Assert.AreEqual(204, HttpCallBack.Response.StatusCode, "Status should be 204");
        }

    }
}