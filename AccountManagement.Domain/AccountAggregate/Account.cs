﻿using AccountManagement.Domain.RoleAggregate;
using Framework.Domain;

namespace AccountManagement.Domain.AccountAggregate
{
    public class Account : EntityBase
    {
        public string Fullname { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Mobile { get; private set; }
        public long RoleId { get; private set; }
        public Role Role { get; private set; }
        public string ProfilePhoto { get; private set; }

        public Account(string fullname, string username, string password, string mobile, long roleId, string profilePhoto)
        {
            Fullname = fullname;
            Username = username;
            Password = password;
            Mobile = mobile;
            RoleId = roleId;
            ProfilePhoto = profilePhoto;
        }

        public void Edit(string fullname, string username, string mobile, long roleId, string profilePhoto)
        {
            Fullname = fullname;
            Username = username;
            Mobile = mobile;
            RoleId = roleId;
            if (!string.IsNullOrWhiteSpace(profilePhoto))
                ProfilePhoto = profilePhoto;
        }

        public void ChangePassword(string password) => Password = password;
    }
}
