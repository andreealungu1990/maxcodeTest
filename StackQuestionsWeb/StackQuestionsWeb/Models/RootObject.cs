using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace StackQuestionsWeb.Models
{
    [DataContract]
    public class RootObject
    {
        [DataMember(Name = "items")]
        public List<Item> Items { get; set; }
        [DataMember(Name = "has_more")]
        public bool HasMore { get; set; }
        [DataMember(Name = "total")]
        public int Total { get; set; }
    }
}