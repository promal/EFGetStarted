using System;
using System.Linq;
using EFGetStarted.Data;
using EFGetStarted.Models;

namespace EFGetStarted
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Opening db session...");
            using (var db = new BloggingContext())
            {
                var blog = new Blog
                {
                    Url = "https://docs.microsoft.com/en-us/ef/core/get-started/?tabs=netcore-cli"
                };

                db.Add(blog);
                db.SaveChanges();


                var queriedBlog = db.Blogs.FirstOrDefault();
                Console.WriteLine("url read from query: " + queriedBlog.Url);

                queriedBlog.Posts.Add(new Post
                {
                    Title = "Update",
                    Content = "Testing Update"
                });
                db.SaveChanges();

                db.Remove(queriedBlog);
                db.SaveChanges();
            }
            Console.WriteLine("Closing db session...");
        }
    }
}
