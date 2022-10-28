using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;

namespace ProyectoIntegrador.Areas.Identity.views
{
    public class ManageUsersViewModel
    {
        public IdentityUser[] Administrator { set; get; }
        public IdentityUser[] Empleados { set; get; }
    }
}
