using System;

namespace WebCount.Models
{
    public class ErrorLog : IBaseModel
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public string StackTrace { get; set; }

        public DateTime DateCreated { get; set; }
    }
}