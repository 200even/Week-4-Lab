﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week4_Lab.Models
{
    public class NewPost
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime PostDate { get; set; }
        public string Author { get; set; }
    }
}