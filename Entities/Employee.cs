using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Entities
{
    // EF Core Support 4 Ways For Mapping Classes in Database (Table, View, Function)
    // 1. By Convention --- (Default Behaviour) 
    // 2. Data Annotatopn (Set Of Attributes Used Data Validation)
    // 3. Fluent API -- (Override OnCreateModel())
    // 4. Class Configurations


    // POCO Class
    // Plained OLD CLR Object Class
    //    internal class Employee
    //    {
    //        public int Id { get; set; }  // Public Numeric Property 'Id' | 'EmployeeId'  PK Identity(1,1)
    //        public string? Name { get; set; } // Reference Type : Allow Null [Optional]    Nvarchar(max)
    //        public double Salary { get; set; } // Value Type : Not Allow Null [Decimal | Float]
    //        public int? Age { get; set; } // Nullable <int> : Allow Null [Optional]
    //        public string? Address { get; set; }
    //    }
    //}

    // 2/ Data Annotation
    //[Table("Employee", Schema = "dbo")]
    //internal class Employee
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    //    public int EmpId { get; set; }

    //    [Required]
    //    [Column(TypeName ="varchar")]
    //    [MaxLength(50)]
    //    [StringLength(50,MinimumLength = 10 , ErrorMessage = "Error")]
    //    public string? Name { get; set; }

    //    [Column(TypeName = "money")]
    //    public double Salary { get; set; }

    //    [Required]
    //    [Range(20, 60)]
    //    public int? Age { get; set; }

    //    [StringLength(50, MinimumLength = 10, ErrorMessage = "Error")]
    //    public string? Address { get; set; }

    //    [Phone]
    //    public string Phone {  get; set; }

    //    [EmailAddress]
    //    public string Email { get; set; }

    //    [NotMapped]
    //    public double TotalSalary { get; set; }

    //}


    //3/ Fluent API
    internal class Employee
    {
        
        public int EmpId { get; set; }

        public string? Name { get; set; }

        public double Salary { get; set; }
        
        public int? Age { get; set; }

        public string? Address { get; set; }

        public string Phone { get; set; }
        
        public string Email { get; set; }

        public double TotalSalary { get; set; }

    }
}