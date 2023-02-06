﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public List<Role> Roles { get; set; }
        public List<Loot> Loots { get; set; }
        public List<Storage> Storages { get; set; }
    }
}
