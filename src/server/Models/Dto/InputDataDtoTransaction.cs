using System;
using System.Runtime.Serialization;

namespace Server.Models.Dto
{
    public class InputDataDtoTransaction
    {
        [DataContract]
        public class TransactionSet
        {
            [DataMember]
            public string UserName { get; set; }
        }
    }
}
