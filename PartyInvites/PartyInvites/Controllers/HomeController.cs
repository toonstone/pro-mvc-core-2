using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
	public class HomeController : Controller
	{
		public ViewResult Index()
		{
			int hour = DateTime.Now.Hour;
			ViewBag.Greeting = hour < 12 ? "Morning" : "Afternoon";
			return this.View("MyView");
		}

		[HttpGet]
		public ViewResult RsvpForm()
		{
			return View();
		}

		[HttpPost]
		public ViewResult RsvpForm(GuestResponse guestResponse)
		{
			if (ModelState.IsValid)
			{
				Repository.AddResponse(guestResponse);
				return View("Thanks", guestResponse);
			}
			else
			{
				// validation Error
				return View();
			}			
		}

		[HttpGet]
		public ViewResult ListResponses()
		{
			return View(Repository.Responses.Where(response => response.WillAttend == true));
		}
	}
}
