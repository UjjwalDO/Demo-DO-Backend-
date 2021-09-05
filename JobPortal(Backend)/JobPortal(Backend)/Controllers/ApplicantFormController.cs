using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
                ConnectionStrings["ApplicantData"].ConnectionString))
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
                ConnectionStrings["ApplicantData"].ConnectionString))
            using (var cmd = new SqlCommand("SelectById", con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);
        }
    }
}