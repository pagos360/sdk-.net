using System.Runtime.Serialization;

namespace Pagos360ApiClientLibrary.Model
{
    [DataContract(Name = "transfer_to")]
    public class TransferTo
    {
        public TransferTo() { }

        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        [DataMember(Name = "amount")]
        public double Amount { get; set; }

        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        [DataMember(Name = "external_reference", EmitDefaultValue = false)]
        public string ExternalReference { get; set; }

        [DataMember(Name = "refundable", EmitDefaultValue = false)]
        public bool Refundable { get; set; }

    }
}
