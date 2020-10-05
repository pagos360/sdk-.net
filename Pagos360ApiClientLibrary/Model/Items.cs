using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Pagos360ApiClientLibrary.Model
{
    [DataContract(Name = "items")]
    public class Items
    {
        public Items() { }

        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public double Amount { get; set; }
    }
}
