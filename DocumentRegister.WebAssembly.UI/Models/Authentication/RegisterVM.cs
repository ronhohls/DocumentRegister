using System.ComponentModel.DataAnnotations;

namespace DocumentRegister.WebAssembly.UI.Models.Authentication
{
	public class RegisterVM
	{
		[Required]
		public string FirstName { get; set; }

		[Required]
		public string LastName { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Required]
		public string UserName { get; set; }

		[Required]
		[DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
		public string Password { get; set; }
	}
}
