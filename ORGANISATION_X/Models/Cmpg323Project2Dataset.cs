using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace ORGANISATION_X.Models
{
    public partial class Cmpg323Project2Dataset
    {
        public int? Age { get; set; }

        public string Attrition { get; set; }

        [DisplayName("Business Travel")]
        public string BusinessTravel { get; set; }

        [DisplayName("Daily Rate")] 
        public int? DailyRate { get; set; }

        public string Department { get; set; }

        [Required(ErrorMessage = "This field is required")]
        
        [DisplayName("Distance From Home")]
        public int? DistanceFromHome { get; set; }


        public int? Education { get; set; }

        [DisplayName("Education Field")] 
        public string EducationField { get; set; }

        [DisplayName("Employee Count")] 
        public bool? EmployeeCount { get; set; }

        [Required(ErrorMessage = "Employee Number is required.")]
        [DisplayName("Employee Number")]
        public string EmployeeNumber { get; set; }

        [DisplayName("Environment Satisfaction")] 
        public int? EnvironmentSatisfaction { get; set; }

        public string Gender { get; set; }

        [DisplayName("Hourly Rate")] 
        public int? HourlyRate { get; set; }

        [DisplayName("Job Involvement")] 
        public int? JobInvolvement { get; set; }

        [DisplayName("Job Level")] 
        public int? JobLevel { get; set; }

        [DisplayName("Job Role")] 
        public string JobRole { get; set; }

        [DisplayName("Job Satisifaction")] 
        public int? JobSatisfaction { get; set; }

        [DisplayName("Marital Status")] 
        public string MaritalStatus { get; set; }

        [Required(ErrorMessage = "Monthly Income is required")]
        
        [DisplayName("Monthly Income")] 
        public int? MonthlyIncome { get; set; }

        [DisplayName("Monthly Rate")] 
        public int? MonthlyRate { get; set; }

        [DisplayName("Num. Companies Worked")] 
        public int? NumCompaniesWorked { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Over 18")] 
        public string Over18 { get; set; }

        [DisplayName("Over Time")] 
        public string OverTime { get; set; }

        [DisplayName("Percent Salary Hike")] 
        public int? PercentSalaryHike { get; set; }

        [DisplayName("Performance Rating")] 
        public int? PerformanceRating { get; set; }

        [DisplayName("Relationship Satisfaction")] 
        public int? RelationshipSatisfaction { get; set; }

        [DisplayName("Standard Hours")] 
        public int? StandardHours { get; set; }

        [DisplayName("Stock Option Level")] 
        public int? StockOptionLevel { get; set; }

        [Required(ErrorMessage = "Total Working Years is required")]
        [DisplayName("Total Working Years")] 
        public int? TotalWorkingYears { get; set; }

        [DisplayName("Training Times Last Year")] 
        public int? TrainingTimesLastYear { get; set; }


        [DisplayName("Working Life Balance")] 
        public int? WorkLifeBalance { get; set; }

        [Required(ErrorMessage = "Years At Company is required")]
        [DisplayName("Years At Company")] 
        public int? YearsAtCompany { get; set; }

        [DisplayName("Years In Current Role")] 
        public int? YearsInCurrentRole { get; set; }

        [DisplayName("Years Since Last Promotion")] 
        public int? YearsSinceLastPromotion { get; set; }
        
        [DisplayName("Years With Current Manager")] 
        public int? YearsWithCurrManager { get; set; }

    }
}
