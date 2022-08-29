using System;
using System.Collections.Generic;
using Wisej.Web;

namespace Wisej.AppWithSessionlessHandler
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			Application.MainPage = new Page1();
		}

		internal static event EventHandler ClientListChanged;
		private static List<string> _clientList = new List<string>();

		internal static void AddClient(string name)
		{
			lock (_clientList)
			{
				if (!_clientList.Contains(name))
				{
					_clientList.Add(name);

					ClientListChanged?.Invoke(null, EventArgs.Empty);
				}
			}
		}

		internal static string[] GetList()
		{
			lock (_clientList)
			{
				return _clientList.ToArray();
			}
		}

		//
		// You can use the entry method below
		// to receive the parameters from the URL in the args collection.
		//
		//static void Main(NameValueCollection args)
		//{
		//}
	}
}