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
            try { 
                return ApiRestServices.ListObjects<CardDebitRequest>(pPath + "/card-debit-request", pAPIKey);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static PaginationResult<CardDebitRequest> ListDebitRequests(string pPath, string pAPIKey, string pExternalReference)
        {
            try { 
                return ApiRestServices.ListObjects<CardDebitRequest>(pPath + "/card-debit-request?external_reference=" + pExternalReference, pAPIKey);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static CardDebitRequest CreateDebitRequest(string pPath, string pAPIKey, CardDebitRequest pDebitRequest)
        {
            try { 
                return ApiRestServices.CreateObject<CardDebitRequest>(pPath + "/card-debit-request", pAPIKey, "card_debit_request", pDebitRequest);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static CardDebitRequest GetCardDebitRequest(string pPath, string pAPIKey, int pId)
        {
            try { 
                return ApiRestServices.GetObject<CardDebitRequest>(pPath + "/card-debit-request", pAPIKey, pId);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static CardDebitRequest CancelDebitRequest(string pPath, string pAPIKey, int pId)
        {
            try { 
                return ApiRestServices.CancelObject<CardDebitRequest>(pPath + "/card-debit-request", pAPIKey, pId);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }
    }
}
