using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
namespace Mapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var context = new BloggingContext();
            //var posts = context.Posts.Take(4);
            //foreach (var post in posts.Include(p => p.Blog))
            //{
            //    Console.WriteLine($"{post.Id}. {post.Title} in the blog {post.Blog.Name}");
            //}


            //var context = new BloggingContext();
            //var posts = context.Posts.Take(4).Include(p => p.Blog);
            //foreach (var post in posts)
            //{
            //    Console.WriteLine($"{post.Id}. {post.Title} in the blog {post.Blog.Name}");
            //}


            //var context = new BloggingContext();
            //var posts = context.Posts.Include(p => p.Blog).Take(4);
            //foreach (var post in posts)
            //{
            //    Console.WriteLine($"{post.Id}. {post.Title} in the blog {post.Blog.Name}");
            //}


            //var context = new BloggingContext();
            //var posts = context.Posts.OrderBy(p => p.Blog.Name).Include(p => p.Blog);
            //foreach (var post in posts)
            //{
            //    Console.WriteLine($"{post.Id}. {post.Title} in the blog {post.Blog.Name}");
            //}


            //var context = new BloggingContext();
            //var posts = context.Posts.OrderBy(p => p.Blog.Name);
            //foreach (var post in posts.Include(p => p.Blog))
            //{
            //    Console.WriteLine($"{post.Id}. {post.Title} in the blog {post.Blog.Name}");
            //}


            //var context = new BloggingContext();
            //var posts = context.Posts.Include(p => p.Blog).OrderBy(p => p.Blog.Name);
            //foreach (var post in posts)
            //{
            //    Console.WriteLine($"{post.Id}. {post.Title} in the blog {post.Blog.Name}");
            //}


            //var context = new BloggingContext();
            //var urls = context.Blogs.OrderByDescending(b => b.Url)
            //        .ThenByDescending(b => b.Posts.Count)
            //        .Select(p => p.Url);
            //foreach (var url in urls)
            //{
            //    Console.WriteLine(url);
            //}


            //var context = new BloggingContext();
            //var names = from post in context.Posts
            //            orderby post.Title.Substring(5, 5)
            //            select post.Title;
            //foreach (var name in names.Skip(5))
            //{
            //    Console.WriteLine(name);
            //}

            //var context = new BloggingContext();
            //var urls = context.Blogs.Where(b => b.Rating > 4)
            //        .Select(b => b.Url)
            //        .OrderByDescending(b => b.Length);
            //foreach (var url in urls)
            //{
            //    Console.WriteLine(url);
            //}


            //var context = new BloggingContext();
            //var urls = context.Posts.Where(p => p.Blog.Rating > 4)
            //        .Select(p => p.Blog.Url)
            //        .OrderByDescending(b => b.Length).Distinct();
            //foreach (var url in urls)
            //{
            //    Console.WriteLine(url);
            //}

            //var context = new BloggingContext();
            //var urls = context.Blogs.Where(b => b.Rating > 4)
            //        .OrderBy(b => b.Name.Length)
            //        .Select(b => b.Url);
            //foreach (var url in urls)
            //{
            //    Console.WriteLine(url);
            //}


            //var context = new BloggingContext();
            //var urls = from blog in context.Blogs
            //           where blog.Rating > 4
            //           orderby blog.Url.Length descending
            //           select blog.Url;
            //foreach (var url in urls)
            //{
            //    Console.WriteLine(url);
            //}


            //var context = new BloggingContext();
            //var urls = from blog in context.Blogs
            //           orderby blog.Url.Length
            //           where blog.Rating > 4
            //           select blog.Url;
            //foreach (var url in urls)
            //{
            //    Console.WriteLine(url);
            //}


            //var context = new BloggingContext();
            //var postGroups = from post in context.Posts.Include(p => p.Blog).AsEnumerable()
            //                 group post by post.Blog.Name;
            //foreach (var group in postGroups)
            //{
            //    Console.WriteLine($"{group.Count()} posts in the group {group.Key}.");
            //}


            //var context = new BloggingContext();
            //var postGroups = context.Posts.Include(p => p.Blog).AsEnumerable().GroupBy(p => p.Blog.Name);
            //foreach (var group in postGroups)
            //{
            //    Console.WriteLine($"{group.Count()} posts in the group {group.Key}.");
            //}


            //var context = new BloggingContext();
            //var postGroups = context.Posts.Include(p => p.Blog).ToList().GroupBy(p => p.Blog.Name);
            //foreach (var group in postGroups)
            //{
            //    Console.WriteLine($"{group.Count()} posts in the group {group.Key}.");
            //}


            //var context = new BloggingContext();
            //var postGroups = context.Posts.GroupBy(p => p.Blog.Name);
            //foreach (var group in postGroups)
            //{
            //    Console.WriteLine($"{group.Count()} posts in the group {group.Key}.");
            //}


            //var context = new BloggingContext();
            //var postGroups = context.Posts.ToList().GroupBy(p => p.Blog.Name);
            //foreach (var group in postGroups)
            //{
            //    Console.WriteLine($"{group.Count()} posts in the group {group.Key}.");
            //}


            //var context = new BloggingContext();
            //var postGroups = context.Posts.AsEnumerable().GroupBy(p => p.Title.Length % 3);
            //foreach (var group in postGroups)
            //{
            //    Console.WriteLine($"Key: {group.Key}");
            //    foreach (var post in group)
            //    {
            //        Console.WriteLine($"\t{post.Title}");
            //    }
            //}


            //var context = new BloggingContext();
            //var postGroups = from post in context.Posts.ToList()
            //                 group post by post.Title.Length % 3;
            //foreach (var group in postGroups)
            //{
            //    Console.WriteLine($"Key: {group.Key}");
            //    foreach (var post in group)
            //    {
            //        Console.WriteLine($"\t{post.Title}");
            //    }
            //}


            //var context = new BloggingContext();
            //var postGroups = from post in context.Posts.ToArray()
            //                 group post by post.Title.Length % 3;
            //foreach (var group in postGroups)
            //{
            //    Console.WriteLine($"Key: {group.Key}");
            //    foreach (var post in group)
            //    {
            //        Console.WriteLine($"\t{post.Title}");
            //    }
            //}

            //var context = new BloggingContext();
            //var query = from post in context.Posts
            //            join blog in context.Blogs on post.Blog.Id equals blog.Id
            //            select new { post.Title, blog.Name };
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"\"{item.Title}\" post in \"{item.Name}\" blog.");
            //}


            //var context = new BloggingContext();
            //var query = from blog in context.Blogs
            //            join post in context.Posts on blog.Id equals post.Blog.Id
            //            select new { post.Title, blog.Name };
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"\"{item.Title}\" post in \"{item.Name}\" blog.");
            //}



            //var context = new BloggingContext();

            //var query = context.Posts.Join(context.Blogs, p => p.Blog.Id, b => b.Id, (p, b) => new { p.Title, b.Name });

            //foreach (var item in query)
            //{
            //    Console.WriteLine($"\"{item.Title}\" post in \"{item.Name}\" blog.");
            //}


            //var context = new BloggingContext();

            //var post = context.Posts.First(p => p.Title.Contains(".NET"));

            //Console.WriteLine($"{post.Id}. {post.Title} in the blog {post.Blog.Name}");



            //var context = new BloggingContext();

            //var blog = context.Blogs.FirstOrDefault(b => b.Rating < 3);

            //Console.WriteLine($"{blog?.Id}. {blog?.Name}.");



            //var context = new BloggingContext();

            //var blog = context.Blogs.Single(b => b.Rating > 3);

            //Console.WriteLine($"{blog?.Id}. {blog?.Name}.");




            //var context = new BloggingContext();

            //var posts = context.Posts.Take(4);

            //foreach (var post in posts.Include(p => p.Blog))
            //{
            //    Console.WriteLine($"{post.Id}. {post.Title} in the blog {post.Blog.Name}");
            //}



            //var context = new BloggingContext();

            //var posts = context.Posts.Take(4).Include(p => p.Blog);

            //foreach (var post in posts)
            //{
            //    Console.WriteLine($"{post.Id}. {post.Title} in the blog {post.Blog.Name}");
            //}



            //var context = new BloggingContext();

            //var posts = context.Posts.Include(p => p.Blog).Take(4);

            //foreach (var post in posts)
            //{
            //    Console.WriteLine($"{post.Id}. {post.Title} in the blog {post.Blog.Name}");
            //}




            //var context = new BloggingContext();

            //var posts = context.Posts.OrderBy(p => p.Blog.Name).Include(p => p.Blog);

            //foreach (var post in posts)
            //{
            //    Console.WriteLine($"{post.Id}. {post.Title} in the blog {post.Blog.Name}");
            //}



            //var context = new BloggingContext();

            //var posts = context.Posts.OrderBy(p => p.Blog.Name);

            //foreach (var post in posts.Include(p => p.Blog))
            //{
            //    Console.WriteLine($"{post.Id}. {post.Title} in the blog {post.Blog.Name}");
            //}



            //var context = new BloggingContext();

            //var posts = context.Posts.Include(p => p.Blog).OrderBy(p => p.Blog.Name);

            //foreach (var post in posts)
            //{
            //    Console.WriteLine($"{post.Id}. {post.Title} in the blog {post.Blog.Name}");
            //}



            //var context = new BloggingContext();

            //var urls = context.Blogs.OrderByDescending(b => b.Url)
            //        .ThenByDescending(b => b.Posts.Count)
            //        .Select(p => p.Url);

            //foreach (var url in urls)
            //{
            //    Console.WriteLine(url);
            //}




            //var context = new BloggingContext();

            //var names = from post in context.Posts
            //            orderby post.Title.Substring(5, 5)
            //            select post.Title;

            //foreach (var name in names.Skip(5))
            //{
            //    Console.WriteLine(name);
            //}



            //var context = new BloggingContext();

            //var urls = context.Blogs.Where(b => b.Rating > 4)
            //        .Select(b => b.Url)
            //        .OrderByDescending(b => b.Length);

            //foreach (var url in urls)
            //{
            //    Console.WriteLine(url);
            //}



            //var context = new BloggingContext();

            //var urls = context.Posts.Where(p => p.Blog.Rating > 4)
            //        .Select(p => p.Blog.Url)
            //        .OrderByDescending(b => b.Length).Distinct();


            //foreach (var url in urls)
            //{
            //    Console.WriteLine(url);
            //}




            //var context = new BloggingContext();

            //var urls = context.Blogs.Where(b => b.Rating > 4)
            //        .OrderBy(b => b.Name.Length)
            //        .Select(b => b.Url);

            //foreach (var url in urls)
            //{
            //    Console.WriteLine(url);
            //}



            //var context = new BloggingContext();

            //var urls = from blog in context.Blogs
            //           where blog.Rating > 4
            //           orderby blog.Url.Length descending
            //           select blog.Url;

            //foreach (var url in urls)
            //{
            //    Console.WriteLine(url);
            //}



            //var context = new BloggingContext();

            //var urls = from blog in context.Blogs
            //           orderby blog.Url.Length
            //           where blog.Rating > 4
            //           select blog.Url;

            //foreach (var url in urls)
            //{
            //    Console.WriteLine(url);
            //}




            //var context = new BloggingContext();

            //var postGroups = from post in context.Posts.Include(p => p.Blog).AsEnumerable()
            //                 group post by post.Blog.Name;

            //foreach (var group in postGroups)
            //{
            //    Console.WriteLine($"{group.Count()} posts in the group {group.Key}.");
            //}




            //var context = new BloggingContext();

            //var postGroups = context.Posts.Include(p => p.Blog).AsEnumerable().GroupBy(p => p.Blog.Name);

            //foreach (var group in postGroups)
            //{
            //    Console.WriteLine($"{group.Count()} posts in the group {group.Key}.");
            //}



            //var context = new BloggingContext();

            //var postGroups = context.Posts.Include(p => p.Blog).ToList().GroupBy(p => p.Blog.Name);

            //foreach (var group in postGroups)
            //{
            //    Console.WriteLine($"{group.Count()} posts in the group {group.Key}.");
            //}


            //LNQEF9 d  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //var context = new BloggingContext();

            //var postGroups = context.Posts.GroupBy(p => p.Blog.Name);

            //foreach (var group in postGroups)
            //{
            //    Console.WriteLine($"{group.Count()} posts in the group {group.Key}.");
            //}



            //LNQEF9 e  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //var context = new BloggingContext();

            //var postGroups = context.Posts.ToList().GroupBy(p => p.Blog.Name);

            //foreach (var group in postGroups)
            //{
            //    Console.WriteLine($"{group.Count()} posts in the group {group.Key}.");
            //}


            //var context = new BloggingContext();

            //var postGroups = context.Posts.AsEnumerable().GroupBy(p => p.Title.Length % 3);

            //foreach (var group in postGroups)
            //{
            //    Console.WriteLine($"Key: {group.Key}");
            //    foreach (var post in group)
            //    {
            //        Console.WriteLine($"\t{post.Title}");
            //    }
            //}




            //var context = new BloggingContext();

            //var postGroups = from post in context.Posts.ToList()
            //                 group post by post.Title.Length % 3;

            //foreach (var group in postGroups)
            //{
            //    Console.WriteLine($"Key: {group.Key}");
            //    foreach (var post in group)
            //    {
            //        Console.WriteLine($"\t{post.Title}");
            //    }
            //}





            //var context = new BloggingContext();

            //var postGroups = from post in context.Posts
            //                 group post by post.Title.Length % 3;

            //foreach (var group in postGroups)
            //{
            //    Console.WriteLine($"Key: {group.Key}");
            //    foreach (var post in group)
            //    {
            //        Console.WriteLine($"\t{post.Title}");
            //    }
            //}



            //var context = new BloggingContext();

            //var postGroups = from post in context.Posts.ToArray()
            //                 group post by post.Title.Length % 3;

            //foreach (var group in postGroups)
            //{
            //    Console.WriteLine($"Key: {group.Key}");
            //    foreach (var post in group)
            //    {
            //        Console.WriteLine($"\t{post.Title}");
            //    }
            //}



            //var context = new BloggingContext();

            //var postGroups = from post in context.Posts.ToArray()
            //                 group post by post.Title.Length / 3;

            //foreach (var group in postGroups)
            //{
            //    Console.WriteLine($"Key: {group.Key}");
            //    foreach (var post in group)
            //    {
            //        Console.WriteLine($"\t{post.Title}");
            //    }
            //}




            //var context = new BloggingContext();

            //var query = from post in context.Posts
            //            join blog in context.Blogs on post.Blog.Id equals blog.Id
            //            select new { post.Title, blog.Name };

            //foreach (var item in query)
            //{
            //    Console.WriteLine($"\"{item.Title}\" post in \"{item.Name}\" blog.");
            //}



            //var context = new BloggingContext();

            //var query = from blog in context.Blogs
            //            join post in context.Posts on blog.Id equals post.Id
            //            select new { post.Title, blog.Name };

            //foreach (var item in query)
            //{
            //    Console.WriteLine($"\"{item.Title}\" post in \"{item.Name}\" blog.");
            //}


            //var context = new BloggingContext();

            //var query = from blog in context.Blogs
            //            join post in context.Posts on blog.Id equals post.Blog.Id
            //            select new { post.Title, blog.Name };

            //foreach (var item in query)
            //{
            //    Console.WriteLine($"\"{item.Title}\" post in \"{item.Name}\" blog.");
            //}



            //var context = new BloggingContext();

            //var query = context.Blogs
            //    .Join(context.Posts, b => b.Id, p => p.Blog.Id, (b, p) => new ValueTuple<string, string>(b.Name, p.Title));

            //foreach (var item in query)
            //{
            //    Console.WriteLine($"\"{item.Item1}\" post in \"{item.Item2}\" blog.");
            //}




            var context = new BloggingContext();

            var query = context.Posts.Join(context.Blogs, p => p.Blog.Id, b => b.Id, (p, b) => new { p.Title, b.Name });

            foreach (var item in query)
            {
                Console.WriteLine($"\"{item.Title}\" post in \"{item.Name}\" blog.");
            }
        }
    }
}
