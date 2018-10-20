﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalGabriel
{
    public class Function
    {
        private string name;
        private string password;
        private string role;

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        
           
        public Function(string name, string password, string role)
        {
        
            this.Name = name;
            this.Password = password;
            this.Role = role;

        }
    }
}
