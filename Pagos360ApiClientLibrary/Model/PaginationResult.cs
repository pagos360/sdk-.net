using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Pagos360ApiClientLibrary.Model
{
    [DataContract(Name = "list")]
    public class PaginationResult<T>
    {
        [DataMember(Name = "current_page")]
        public int CurrentPage { get; set; }

        [DataMember(Name = "items_per_page")]
        public int ItemsPerPage { get; set; }

        [DataMember(Name = "total_count")]
        public int TotalCount { get; set; }

        [DataMember(Name = "data")]
        public List<T> Data { get; set; }
    }
}
