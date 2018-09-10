using Pagos360ApiClientLibrary.Model;
using Pagos360ApiClientLibrary.Services;

namespace Pagos360ApiClientLibrary.Resources
{
    public class Items
    {
        public static PaginationResult<Item> ListItems(string pPath, string pAPIKey)
        {
            return ApiRestServices.ListObjects<Item>(pPath + "/item", pAPIKey);
        }

        public static Item CreateItem(string pPath, string pAPIKey, Item pItem)
        {
            return ApiRestServices.CreateObject<Item>(pPath + "/item", pAPIKey, "item", pItem);          
        }

        public static Item GetItem(string pPath, string pAPIKey, int pId)
        {
            return ApiRestServices.GetObject<Item>(pPath + "/item", pAPIKey, pId);
        }

        public static Item DeletItem(string pPath, string pAPIKey, int pId)
        {
           return ApiRestServices.DeletObject<Item>(pPath + "/item", pAPIKey, pId);
        }
    }
}
