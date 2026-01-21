using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class CheckFields
    {
        public static bool Check_Register_Fields(string[] fields)
        {
            foreach (string field in fields)
            {
                if(field == string.Empty)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
