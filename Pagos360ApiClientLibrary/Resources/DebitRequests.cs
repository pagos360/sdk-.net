using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pagos360ApiClientLibrary.Model;
using Pagos360ApiClientLibrary.Services;

namespace Pagos360ApiClientLibrary.Resources
{
    public class DebitRequests
    {
        public static PaginationResult<DebitRequest> ListDebitRequests(string pPath, string pAPIKey)
        {
            return ApiRestServices.ListObjects<DebitRequest>(pPath + "/debit-request", pAPIKey);
        }

        public static PaginationResult<DebitRequest> ListDebitRequests(string pPath, string pAPIKey, string pExternalReference)
        {
            return ApiRestServices.ListObjects<DebitRequest>(pPath + "/debit-request?external_reference=" + pExternalReference, pAPIKey);
        }

        public static DebitRequest CreateDebitRequest(string pPath, string pAPIKey, DebitRequest pDebitRequest)
        {
            return ApiRestServices.CreateObject<DebitRequest>(pPath + "/debit-request", pAPIKey, "debit_request", pDebitRequest);
        }

        public static DebitRequest GetDebitRequest(string pPath, string pAPIKey, int pId)
        {
            return ApiRestServices.GetObject<DebitRequest>(pPath + "/debit-request", pAPIKey, pId);
        }

        public static DebitRequest CancelDebitRequest(string pPath, string pAPIKey, int pId)
        {
            return ApiRestServices.CancelObject<DebitRequest>(pPath + "/debit-request", pAPIKey, pId);
        }

        public static string GetNextBusinessDay(string pPath, string pAPIKey, BusinessDay pDebitRequest)
        {
            return ApiRestServices.GetFirstDudeDate<BusinessDay>(pPath + "/validator/next-business-day", pAPIKey, "next_business_day", pDebitRequest);
        }
    }
}
