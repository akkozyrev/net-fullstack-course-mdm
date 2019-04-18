using System;
using System.Runtime.Serialization;

namespace Server.Models.Dto
{
    public class InputDataDtoUser
    {
        [DataContract]
        public class UserSet
        {
            [DataMember]
            public string UserName { get; set; }
        }
    }
}
