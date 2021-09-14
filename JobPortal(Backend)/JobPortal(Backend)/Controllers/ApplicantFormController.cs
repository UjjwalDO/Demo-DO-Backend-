using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using JobPortal_Backend_.Models;

namespace JobPortal_Backend_.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ApplicantFormController : ApiController
    {
        
        public HttpResponseMessage Get()
        {
            DataTable table = new DataTable();
            using (var con = new SqlConnection(ConfigurationManager.
                ConnectionStrings["MyDbConn"].ConnectionString))
            using (var cmd = new SqlCommand("SelectAll", con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);
        }

        public HttpResponseMessage Get(int Id)
        {
            DataTable table = new DataTable();
            using (var con = new SqlConnection(ConfigurationManager.
                ConnectionStrings["MyDbConn"].ConnectionString))
            using (var cmd = new SqlCommand("SelectById", con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);
        }

        public string Post(ApplicantForm form)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.
                    ConnectionStrings["MyDbConn"].ConnectionString))
                {
                    SqlCommand command = new SqlCommand("InsertApplicant", con);
                    command.Connection.Open();
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FirstName", form.FirstName);
                    command.Parameters.AddWithValue("@MidName", form.MidName);
                    command.Parameters.AddWithValue("@LastName", form.LastName);
                    command.Parameters.AddWithValue("@StreetAdd", form.StreetAdd);
                    command.Parameters.AddWithValue("@CityId", form.CityId);
                    command.Parameters.AddWithValue("@StateId", form.StateId);
                    command.Parameters.AddWithValue("@CountryId", form.CountryId);
                    command.Parameters.AddWithValue("@CodeTypeId", form.CodeTypeId);
                    command.Parameters.AddWithValue("@Phone", form.Phone);
                    command.Parameters.AddWithValue("@Email", form.Email);
                    command.Parameters.AddWithValue("@DOB", form.DOB);
                    command.Parameters.AddWithValue("@USCitizen", form.USCitizen);
                    command.Parameters.AddWithValue("@PositionId", form.PositionId);
                    command.Parameters.AddWithValue("@StartDate", form.StartDate);
                    command.Parameters.AddWithValue("@SalaryDesired", form.Salary);
                    command.Parameters.AddWithValue("@PastEmp", form.PastEmp);
                    command.Parameters.AddWithValue("@PastApply", form.PastApply);
                    command.Parameters.AddWithValue("@ClgName", form.ClgName);
                    command.Parameters.AddWithValue("@CourseYear", form.CourseYear);
                    command.Parameters.AddWithValue("@CourseGraduate", form.CourseGraduate);
                    command.Parameters.AddWithValue("@ClgName1", form.ClgName1);
                    command.Parameters.AddWithValue("@CourseYear1", form.CourseYear1);
                    command.Parameters.AddWithValue("@CourseGraduate1", form.CourseGraduate1);
                    command.Parameters.AddWithValue("@StudyId1", form.StudyId1);
                    command.Parameters.AddWithValue("@ClgName2", form.ClgName2);
                    command.Parameters.AddWithValue("@CourseYear2", form.CourseYear2);
                    command.Parameters.AddWithValue("@CourseGraduate2", form.CourseGraduate2);
                    command.Parameters.AddWithValue("@StudyId2", form.StudyId2);
                    command.Parameters.AddWithValue("@ClgName3", form.ClgName3);
                    command.Parameters.AddWithValue("@CourseYear3", form.CourseYear3);
                    command.Parameters.AddWithValue("@CourseGraduate3", form.CourseGraduate3);
                    command.Parameters.AddWithValue("@StudyId3", form.StudyId3);
                    command.Parameters.AddWithValue("@Skills", form.Skills);
                    command.Parameters.AddWithValue("@Qualifications", form.Qualifications);
                    command.Parameters.AddWithValue("@EmpName", form.EmpName);
                    command.Parameters.AddWithValue("@EmpPositionId", form.EmpPositionId);
                    command.Parameters.AddWithValue("@EmpSalary", form.EmpSalary);
                    command.Parameters.AddWithValue("@ReasonForLeaving", form.ReasonForLeaving);
                    command.Parameters.AddWithValue("@EmpStartDate", form.EmpStartDate);
                    command.Parameters.AddWithValue("@EmpName1", form.EmpName1);
                    command.Parameters.AddWithValue("@EmpPositionId1", form.EmpPositionId1);
                    command.Parameters.AddWithValue("@EmpSalary1", form.EmpSalary1);
                    command.Parameters.AddWithValue("@ReasonForLeaving1", form.ReasonForLeaving1);
                    command.Parameters.AddWithValue("@EmpStartDate1", form.EmpStartDate1);
                    command.Parameters.AddWithValue("@EmpEndDate1", form.EmpEndDate1);
                    command.Parameters.AddWithValue("@EmpName2", form.EmpName2);
                    command.Parameters.AddWithValue("@EmpPositionId2", form.EmpPositionId2);
                    command.Parameters.AddWithValue("@EmpSalary2", form.EmpSalary2);
                    command.Parameters.AddWithValue("@ReasonForLeaving2", form.ReasonForLeaving2);
                    command.Parameters.AddWithValue("@EmpStartDate2", form.EmpStartDate2);
                    command.Parameters.AddWithValue("@EmpEndDate2", form.EmpEndDate2);
                    command.Parameters.AddWithValue("@MayWeContact", form.MayWeConnect);
                    command.Parameters.AddWithValue("@NameOfReference", form.NameOfReference);
                    command.Parameters.AddWithValue("@Relationship", form.Relationship);
                    command.Parameters.AddWithValue("@YearsAcquainted", form.YearsAcquainted);
                    command.Parameters.AddWithValue("@ReferencePhone", form.ReferencePhone);
                    command.Parameters.AddWithValue("@ReferenceEmail", form.ReferenceEmail);
                    command.Parameters.AddWithValue("@NameOfReference1", form.NameOfReference1);
                    command.Parameters.AddWithValue("@Relationship1", form.Relationship1);
                    command.Parameters.AddWithValue("@YearsAcquainted1", form.YearsAcquainted1);
                    command.Parameters.AddWithValue("@ReferencePhone1", form.ReferencePhone1);
                    command.Parameters.AddWithValue("@ReferenceEmail1", form.ReferenceEmail1);
                    command.Parameters.AddWithValue("@NameOfReference2", form.NameOfReference2);
                    command.Parameters.AddWithValue("@Relationship2", form.Relationship2);
                    command.Parameters.AddWithValue("@YearsAcquainted2", form.YearsAcquainted2);
                    command.Parameters.AddWithValue("@ReferencePhone2", form.ReferencePhone2);
                    command.Parameters.AddWithValue("@ReferenceEmail2", form.ReferenceEmail2);
                    command.Parameters.AddWithValue("@DocName", form.DocName);
                    command.Parameters.AddWithValue("@DocExtension", form.DocExtension);
                    command.Parameters.AddWithValue("@DocName1", form.DocName1);
                    command.Parameters.AddWithValue("@DocExtension1", form.DocExtension1);
                    command.Parameters.AddWithValue("@Signature", form.Signature);

                    if (command.Connection.State == ConnectionState.Open)
                    {
                        command.ExecuteNonQuery();
                    }
                }
                return "Added Successfully";

            }
            catch (Exception ex)
            {
                return "Failed to add !!! "+ex;
            }

        }
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/City/{Id}")]
        [HttpGet]
        public HttpResponseMessage City(int Id)
        {
            DataTable table = new DataTable();
            using (var con = new SqlConnection(ConfigurationManager.
                ConnectionStrings["MyDbConn"].ConnectionString))
            using (var cmd = new SqlCommand("SelectCity", con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);
        }
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/State/{Id}")]
        [HttpGet]
        public HttpResponseMessage State(int Id)
        {
            DataTable table = new DataTable();
            using (var con = new SqlConnection(ConfigurationManager.
                ConnectionStrings["MyDbConn"].ConnectionString))
            using (var cmd = new SqlCommand("SelectState", con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);
        }

        [Route("api/Country")]
        [HttpGet]
        public HttpResponseMessage Country()
        {
            DataTable table = new DataTable();
            using (var con = new SqlConnection(ConfigurationManager.
                ConnectionStrings["MyDbConn"].ConnectionString))
            using (var cmd = new SqlCommand("SelectCountry", con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);
        }
  
        [Route("api/AreaOfStudy")]
        [HttpGet]
        public HttpResponseMessage AreaOfStudy()
        {
            DataTable table = new DataTable();
            using (var con = new SqlConnection(ConfigurationManager.
                ConnectionStrings["MyDbConn"].ConnectionString))
            using (var cmd = new SqlCommand("SelectAreaOfStudy", con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);
        }

        [Route("api/Course")]
        [HttpGet]
        public HttpResponseMessage Course()
        {
            DataTable table = new DataTable();
            using (var con = new SqlConnection(ConfigurationManager.
                ConnectionStrings["MyDbConn"].ConnectionString))
            using (var cmd = new SqlCommand("SelectCourse", con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);
        }

        [Route("api/Document")]
        [HttpGet]
        public HttpResponseMessage Document()
        {
            DataTable table = new DataTable();
            using (var con = new SqlConnection(ConfigurationManager.
                ConnectionStrings["MyDbConn"].ConnectionString))
            using (var cmd = new SqlCommand("SelectDocument", con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);
        }

        [Route("api/Emp")]
        [HttpGet]
        public HttpResponseMessage Emp()
        {
            DataTable table = new DataTable();
            using (var con = new SqlConnection(ConfigurationManager.
                ConnectionStrings["MyDbConn"].ConnectionString))
            using (var cmd = new SqlCommand("SelectEmp", con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);
        }

        [Route("api/Position")]
        [HttpGet]
        public HttpResponseMessage Position()
        {
            DataTable table = new DataTable();
            using (var con = new SqlConnection(ConfigurationManager.
                ConnectionStrings["MyDbConn"].ConnectionString))
            using (var cmd = new SqlCommand("SelectPosition", con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);
        }
    }
}