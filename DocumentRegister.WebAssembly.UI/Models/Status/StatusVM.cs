using System.ComponentModel.DataAnnotations;

namespace DocumentRegister.WebAssembly.UI.Models.Status
{
    public class StatusVM
    {
        public int StatusID { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
