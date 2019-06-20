using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Pagos360ApiClientLibrary.Model
{
    [DataContract(Name = "card_debit_request")]
    public class CardDebitRequest
    {
        public CardDebitRequest() { }

        [DataMember(Name = "amount")]
        public double Amount { get; set; }

        [DataMember(Name = "card_adhesion_id")]
        public int CardAdhesionId { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "month")]
        public int Month { get; set; }

        [DataMember(Name = "year")]
        public int Year { get; set; }
    }
}
