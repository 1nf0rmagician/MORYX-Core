// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using Microsoft.EntityFrameworkCore;
using Moryx.Model;
using Moryx.Model.Attributes;
using Moryx.Model.PostgreSQL;

namespace Moryx.TestTools.Test.Model
{
    /// <summary>
    /// The DBContext of this database model.
    /// </summary>
    [ModelConfigurator(typeof(NpgsqlModelConfigurator))]
    public class TestModelContext : MoryxDbContext
    {
        public TestModelContext()
        {
        }

        public TestModelContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }

        public virtual DbSet<CarEntity> Cars { get; set; }

        public virtual DbSet<WheelEntity> Wheels { get; set; }

        public virtual DbSet<SportCarEntity> SportCars { get; set; }

        public virtual DbSet<JsonEntity> Jsons { get; set; }

        public virtual DbSet<HugePocoEntity> HugePocos { get; set; }

        public virtual DbSet<HouseEntity> Houses { get; set; }
    }
}
