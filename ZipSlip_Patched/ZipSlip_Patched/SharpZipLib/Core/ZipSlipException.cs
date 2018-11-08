using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZipSlip_Patched.SharpZipLib.Core
{
    public class ZipSlipException : Exception
    {
        public ZipSlipException() : base("An invalid name was specified")
        {
        }

        public ZipSlipException(string message) : base(message)
        {
        }
    }
}