using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace StackQuestionsWeb.Models
{
    [DataContract]
    public class Item
    {
        [DataMember(Name = "tags")]
        public List<string> Tags { get; set; }
      
        [DataMember(Name = "view_count")]
        public int ViewCount { get; set; }

        [DataMember(Name = "answer_count")]
        public int AnswerCount { get; set; }

        [DataMember(Name = "score")]
        public int Score { get; set; }

        [DataMember(Name = "creation_date")]
        public int CreationDate { get; set; }
      
        [DataMember(Name = "question_id")]
        public int QuestionId { get; set; }

        [DataMember(Name = "link")]
        public string Link { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "body")]
        public string Body { get; set; }

        [DataMember(Name = "share_link")]
        public string ShareLink { get; set; }
       
    }
}