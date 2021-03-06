﻿using System;
using Xamarin.Forms;

namespace TodoXaml
{
	public static class App
	{
		public static Page GetMainPage ()
		{
			var tdlx = new TodoListXaml ();
			tdlx.BindingContext = App.Database.GetItems ();
			var mainNav = new NavigationPage (tdlx);

			return mainNav;
		}

		static SQLite.Net.SQLiteConnection conn;
		static TodoItemDatabase database;
		public static void SetDatabaseConnection (SQLite.Net.SQLiteConnection connection)
		{
			conn = connection;
			database = new TodoItemDatabase (conn);
		}
		public static TodoItemDatabase Database {
			get { return database; }
		}


		static ITextToSpeech TextToSpeech;
		public static void SetTextToSpeech (ITextToSpeech speech)
		{
			TextToSpeech = speech;
		}
		public static ITextToSpeech Speech {
			get { return TextToSpeech; }
		}
	}
}

