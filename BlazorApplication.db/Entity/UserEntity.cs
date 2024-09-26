//using Microsoft.AspNet.Identity.EntityFramework;//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApplication.Data.Entity
{
	 public class UserEntity
	 {
		[Key]
		public int Userid { get; set; }
		public string Name { get; set; }
		public long PhoneNumber { get; set; }
		public string Password { get; set; }
	 }
}
