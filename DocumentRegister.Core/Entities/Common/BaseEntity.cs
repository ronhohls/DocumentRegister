using System.ComponentModel.DataAnnotations.Schema;

namespace DocumentRegister.Core.Entities.Common
{
	[NotMapped]
	public abstract class BaseEntity
	{
		public DateTime? DateCreated {  get; set; }
		public string? CreatedBy { get; set; }
		public DateTime? DateModified { get; set; }
		public string? ModifiedBy { get; set; }
	}
}
