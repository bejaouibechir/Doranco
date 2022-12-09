using Microsoft.Build.Framework;

namespace MVCCore.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        [Required]
        public string Message { get; set; } = string.Empty;
    }
}