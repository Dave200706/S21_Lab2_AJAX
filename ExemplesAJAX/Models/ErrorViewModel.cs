using Microsoft.AspNetCore.Components.Forms;

namespace ExemplesAJAX.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        
        
    }
}
