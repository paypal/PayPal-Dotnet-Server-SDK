// <copyright file="OrdersControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>

using APIMatic.Core.Types;
using PayPalRESTAPIs.Standard.Exceptions;
using PayPalRESTAPIs.Standard.Models;
using PayPalRESTAPIs.Standard.Utilities;

namespace e2eTests
{
    using NUnit.Framework;
    using PayPalRESTAPIs.Standard.Controllers;
    using PayPalRESTAPIs.Standard.Http.Response;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// OrdersControllerTest.
    /// </summary>
    [TestFixture]
    public class e2eTests : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private OrdersController ordersController;
        private PaymentsController paymentsController;
        private VaultController vaultController;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.ordersController = this.Client.OrdersController;
            this.paymentsController = this.Client.PaymentsController;
            this.vaultController = this.Client.VaultController;
        }

        // Standard Checkout flow
        [Test]
        public async Task StandardCheckoutFlow()
        {
            // Create Order
            OrdersCreateInput ordersCreateInput = new OrdersCreateInput
            {
                Body = new OrderRequest
                {
                    Intent = CheckoutPaymentIntent.CAPTURE,
                    PurchaseUnits = new List<PayPalRESTAPIs.Standard.Models.PurchaseUnitRequest>
                    {
                        new PurchaseUnitRequest
                        {
                            Amount = new AmountWithBreakdown
                            {
                                CurrencyCode = "USD",
                                MValue = "100.00",
                            },
                            ReferenceId = "d9f80740-38f0-11e8-b467-0ed5f89f718b",
                        },
                    },
                    PaymentSource = new PaymentSource
                    {
                        Paypal = new PayPalWallet
                        {
                            ExperienceContext = new PayPalWalletExperienceContext
                            {
                                Locale = "en-US",
                                ReturnUrl = "https://example.com/returnUrl",
                                CancelUrl = "https://example.com/cancelUrl",
                                LandingPage = PayPalExperienceLandingPage.LOGIN,
                            },
                        },
                    },
                },
                Prefer = "return=representation",
            };
            ApiResponse<Order> orderDetails = await ordersController.OrdersCreateAsync(ordersCreateInput);
            // Test response code
            Assert.AreEqual(200, orderDetails.StatusCode, "Status should be 200");

            // Complete the payment
            var playwright = new PlaywrightFlows();
            bool isPaymentComplete = await playwright.CompletePayment(orderDetails.Data.Links[1].Href);
            Assert.IsTrue(isPaymentComplete);

            // capture order
            OrdersCaptureInput ordersCaptureInput = new OrdersCaptureInput
            {
                Id = orderDetails.Data.Id,
                Prefer = "return=representation",
            };
            ApiResponse<Order> captureResponse = await ordersController.OrdersCaptureAsync(ordersCaptureInput);
            // test response code
            Assert.AreEqual(201, captureResponse.StatusCode, "Status should be 201");

            // Get Order Details
            OrdersGetInput ordersGetInput = new OrdersGetInput
            {
                Id = orderDetails.Data.Id,
            };
            ApiResponse<Order> result = await ordersController.OrdersGetAsync(ordersGetInput);
            // test response code
            Assert.AreEqual(200, result.StatusCode, "Status should be 200");

        }

        // Authorize And Capture flow
        [Test]
        public async Task AuthorizeAndCaptureFlow()
        {
            // Create Order
            OrdersCreateInput ordersCreateInput = new OrdersCreateInput
            {
                Body = new OrderRequest
                {
                    Intent = CheckoutPaymentIntent.AUTHORIZE,
                    PurchaseUnits = new List<PayPalRESTAPIs.Standard.Models.PurchaseUnitRequest>
                    {
                        new PurchaseUnitRequest
                        {
                            Amount = new AmountWithBreakdown
                            {
                                CurrencyCode = "USD",
                                MValue = "25.00",
                                Breakdown = new AmountBreakdown
                                {
                                    ItemTotal = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "25.00",
                                    },
                                    Shipping = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "0",
                                    },
                                    TaxTotal = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "0",
                                    },
                                },
                            },
                            Description = "Clothing Shop",
                            Items = new List<PayPalRESTAPIs.Standard.Models.Item>
                            {
                                new Item
                                {
                                    Name = "Levis 501",
                                    UnitAmount = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "25.00",
                                    },
                                    Quantity = "1",
                                    Tax = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "0.00",
                                    },
                                    Sku = "5158936",
                                },
                            },
                        },
                    },
                    PaymentSource = new PaymentSource
                    {
                        Paypal = new PayPalWallet
                        {
                            ExperienceContext = new PayPalWalletExperienceContext
                            {
                                Locale = "en-US",
                                ReturnUrl = "https://example.com/returnUrl",
                                CancelUrl = "https://example.com/cancelUrl",
                                LandingPage = PayPalExperienceLandingPage.LOGIN,
                            },
                        },
                    },
                },
                Prefer = "return=representation",
            };
            ApiResponse<Order> orderDetails = await ordersController.OrdersCreateAsync(ordersCreateInput);
            // Test response code
            Assert.AreEqual(200, orderDetails.StatusCode, "Status should be 200");

            // Complete the payment
            var playwright = new PlaywrightFlows();
            bool isPaymentComplete = await playwright.CompletePayment(orderDetails.Data.Links[1].Href);
            Assert.IsTrue(isPaymentComplete);

            // Authorize order
            OrdersAuthorizeInput ordersAuthorizeInput = new OrdersAuthorizeInput
            {
                Id = orderDetails.Data.Id,
                Prefer = "return=representation",
            };
            ApiResponse<OrderAuthorizeResponse> authorizeResponse = await ordersController.OrdersAuthorizeAsync(ordersAuthorizeInput);
            // test response code
            Assert.AreEqual(201, authorizeResponse.StatusCode, "Status should be 201");

            // Capture Authorization
            AuthorizationsCaptureInput authorizationsCaptureInput = new AuthorizationsCaptureInput
            {
                AuthorizationId = authorizeResponse.Data.PurchaseUnits[0].Payments.Authorizations[0].Id,
                Prefer = "return=representation",
            };
            ApiResponse<CapturedPayment> captureAuthResponse = await paymentsController.AuthorizationsCaptureAsync(authorizationsCaptureInput);
            // test response code
            Assert.AreEqual(201, captureAuthResponse.StatusCode, "Status should be 201");

            // Get Authorization
            ApiResponse<PaymentAuthorization> getAuthorizationResponse = await paymentsController.AuthorizationsGetAsync(authorizeResponse.Data.PurchaseUnits[0].Payments.Authorizations[0].Id);
            // test response code
            Assert.AreEqual(200, getAuthorizationResponse.StatusCode, "Status should be 200");

            // Get Capture
            ApiResponse<CapturedPayment> getCaptureResponse = await paymentsController.CapturesGetAsync(captureAuthResponse.Data.Id);
            // test response code
            Assert.AreEqual(200, getCaptureResponse.StatusCode, "Status should be 200");

        }

        // Void Authorization flow
        [Test]
        public async Task VoidAuthorizationFlow()
        {
            // Create Order
            OrdersCreateInput ordersCreateInput = new OrdersCreateInput
            {
                Body = new OrderRequest
                {
                    Intent = CheckoutPaymentIntent.AUTHORIZE,
                    PurchaseUnits = new List<PayPalRESTAPIs.Standard.Models.PurchaseUnitRequest>
                    {
                        new PurchaseUnitRequest
                        {
                            Amount = new AmountWithBreakdown
                            {
                                CurrencyCode = "USD",
                                MValue = "25.00",
                                Breakdown = new AmountBreakdown
                                {
                                    ItemTotal = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "25.00",
                                    },
                                    Shipping = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "0",
                                    },
                                    TaxTotal = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "0",
                                    },
                                },
                            },
                            Description = "Clothing Shop",
                            Items = new List<PayPalRESTAPIs.Standard.Models.Item>
                            {
                                new Item
                                {
                                    Name = "Levis 501",
                                    UnitAmount = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "25.00",
                                    },
                                    Quantity = "1",
                                    Tax = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "0.00",
                                    },
                                    Sku = "5158936",
                                },
                            },
                        },
                    },
                    PaymentSource = new PaymentSource
                    {
                        Paypal = new PayPalWallet
                        {
                            ExperienceContext = new PayPalWalletExperienceContext
                            {
                                Locale = "en-US",
                                ReturnUrl = "https://example.com/returnUrl",
                                CancelUrl = "https://example.com/cancelUrl",
                                LandingPage = PayPalExperienceLandingPage.LOGIN,
                            },
                        },
                    },
                },
                Prefer = "return=representation",
            };
            ApiResponse<Order> orderDetails = await ordersController.OrdersCreateAsync(ordersCreateInput);
            // Test response code
            Assert.AreEqual(200, orderDetails.StatusCode, "Status should be 200");

            // Complete the payment
            var playwright = new PlaywrightFlows();
            bool isPaymentComplete = await playwright.CompletePayment(orderDetails.Data.Links[1].Href);
            Assert.IsTrue(isPaymentComplete);

            // Authorize order
            OrdersAuthorizeInput ordersAuthorizeInput = new OrdersAuthorizeInput
            {
                Id = orderDetails.Data.Id,
                Prefer = "return=representation",
            };
            ApiResponse<OrderAuthorizeResponse> authorizeResponse = await ordersController.OrdersAuthorizeAsync(ordersAuthorizeInput);
            // test response code
            Assert.AreEqual(201, authorizeResponse.StatusCode, "Status should be 201");

            // Void Authorization
            AuthorizationsVoidInput authorizationsVoidInput = new AuthorizationsVoidInput
            {
                AuthorizationId = authorizeResponse.Data.PurchaseUnits[0].Payments.Authorizations[0].Id,
                Prefer = "return=representation",
            };
            await paymentsController.AuthorizationsVoidAsync(authorizationsVoidInput);
            // test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

        }

        // Refund flow
        [Test]
        public async Task RefundFlow()
        {
            // Create Order
            OrdersCreateInput ordersCreateInput = new OrdersCreateInput
            {
                Body = new OrderRequest
                {
                    Intent = CheckoutPaymentIntent.CAPTURE,
                    PurchaseUnits = new List<PayPalRESTAPIs.Standard.Models.PurchaseUnitRequest>
                    {
                        new PurchaseUnitRequest
                        {
                            Amount = new AmountWithBreakdown
                            {
                                CurrencyCode = "USD",
                                MValue = "100.00",
                            },
                            ReferenceId = "d9f80740-38f0-11e8-b467-0ed5f89f718b",
                        },
                    },
                    PaymentSource = new PaymentSource
                    {
                        Paypal = new PayPalWallet
                        {
                            ExperienceContext = new PayPalWalletExperienceContext
                            {
                                Locale = "en-US",
                                ReturnUrl = "https://example.com/returnUrl",
                                CancelUrl = "https://example.com/cancelUrl",
                                LandingPage = PayPalExperienceLandingPage.LOGIN,
                            },
                        },
                    },
                },
                Prefer = "return=representation",
            };
            ApiResponse<Order> orderDetails = await ordersController.OrdersCreateAsync(ordersCreateInput);
            // Test response code
            Assert.AreEqual(200, orderDetails.StatusCode, "Status should be 200");

            // Complete the payment
            var playwright = new PlaywrightFlows();
            bool isPaymentComplete = await playwright.CompletePayment(orderDetails.Data.Links[1].Href);
            Assert.IsTrue(isPaymentComplete);

            // capture order
            OrdersCaptureInput ordersCaptureInput = new OrdersCaptureInput
            {
                Id = orderDetails.Data.Id,
                Prefer = "return=representation",
            };
            ApiResponse<Order> captureResponse = await ordersController.OrdersCaptureAsync(ordersCaptureInput);
            // test response code
            Assert.AreEqual(201, captureResponse.StatusCode, "Status should be 201");

            // Refund
            CapturesRefundInput capturesRefundInput = new CapturesRefundInput
            {
                CaptureId = captureResponse.Data.PurchaseUnits[0].Payments.Captures[0].Id,
                Prefer = "return=representation",
            };
            ApiResponse<Refund> refundResponse = await paymentsController.CapturesRefundAsync(capturesRefundInput);
            // test response code
            Assert.AreEqual(201, refundResponse.StatusCode, "Status should be 201");

            // Get Refund
            ApiResponse<Refund> getRefundResponse = await paymentsController.RefundsGetAsync(refundResponse.Data.Id);
            // test response code
            Assert.AreEqual(200, getRefundResponse.StatusCode, "Status should be 200");
        }

        // Patch Order flow
        [Test]
        public async Task PatchOrderFlow()
        {
            // Create Order
            OrdersCreateInput ordersCreateInput = new OrdersCreateInput
            {
                Body = new OrderRequest
                {
                    Intent = CheckoutPaymentIntent.CAPTURE,
                    PurchaseUnits = new List<PayPalRESTAPIs.Standard.Models.PurchaseUnitRequest>
                    {
                        new PurchaseUnitRequest
                        {
                            Amount = new AmountWithBreakdown
                            {
                                CurrencyCode = "USD",
                                MValue = "10.00",
                                Breakdown = new AmountBreakdown
                                {
                                    ItemTotal = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "10.0",
                                    },
                                    Shipping = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "0.0",
                                    },
                                    TaxTotal = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "0",
                                    },
                                },
                            },
                            Description = "Camera Shop",
                            Items = new List<PayPalRESTAPIs.Standard.Models.Item>
                            {
                                new Item
                                {
                                    Name = "Levis 501 Selvedge STF",
                                    UnitAmount = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "5.00",
                                    },
                                    Quantity = "1",
                                    Tax = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "0.00",
                                    },
                                    Sku = "5158936",
                                },
                                new Item
                                {
                                    Name = "T-Shirt",
                                    UnitAmount = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "5.00",
                                    },
                                    Quantity = "1",
                                    Tax = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "0.00",
                                    },
                                    Sku = "1457432",
                                },
                            },
                            Shipping = new ShippingDetails
                            {
                                Address = new Address
                                {
                                    CountryCode = "US",
                                    AddressLine1 = "123 Main Street",
                                    AdminArea2 = "San Jose",
                                    AdminArea1 = "CA",
                                    PostalCode = "95131",
                                },
                            },
                        },
                    },
                    PaymentSource = new PaymentSource
                    {
                        Paypal = new PayPalWallet
                        {
                            ExperienceContext = new PayPalWalletExperienceContext
                            {
                                Locale = "en-US",
                                ReturnUrl = "https://example.com/returnUrl",
                                CancelUrl = "https://example.com/cancelUrl",
                            },
                        },
                    },
                },
                Prefer = "return=representation",
            };

            ApiResponse<Order> orderDetails = await ordersController.OrdersCreateAsync(ordersCreateInput);
            // Test response code
            Assert.AreEqual(200, orderDetails.StatusCode, "Status should be 200");

            // Patch order
            OrdersPatchInput ordersPatchInput = new OrdersPatchInput
            {
                Id = orderDetails.Data.Id,
                Body = new List<PayPalRESTAPIs.Standard.Models.Patch>
                {
                    new Patch
                    {
                        Op = PatchOp.Replace,
                        Path = "/purchase_units/@reference_id=='default'/shipping/address",
                        MValue = JsonValue.FromObject(new Dictionary<string, string>
                        {
                            { "address_line_1", "123 Main St" },
                            { "address_line_2", "Floor 6" },
                            { "admin_area_2", "San Francisco" },
                            { "admin_area_1", "CA" },
                            { "postal_code", "94107" },
                            { "country_code", "US" }
                        })
                    },
                },
            };
            await ordersController.OrdersPatchAsync(ordersPatchInput);
            // test response code
            Assert.AreEqual(204, HttpCallBack.Response.StatusCode, "Status should be 204");

            // Get Order Detail
            OrdersGetInput ordersGetInput = new OrdersGetInput
            {
                Id = orderDetails.Data.Id,
            };
            ApiResponse<Order> orderResponse = await ordersController.OrdersGetAsync(ordersGetInput);
            // test response code
            Assert.AreEqual(200, orderResponse.StatusCode, "Status should be 200");
        }

        // Confirm Order flow
        [Test]
        public async Task ConfirmOrderFlow()
        {
            // Create Order
            OrdersCreateInput ordersCreateInput = new OrdersCreateInput
            {
                Body = new OrderRequest
                {
                    Intent = CheckoutPaymentIntent.CAPTURE,
                    PurchaseUnits = new List<PayPalRESTAPIs.Standard.Models.PurchaseUnitRequest>
                    {
                        new PurchaseUnitRequest
                        {
                            Amount = new AmountWithBreakdown
                            {
                                CurrencyCode = "USD",
                                MValue = "100.00",
                            },
                            ReferenceId = "d9f80740-38f0-11e8-b467-0ed5f89f718b",
                        },
                    },
                    PaymentSource = new PaymentSource
                    {
                        Paypal = new PayPalWallet
                        {
                            ExperienceContext = new PayPalWalletExperienceContext
                            {
                                Locale = "en-US",
                                ReturnUrl = "https://example.com/returnUrl",
                                CancelUrl = "https://example.com/cancelUrl",
                                LandingPage = PayPalExperienceLandingPage.LOGIN,
                            },
                        },
                    },
                },
                Prefer = "return=representation",
            };
            ApiResponse<Order> orderDetails = await ordersController.OrdersCreateAsync(ordersCreateInput);
            // Test response code
            Assert.AreEqual(200, orderDetails.StatusCode, "Status should be 200");

            // Confirm Order
            OrdersConfirmInput ordersConfirmInput = new OrdersConfirmInput
            {
                Id = orderDetails.Data.Id,
                Prefer = "return=representation",
                Body = new ConfirmOrderRequest
                {
                    PaymentSource = new PaymentSource
                    {
                        Paypal = new PayPalWallet
                        {
                            EmailAddress = "customer@example.com",
                            Name = new Name
                            {
                                GivenName = "John",
                                Surname = "Doe",
                            },
                            ExperienceContext = new PayPalWalletExperienceContext
                            {
                                BrandName = "EXAMPLE INC",
                                Locale = "en-US",
                                ShippingPreference = ShippingPreference.SETPROVIDEDADDRESS,
                                ReturnUrl = "https://example.com/returnUrl",
                                CancelUrl = "https://example.com/cancelUrl",
                                LandingPage = PayPalExperienceLandingPage.LOGIN,
                                UserAction = PayPalExperienceUserAction.PAYNOW,
                                PaymentMethodPreference = PayeePaymentMethodPreference.IMMEDIATEPAYMENTREQUIRED,
                            },
                        },
                    },
                },
            };
            ApiResponse<Order> confirmOrderResponse = await ordersController.OrdersConfirmAsync(ordersConfirmInput);
            // test response code
            Assert.AreEqual(200, confirmOrderResponse.StatusCode, "Status should be 200");

            // Complete the payment
            var playwright = new PlaywrightFlows();
            bool isPaymentComplete = await playwright.CompletePayment(orderDetails.Data.Links[1].Href);
            Assert.IsTrue(isPaymentComplete);

            // capture order
            OrdersCaptureInput ordersCaptureInput = new OrdersCaptureInput
            {
                Id = orderDetails.Data.Id,
                Prefer = "return=representation",
            };
            ApiResponse<Order> captureResponse = await ordersController.OrdersCaptureAsync(ordersCaptureInput);
            // test response code
            Assert.AreEqual(201, captureResponse.StatusCode, "Status should be 201");

        }

        // Add Shipping Tracker Info flow
        [Test]
        public async Task AddShippingTrackerInformationToOrderFlow()
        {
            // Create Order
            OrdersCreateInput ordersCreateInput = new OrdersCreateInput
            {
                Body = new OrderRequest
                {
                    Intent = CheckoutPaymentIntent.CAPTURE,
                    PurchaseUnits = new List<PayPalRESTAPIs.Standard.Models.PurchaseUnitRequest>
                    {
                        new PurchaseUnitRequest
                        {
                            Amount = new AmountWithBreakdown
                            {
                                CurrencyCode = "USD",
                                MValue = "10.00",
                                Breakdown = new AmountBreakdown
                                {
                                    ItemTotal = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "10.0",
                                    },
                                    Shipping = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "0.0",
                                    },
                                    TaxTotal = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "0",
                                    },
                                },
                            },
                            Description = "Camera Shop",
                            Items = new List<PayPalRESTAPIs.Standard.Models.Item>
                            {
                                new Item
                                {
                                    Name = "Levis 501 Selvedge STF",
                                    UnitAmount = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "5.00",
                                    },
                                    Quantity = "1",
                                    Tax = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "0.00",
                                    },
                                    Sku = "5158936",
                                },
                                new Item
                                {
                                    Name = "T-Shirt",
                                    UnitAmount = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "5.00",
                                    },
                                    Quantity = "1",
                                    Tax = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "0.00",
                                    },
                                    Sku = "1457432",
                                },
                            },
                            Shipping = new ShippingDetails
                            {
                                Address = new Address
                                {
                                    CountryCode = "US",
                                    AddressLine1 = "123 Main Street",
                                    AdminArea2 = "San Jose",
                                    AdminArea1 = "CA",
                                    PostalCode = "95131",
                                },
                            },
                        },
                    },
                    PaymentSource = new PaymentSource
                    {
                        Paypal = new PayPalWallet
                        {
                            ExperienceContext = new PayPalWalletExperienceContext
                            {
                                Locale = "en-US",
                                ReturnUrl = "https://example.com/returnUrl",
                                CancelUrl = "https://example.com/cancelUrl",
                            },
                        },
                    },
                },
                Prefer = "return=representation",
            };

            ApiResponse<Order> orderDetails = await ordersController.OrdersCreateAsync(ordersCreateInput);
            // Test response code
            Assert.AreEqual(200, orderDetails.StatusCode, "Status should be 200");

            // Complete the payment
            var playwright = new PlaywrightFlows();
            bool isPaymentComplete = await playwright.CompletePayment(orderDetails.Data.Links[1].Href);
            Assert.IsTrue(isPaymentComplete);

            // capture order
            OrdersCaptureInput ordersCaptureInput = new OrdersCaptureInput
            {
                Id = orderDetails.Data.Id,
                Prefer = "return=representation",
            };
            ApiResponse<Order> captureResponse = await ordersController.OrdersCaptureAsync(ordersCaptureInput);
            // test response code
            Assert.AreEqual(201, captureResponse.StatusCode, "Status should be 201");

            // Create Order Track
            OrdersTrackCreateInput ordersTrackCreateInput = new OrdersTrackCreateInput
            {
                Id = orderDetails.Data.Id,
                Body = new OrderTrackerRequest
                {
                    CaptureId = captureResponse.Data.PurchaseUnits[0].Payments.Captures[0].Id,
                    TrackingNumber = "443844607820",
                    Carrier = ShipmentCarrier.FEDEX,
                    NotifyPayer = false,
                    Items = new List<PayPalRESTAPIs.Standard.Models.OrderTrackerItem>
                    {
                        new OrderTrackerItem
                        {
                            Name = "T-Shirt",
                            Quantity = "1",
                            Sku = "sku02",
                            Url = "https://www.example.com/example",
                            ImageUrl = "https://www.example.com/example.jpg",
                            Upc = new UniversalProductCode
                            {
                                Type = UPCType.UPCA,
                                Code = "upc001",
                            },
                        },
                    },
                },
            };
            ApiResponse<Order> orderTrackResponse = await ordersController.OrdersTrackCreateAsync(ordersTrackCreateInput);
            // test response code
            Assert.AreEqual(201, orderTrackResponse.StatusCode, "Status should be 201");

            // Update Track Order
            OrdersTrackersPatchInput ordersTrackersPatchInput = new OrdersTrackersPatchInput
            {
                Id = orderDetails.Data.Id,
                TrackerId = orderTrackResponse.Data.PurchaseUnits[0].Shipping.Trackers[0].Id,
                Body = new List<PayPalRESTAPIs.Standard.Models.Patch>
                {
                    new Patch
                    {
                        Op = PatchOp.Replace,
                        Path = "/notify_payer",
                        MValue = JsonValue.FromBoolean(true)
                    },
                },
            };
            await ordersController.OrdersTrackersPatchAsync(ordersTrackersPatchInput);
            // test response code
            Assert.AreEqual(204, HttpCallBack.Response.StatusCode, "Status should be 204");

        }

        // Payment Method With Purchase Flow
        [Test]
        public async Task PaymentMethodWithPurchaseFlow()
        {
            // Create Order
            OrdersCreateInput ordersCreateInput = new OrdersCreateInput
            {
                Body = new OrderRequest
                {
                    Intent = CheckoutPaymentIntent.CAPTURE,
                    PurchaseUnits = new List<PayPalRESTAPIs.Standard.Models.PurchaseUnitRequest>
                    {
                        new PurchaseUnitRequest
                        {
                            Amount = new AmountWithBreakdown
                            {
                                CurrencyCode = "USD",
                                MValue = "10.00",
                                Breakdown = new AmountBreakdown
                                {
                                    ItemTotal = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "10.00",
                                    },
                                },
                            },
                            Description = "Camera Shop",
                            Items = new List<PayPalRESTAPIs.Standard.Models.Item>
                            {
                                new Item
                                {
                                    Name = "Camera",
                                    UnitAmount = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "10.00",
                                    },
                                    Quantity = "1",
                                },
                            },
                            Shipping = new ShippingDetails
                            {
                                Address = new Address
                                {
                                    CountryCode = "US",
                                    AddressLine1 = "500 Main Street",
                                    AddressLine2 = "#1000",
                                    AdminArea2 = "San Jose",
                                    AdminArea1 = "CA",
                                    PostalCode = "95131",
                                },
                            },
                        },
                    },
                    PaymentSource = new PaymentSource
                    {
                        Paypal = new PayPalWallet
                        {
                            Attributes = new PayPalWalletAttributes
                            {
                                Vault = new PayPalWalletVaultInstruction
                                {
                                    UsageType = PayPalPaymentTokenUsageType.MERCHANT,
                                    StoreInVault = StoreInVaultInstruction.ONSUCCESS,
                                },
                            },
                            ExperienceContext = new PayPalWalletExperienceContext
                            {
                                ShippingPreference = ShippingPreference.SETPROVIDEDADDRESS,
                                ReturnUrl = "https://example.com/returnUrl",
                                CancelUrl = "https://example.com/cancelUrl",
                            },
                        },
                    },
                },
                PayPalRequestId = Guid.NewGuid().ToString(),
                Prefer = "return=representation",
            };
            ApiResponse<Order> orderDetails = await ordersController.OrdersCreateAsync(ordersCreateInput);
            // Test response code
            Assert.AreEqual(200, orderDetails.StatusCode, "Status should be 200");

            // Complete the payment
            var playwright = new PlaywrightFlows();
            bool isPaymentComplete = await playwright.CompletePayment(orderDetails.Data.Links[1].Href);
            Assert.IsTrue(isPaymentComplete);

            // capture order
            OrdersCaptureInput ordersCaptureInput = new OrdersCaptureInput
            {
                Id = orderDetails.Data.Id,
                Prefer = "return=representation",
            };
            ApiResponse<Order> captureResponse = await ordersController.OrdersCaptureAsync(ordersCaptureInput);
            // test response code
            Assert.AreEqual(201, captureResponse.StatusCode, "Status should be 201");

        }

        // Payment Method WithOut Purchase Flow
        [Test]
        public async Task PaymentMethodWithOutPurchaseFlow()
        {
            // Create Setup Token
            SetupTokensCreateInput setupTokensCreateInput = new SetupTokensCreateInput
            {
                PayPalRequestId = Guid.NewGuid().ToString(),
                Body = new SetupTokenRequest
                {
                    PaymentSource = new SetupTokenRequestPaymentSource
                    {
                        Paypal = new VaultPayPalWalletRequest
                        {
                            Description = "Description for PayPal to be shown to PayPal payer",
                            PermitMultiplePaymentTokens = true,
                            UsageType = "MERCHANT",
                            CustomerType = "CONSUMER",
                            ExperienceContext = new VaultExperienceContext
                            {
                                ReturnUrl = "https://example.com/returnUrl",
                                CancelUrl = "https://example.com/cancelUrl",
                            },
                        },
                    },
                },
            };
            ApiResponse<SetupTokenResponse> setupTokenResponse = await vaultController.SetupTokensCreateAsync(setupTokensCreateInput);
            // Test response code
            Assert.AreEqual(201, setupTokenResponse.StatusCode, "Status should be 201");

            // Save Payment Method
            var playwright = new PlaywrightFlows();
            bool isPaymentMethodSaved = await playwright.SavePaymentMethod(setupTokenResponse.Data.Links[1].Href);
            Assert.IsTrue(isPaymentMethodSaved);

            // Create Payment Token
            PaymentTokensCreateInput paymentTokensCreateInput = new PaymentTokensCreateInput
            {
                PayPalRequestId = Guid.NewGuid().ToString(),
                Body = new PaymentTokenRequest
                {
                    PaymentSource = new PaymentTokenRequestPaymentSource
                    {
                        Token = new VaultTokenRequest
                        {
                            Id = setupTokenResponse.Data.Id,
                            Type = TokenType.SETUPTOKEN,
                        },
                    },
                },
            };
            ApiResponse<PaymentTokenResponse> paymentTokenResponse = await vaultController.PaymentTokensCreateAsync(paymentTokensCreateInput);
            // test response code
            Assert.AreEqual(201, paymentTokenResponse.StatusCode, "Status should be 201");

            // Create Order For Returning Buyer
            OrdersCreateInput ordersCreateInput = new OrdersCreateInput
            {
                Body = new OrderRequest
                {
                    Intent = CheckoutPaymentIntent.CAPTURE,
                    PurchaseUnits = new List<PayPalRESTAPIs.Standard.Models.PurchaseUnitRequest>
                    {
                        new PurchaseUnitRequest
                        {
                            Amount = new AmountWithBreakdown
                            {
                                CurrencyCode = "USD",
                                MValue = "10.00",
                                Breakdown = new AmountBreakdown
                                {
                                    ItemTotal = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "10.00",
                                    },
                                },
                            },
                            Description = "Camera Shop",
                            Items = new List<PayPalRESTAPIs.Standard.Models.Item>
                            {
                                new Item
                                {
                                    Name = "Camera",
                                    UnitAmount = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "10.00",
                                    },
                                    Quantity = "1",
                                },
                            },
                            Shipping = new ShippingDetails
                            {
                                Address = new Address
                                {
                                    CountryCode = "US",
                                    AddressLine1 = "500 Main Street",
                                    AddressLine2 = "#1000",
                                    AdminArea2 = "San Jose",
                                    AdminArea1 = "CA",
                                    PostalCode = "95131",
                                },
                            },
                        },
                    },
                    PaymentSource = new PaymentSource
                    {
                        Paypal = new PayPalWallet
                        {
                            VaultId = paymentTokenResponse.Data.Id,
                        },
                    },
                },
                PayPalRequestId = Guid.NewGuid().ToString(),
                Prefer = "return=representation",
            };
            ApiResponse<Order> orderDetails = await ordersController.OrdersCreateAsync(ordersCreateInput);
            // test response code
            Assert.AreEqual(201, paymentTokenResponse.StatusCode, "Status should be 201");

            // GET Setup Token
            ApiResponse<SetupTokenResponse> getSetupTokenResponse = await vaultController.SetupTokensGetAsync(setupTokenResponse.Data.Id);
            // test response code
            Assert.AreEqual(200, getSetupTokenResponse.StatusCode, "Status should be 200");

            // GET Payment Token
            ApiResponse<PaymentTokenResponse> getPaymentTokenResponse = await vaultController.PaymentTokensGetAsync(paymentTokenResponse.Data.Id);
            // test response code
            Assert.AreEqual(200, getPaymentTokenResponse.StatusCode, "Status should be 200");

        }

        // 3D Secure Authentication Single-Step Flow
        [Test]
        public async Task SecureAuthenticationSingleStepFlow()
        {
            // Create Order
            OrdersCreateInput ordersCreateInput = new OrdersCreateInput
            {
                Body = new OrderRequest
                {
                    Intent = CheckoutPaymentIntent.CAPTURE,
                    PurchaseUnits = new List<PayPalRESTAPIs.Standard.Models.PurchaseUnitRequest>
                    {
                        new PurchaseUnitRequest
                        {
                            Amount = new AmountWithBreakdown
                            {
                                CurrencyCode = "USD",
                                MValue = "10.00",
                                Breakdown = new AmountBreakdown
                                {
                                    ItemTotal = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "10.00",
                                    },
                                },
                            },
                            Description = "Camera Shop",
                            CustomId = "testcustom_id",
                            InvoiceId = Guid.NewGuid().ToString(),
                            Items = new List<PayPalRESTAPIs.Standard.Models.Item>
                            {
                                new Item
                                {
                                    Name = "Levis 501 Selvedge STF",
                                    UnitAmount = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "5.00",
                                    },
                                    Quantity = "1",
                                    Tax = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "0.00",
                                    },
                                    Sku = "5158936",
                                },
                                new Item
                                {
                                    Name = "T-Shirt",
                                    UnitAmount = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "5.00",
                                    },
                                    Quantity = "1",
                                    Tax = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "0.00",
                                    },
                                    Sku = "1457432",
                                },
                            },
                        },
                    },
                    PaymentSource = new PaymentSource
                    {
                        Card = new CardRequest
                        {
                            Name = "John Doe",
                            Number = "4868719995056080",
                            Expiry = "2027-02",
                            BillingAddress = new Address
                            {
                                CountryCode = "US",
                                AddressLine1 = "2211 N First Street",
                                AdminArea2 = "San Jose",
                                AdminArea1 = "CA",
                                PostalCode = "95131",
                            },
                            Attributes = new CardAttributes
                            {
                                Verification = new CardVerification
                                {
                                    Method = CardVerificationMethod.SCAALWAYS,
                                },
                            },
                            ExperienceContext = new CardExperienceContext
                            {
                                ReturnUrl = "https://example.com/returnUrl",
                                CancelUrl = "https://example.com/cancel",
                            },
                        },
                    },
                },
                PayPalRequestId = Guid.NewGuid().ToString(),
                Prefer = "return=representation",
            };
            ApiResponse<Order> orderDetails = await ordersController.OrdersCreateAsync(ordersCreateInput);
            // Test response code
            Assert.AreEqual(201, orderDetails.StatusCode, "Status should be 201");

            // Complete Helios Verification
            var playwright = new PlaywrightFlows();
            bool isVerificationComplete = await playwright.CompleteHeliosVerification(orderDetails.Data.Links[1].Href, true);
            Assert.IsTrue(isVerificationComplete);

            // Get Order Details
            OrdersGetInput ordersGetInput = new OrdersGetInput
            {
                Id = orderDetails.Data.Id,
            };
            ApiResponse<Order> result = await ordersController.OrdersGetAsync(ordersGetInput);
            // test response code
            Assert.AreEqual(200, result.StatusCode, "Status should be 200");

            // capture order
            OrdersCaptureInput ordersCaptureInput = new OrdersCaptureInput
            {
                Id = orderDetails.Data.Id,
                Prefer = "return=representation",
            };
            ApiResponse<Order> captureResponse = await ordersController.OrdersCaptureAsync(ordersCaptureInput);
            // test response code
            Assert.AreEqual(201, captureResponse.StatusCode, "Status should be 201");

        }

        // 3D Secure Authentication Multi-Step Flow
        [Test]
        public async Task SecureAuthenticationMultiStepFlow()
        {
            // Create Order
            OrdersCreateInput ordersCreateInput = new OrdersCreateInput
            {
                Body = new OrderRequest
                {
                    Intent = CheckoutPaymentIntent.CAPTURE,
                    PurchaseUnits = new List<PayPalRESTAPIs.Standard.Models.PurchaseUnitRequest>
                    {
                        new PurchaseUnitRequest
                        {
                            Amount = new AmountWithBreakdown
                            {
                                CurrencyCode = "USD",
                                MValue = "10.00",
                                Breakdown = new AmountBreakdown
                                {
                                    ItemTotal = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "10.00",
                                    },
                                },
                            },
                            Description = "Camera Shop",
                            CustomId = "testcustom_id",
                            InvoiceId = Guid.NewGuid().ToString(),
                            Items = new List<PayPalRESTAPIs.Standard.Models.Item>
                            {
                                new Item
                                {
                                    Name = "Levis 501 Selvedge STF",
                                    UnitAmount = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "5.00",
                                    },
                                    Quantity = "1",
                                    Tax = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "0.00",
                                    },
                                    Sku = "5158936",
                                },
                                new Item
                                {
                                    Name = "T-Shirt",
                                    UnitAmount = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "5.00",
                                    },
                                    Quantity = "1",
                                    Tax = new Money
                                    {
                                        CurrencyCode = "USD",
                                        MValue = "0.00",
                                    },
                                    Sku = "1457432",
                                },
                            },
                        },
                    },
                },
                PayPalRequestId = Guid.NewGuid().ToString(),
                Prefer = "return=representation",
            };
            ApiResponse<Order> orderDetails = await ordersController.OrdersCreateAsync(ordersCreateInput);
            // Test response code
            Assert.AreEqual(201, orderDetails.StatusCode, "Status should be 201");

            // capture order
            OrdersCaptureInput ordersCapture422Input = new OrdersCaptureInput
            {
                Id = orderDetails.Data.Id,
                Prefer = "return=representation",
                Body = new OrderCaptureRequest
                {
                    PaymentSource = new OrderCaptureRequestPaymentSource
                    {
                        Card = new CardRequest
                        {
                            Name = "John Doe",
                            Number = "4868719460707704",
                            Expiry = "2027-02",
                            BillingAddress = new Address
                            {
                                CountryCode = "US",
                                AddressLine1 = "2211 N First Street",
                                AdminArea2 = "San Jose",
                                AdminArea1 = "CA",
                                PostalCode = "95131",
                            },
                            Attributes = new CardAttributes
                            {
                                Verification = new CardVerification
                                {
                                    Method = CardVerificationMethod.SCAALWAYS,
                                },
                            },
                            ExperienceContext = new CardExperienceContext
                            {
                                ReturnUrl = "https://example.com/returnUrl",
                                CancelUrl = "https://example.com/cancelUrl",
                            },
                        },
                    },
                },
            };
            try
            {
                ApiResponse<Order> captureSuccessResponse = await ordersController.OrdersCaptureAsync(ordersCapture422Input);
                // test response code
                Assert.AreEqual(201, captureSuccessResponse.StatusCode, "Status should be 201");
            }
            catch (ErrorException capture422ErrorException)
            {
                // test response code
                Assert.AreEqual(422, HttpCallBack.Response.StatusCode, "Status should be 422");
                // Complete Helios Verification
                var playwright = new PlaywrightFlows();
                bool isVerificationComplete = await playwright.CompleteHeliosVerification(capture422ErrorException.Links[0].Href, false);
                Assert.IsTrue(isVerificationComplete);
            }

            // Get Order Details
            OrdersGetInput ordersGetInput = new OrdersGetInput
            {
                Id = orderDetails.Data.Id,
            };
            ApiResponse<Order> result = await ordersController.OrdersGetAsync(ordersGetInput);
            // test response code
            Assert.AreEqual(200, result.StatusCode, "Status should be 200");

            // capture order
            OrdersCaptureInput ordersCaptureInput = new OrdersCaptureInput
            {
                Id = orderDetails.Data.Id,
                Prefer = "return=representation",
            };
            ApiResponse<Order> captureResponse = await ordersController.OrdersCaptureAsync(ordersCaptureInput);
            // test response code
            Assert.AreEqual(201, captureResponse.StatusCode, "Status should be 201");

        }

    }
}