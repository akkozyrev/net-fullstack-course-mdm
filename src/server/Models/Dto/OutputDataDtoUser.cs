using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Server.Models.Dto
{
    public class OutputDataDtoUser
    {
        [DataContract]
        public class UserSet
        {
            [DataMember]
            public string UserName { get; set; }
        }
        [DataMember]
        public List<UserSet> UserSets { get; set; } = new List<UserSet>();
    }
}
