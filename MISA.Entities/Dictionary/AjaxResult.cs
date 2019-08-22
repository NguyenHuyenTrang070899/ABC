using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MISA.WDT02.NTHTrang.Models
{
    public class AjaxResult
    {
        public bool Success { get; set; }
        public object Data { get; set; }
        public string Message { get; set; }

        public AjaxResult()
        {
            Success = true;
        }
    }
}