using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SaqueNaWeb.Models
{
	public class Log
	{
	    public int Id { get; set; }
        [Required(ErrorMessage = "UserName is required")]
		public string UserName { get; set; }
		[Required(ErrorMessage = "Password is required")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}
