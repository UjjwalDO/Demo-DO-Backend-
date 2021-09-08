using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobPortal_Backend_.Models
{
	public class ApplicantForm
	{
		public int ApplicantId { get; set; }
		public string FirstName { get; set; }
		public string MidName { get; set; }
		public string LastName { get; set; }
		public string StreetAdd { get; set; }
		public int CscId { get; set; }
		public int CityId { get; set; }
		public int StateId { get; set; }
		public int CountryId { get; set; }
		public int CodeTypeId { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string DOB { get; set; }
		public Boolean USCitizen { get; set; }
		public int PositionId { get; set; }
		public string StartDate { get; set; }
		public string Salary { get; set; }
		public Boolean PastEmp { get; set; }
		public Boolean PastApply { get; set; }
		public int CourseId { get; set; }
		public int CourseYear { get; set; }
		public Boolean CourseGraduate { get; set; }
		public int StudyId { get; set; }
		public string Skills { get; set; }
		public string Qualifications { get; set; }
		public int EmpTypeId { get; set; }
		public int EmpPositionId { get; set; }
		public string EmpSalary { get; set; }
		public string ReasonForLeaving { get; set; }
		public string EmpStartDate { get; set; }
		public string EmpEndDate { get; set; }
		public Boolean MayWeConnect { get; set; }
		public string NameOfReference { get; set; }
		public string Relationship { get; set; }
		public int YearsAcquainted { get; set; }
		public string ReferencePhone { get; set; }
		public string ReferenceEmail { get; set; }
		public int DocTypeId { get; set; }
		public byte[] DocExtension { get; set; }
		public string DocName { get; set; }
		public string Signature { get; set; }
	}
}