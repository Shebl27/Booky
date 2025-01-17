﻿using System.Collections.Generic;

namespace Booky.Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        //Navigations Properties
        public List<Book_Author> Book_Authors { get; set; }
    }
}