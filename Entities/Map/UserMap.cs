﻿using System.Data.Entity.ModelConfiguration;

namespace NorthwindEfCodeFirstFluentApi.Entities.Map
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            this.ToTable("User");
            this.HasKey(i=>i.Id);

            this.Property(i => i.Id).
                IsRequired().
                HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(i => i.Name).
                IsRequired().
                HasMaxLength(40);

            this.Property(i => i.Surname).
                IsRequired().
                HasMaxLength(30);

            this.Property(i => i.Birth).
                IsRequired();

            this.Property(i => i.CreateDate).
               IsRequired();

            this.Property(i => i.Adres).
                HasMaxLength(30);

            this.Property(i => i.Id).HasColumnName("Id");
            this.Property(i => i.Name).HasColumnName("Name");
            this.Property(i => i.Surname).HasColumnName("Surname");
            this.Property(i => i.Birth).HasColumnName("Birth");
            this.Property(i => i.CreateDate).HasColumnName("CreateDate");
            this.Property(i => i.Adres).HasColumnName("Adres");
        }
    }
}
