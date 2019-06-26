using System.Runtime.Serialization;

namespace Pagos360ApiClientLibrary.Model
{
    [DataContract(Name = "request-result")]
    public class RequestResult
    {
        public RequestResult() { }

        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public string Channel { get; set; }

        [DataMember(Name = "paid_at", EmitDefaultValue = false)]
        public string PaidAt { get; set; }

        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        [DataMember(Name = "available_at", EmitDefaultValue = false)]
        public string AvailableAt { get; set; }

        [DataMember(Name = "rejected_at", EmitDefaultValue = false)]
        public string RejectedAt { get; set; }

        [DataMember(Name = "is_available", EmitDefaultValue = false)]
        public bool IsAvaliable { get; set; }

        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public double Amount { get; set; }

        [DataMember(Name = "gross_fee", EmitDefaultValue = false)]
        public double GrossFee { get; set; }

        [DataMember(Name = "net_fee", EmitDefaultValue = false)]
        public double NetFee { get; set; }

        [DataMember(Name = "fee_iva", EmitDefaultValue = false)]
        public double FeeIva { get; set; }

        [DataMember(Name = "net_amount", EmitDefaultValue = false)]
        public double NetAmount { get; set; }

        [DataMember(Name = "state_comment", EmitDefaultValue = false)]
        public string StateComment { get; set; }
    }
}
