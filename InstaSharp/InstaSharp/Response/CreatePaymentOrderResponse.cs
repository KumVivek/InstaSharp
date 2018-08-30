using InstaSharp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstaSharp.Response
{
    public class CreatePaymentOrderResponse
    {
        public Order order { get; set; }
        public PaymentOptions payment_options { get; set; }
    }
}
