using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HWHDotNetCore.ConsoleApp.Dtos;

namespace HWHDotNetCore.ConsoleApp.EFCoreExamples
{
    internal class EFCoreExample


    {
        private readonly AppDbContext db = new AppDbContext();

        public void Run()
        {
            //Edit(9);
            Read();

            //Create("Title100", "author100", "content100");

            //Update(9, "Title1000", "author1000", "content1000");
            //Delete(1011);
            // Read();


        }

        private void Read()
        {

            var lst = db.Blog.ToList();

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

            var item = db.Blog.FirstOrDefault(x => x.BlogId == id);

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



            // foreach(BlogDto x in db.Blogs)
            //  {
            //      if(x.BlogId == id)
            //  }

        }

        public void Create(string title, string author, string content)
        {

            var item = new BlogDto
            {
                BlogAuthor = author,
                BlogTitle = title,
                BlogContent = content,

            };

            db.Blog.Add(item);
            int result = db.SaveChanges();

            string message = result > 0 ? "Saving Successful." : "Saving Failed";
            Console.WriteLine(message);

        }

        public void Update(int id, string title, string author, string content)
        {


            var item = db.Blog.FirstOrDefault(x => x.BlogId == id);

            if (item is null)
            {

                Console.WriteLine("Not data found");
                return;
            }

            item.BlogTitle = title;
            item.BlogAuthor = author;
            item.BlogAuthor = content;

            int result = db.SaveChanges();

            string message = result > 0 ? "Updating Successful." : "Updating Failed";
            Console.WriteLine(message);

        }

        public void Delete(int id)
        {

            var item = db.Blog.FirstOrDefault(x => x.BlogId == id);

            if (item is null)
            {

                Console.WriteLine("Not data found");
                return;
            }

            db.Blog.Remove(item);
            int result = db.SaveChanges();

            string message = result > 0 ? "Deleting Successful." : "Deleting Failed";
            Console.WriteLine(message);


        }


    }
}
