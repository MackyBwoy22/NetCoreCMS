﻿using NetCoreCMS.Framework.Core.Models;

namespace NetCoreCMS.Framework.Core.Events.App
{
    public class UserActivity
    {
        public NccUser User{ get; set; }
        public string Ip { get; set; }
        public Type ActivityType { get; set; }

        public enum Type
        {
            Registered,
            Logedin,
            Logedout,
            RoleChanged,
            InActivated,
            EmailConfirmed,
            Activated            
        }
    }
}