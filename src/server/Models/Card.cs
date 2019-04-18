using System;
using System.Collections.Generic;
using Server.Infrastructure;
using Server.Services.Checkers;

namespace Server.Models
{
    /// <summary>
    /// Card domain model
    /// </summary>
    public class Card
    {
        public Card(string cardNumber)
        {
            if (string.IsNullOrWhiteSpace(cardNumber))
                throw new Exception("Card number is null or empty");

            CardChecker cardChecker = new CardChecker();
            if(!cardChecker.CheckCardNumber(cardNumber))
                throw new Exception("Card number is incorrect");

            CardNumber = cardNumber;
        }
        /// <summary>
        /// Card number.
        /// </summary>
        /// <returns>string card number representation</returns>
        public string CardNumber { get; set; }

        /// <summary>
        /// Short name of the cards
        /// </summary>
        public string CardName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public DateTime CardExpireDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string CardCVV { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public decimal CardAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        public Currency CardCurrency { get; set; }

        /// <summary>
        /// Getter card transaction list
        /// </summary>
        public List<Transaction> Transactions { get; } = new List<Transaction>();
    }
}