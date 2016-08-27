using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCount.Models
{
    public class Role : IBaseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}