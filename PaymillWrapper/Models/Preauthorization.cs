﻿using System.Runtime.Serialization;

namespace PaymillWrapper.Models
{
    /// <summary>
    /// A transaction is the charging of a credit card or a direct debit.
    /// </summary>
    public class Preauthorization : BaseModel, IQueryableAmount, IQueryableClient, IQueryablePayment
    {
        /// <summary>
        /// Amount of this transaction
        /// </summary>
        [DataMember(Name = "Amount")]
        public double Amount { get; set; }

        /// <summary>
        /// Formatted amount of this transaction
        /// </summary>
        [IgnoreDataMember]
        public double AmountFormatted
        {
            get
            {
                return Amount / 100;
            }
        }

        /// <summary>
        /// Whether this transaction was issued while being in live mode or not
        /// </summary>
        [DataMember(Name = "Livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Creditcard-object or directdebit-object
        /// </summary>
        [DataMember(Name = "Payment")]
        public Payment Payment { get; set; }

        /// <summary>
        /// Client-object
        /// </summary>
        [DataMember(Name = "Client")]
        public Client Client { get; set; }

        /// <summary>
        /// ISO 4217 formatted currency code
        /// </summary>
        [DataMember(Name = "Currency")]
        public string Currency { get; set; }

        /// <summary>
        /// A token generated through JavaScript-Bridge Paymill
        /// </summary>
        [DataMember(Name = "Token")]
        public string Token { get; set; }

    }

    public enum PreauthorizationStatus
    {
        Open,
        Pending,
        Closed,
        Failed, 
        Deleted,
        Preauth
    }
}