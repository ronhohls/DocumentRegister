using System.ComponentModel.DataAnnotations;

namespace DocumentRegister.WebAssembly.UI.Models.DataType
{
	public class DataTypeVM
	{
		public int DataTypeId { get; set; }
		[Required]
		public string Name { get; set; }
	}
}
