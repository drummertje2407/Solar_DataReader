using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Solar_DataReader
{
    public class DataHandler
    {
        
        public void ProcessData(string data)
        {
           // Form1.instance.Records.Add(Form1.instance.Dataset);

            string[] buffer = data.Split('|');
            foreach (string str in buffer)
            {
                string[] SingleDataBlock = str.Split(':');
                
                switch (SingleDataBlock[0])
                {
                    case "gpsfix":
                        try
                        {
                            if (double.Parse(SingleDataBlock[1]) > 0)
                            { Form1.instance.Dataset.GPS_fix = true; }
                        }
                        catch (Exception) { }
                        break;

                    case "lon":
                        try { Form1.instance.Dataset.Lontitude = double.Parse(SingleDataBlock[1]); }
                        catch (Exception) { }
                        break;

                    case "lat":
                        try { Form1.instance.Dataset.Latitude = double.Parse(SingleDataBlock[1]); }
                        catch (Exception) { }
                        break;

                    case "speed":
                        try { Form1.instance.Dataset.Speed = Math.Round(double.Parse(SingleDataBlock[1]) / 3.6); }
                        catch (Exception) { }
                        break;
                        
                    case "mppt1_v":
                        try { Form1.instance.Dataset.U_MPPT_1 = double.Parse(SingleDataBlock[1])/1000; }
                        catch (Exception) { }
                        break;

                    case "mppt1_ppv":
                        try { Form1.instance.Dataset.P_PV_1 = double.Parse(SingleDataBlock[1]) / 1000; }
                        catch (Exception) { }
                        break;

                    case "mppt1_i":
                        try { Form1.instance.Dataset.I_MPPT_1 = double.Parse(SingleDataBlock[1]); }
                        catch (Exception) { }
                        break;

                    case "mppt1_err":
                        try { Form1.instance.Dataset.ERR_MPPT_1 = Int32.Parse(SingleDataBlock[1]); }
                        catch (Exception) { }
                        break;

                    case "mppt1_vpv":
                        try { Form1.instance.Dataset.U_MPPT_PV_1 = Math.Round(double.Parse(SingleDataBlock[1])/1000); }
                        catch (Exception) { }
                        break;

                    case "mppt2_v":
                        try { Form1.instance.Dataset.U_MPPT_2 = double.Parse(SingleDataBlock[1])/1000; }
                        catch (Exception) { }
                        break;

                    case "mppt2_ppv":
                        try { Form1.instance.Dataset.P_PV_2 = double.Parse(SingleDataBlock[1]); }
                        catch (Exception) { }
                        break;

                    case "mppt2_i":
                        try { Form1.instance.Dataset.I_MPPT_2 = double.Parse(SingleDataBlock[1]); }
                        catch (Exception) { }
                        break;

                    case "mppt2_err":
                        try { Form1.instance.Dataset.ERR_MPPT_2 = Int32.Parse(SingleDataBlock[1]); }
                        catch (Exception) { }
                        break;

                    case "mppt2_vpv":
                        try { Form1.instance.Dataset.U_MPPT_PV_2 = double.Parse(SingleDataBlock[1]); }
                        catch (Exception) { }
                        break;

                    case "time":
                        try { Form1.instance.Dataset.Time = float.Parse(SingleDataBlock[1]); }
                        catch (Exception) { }
                        break;
                    case "bmv_soc":
                        try { Form1.instance.Dataset.SOC = Math.Round(double.Parse(SingleDataBlock[1])/10); }
                        catch (Exception) { }
                        break;

                    case "bmv_v":
                        try { Form1.instance.Dataset.U_BAT = Math.Round(double.Parse(SingleDataBlock[1]) / 1000); }
                        catch (Exception) { }
                        break;

                    case "bmv_i":
                        try { Form1.instance.Dataset.U_BAT = Math.Round(double.Parse(SingleDataBlock[1]) / 1000); }
                        catch (Exception) { }
                        break;

                    case "bmv_p":
                        try { Form1.instance.Dataset.P_Res = Math.Round(double.Parse(SingleDataBlock[1])); }
                        catch (Exception) { }
                        break;





                }
                  
            }
        }

    }
}
