using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Pagos360ApiClientLibrary.Model
{
    public class Webhook
    {
        [DataMember(Name = "entity_name", EmitDefaultValue = false)]
        public string EntityName { get; set; }
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }
        [DataMember(Name = "entity_id", EmitDefaultValue = false)]
        public int EntityId { get; set; }
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedcreatedAt { get; set; }
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public object Payload { get; set; }
    }
}
