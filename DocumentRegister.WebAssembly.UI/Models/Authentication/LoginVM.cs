using System.ComponentModel.DataAnnotations;

namespace DocumentRegister.WebAssembly.UI.Models.Authentication
{
	public class LoginVM
	{
		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Required]
		[DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
		public string Password { get; set; }
		public string ReturnUrl { get; set; }
	}
}
