using System;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Media;

using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;

using Discord;
using Discord.WebSocket;

namespace Solar_DataReader
{
    public partial class Form1 : Form
    {
      
        public static Form1 instance;
        public Timer Timer { get; set; }

        private DiscordBot bot;

        public float Time { get; set; }
        public double Speed { get; set; }
        public double Lontitude { get; set; }
        public double Latitude { get; set; }
        public bool GPS_fix { get; set; }
        public int GPS_Quality { get; set; }

        public double P_PV { get; set; }
        public double P_Motor { get; set; }
        public double P_Res { get; set; }

        public double U_MPPT_PV_1 { get; set; }
        public double I_MPPT_PV_1 { get; set; }
        public double U_MPPT_1 { get; set; }
        public double I_MPPT_1 { get; set; }
        public int ERR_MPPT_1 { get; set; }

        public double U_PV_2 { get; set; }
        public double I_PV_2 { get; set; }
        public double U_MPPT_2 { get; set; }
        public double I_MPPT_2 { get; set; }
        public int ERR_MPPT_2 { get; set; }

        public double SOC { get; set; }


        public Form1()
        {
            InitializeComponent();
            instance = this;

            #region Initialize gauges
            solidGaugeP_solar.Uses360Mode = false;
            solidGaugeP_solar.From = 0;
            solidGaugeP_solar.To = 100;
            solidGaugeP_solar.FromColor = Colors.Red;
            solidGaugeP_solar.ToColor = Colors.Green;

            solidGaugeP_motor.Uses360Mode = false;
            solidGaugeP_motor.From = 0;
            solidGaugeP_motor.To = 100;
            solidGaugeP_solar.FromColor = Colors.Red;
            solidGaugeP_solar.ToColor = Colors.Green;

            solidGaugeSpeed.Uses360Mode = false;
            solidGaugeSpeed.From = 0;
            solidGaugeSpeed.To = 20;
            solidGaugeSpeed.Text = "Speed km/h";

            solidGaugeSOC.Uses360Mode = false;
            solidGaugeSOC.From = 0;
            solidGaugeSOC.To = 100;
            solidGaugeSOC.Text = "SOC%";
            #endregion

            Timer = new Timer{Interval = 10};
            Timer.Tick += Update_GUI;
            Timer.Start();
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

        private void Update_GUI(object sender, EventArgs e)
        {
            
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

        
    }
}
