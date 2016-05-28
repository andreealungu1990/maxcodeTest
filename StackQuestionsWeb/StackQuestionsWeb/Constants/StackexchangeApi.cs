using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StackQuestionsWeb.Constants
{
    public static class StackexchangeApi
    {
        public const string Url = @"https://api.stackexchange.com/2.2/questions";
        public const string Order = "desc";
        public const string Sort = "votes";
        public const string Site = "stackoverflow";
        public const string Filter = "!FsaoAlyDgQYKf.29A3mLybMzWt";

    }
}