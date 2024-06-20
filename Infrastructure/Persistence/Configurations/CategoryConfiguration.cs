using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
	void IEntityTypeConfiguration<Category>.Configure(EntityTypeBuilder<Category> builder)
	{
		Category category1 = new()
		{
			Id = 1,
			Name = "Elektirik",
			Priorty = 1,
			ParentId = 0,
			IsDeleted = false,
			CreatedDate = DateTime.Now,
		};
		Category category2 = new()
		{
			Id = 2,
			Name = "Moda",
			Priorty = 2,
			ParentId = 0,
			IsDeleted = false,
			CreatedDate = DateTime.Now,
		};
		Category category3 = new()
		{
			Id = 3,
			Name = "Bilgisayar",
			Priorty = 1,
			ParentId = 1,
			IsDeleted = false,
			CreatedDate = DateTime.Now,
		};
		Category category4 = new()
		{
			Id = 4,
			Name = "Kadin",
			Priorty = 1,
			ParentId = 2,
			IsDeleted = false,
			CreatedDate = DateTime.Now,
		};
		builder.HasData(category1, category2, category3, category4);
	}
}
