using Dapper;
using HWHDotNetCore.ConsoleApp.Dtos;
using HWHDotNetCore.ConsoleApp.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HWHDotNetCore.ConsoleApp.DapperExamples
{
    internal class DapperExample


    {

        public void Run()
        {

            Read();
            // Delete(1010);
            //Update(1010,"title","MyaMya","hereContect");
            //  Edit(1);
            //  Edit(10);

            //  Create("Doc", "HlaHla", "thiscontent");



        }
        private void Read()
        {

            using IDbConnection db = new SqlConnection(ConnectionStrings.sqlconnectiionStringBuilder.ConnectionString);
            List<BlogDto> lst = db.Query<BlogDto>("Select * from tbl_blog").ToList();

            foreach (BlogDto item in lst)
            {

                Console.WriteLine(item.BlogId);
                Console.WriteLine(item.BlogTitle);
                Console.WriteLine(item.BlogAuthor);
                Console.WriteLine(item.BlogContent);
                Console.WriteLine("_______________________________________________");

            }


        }

        private void Edit(int id)
        {

            using IDbConnection db = new SqlConnection(ConnectionStrings.sqlconnectiionStringBuilder.ConnectionString);
            var item = db.Query<BlogDto>("select * from  tbl_blog where blogid = @Blogid", new BlogDto { BlogId = id }).FirstOrDefault();

            if (item is null)
            {
                Console.WriteLine("Not data found");
                return;
            }

            Console.WriteLine(item.BlogId);
            Console.WriteLine(item.BlogTitle);
            Console.WriteLine(item.BlogAuthor);
            Console.WriteLine(item.BlogContent);
            Console.WriteLine("_______________________________________________");
        }

        public void Create(string title, string author, string content)
        {

            var item = new BlogDto
            {
                BlogAuthor = author,
                BlogTitle = title,
                BlogContent = content,

            };

            string query = @"INSERT INTO [dbo].[Tbl_Blog]
           ([BlogTitle]
           ,[BlogAuthor]
           ,[BlogContent])
   VALUES
           (@BlogTitle,
		   @BlogAuthor,
		   @BlogContent
          
           )";

            using IDbConnection db = new SqlConnection(ConnectionStrings.sqlconnectiionStringBuilder.ConnectionString);
            int result = db.Execute(query, item);

            string message = result > 0 ? "Saving Successful." : "Saving Failed";
            Console.WriteLine(message);

        }

        public void Update(int id, string title, string author, string content)
        {

            var item = new BlogDto
            {
                BlogId = id,
                BlogAuthor = author,
                BlogTitle = title,
                BlogContent = content,

            };

            string query = @"UPDATE [dbo].[Tbl_Blog]
             SET [BlogTitle] = @BlogTitle
          ,[BlogAuthor] = @BlogAuthor
          ,[BlogContent] = @BlogContent
             WHERE BlogId = @BlogID";

            using IDbConnection db = new SqlConnection(ConnectionStrings.sqlconnectiionStringBuilder.ConnectionString);
            int result = db.Execute(query, item);

            string message = result > 0 ? "Updating Successful." : "Updating Failed";
            Console.WriteLine(message);

        }

        public void Delete(int id)
        {

            var item = new BlogDto
            {
                BlogId = id


            };

            string query = @"DELETE FROM [dbo].[Tbl_Blog]
      WHERE BlogId = @BlogId";

            using IDbConnection db = new SqlConnection(ConnectionStrings.sqlconnectiionStringBuilder.ConnectionString);
            int result = db.Execute(query, item);

            string message = result > 0 ? "Deleting Successful." : "Deleting Failed";
            Console.WriteLine(message);

        }

    }
}
