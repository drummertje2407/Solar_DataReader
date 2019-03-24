using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar_DataReader
{
   public class Commands : ModuleBase
    {
        [Command("Ping")]
        public async Task Ping()
        {
            var msg = await ReplyAsync("***Calculating ping...***");

            await ReplyAsync($"Pong! ***{msg.Timestamp.Millisecond - DateTime.Now.Millisecond}***ms");
            
            await msg.DeleteAsync();

        }

        [Command("datasend")]
        public async Task Datasend(string Speed, string coordinates, string V1, string V2, string I1, string I2, string BP)
        {

        }
    }
}
