// <copyright file="OrdersControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>

namespace unitTests
{
    using NUnit.Framework;
    using PayPalRESTAPIs.Standard.Controllers;
    using PayPalRESTAPIs.Standard.Exceptions;
    using PayPalRESTAPIs.Standard.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// OrdersControllerTest.
    /// </summary>
    [TestFixture]
    public class OrdersControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private OrdersController ordersController;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.ordersController = this.Client.OrdersController;
        }

        // Returns 400 Response on Create Order 
        [Test]
        public async Task TestOrdersCreate400()
        {
            OrdersCreateInput ordersCreateInput = new OrdersCreateInput
            {
                Body = new OrderRequest
                {
                    Intent = CheckoutPaymentIntent.CAPTURE,
                    PurchaseUnits = new List<PayPalRESTAPIs.Standard.Models.PurchaseUnitRequest>
                    {

                    },
                },
                PayPalClientMetadataId = "PayPal-Client-Metadata-Id",
                Prefer = "return=minimal",
            };

            ErrorException exception = Assert.Throws<ErrorException>(() => ordersController.OrdersCreate(ordersCreateInput));
            // Test response code
            Assert.AreEqual(400, exception.ResponseCode, "Status should be 400");
        }

        // Returns 404 Response on Patch Order
        [Test]
        public async Task TestPatchOrder404()
        {
            OrdersPatchInput ordersPatchInput = new OrdersPatchInput
            {
                Id = "id0",
                Body = new List<PayPalRESTAPIs.Standard.Models.Patch>
                {
                    new Patch
                    {
                        Op = PatchOp.Add,
                    },
                },
            };
            ErrorException exception = Assert.Throws<ErrorException>(() => ordersController.OrdersPatch(ordersPatchInput));

            // Test response code
            Assert.AreEqual(404, exception.ResponseCode, "Status should be 404");
        }

        // Returns 404 Response on Confirm Order
        [Test]
        public async Task TestConfirmOrder404()
        {
            OrdersConfirmInput ordersConfirmInput = new OrdersConfirmInput
            {
                Id = "id0",
                Prefer = "return=minimal",
                Body = new ConfirmOrderRequest
                {
                    PaymentSource = new PaymentSource
                    {
                    },
                    ProcessingInstruction = ProcessingInstruction.NOINSTRUCTION,
                },
            };

            ErrorException exception = Assert.Throws<ErrorException>(() => ordersController.OrdersConfirm(ordersConfirmInput));

            // Test response code
            Assert.AreEqual(404, exception.ResponseCode, "Status should be 404");
        }

        // Returns 404 Response on Authorize Order
        [Test]
        public async Task TestAuthorizeOrder404()
        {
            OrdersAuthorizeInput ordersAuthorizeInput = new OrdersAuthorizeInput
            {
                Id = "id0",
                Prefer = "return=minimal",
            };
            ErrorException exception = Assert.Throws<ErrorException>(() => ordersController.OrdersAuthorize(ordersAuthorizeInput));

            // Test response code
            Assert.AreEqual(404, exception.ResponseCode, "Status should be 404");
        }

        // Returns 400 Response on Create Order Track
        [Test]
        public async Task TestCreateOrderTrack400()
        {
            OrdersTrackCreateInput ordersTrackCreateInput = new OrdersTrackCreateInput
            {
                Id = "id0",
                Body = new OrderTrackerRequest
                {
                    CaptureId = "capture_id8",
                    NotifyPayer = false,
                },
            };

            ErrorException exception = Assert.Throws<ErrorException>(() => ordersController.OrdersTrackCreate(ordersTrackCreateInput));
            // Test response code
            Assert.AreEqual(400, exception.ResponseCode, "Status should be 400");
        }

        // Returns 404 Response on Patch Order Track
        [Test]
        public async Task TestPatchOrderTrack404()
        {
            OrdersTrackersPatchInput ordersTrackersPatchInput = new OrdersTrackersPatchInput
            {
                Id = "id0",
                TrackerId = "tracker_id2"
            };
            ErrorException exception = Assert.Throws<ErrorException>(() => ordersController.OrdersTrackersPatch(ordersTrackersPatchInput));

            // Test response code
            Assert.AreEqual(404, exception.ResponseCode, "Status should be 404");
        }

        // Returns 404 Response on Get Order
        [Test]
        public async Task TestGetOrder404()
        {
            OrdersGetInput ordersGetInput = new OrdersGetInput
            {
                Id = "id0",
            };
            ErrorException exception = Assert.Throws<ErrorException>(() => ordersController.OrdersGet(ordersGetInput));

            // Test response code
            Assert.AreEqual(404, exception.ResponseCode, "Status should be 404");
        }

    }
}