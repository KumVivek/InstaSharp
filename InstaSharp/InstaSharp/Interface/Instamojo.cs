using InstaSharp.Model;
using InstaSharp.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstaSharp.Interface
{
    public interface IInstamojo
    {
        /**
         * Create a Payment Order request Create a Payment Order request response.
         *
         * @param paymentRequest the payment request
         * @return the create payment request response
         */
        CreatePaymentOrderResponse CreateNewPaymentRequest(PaymentOrder objPaymentRequest);

        /**
          * Get all your payment orders.
          *
          * @return the payment request status
          */
        PaymentOrderListResponse GetPaymentOrderList(PaymentOrderListRequest objPaymentOrderListRequest);

        /**
          * Get details of this payment order.
          *
          * @param strPaymentId        the payment id
          * @return the payment status
          */
        PaymentOrderDetailsResponse GetPaymentOrderDetails(string strOrderId);

        /**
          * Get details of this payment order of TransactionId
          *
          * @return the payment request list
          */
        PaymentOrderDetailsResponse GetPaymentOrderDetailsByTransactionId(string strTransactionId);

        /**
         * Create a Refund request.
         *
         * @return the Sucess
         */
        CreateRefundResponce CreateNewRefundRequest(Refund objRefund);
    }
}
