using System;
using System.Collections.Generic;
using System.Text;

namespace ContactApp
{
    public class Note
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Note()
        {

        }

        public Note(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
