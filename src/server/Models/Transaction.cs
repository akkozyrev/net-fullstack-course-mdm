using System;
using Server.Infrastructure;

namespace Server.Models
{
    /// <summary>
    /// Transaction domain model
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Transaction Number
        /// </summary>
        /// <returns> string number of transaction</returns>
        public string TransactionNumber {get; set;}

        /// <summary>
        /// Transaction Description
        /// </summary>
        /// <returns>string transaction Description</returns>
        public string TransactionDescription {get; set;}
        
        /// <summary>
        /// Transaction Date
        /// </summary>
        /// <value></value>
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// Card number to be debited.
        /// </summary>
        /// <returns>string card number to be debited</returns>
        public string CardNumberFrom { get; set; }

        /// <summary>
        /// Card number for enrollment.
        /// </summary>
        /// <returns>string card number for enrollment</returns>
        public string CardNumberTo { get; set; }

        /// <summary>
        /// Amount to be debited
        /// </summary>
        /// <returns>decimal amount to be debited</returns>
        public decimal AmountFrom { get; set; }//

        /// <summary>
        /// Amount for enrollment
        /// </summary>
        /// <returns>decimal amount for enrollment</returns>
        public decimal AmountTo { get; set; }//
        
        /// <summary>
        /// Currency of amount to be debited
        /// </summary>
        /// <returns>currency of amount to be debited</returns>
        public Currency CurrencyFrom { get; set; }//

        /// <summary>
        /// Currency of amount for enrollment
        /// </summary>
        /// <returns>currency of amount for enrollment</returns>
        public Currency CurrencyTo { get; set; }
    }
}