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

        [DataMember(Name = "adhesion_holder_name")]
        public string AdhesionHolderName { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "external_reference")]
        public string ExternalReference { get; set; }

        [DataMember(Name = "card_holder_name")]
        public string CardHolderName { get; set; }

        [DataMember(Name = "card_number")]
        public string CardNumber { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }
    }
}
