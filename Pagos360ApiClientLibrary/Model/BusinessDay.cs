using System.Runtime.Serialization;

namespace Pagos360ApiClientLibrary.Model
{
    [DataContract(Name = "next_business_day")]
    public class BusinessDay
    {
        public BusinessDay() { }

        [DataMember(Name = "date", EmitDefaultValue = false)]
        public string Date { get; set; }

        [DataMember(Name = "days", EmitDefaultValue = false)]
        public string Days { get; set; }
    }
}
