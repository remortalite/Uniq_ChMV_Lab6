using System;
using System.Collections.Generic;
using System.Text;

using App.Models;

namespace App.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

	public List<Planner> Items = new List<Planner>(); 

	public MainWindowViewModel()
	{
		Items.Add(new Planner ("hey", "sdfsfsdf", DateTime.Today));
		Items.Add(new Planner ("hey", "sdfsfsdf", DateTime.Today));
		Items.Add(new Planner ("hey", "sdfsfsdf", DateTime.Today));
		Items.Add(new Planner ("hey", "sdfsfsdf", DateTime.Today));
		Items.Add(new Planner ("hey", "sdfsfsdf", DateTime.Today));
		Items.Add(new Planner ("hey", "sdfsfsdf", DateTime.Today));
		Items.Add(new Planner ("hey", "sdfsfsdf", DateTime.Today));

		foreach (var el in Items)
			Console.WriteLine(el.Name);
	}

    }
}
