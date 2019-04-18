using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Server.Models.Dto
{
    public class InputDataDtoCard
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
            public string CardCVV { get; set; }
        }
        [DataMember]
        public List<CardSet> CardSets { get; set; } = new List<CardSet>();
    }
}
