using Pagos360ApiClientLibrary.Model;
using Pagos360ApiClientLibrary.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pagos360ApiClientLibrary.Resources
{
    public class CardDebitRequests
    {
        public static PaginationResult<CardDebitRequest> ListDebitRequests(string pPath, string pAPIKey)
        {
            return ApiRestServices.ListObjects<CardDebitRequest>(pPath + "/card-debit-request", pAPIKey);
        }

        public static PaginationResult<CardDebitRequest> ListDebitRequests(string pPath, string pAPIKey, string pExternalReference)
        {
            return ApiRestServices.ListObjects<CardDebitRequest>(pPath + "/card-debit-request?external_reference=" + pExternalReference, pAPIKey);
        }

        public static CardDebitRequest CreateDebitRequest(string pPath, string pAPIKey, CardDebitRequest pDebitRequest)
        {
            return ApiRestServices.CreateObject<CardDebitRequest>(pPath + "/card-debit-request", pAPIKey, "card_debit_request", pDebitRequest);
        }

        public static CardDebitRequest CancelDebitRequest(string pPath, string pAPIKey, int pId)
        {
            return ApiRestServices.CancelObject<CardDebitRequest>(pPath + "/card-debit-request", pAPIKey, pId);
        }
    }
}
