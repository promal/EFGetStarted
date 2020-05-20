using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace EFGetStarted.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }


        public List<Post> Posts { get; } = new List<Post>();
    }
}
