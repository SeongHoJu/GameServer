using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace GameServer.Models
{
    public class UserInfo
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public DateTime LastestConnectDate { get; set; }
    }

    public class UserInfoDBContext : DbContext
    {
        public DbSet<UserInfo> Users { get; set; }
    }
}