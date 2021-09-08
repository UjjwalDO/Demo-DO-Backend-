using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using JobPortal_Backend_.Models;

namespace JobPortal_Backend_.Controllers
{
    public class ApplicantFormController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]

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
                    command.Parameters.AddWithValue("@CscId", form.CscId);
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
                    command.Parameters.AddWithValue("@CourseId", form.CourseId);
                    command.Parameters.AddWithValue("@CourseYear", form.CourseYear);
                    command.Parameters.AddWithValue("@CourseGraduate", form.CourseGraduate);
                    command.Parameters.AddWithValue("@StudyId", form.StudyId);
                    command.Parameters.AddWithValue("@Skills", form.Skills);
                    command.Parameters.AddWithValue("@Qualifications", form.Qualifications);
                    command.Parameters.AddWithValue("@EmpTypeId", form.EmpTypeId);
                    command.Parameters.AddWithValue("@EmpPositionId", form.EmpPositionId);
                    command.Parameters.AddWithValue("@EmpSalary", form.EmpSalary);
                    command.Parameters.AddWithValue("@ReasonForLeaving", form.ReasonForLeaving);
                    command.Parameters.AddWithValue("@EmpStartDate", form.EmpStartDate);
                    command.Parameters.AddWithValue("@EmpEndDate", form.EmpEndDate);
                    command.Parameters.AddWithValue("@MayWeContact", form.MayWeConnect);
                    command.Parameters.AddWithValue("@NameOfReference", form.NameOfReference);
                    command.Parameters.AddWithValue("@Relationship", form.Relationship);
                    command.Parameters.AddWithValue("@YearsAcquainted", form.YearsAcquainted);
                    command.Parameters.AddWithValue("@ReferencePhone", form.ReferencePhone);
                    command.Parameters.AddWithValue("@ReferenceEmail", form.ReferenceEmail);
                    command.Parameters.AddWithValue("@DocTypeId", form.DocTypeId);
                    command.Parameters.AddWithValue("@DocExtention", form.DocExtension);
                    command.Parameters.AddWithValue("@DocName",form.DocName);
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
                return "Failed to add !!!";
            }

        }
    }
}