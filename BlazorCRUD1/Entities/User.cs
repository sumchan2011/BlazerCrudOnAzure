using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorCRUD1.Entities
{
    public class User : Base
    {
        public User()
        {
        }

        public String UserName { get; set; }
        public String PasswordHash { get; set; }

    }
}
