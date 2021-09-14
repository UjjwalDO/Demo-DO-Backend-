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
		public string ClgName { get; set; }
		public int CourseYear { get; set; }
		public Boolean CourseGraduate { get; set; }
		public string ClgName1 { get; set; }
		public int CourseYear1 { get; set; }
		public Boolean CourseGraduate1 { get; set; }
		public int StudyId1 { get; set; }
		public string ClgName2 { get; set; }
		public int CourseYear2 { get; set; }
		public Boolean CourseGraduate2 { get; set; }
		public int StudyId2 { get; set; }
		public string ClgName3 { get; set; }
		public int CourseYear3 { get; set; }
		public Boolean CourseGraduate3 { get; set; }
		public int StudyId3 { get; set; }
		public string Skills { get; set; }
		public string Qualifications { get; set; }
		public string EmpName { get; set; }
		public int EmpPositionId { get; set; }
		public string EmpSalary { get; set; }
		public string ReasonForLeaving { get; set; }
		public string EmpStartDate { get; set; }
		public string EmpName1 { get; set; }
		public int EmpPositionId1 { get; set; }
		public string EmpSalary1 { get; set; }
		public string ReasonForLeaving1 { get; set; }
		public string EmpStartDate1 { get; set; }
		public string EmpEndDate1 { get; set; }
		public string EmpName2 { get; set; }
		public int EmpPositionId2 { get; set; }
		public string EmpSalary2 { get; set; }
		public string ReasonForLeaving2 { get; set; }
		public string EmpStartDate2 { get; set; }
		public string EmpEndDate2 { get; set; }
		public Boolean MayWeConnect { get; set; }
		public string NameOfReference { get; set; }
		public string Relationship { get; set; }
		public int YearsAcquainted { get; set; }
		public string ReferencePhone { get; set; }
		public string ReferenceEmail { get; set; }
		public string NameOfReference1 { get; set; }
		public string Relationship1 { get; set; }
		public int YearsAcquainted1 { get; set; }
		public string ReferencePhone1 { get; set; }
		public string ReferenceEmail1 { get; set; }
		public string NameOfReference2 { get; set; }
		public string Relationship2 { get; set; }
		public int YearsAcquainted2 { get; set; }
		public string ReferencePhone2 { get; set; }
		public string ReferenceEmail2 { get; set; }
		public string DocName { get; set; }
		public byte[] DocExtension { get; set; }
		public string DocName1 { get; set; }
		public byte[] DocExtension1 { get; set; }
		public string Signature { get; set; }
	}
}