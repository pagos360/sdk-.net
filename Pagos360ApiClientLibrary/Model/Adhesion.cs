using System.Runtime.Serialization;

namespace Pagos360ApiClientLibrary.Model
{
    [DataContract(Name = "adhesion")]
    public class Adhesion
    {
        public Adhesion() { }

        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }
        
        [DataMember(Name = "adhesion_holder_name")]
        public string AdhesionHolderName { get; set; }
        
        [DataMember(Name = "bank", EmitDefaultValue = false)]
        public string Bank { get; set; }

        [DataMember(Name = "cbu_holder_id_number")]
        public long CbuHolderIdNumber { get; set; }

        [DataMember(Name = "cbu_holder_name")]
        public string CbuHolderName { get; set; }

        [DataMember(Name = "cbu_number")]
        public string CbuNumber { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "short_description")]
        public string ShortDescription { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "external_reference")]
        public string ExternalReference { get; set; }
    }
}
