using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace Service
{
    public class Alter_Mounth
    {
        public static string Alter()
        {
            DateTime time = DateTime.Now;

            if (time.Day >= 1 && time.Day <= 5)
            {
                string after_mounth_name = time.AddMonths(-1).ToString("MMMM", new CultureInfo("pt-BR"));
                return after_mounth_name.ToUpper();
            }

            string mounth = time.ToString("MMMM", new CultureInfo("pt-BR"));
            return mounth.ToUpper();
        }
    }
}
