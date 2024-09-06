// <copyright file="PaymentsControllerTest.cs" company="APIMatic">
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
    /// PaymentsControllerTest.
    /// </summary>
    [TestFixture]
    public class PaymentsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private PaymentsController paymentsController;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.paymentsController = this.Client.PaymentsController;
        }

        // Test Get Authorization for 404 status code
        [Test]
        public async Task TestGetAuthorization404()
        {
            ErrorException exception = Assert.Throws<ErrorException>(() => paymentsController.AuthorizationsGet("authorization_id8"));
            // Test response code
            Assert.AreEqual(404, exception.ResponseCode, "Status should be 404");
        }

        // Test Captures Refund for 404 status code
        [Test]
        public async Task TestCaptureRefund404()
        {
            CapturesRefundInput capturesRefundInput = new CapturesRefundInput
            {
                CaptureId = "capture_id",
                Prefer = "return=minimal",
            };
            ErrorException exception = Assert.Throws<ErrorException>(() => paymentsController.CapturesRefund(capturesRefundInput));
            // Test response code
            Assert.AreEqual(404, exception.ResponseCode, "Status should be 404");
        }

        // Test Get Refund for 404 status code
        [Test]
        public async Task TestGetRefund404()
        {
            ErrorException exception = Assert.Throws<ErrorException>(() => paymentsController.RefundsGet("refund_id4"));
            // Test response code
            Assert.AreEqual(404, exception.ResponseCode, "Status should be 404");
        }

        // Test Authorizations Capture for 404 status code
        [Test]
        public async Task TestAuthorizationsCapture404()
        {
            AuthorizationsCaptureInput authorizationsCaptureInput = new AuthorizationsCaptureInput
            {
                AuthorizationId = "authorization_id8",
                Prefer = "return=minimal",
            };
            ErrorException exception = Assert.Throws<ErrorException>(() => paymentsController.AuthorizationsCapture(authorizationsCaptureInput));
            // Test response code
            Assert.AreEqual(404, exception.ResponseCode, "Status should be 404");
        }

        // Test Authorizations Reauthorize for 404 status code
        [Test]
        public async Task TestAuthorizationsReauthorize404()
        {
            AuthorizationsReauthorizeInput authorizationsReauthorizeInput = new AuthorizationsReauthorizeInput
            {
                AuthorizationId = "authorization_id8",
                Prefer = "return=minimal",
            };
            ErrorException exception = Assert.Throws<ErrorException>(() => paymentsController.AuthorizationsReauthorize(authorizationsReauthorizeInput));
            // Test response code
            Assert.AreEqual(404, exception.ResponseCode, "Status should be 404");
        }

        // Test Authorizations Void for 404 status code
        [Test]
        public async Task TestAuthorizationsVoid404()
        {
            AuthorizationsVoidInput authorizationsVoidInput = new AuthorizationsVoidInput
            {
                AuthorizationId = "authorization_id8",
                Prefer = "return=minimal",
            };
            ErrorException exception = Assert.Throws<ErrorException>(() => paymentsController.AuthorizationsVoid(authorizationsVoidInput));
            // Test response code
            Assert.AreEqual(404, exception.ResponseCode, "Status should be 404");
        }

        // Test Get Captures for 404 status code
        [Test]
        public async Task TestGetCaptures404()
        {
            ErrorException exception = Assert.Throws<ErrorException>(() => paymentsController.CapturesGet("capture_id2"));
            // Test response code
            Assert.AreEqual(404, exception.ResponseCode, "Status should be 404");
        }


    }
}