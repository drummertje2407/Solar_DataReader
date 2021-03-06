﻿

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
        DataHandler model = new DataHandler();
        [Command("Ping")]
        public async Task Ping()
        {
            var msg = await ReplyAsync("***Calculating ping...***");

            await ReplyAsync($"Pong! ***{msg.Timestamp.Millisecond - DateTime.Now.Millisecond}***ms");
            
            await msg.DeleteAsync();

        }

        [Command("Datasend")]
        public async Task Datasend(string Data)
        {
            
            model.ProcessData(Data);
        }
    }
}
