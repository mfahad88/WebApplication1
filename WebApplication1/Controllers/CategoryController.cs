using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api/Category")]
    public class CategoryController : ApiController
    {
        SqlConnection conn = ConnectionManager.DbConnection();
        // GET: api/Category
        //public List<CategoryModel> Get()
        public List<CategoryModel> Get()
        {
            String sql_query = "SELECT * FROM [Restaurant].[dbo].[Category]";
            
            
            List<CategoryModel> list = new List<CategoryModel>();
            
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql_query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    CategoryModel model = new CategoryModel(reader.GetInt16(0),reader.GetString(1),
                                                            reader.GetString(2), reader.GetString(3));
                    model.Cat_Id = reader.GetInt16(0);
                    list.Add(model);
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return list;

        }

        // GET: api/Category/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Category
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Category/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Category/5
        public void Delete(int id)
        {
        }
    }
}
