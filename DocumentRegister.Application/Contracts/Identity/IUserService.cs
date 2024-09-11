﻿using DocumentRegister.Application.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentRegister.Application.Contracts.Identity
{
    public interface IUserService
	{
		Task<List<Employee>> GetEmployees();
		Task<Employee> GetEmployee(string userId);
		public string UserId { get; }
	}
}
