﻿using System.Configuration;
// ReSharper disable UnusedMember.Global

namespace Uol.PagSeguro.Configuration
{
    /// <inheritdoc />
    public class UrlsElement : ConfigurationElement
    {
        private const string PaymentKey = "Payment";
        private const string PaymentRedirectKey = "PaymentRedirect";
        private const string NotificationKey = "Notification";
        private const string SearchKey = "Search";
        private const string SearchAbandonedKey = "SearchAbandoned";
        private const string CancelKey = "Cancel";
        private const string RefundKey = "Refund";
        private const string PreApprovalKey = "PreApproval";
        private const string DirectPaymentKey = "DirectPayment";
        private const string AuthorizationKey = "Authorization";

        /// <summary>
        /// 
        /// </summary>
        [ConfigurationProperty(PaymentKey, IsRequired = true)]
        public UrlElement Payment
        {
            get => (UrlElement)this[PaymentKey];
            set => this[PaymentKey] = value;
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigurationProperty(PaymentRedirectKey, IsRequired = true)]
        public UrlElement PaymentRedirect
        {
            get => (UrlElement)this[PaymentRedirectKey];
            set => this[PaymentRedirectKey] = value;
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigurationProperty(NotificationKey, IsRequired = true)]
        public UrlElement Notification
        {
            get => (UrlElement)this[NotificationKey];
            set => this[NotificationKey] = value;
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigurationProperty(SearchKey, IsRequired = true)]
        public UrlElement Search
        {
            get => (UrlElement)this[SearchKey];
            set => this[SearchKey] = value;
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigurationProperty(SearchAbandonedKey, IsRequired = true)]
        public UrlElement SearchAbandoned
        {
            get => (UrlElement)this[SearchAbandonedKey];
            set => this[SearchAbandonedKey] = value;
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigurationProperty(CancelKey, IsRequired = true)]
        public UrlElement Cancel
        {
            get => (UrlElement)this[CancelKey];
            set => this[CancelKey] = value;
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigurationProperty(RefundKey, IsRequired = true)]
        public UrlElement Refund
        {
            get => (UrlElement)this[RefundKey];
            set => this[RefundKey] = value;
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigurationProperty(PreApprovalKey, IsRequired = true)]
        public PreApprovalElement PreApproval
        {
            get => (PreApprovalElement)this[PreApprovalKey];
            set => this[PreApprovalKey] = value;
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigurationProperty(DirectPaymentKey, IsRequired = true)]
        public DirectPaymentElement DirectPayment
        {
            get => (DirectPaymentElement)this[DirectPaymentKey];
            set => this[DirectPaymentKey] = value;
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigurationProperty(AuthorizationKey, IsRequired = true)]
        public AuthorizationElement Authorization
        {
            get => (AuthorizationElement)this[AuthorizationKey];
            set => this[AuthorizationKey] = value;
        }
    }
}
