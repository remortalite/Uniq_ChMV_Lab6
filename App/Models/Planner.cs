using System;
using System.Collections;

namespace App.Models
{
	public class Planner 
	{
		public string Name { get; set;}
		public string Text { get; set;}
		public DateTime dateTime {get; set;}

		public Planner(string name, string text, DateTime dt)
		{
			Name = name;
			Text = text;
			dateTime = dt;
		}
	}
}
