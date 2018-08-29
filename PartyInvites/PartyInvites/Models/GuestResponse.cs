using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
		[Required(ErrorMessage = "Please enter your name")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Please enter your email address")]
		[RegularExpression(@"[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}", ErrorMessage = "Please enter a valid email address")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Please enter a phone number")]
		public string Phone { get; set; }

		[Required(ErrorMessage = "Please say whether you can attend")]
		public bool? WillAttend { get; set; }
	}
}
