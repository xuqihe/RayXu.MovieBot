using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using RayXu.MovieBot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RayXu.MovieBot.Dialogs
{
    [LuisModel("62181c6c-c55c-40ef-b850-eabc5d88b0ae", "1a70f030b9484b6ab90bb1436017652d")]
    [Serializable]
    public class MovieDialog : LuisDialog<object>
    {
        internal MovieDialog()
        { }

        [LuisIntent("")]
        [LuisIntent(ConstValue.NoneIntent)]
        public async Task None(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(ConstValue.NoneReply);
            context.Wait(MessageReceived);
        }


        [LuisIntent(ConstValue.GreetingIntent)]
        public async Task Greeting(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(ConstValue.GreetingReply);
            context.Wait(MessageReceived);
        }

        [LuisIntent(ConstValue.FindMovieIntent)]
        public async Task FindMovie(IDialogContext context, LuisResult result)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var entity in result.Entities)
            {
                sb.Append(entity.Type + "*" + entity.Entity + "|");
            }


            await context.PostAsync(sb.ToString());
            context.Wait(MessageReceived);
        }
    }
}