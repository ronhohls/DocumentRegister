using System.ComponentModel.DataAnnotations;

namespace DocumentRegister.WebAssembly.UI.Models.MediaType
{
	public class MediaTypeVM
	{
		public int MediaTypeId { get; set; }
		[Required]
		public string Description { get; set; }
	}
}
