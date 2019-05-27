using System;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Media;

using CsvHelper;

using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;

using Discord;
using Discord.WebSocket;
using System.Collections.Generic;

namespace Solar_DataReader
{
    public partial class Form1 : Form
    {
      
        public static Form1 instance;
        public Timer Timer { get; set; }
        public Timer Timer2;
        public DataHolder Dataset = new DataHolder();

        private DiscordBot bot;

        public List<DataHolder> Records = new List<DataHolder>();


        public Form1()
        {
            InitializeComponent();
            instance = this;

            #region Initialize gauges
            solidGaugeP_solar.Uses360Mode = false;
            solidGaugeP_solar.From = 0;
            solidGaugeP_solar.To = 100;


            solidGaugeP_motor.Uses360Mode = false;
            solidGaugeP_motor.From = 0;
            solidGaugeP_motor.To = -100;
            solidGaugeP_motor.FromColor = Colors.Green;
            solidGaugeP_motor.ToColor = Colors.Red;

            solidGaugeSpeed.Uses360Mode = false;
            solidGaugeSpeed.From = 0;
            solidGaugeSpeed.To = 20;
            solidGaugeSpeed.Text = "Speed km/h";

            solidGaugeSOC.Uses360Mode = false;
            solidGaugeSOC.From = 0;
            solidGaugeSOC.To = 100;
            solidGaugeSOC.Text = "SOC%";
            

            solidGauge_I_BAT.Uses360Mode = false;
            solidGauge_I_BAT.From = 0;
            solidGauge_I_BAT.To = 150;

            solidGauge_MPPT1_I.Uses360Mode = false;
            solidGauge_MPPT1_I.From = 0;
            solidGauge_MPPT1_I.To = 50;

            solidGauge_MPPT1_U.Uses360Mode = false;
            solidGauge_MPPT1_U.From = 0;
            solidGauge_MPPT1_U.To = 60;

            solidGauge_MPPT2_I.Uses360Mode = false;
            solidGauge_MPPT2_I.From = 0;
            solidGauge_MPPT2_I.To = 50;

            solidGauge_MPPT2_U.Uses360Mode = false;
            solidGauge_MPPT2_U.From = 0;
            solidGauge_MPPT2_U.To = 60;
            #endregion

            Timer = new Timer{Interval = 10};
            Timer.Tick += Update_GUI;
            Timer.Start();

            Timer2 = new Timer { Interval = 1000 };
            Timer2.Tick += Savedata;
            Timer2.Start();
        }

        private void Savedata(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                if (Dataset != null)
                {
                    try
                    {
                        #region Savedata
                        using (var writer = new StreamWriter(@"C:\Users\Jelte\Documents\data.csv"))
                        using (var csvWriter = new CsvWriter(writer))
                        {
                            csvWriter.WriteRecord(Dataset);
                        }
                        #endregion
                    }
                    catch (Exception ex) { MessageBox.Show("Error: Cannot acces data.txt \r\n" + ex.Message.ToString(), "ERROR"); return; }


                }
            }
           
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
            solidGaugeP_motor.Value = Dataset.P_motor;
            solidGaugeSpeed.Value = Dataset.Speed;
            solidGaugeSOC.Value = Dataset.SOC;
            solidGaugeP_solar.Value = Dataset.P_PV;
            solidGauge_MPPT1_I.Value = Dataset.I_MPPT_1;
            solidGauge_MPPT1_U.Value = Dataset.U_MPPT_1;
            solidGauge_MPPT2_I.Value = Dataset.I_MPPT_2;
            solidGauge_MPPT2_U.Value = Dataset.U_MPPT_2;
            solidGauge_I_BAT.Value = Dataset.I_res;

            if (Dataset.GPS_fix)
                pictureBox1.Image = Solar_DataReader.Properties.Resources.Trafficlight_green_icon;
            else
                pictureBox1.Image = Solar_DataReader.Properties.Resources.Erroricon404;
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
