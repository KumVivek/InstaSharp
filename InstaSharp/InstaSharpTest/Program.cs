using InstaSharp;
using InstaSharp.Exceptions;
using InstaSharp.Interface;
using InstaSharp.Model;
using InstaSharp.Response;
using System;
using System.IO;
using System.Net;

namespace InstaSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            string Insta_client_id = "test_wFoKMDRhHHmehzxtrH3B01KfwapTWC6W1oB",
                   Insta_client_secret = "test_FsfZhIaMsGgb5XqsyNtDBEqM8D28ZIigmgawLJggQdwgVlt4IxGAaklnotRxfPbHDNiJ1cot9xhZmRgo5Fj7aQwqmeXMFYviU2ajH8r70Cvi59ocZ7qTd7aiZPJ",
                   Insta_Endpoint = InstamojoConstants.INSTAMOJO_API_ENDPOINT,
                   Insta_Auth_Endpoint = InstamojoConstants.INSTAMOJO_AUTH_ENDPOINT;
            try
            {
                IInstamojo objClass = InstamojoImplementation.getApi(Insta_client_id, Insta_client_secret, Insta_Endpoint, Insta_Auth_Endpoint);

                # region   1. Create Payment Order
                //  Create Payment Order
                //PaymentOrder objPaymentRequest = new PaymentOrder();
                ////Required POST parameters
                //objPaymentRequest.name = "Vivek";
                //objPaymentRequest.email = "foo@example.com";
                //objPaymentRequest.phone = "9969156561";
                //objPaymentRequest.amount = 9;
                //objPaymentRequest.currency = "INR";
                //objPaymentRequest.description = "";
                //objPaymentRequest.webhook_url = "https://your.server.com/webhook";
                //string randomName = Path.GetRandomFileName();
                //randomName = randomName.Replace(".", string.Empty);
                //objPaymentRequest.transaction_id = Guid.NewGuid().ToString();

                //objPaymentRequest.redirect_url = "https://swaggerhub.com/api/saich/pay-with-instamojo/1.0.0";
                ////Extra POST parameters 

                //if (objPaymentRequest.validate())
                //{

                //    if (objPaymentRequest.nameInvalid)
                //    {
                //        Console.Write("Name is not valid");
                //    }

                //}
                //else
                //{
                //    try
                //    {
                //        CreatePaymentOrderResponse objPaymentResponse = objClass.CreateNewPaymentRequest(objPaymentRequest);
                //        Console.Write("Order Id = " + objPaymentResponse.order.id);
                //    }
                //    catch (ArgumentNullException ex)
                //    {
                //        Console.Write(ex.Message);
                //    }
                //    catch (WebException ex)
                //    {
                //        Console.Write(ex.Message);
                //    }
                //    catch (IOException ex)
                //    {
                //        Console.Write(ex.Message);
                //    }
                //    catch (InvalidPaymentOrderException ex)
                //    {
                //        Console.Write(ex.Message);
                //    }
                //    catch (ConnectionException ex)
                //    {
                //        Console.Write(ex.Message);
                //    }
                //    catch (BaseException ex)
                //    {
                //        Console.Write(ex.Message);
                //    }
                //    catch (Exception ex)
                //    {
                //        Console.Write("Error:" + ex.Message);
                //    }
                //}
                #endregion

                # region   2. Get All your Payment Orders List
                //  Get All your Payment Orders
                //try
                //{
                //    PaymentOrderListRequest objPaymentOrderListRequest = new PaymentOrderListRequest();
                //    //Optional Parameters
                //    objPaymentOrderListRequest.limit = 21;
                //    objPaymentOrderListRequest.page = 3;

                //    PaymentOrderListResponse objPaymentRequestStatusResponse = objClass.getPaymentOrderList(objPaymentOrderListRequest);
                //    foreach (var item in objPaymentRequestStatusResponse.orders)
                //    {
                //        Console.WriteLine(item.email + item.description + item.amount);
                //    }
                //    Console.Write("Order List = " + objPaymentRequestStatusResponse.orders.Count());
                //}
                //catch (ArgumentNullException ex)
                //{
                //    Console.Write(ex.Message);
                //}
                //catch (WebException ex)
                //{
                //    Console.Write(ex.Message);
                //}
                //catch (Exception ex)
                //{
                //    Console.Write("Error:" + ex.Message);
                //}
                #endregion

                # region   3. Get details of this payment order Using Order Id
                ////  Get details of this payment order
                //try
                //{
                //    PaymentOrderDetailsResponse objPaymentRequestDetailsResponse = objClass.getPaymentOrderDetails("3189cff7c68245bface8915cac1f"); //"3189cff7c68245bface8915cac1f89df");
                //    Console.Write("Transaction Id = " + objPaymentRequestDetailsResponse.transaction_id);
                //}
                //catch (ArgumentNullException ex)
                //{
                //    Console.Write(ex.Message);
                //}
                //catch (WebException ex)
                //{
                //    Console.Write(ex.Message);
                //}
                //catch (Exception ex)
                //{
                //    Console.Write("Error:" + ex.Message);
                //}
                #endregion

                # region   4. Get details of this payment order Using TransactionId
                ////  Get details of this payment order Using TransactionId
                //try
                //{
                //    PaymentOrderDetailsResponse objPaymentRequestDetailsResponse = objClass.getPaymentOrderDetailsByTransactionId("test1");
                //    Console.Write("Transaction Id = " + objPaymentRequestDetailsResponse.transaction_id);
                //}
                //catch (ArgumentNullException ex)
                //{
                //    Console.Write(ex.Message);
                //}
                //catch (WebException ex)
                //{
                //    Console.Write(ex.Message);
                //}
                //catch (Exception ex)
                //{
                //    Console.Write("Error:" + ex.Message);
                //}
                #endregion

                # region   5. Create Refund
                //  Create Payment Order
                Refund objRefundRequest = new Refund();
                //Required POST parameters
                //objPaymentRequest.name = "ABCD";
                objRefundRequest.payment_id = "MOJO8830005N70918763";
                objRefundRequest.type = "TNR";
                objRefundRequest.body = "abcd";
                objRefundRequest.refund_amount = 9;

                if (objRefundRequest.validate())
                {
                    if (objRefundRequest.payment_idInvalid)
                    {
                        Console.Write("payment_id is not valid");
                    }
                }
                else
                {
                    try
                    {
                        CreateRefundResponce objRefundResponse = objClass.CreateNewRefundRequest(objRefundRequest);
                        Console.Write("Refund Id = " + objRefundResponse.refund.id);
                    }
                    catch (ArgumentNullException ex)
                    {
                        Console.Write(ex.Message);
                    }
                    catch (WebException ex)
                    {
                        Console.Write(ex.Message);
                    }
                    catch (IOException ex)
                    {
                        Console.Write(ex.Message);
                    }
                    catch (InvalidPaymentOrderException ex)
                    {
                        Console.Write(ex.Message);
                    }
                    catch (ConnectionException ex)
                    {
                        Console.Write(ex.Message);
                    }
                    catch (BaseException ex)
                    {
                        Console.Write(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.Write("Error:" + ex.Message);
                    }
                }
                #endregion

               // Application.Run();

            }
            catch (BaseException ex)
            {
                Console.Write("CustomException" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.Write("Exception" + ex.Message);
            }
        }
    }
}
