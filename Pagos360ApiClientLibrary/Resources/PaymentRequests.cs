using Pagos360ApiClientLibrary.Model;
using Pagos360ApiClientLibrary.Services;

namespace Pagos360ApiClientLibrary.Resources
{
    public class PaymentRequests
    {
        public static PaginationResult<PaymentRequest> ListPaymentRequests(string pPath, string pAPIKey)
        {
            return ApiRestServices.ListObjects<PaymentRequest>(pPath + "/payment-request", pAPIKey);
        }

        public static PaymentRequest CreatePaymentRequest(string pPath, string pAPIKey, PaymentRequest pPaymentRequest)
        {
            return ApiRestServices.CreateObject<PaymentRequest>(pPath + "/payment-request", pAPIKey, "payment_request", pPaymentRequest);
        }

        public static PaymentRequest GetPaymentRequest(string pPath, string pAPIKey, int pPaymentId)
        {
            return ApiRestServices.GetObject<PaymentRequest>(pPath + "/payment-request", pAPIKey, pPaymentId);
        }
    }
}
