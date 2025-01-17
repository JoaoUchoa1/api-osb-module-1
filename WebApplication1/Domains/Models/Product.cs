﻿using System;
using WebApplication1.Domains.Helpers;
using WebApplication1.Domains.Models;

public class Product
{
		public int Id { get; set; }
		public string Name { get; set; }
		public short QuantityInPackage { get; set; }
		public EUnitOfMeasurement UnitOfMeasurement { get; set; }

		public int CategoryId { get; set; }
		public Category Category { get; set; }
}

