using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entity
{
	public class PasswordCode
	{
		public int Id { get; set; }
		public virtual User User { get; set; }
		public int UserId { get; set; }

		[StringLength(6)]
		public string Code { get; set; }

	}
}
