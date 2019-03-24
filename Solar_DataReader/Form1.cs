using System;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

using Discord;
using Discord.WebSocket;

namespace Solar_DataReader
{
    public partial class Form1 : Form
    {
        
        public static Form1 instance;

        private DiscordBot bot;

        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        public void Log(string msg)
        {
            Console_output.Invoke(new Action(() => Console_output.AppendText(msg + Environment.NewLine))); 
            //some stackoverflow magic that prevend error, something to do with different threads.
            //https://www.codeproject.com/Questions/1007873/How-to-remove-System-InvalidOperationException
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {

            bot = new DiscordBot();

            string Token = "";
            try
            {
                #region GetToken

                var FileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Solardata"); //get apdata path
                Directory.CreateDirectory(FileName);                                                                  //if directory already exists, the line will be ignored.
                using (var Stream = new FileStream(Path.Combine(FileName,"Token.txt"), FileMode.OpenOrCreate, FileAccess.ReadWrite))
                using (var Readtoken = new StreamReader(Stream))
                {
                    Token = Readtoken.ReadToEnd();
                }

                #endregion
            }
            catch(FileNotFoundException ex) { MessageBox.Show("Error: The token is not yet created of deleted, please make a new one \r\n" + ex.Message.ToString(), "ERROR"); return; }
            catch (Exception ex) { MessageBox.Show("Error: Cannot acces Token.txt \r\n" + ex.Message.ToString(), "ERROR"); return; }
            

            try
            {
                bot.Run(Token);
            }
            catch (Exception ex) { MessageBox.Show("Error: Cannot connect your Bot to the internet \r\n" + ex.Message.ToString(), "ERROR"); return; }

            

        }

        
        

        private void changeTokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Token =  Interaction.InputBox("Type in your token: ", "Input");                                          //ask for new token
            var FileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Solardata"); //get apdata path
            Directory.CreateDirectory(FileName);                                                                            //if directory already exists, the line will be ignored.

            try { File.WriteAllText(Path.Combine(FileName,"Token.txt"), Token); }                                           //update or create Token.txt
            catch (UnauthorizedAccessException ex) { MessageBox.Show("Error: Cannot acces the Token file \r\n" + ex.Message.ToString(), "ERROR"); return; }
            catch(Exception ex) { MessageBox.Show("Error: " + ex.Message.ToString(), "ERROR"); return; }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
