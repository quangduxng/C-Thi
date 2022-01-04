﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCD.DTO
{
    public class Account
    {
        public Account(string userName, string password, string displayName, int type)
        {
            this.UserName = userName;
            this.Password = password;
            this.DisplayName = displayName;
            this.Type = type;
        }

        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.Password = row["password"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.Type = (int)row["type"];

        }

        private int type;
        private string password;
        private string displayName;
        private string userName;

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string Password { get => password; set => password = value; }
        public int Type { get => type; set => type = value; }
    }
}
