﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mapping.Classes
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Blog Blog { get; set; }
    }
}
