using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Entities
{
    public class IdentityUserEntity : IdentityUser
    {
        public string Avatar { get; set; }
    }
}
