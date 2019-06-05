using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;





namespace Solar_DataReader
{

    public class DataHolder
    {
        public float Time { get; set; }
        public double Speed { get; set; }
        public double Lontitude { get; set; }
        public double Latitude { get; set; }
        public bool GPS_fix { get; set; }
        public int GPS_Quality { get; set; }
        double p_pv;
        public double P_PV
        {
            get
            {
                return P_PV_1 + P_PV_2;
            }
            set
            {
                this.p_pv = value;
            }
        }
        double p_motor;
        public double P_motor
        {
            get
            {
                if (P_Res < 0)
                     return P_Res + P_PV;
                else
                    return P_Res - P_PV;
            }
            set
            {
                this.p_motor = value;
            }        
        }
       public double P_Res { get; set; }

        public double P_PV_1 { get; set; }
        public double U_MPPT_PV_1 { get; set; }
        public double I_MPPT_PV_1 { get; set; }
        public double U_MPPT_1 { get; set; }
        public double I_MPPT_1 { get; set; }
        public int ERR_MPPT_1 { get; set; }

        public double P_PV_2 { get; set; }
        public double U_MPPT_PV_2 { get; set; }
        public double I_MPPT_PV_2 { get; set; }
        public double U_MPPT_2 { get; set; }
        public double I_MPPT_2 { get; set; }
        public int ERR_MPPT_2 { get; set; }

        public double SOC { get; set; }
        public double U_BAT { get; set; }
        public double I_res { get; set; }

        

    }

    
}