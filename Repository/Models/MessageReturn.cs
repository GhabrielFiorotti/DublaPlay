using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Threading;

namespace Repository.Models
{
    public class MessageReturn
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public object ObjectsReturn { get; set; }


        public MessageReturn(string title, string description, bool status, object objects)
        {
            Title = title;
            Description = description;
            Status = status;
            ObjectsReturn = objects;
        }

        public MessageReturn(string title, string description, bool status)
        {
            Title = title;
            Status = status;
            Description = description;
        }

    }

}
