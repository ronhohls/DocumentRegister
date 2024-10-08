﻿using DocumentRegister.Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DocumentRegister.Infrastructure.Identity.DbContext
{
	public class DocumentRegisterIdentityDbContext : IdentityDbContext<ApplicationUser>
	{
        public DocumentRegisterIdentityDbContext(DbContextOptions<DocumentRegisterIdentityDbContext> options)
            : base(options) 
		{ 

		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.ApplyConfigurationsFromAssembly(typeof(DocumentRegisterIdentityDbContext).Assembly);
		}
	}
}
