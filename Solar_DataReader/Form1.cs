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
        DiscordSocketClient Client;
        public static Form1 instance;

        public Form1()
        {
            InitializeComponent();
            instance = this;
        }
        public void Log(string msg)
        {
            Console_output.AppendText(msg + Environment.NewLine);
        }

        private async void Btn_Connect_Click(object sender, EventArgs e)
        {
            
            string Token = "";
            try
            {
                #region GetToken

                using (var Stream = new FileStream(@"C:\Windows\Temp\SolarData\Token.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
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
                
            }
            catch (Exception ex) { MessageBox.Show("Error: Cannot connect your Bot to the internet \r\n" + ex.Message.ToString(), "ERROR"); return; }

            

        }

        
        

        private void changeTokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Token =  Interaction.InputBox("Type in your token: ", "Input", "Default Text");
            try { File.WriteAllText(@"C:\Windows\Temp\SolarData\Token.txt", Token); }
            catch (UnauthorizedAccessException ex) { MessageBox.Show("Error: Cannot acces the Token file \r\n" + ex.Message.ToString(), "ERROR"); return; }
            catch(Exception ex) { MessageBox.Show("Error: " + ex.Message.ToString(), "ERROR"); return; }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
