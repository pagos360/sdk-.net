using Pagos360ApiClientLibrary.Model;
using Pagos360ApiClientLibrary.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pagos360ApiClientLibrary.Resources
{
    public class CardAdhesions
    {
        public static PaginationResult<CardAdhesion> ListAdhesions(string pPath, string pParam, string pAPIKey)
        {
            try
            {
                return ApiRestServices.ListObjects<CardAdhesion>(pPath + "/card-adhesion" + pParam, pAPIKey);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }

        }

        public static CardAdhesion CreateAdhesion(string pPath, string pAPIKey, CardAdhesion pAdhesion, bool pAutoSign)
        {
            try {
                string autoSign = "";
                return ApiRestServices.CreateObject<CardAdhesion>(pPath + "/card-adhesion" + autoSign, pAPIKey, "card_adhesion", pAdhesion);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static CardAdhesion GetAdhesion(string pPath, string pAPIKey, int pId)
        {
            try { 
                return ApiRestServices.GetObject<CardAdhesion>(pPath + "/card-adhesion", pAPIKey, pId);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }

        public static CardAdhesion CancelAdhesion(string pPath, string pAPIKey, int pId)
        {
            try {
                return ApiRestServices.CancelObject<CardAdhesion>(pPath + "/card-adhesion", pAPIKey, pId);
            }
            catch (ApplicationException ae)
            {
                throw new ApplicationException(ae.Message);
            }
        }
    }
}
