using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3004_.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int Remaining { get; set; }
        public string Pic { get; set; }
    }
}