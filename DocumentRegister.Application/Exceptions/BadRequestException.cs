﻿using FluentValidation.Results;

namespace DocumentRegister.Application.Exceptions
{
	public class BadRequestException : Exception
	{
		public List<string> ValidationErrors { get; set; }
		public BadRequestException(string message) : base(message) { }

		public BadRequestException(string message, ValidationResult validationResult) : base(message) 
		{
			ValidationErrors = [];
			foreach (var error in validationResult.Errors)
			{
				ValidationErrors.Add(error.ErrorMessage);
			}
		}

	}
}
