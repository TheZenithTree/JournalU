﻿using GreenJournal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GreenJournal.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewEntry : ContentPage
	{
		public ViewEntry (ViewEntryVM entryVM)
		{
			InitializeComponent ();
			this.BindingContext = entryVM;
		}
	}
}