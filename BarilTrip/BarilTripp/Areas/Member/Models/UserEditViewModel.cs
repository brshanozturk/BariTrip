﻿using Microsoft.AspNetCore.Http;

namespace BarilTripp.Areas.Member.Models
{
	public class UserEditViewModel
	{
        public string name { get; set; }
        public string surname { get; set; }
        public string password { get; set; }
        public string confrimpassword { get; set; }
        public string phonenumber { get; set; }
        public string mail { get; set; }
        public string imageurl { get; set; }

        public IFormFile Image { get; set; }




    }
}
