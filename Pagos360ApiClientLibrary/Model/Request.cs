using System.Runtime.Serialization;

namespace Pagos360ApiClientLibrary.Model
{
    [DataContract(Name = "request")]
    public class Request
    {
        public Request() { }

        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        [DataMember(Name = "state_comment", EmitDefaultValue = false)]
        public string StateComment { get; set; }

        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        [DataMember(Name = "first_due_date")]
        public string FirstDueDate { get; set; }

        [DataMember(Name = "first_total")]
        public double FirstTotal { get; set; }

        [DataMember(Name = "second_due_date", EmitDefaultValue = false)]
        public string SecondDueDate { get; set; }

        [DataMember(Name = "second_total", EmitDefaultValue = false)]
        public double SecondTotal { get; set; }

        [DataMember(Name = "payer_email")]
        public string PayerEmail { get; set; }

        [DataMember(Name = "payer_name")]
        public string PayerName { get; set; }

        [DataMember(Name = "adhesion", EmitDefaultValue = false)]
        public Adhesion Adhesion { get; set; }

        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        [DataMember(Name = "external_reference")]
        public string ExternalReference { get; set; }
    }
}
