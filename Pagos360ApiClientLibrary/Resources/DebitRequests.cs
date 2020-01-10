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
            try { 
                return ApiRestServices.ListObjects<DebitRequest>(pPath + "/debit-request", pAPIKey);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static PaginationResult<DebitRequest> ListDebitRequests(string pPath, string pAPIKey, string pExternalReference)
        {
            try { 
                return ApiRestServices.ListObjects<DebitRequest>(pPath + "/debit-request?external_reference=" + pExternalReference, pAPIKey);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static DebitRequest CreateDebitRequest(string pPath, string pAPIKey, DebitRequest pDebitRequest)
        {
            try { 
                return ApiRestServices.CreateObject<DebitRequest>(pPath + "/debit-request", pAPIKey, "debit_request", pDebitRequest);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static DebitRequest GetDebitRequest(string pPath, string pAPIKey, int pId)
        {
            try { 
                return ApiRestServices.GetObject<DebitRequest>(pPath + "/debit-request", pAPIKey, pId);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static DebitRequest CancelDebitRequest(string pPath, string pAPIKey, int pId)
        {
            try { 
                return ApiRestServices.CancelObject<DebitRequest>(pPath + "/debit-request", pAPIKey, pId);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static string GetNextBusinessDay(string pPath, string pAPIKey, BusinessDay pDebitRequest)
        {
            return ApiRestServices.GetFirstDudeDate<BusinessDay>(pPath + "/validator/next-business-day", pAPIKey, "next_business_day", pDebitRequest);
        }
    }
}
