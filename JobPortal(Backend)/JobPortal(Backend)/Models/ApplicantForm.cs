using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobPortal_Backend_.Models
{
    public class ApplicantForm
    {
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string MidName { get; set; }
		public string LastName { get; set; }
		public string StreetAdd { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string ZipCode { get; set; }
		public string Country { get; set; }
		public string AreaCode { get; set; }
		public int Phone { get; set; }
		public string Email { get; set; }
		public string DOB { get; set; }
		public Boolean USCitizen { get; set; }
		public string ApplyPosition { get; set; }
		public string StartDate { get; set; }
		public int SalaryDesired { get; set; }
		public string PastEmp { get; set; }
		public string PastApply { get; set; }
		public string Course { get; set; }
		public int CourseYear { get; set; }
		public Boolean CourseGraduate { get; set; }
		public string CourseAreaOfstudy { get; set; }
		public string Skills { get; set; }
		public string Qualifications { get; set; }
		public string NameOfEmp { get; set; }
		public string Position { get; set; }
		public int Salary { get; set; }
		public string ReasonForLeaving { get; set; }
		public string EmpStartDate { get; set; }
		public string EmpEndDate { get; set; }
		public Boolean MayWeConnect { get; set; }
		public string NameOfReference { get; set; }
		public string Relationship { get; set; }
		public string YearsAcquainted { get; set; }
		public int ReferencePhone { get; set; }
		public string ReferenceEmail { get; set; }
		public string CoverLetter { get; set; }
		public string Resume { get; set; }
		public string Signature { get; set; }
	}
}