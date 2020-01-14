using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Pagos360ApiClientLibrary.Model;

namespace Pagos360ApiClientLibrary.Model
{
    [DataContract(Name = "card_debit_request")]
    public class CardDebitRequest
    {
        public CardDebitRequest() { }
        
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

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

        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        [DataMember(Name = "card_adhesion", EmitDefaultValue = false)]
        public CardAdhesion CardAdhesionObject { get; set; }

        [DataMember(Name = "request_result", EmitDefaultValue = false)]
        public RequestResult RequestResultObject { get; set; }

        [DataMember(Name = "rejected_at", EmitDefaultValue = false)]
        public string RejectedAt { get; set; }

        [DataMember(Name = "state_comment", EmitDefaultValue = false)]
        public string StateComment { get; set; }

    }
}
