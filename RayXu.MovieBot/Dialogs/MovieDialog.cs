using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using RayXu.MovieBot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace RayXu.MovieBot.Dialogs
{
    [LuisModel("62181c6c-c55c-40ef-b850-eabc5d88b0ae", "d16eb85b04964130b98d9aabed8b34b7")]
    [Serializable]
    public class MovieDialog : LuisDialog<object>
    {
        internal MovieDialog()
        { }


        [LuisIntent(ConstValue.GreetingIntent)]
        public async Task Greeting(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(ConstValue.GreetingReply);
            context.Wait(MessageReceived);
        }
    }
}