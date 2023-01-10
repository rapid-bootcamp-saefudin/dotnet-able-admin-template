using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS.DataContext
{
    [Table("tbl_employee")]
    public class EmployeeEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("employee_name")]
        public String EmployeeName { get; set; }

        [Column("employee_email")]
        public String EmployeeEmail { get; set; }

        [Column("employee_gender")]
        public String EmployeeGender { get; set; }

        [Column("employee_job_position")]
        public String EmployeeJobPosition { get; set; }

        [Column("employee_status")]
        public String EmployeeStatus { get; set; }
    }

}
