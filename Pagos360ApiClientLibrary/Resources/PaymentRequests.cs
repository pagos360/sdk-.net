using System;
using Pagos360ApiClientLibrary.Model;
using Pagos360ApiClientLibrary.Services;

namespace Pagos360ApiClientLibrary.Resources
{
    public class PaymentRequests
    {
        public static PaginationResult<PaymentRequest> ListPaymentRequests(string pPath, string pAPIKey)
        {
            try { 
                return ApiRestServices.ListObjects<PaymentRequest>(pPath + "/payment-request", pAPIKey);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static PaymentRequest CreatePaymentRequest(string pPath, string pAPIKey, PaymentRequest pPaymentRequest)
        {
            try { 
                return ApiRestServices.CreateObject<PaymentRequest>(pPath + "/payment-request", pAPIKey, "payment_request", pPaymentRequest);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static PaymentRequest GetPaymentRequest(string pPath, string pAPIKey, int pPaymentId)
        {
            try { 
                return ApiRestServices.GetObject<PaymentRequest>(pPath + "/payment-request", pAPIKey, pPaymentId);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }
    }
}
