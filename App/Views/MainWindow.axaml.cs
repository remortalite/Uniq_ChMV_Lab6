using Avalonia.Controls;

using System;

namespace App.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

	    this.FindControl<DatePicker>("MainDatePicker").SelectedDate = DateTime.Today;
        }
    }
}
