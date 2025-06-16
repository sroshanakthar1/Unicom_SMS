using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_2025_06_02.Data
{
    public static class Migration
    {
        public static string CreateUsersTable => @"
        CREATE TABLE IF NOT EXISTS Users (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Username TEXT NOT NULL,
            Name TEXT NOT NULL,
            Password TEXT NOT NULL,
            Role TEXT NOT NULL
        );";
    }
}
