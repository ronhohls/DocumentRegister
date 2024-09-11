using FluentValidation.Results;

namespace DocumentRegister.Application.Exceptions
{
	public class NotFoundException : Exception
	{
		public List<string> ValidationErrors { get; set; }
		public NotFoundException(string message) : base(message) { }

		public NotFoundException(string name, object key) : base($"{name} ({key}) was not found") { }
		

	}
}
