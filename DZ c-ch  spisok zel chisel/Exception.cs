using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_ch__spisok_zel_chisel
{
    public class NoPositiveNumbersException: Exception
    {
        string Message;
        public NoPositiveNumbersException(string message):base(message) 
        {
            Message = message;
            
        }
    }

    public class InvalidContactException : Exception 
    {
        string Message;
        public InvalidContactException(string message) : base(message)
        {
            Message = message;

        }



    }
}
