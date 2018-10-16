using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Pagos360ApiClientLibrary.Model
{
    [DataContract(Name = "payment_request")]
    public class PaymentRequest
    {
        public PaymentRequest() { }

        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "external_reference", EmitDefaultValue = false)]
        public string ExternalReference { get; set; }

        [DataMember(Name = "payer_name", EmitDefaultValue = false)]
        public string PayerName { get; set; }

        [DataMember(Name = "payer_email")]
        public string PayerEmail { get; set; }

        [DataMember(Name = "back_url_success", EmitDefaultValue = false)]
        public string BackUrlSuccess { get; set; }

        [DataMember(Name = "back_url_pending", EmitDefaultValue = false)]
        public string BackUrlPending { get; set; }

        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public string Metadata { get; set; }

        [DataMember(Name = "excluded_channels", EmitDefaultValue = false)]
        public string ExcludedChannels { get; set; }
        
        [DataMember(Name = "first_due_date")]
        public string FirstDueDate { get; set; }

        [DataMember(Name = "first_total")]
        public double FirstTotal { get; set; }

        [DataMember(Name = "second_due_date", EmitDefaultValue = false)]
        public string SecondDueDate { get; set; }

        [DataMember(Name = "second_total", EmitDefaultValue = false)]
        public double SecondTotal { get; set; }

        [DataMember(Name = "barcode", EmitDefaultValue = false)]
        public string Barcode { get; set; }

        [DataMember(Name = "barcode_url", EmitDefaultValue = false)]
        public string BarcodeUrl { get; set; }

        [DataMember(Name = "pdf_url", EmitDefaultValue = false)]
        public string PdfUrl { get; set; }

        [DataMember(Name = "checkout_url", EmitDefaultValue = false)]
        public string CheckoutUrl { get; set; }

        [DataMember(Name = "request_result", EmitDefaultValue = false)]
        public List<RequestResult> RequestResult { get; set; }        
    }
}
