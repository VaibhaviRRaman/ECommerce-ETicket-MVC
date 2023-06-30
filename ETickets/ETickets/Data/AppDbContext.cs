using System;
using Microsoft.EntityFrameworkCore;
namespace ETickets.Data
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
				
		}

	}
}

