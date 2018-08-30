using InstaSharp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstaSharp.Response
{
    public class PaymentOrderListResponse
    {
        public int? count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public Order[] orders { get; set; }

    }
}
