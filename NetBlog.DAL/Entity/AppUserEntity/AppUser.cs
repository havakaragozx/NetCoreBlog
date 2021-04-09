using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace NetBlog.DAL.Entity.AppUserEntity
{
    //package manager console üzerinden Microsoft.AspNetCore.Identity.EntityFrameworkCore kütüphanesini kurmamız gereklidir.
   public class AppUser:IdentityUser
    {
    }
}
