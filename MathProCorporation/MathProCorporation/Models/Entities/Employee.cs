﻿//-----------------------------------------------------------------------
// <copyright file="Employee.cs" company="Primat NaUKMA">
//     Primat NaUKMA Inc.
// </copyright>
//-----------------------------------------------------------------------

namespace MathProCorporation.TaskManagerDatabase
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using MathProCorporation.Models;

    /// <summary>
    /// Represents a company's employee
    /// </summary>
    public class Employee
    {
        [Key]
        public string EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public ApplicationUser User { get; set; }

        /// <summary>
        /// Gets or sets the list of current tasks
        /// </summary>
        public virtual List<Task> Tasks { get; set; }
    }
}