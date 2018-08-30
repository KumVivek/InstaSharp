using InstaSharp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstaSharp.Response
{
    public class CreateRefundResponce
    {
        public Refund refund { get; set; }
        public bool success { get; set; }
    }
}
