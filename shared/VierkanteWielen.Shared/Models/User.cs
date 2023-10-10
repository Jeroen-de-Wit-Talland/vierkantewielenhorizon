using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierkanteWielen.Shared.Models
{
    internal class User : IdentityUser
    {
		private string _firstName = string.Empty;

		[Required]
		public string FirstName
		{
			get { return _firstName; }
			set { _firstName = value; }
		}

		private string _lastName = string.Empty;
		[Required]
		public string LastName
		{
			get { return _lastName; }
			set { _lastName = value; }
		}




	}
}
