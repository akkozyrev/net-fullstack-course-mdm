using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using Server.Infrastructure;

namespace Server.Models.Dto
{
    public class OutputDataDtoCard
    {
        [DataContract]
        public class CardSet
        {
            [DataMember]
            public string CardNumber { get; set; }

            [DataMember]
            public string CardName { get; set; }

            [DataMember]
            public DateTime CardExpireDate { get; set; }

            [DataMember]
            public decimal CardAmount { get; set; }

            [DataMember]
            public Currency CardCurrency { get; set; }
        }

        [DataMember]
        public List<CardSet> CardSets { get; set; } = new List<CardSet>();
    }
}