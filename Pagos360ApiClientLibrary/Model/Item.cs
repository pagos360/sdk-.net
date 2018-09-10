using System.Runtime.Serialization;

namespace Pagos360ApiClientLibrary.Model
{
    [DataContract(Name = "item")]
    public class Item
    {
        public Item() { }

        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        [DataMember(Name = "deleted_at", EmitDefaultValue = false)]
        public string DeletedAt { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "short_name")]
        public string ShortName { get; set; }
    }
}
