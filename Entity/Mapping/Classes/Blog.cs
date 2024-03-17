using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mapping.Classes
{
    public class Blog
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public List<Post> Posts { get; set; }
    }
}
