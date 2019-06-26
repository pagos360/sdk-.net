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
            return ApiRestServices.ListObjects<CardAdhesion>(pPath + "/card-adhesion" + pParam, pAPIKey);
        }

        public static CardAdhesion CreateAdhesion(string pPath, string pAPIKey, CardAdhesion pAdhesion, bool pAutoSign)
        {
            string autoSign = "";
            return ApiRestServices.CreateObject<CardAdhesion>(pPath + "/card-adhesion" + autoSign, pAPIKey, "card_adhesion", pAdhesion);
        }

        public static CardAdhesion GetAdhesion(string pPath, string pAPIKey, int pId)
        {
            return ApiRestServices.GetObject<CardAdhesion>(pPath + "/card-adhesion", pAPIKey, pId);
        }

        public static CardAdhesion CancelAdhesion(string pPath, string pAPIKey, int pId)
        {
            return ApiRestServices.CancelObject<CardAdhesion>(pPath + "/card-adhesion", pAPIKey, pId);
        }
    }
}
