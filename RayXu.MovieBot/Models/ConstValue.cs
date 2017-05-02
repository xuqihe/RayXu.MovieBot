using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RayXu.MovieBot.Models
{
    public class ConstValue
    {
        #region Intent
        public const string GreetingIntent = "greeting";
        public const string NoneIntent = "None";

        public const string FindMovieIntent = "find_movie";
        #endregion

        #region Default Reply
        public const string GreetingReply = "您好，我是小影，您的影视助手！";
        public const string NoneReply = "对不起，我还不能回答这个问题！";
        #endregion
    }
}