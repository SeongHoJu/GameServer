using System;
using System.Data.Entity;


namespace GameServer.Models
{
    public class UserInfo
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public DateTime LastestConnectDate { get; set; }
    }

    public class UserInfoDBContext : DbContext
    {
        public DbSet<UserInfo> UserLs { get; set; }
    }
}