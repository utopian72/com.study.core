using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace com.study.core.model
{
    public class User
    {
		public string  Id { get; set; }

		[Encrypted]
		public string Username { get; set; }

		[Encrypted]
		public string Password { get; set; }

		public int Age { get; set; }
	}
}
