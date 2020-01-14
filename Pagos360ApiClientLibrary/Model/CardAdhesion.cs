using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Pagos360ApiClientLibrary.Model
{
    [DataContract(Name = "card_adhesion")]
    public class CardAdhesion
    {
        public CardAdhesion() { }

        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        [DataMember(Name = "external_reference")]
        public string ExternalReference { get; set; }

        [DataMember(Name = "adhesion_holder_name")]
        public string AdhesionHolderName { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "card_holder_name")]
        public string CardHolderName { get; set; }

        [DataMember(Name = "card_number")]
        public string CardNumber { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "last_four_digits", EmitDefaultValue = false)]
        public string LastFourDigits { get; set; }

        [DataMember(Name = "card", EmitDefaultValue = false)]
        public string CardBrand { get; set; }

        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        [DataMember(Name = "state_comment", EmitDefaultValue = false)]
        public string StateComment { get; set; }

        [DataMember(Name = "canceled_at", EmitDefaultValue = false)]
        public string CanceledAt { get; set; }

    }
}
