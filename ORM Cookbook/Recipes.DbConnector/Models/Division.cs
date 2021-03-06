﻿using DbConnector.Core.Extensions;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recipes.DbConnector.Models
{
    [Table("Division")]
    public class Division : IDivision
    {
        public readonly static string TableName = typeof(Division).GetAttributeValue((TableAttribute ta) => ta?.Name) ?? typeof(Division).Name;

        public int CreatedByEmployeeKey { get; set; }

        public DateTime CreatedDate { get; set; }

        public Guid DivisionId { get; set; }

        public int DivisionKey { get; set; }

        public string? DivisionName { get; set; }

        public float? FloorSpaceBudget { get; set; }

        public decimal? FteBudget { get; set; }

        public DateTimeOffset? LastReviewCycle { get; set; }
        public int? MaxEmployees { get; set; }
        public int ModifiedByEmployeeKey { get; set; }

        public DateTime ModifiedDate { get; set; }

        public decimal? SalaryBudget { get; set; }

        public TimeSpan? StartTime { get; set; }

        public decimal? SuppliesBudget { get; set; }
    }
}
