using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pagos360ApiClientLibrary.Model;
using Pagos360ApiClientLibrary.Services;

namespace Pagos360ApiClientLibrary.Resources
{
    public class Adhesions
    {
        public static PaginationResult<Adhesion> ListAdhesions(string pPath, string pParam, string pAPIKey)
        {
            return ApiRestServices.ListObjects<Adhesion>(pPath + "/adhesion" + pParam, pAPIKey);
        }

        public static Adhesion CreateAdhesion(string pPath, string pAPIKey, Adhesion pAdhesion, bool pAutoSign)
        {
            string autoSign = "";            
            return ApiRestServices.CreateObject<Adhesion>(pPath + "/adhesion" + autoSign, pAPIKey, "adhesion", pAdhesion);
        }

        public static Adhesion GetAdhesion(string pPath, string pAPIKey, int pId)
        {
            return ApiRestServices.GetObject<Adhesion>(pPath + "/adhesion", pAPIKey, pId);
        }

        public static Adhesion CancelAdhesion(string pPath, string pAPIKey, int pId)
        {
            return ApiRestServices.CancelObject<Adhesion>(pPath + "/adhesion", pAPIKey, pId);
        }
    }
}
