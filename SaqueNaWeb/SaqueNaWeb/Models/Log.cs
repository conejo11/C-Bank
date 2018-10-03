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

		[Display(Name = "Usuário")]
        [Required(ErrorMessage = "Digite Seu Nome de Usuário")]
		public string UserName { get; set; }

		[Display(Name = "Senha")]
		[Required(ErrorMessage = "Digite Sua Senha")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		public int Notes { get; set; }

		[Display(Name = "Saque")]
		[RegularExpression(@"[0-9]+[a-zA-Z""'\s-]*$")]
		public double Total { get; set; }
	}
}
