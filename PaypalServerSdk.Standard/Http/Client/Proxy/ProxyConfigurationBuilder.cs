// <copyright file="ProxyConfigurationBuilder.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Proxy;

namespace PaypalServerSdk.Standard.Http.Client.Proxy
{
    /// <summary>
    /// Represents the proxy server configurations for API calls.
    /// </summary>
    public class ProxyConfigurationBuilder
    {
        private string _address;
        private int _port = 8080;
        private string _user;
        private string _pass;
        private bool _tunnel;

        /// <summary>
        /// Sets the Address.
        /// </summary>
        /// <param name="address"></param>
        public ProxyConfigurationBuilder(string address)
        {
            _address = address;
        }

        /// <summary>
        /// Sets the Port.
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        public ProxyConfigurationBuilder Port(int port) 
        {
            _port = port;
             return this;
        }
        
        /// <summary>
        /// Sets the Auth.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public ProxyConfigurationBuilder Auth(string user, string pass)
        {
            _user = user;
            _pass = pass;
            return this;
        }
        
        /// <summary>
        /// Sets the Tunnel.
        /// </summary>
        /// <param name="tunnel"></param>
        /// <returns></returns>
        public ProxyConfigurationBuilder Tunnel(bool tunnel)
        {
            _tunnel = tunnel;
            return this;
        }

        internal CoreProxyConfiguration Build()
        {
            return new CoreProxyConfiguration(_address, _port, _user, _pass, _tunnel);
        }
    }
}
