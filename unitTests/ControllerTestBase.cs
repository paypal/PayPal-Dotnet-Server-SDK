// <copyright file="ControllerTestBase.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>


namespace unitTests
{
    using NUnit.Framework;
    using PaypalServerSDK.Standard;
    using PaypalServerSDK.Standard.Http.Client;

    /// <summary>
    /// ControllerTestBase Class.
    /// </summary>
    [TestFixture]
    public class ControllerTestBase
    {
        /// <summary>
        /// Assert precision.
        /// </summary>
        protected const double AssertPrecision = 0.1;

        /// <summary>
        /// Gets HttpCallBackHandler.
        /// </summary>
        internal HttpCallback HttpCallBack { get; private set; } = new HttpCallback();

        /// <summary>
        /// Gets PaypalServerSDKClient Client.
        /// </summary>
        protected PaypalServerSDKClient Client { get; private set; }

        /// <summary>
        /// Set up the client.
        /// </summary>
        [OneTimeSetUp]
        public void SetUp()
        {
            PaypalServerSDKClient config = PaypalServerSDKClient.CreateFromEnvironment();
            this.Client = config.ToBuilder()
                .HttpCallback(HttpCallBack)
                .Build();

        }
    }
}