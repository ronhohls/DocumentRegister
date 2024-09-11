using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRegister.Core.Entities.Common
{
	public abstract class BaseEntity
	{
		public DateTime? DateCreated {  get; set; }
		public string? CreatedBy { get; set; }
		public DateTime? DateModified { get; set; }
		public string? ModifiedBy { get; set; }
	}
}
