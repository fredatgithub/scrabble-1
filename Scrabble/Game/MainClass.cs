//  
//  MainClass.cs
//  
//  Author:
//       Ondřej Profant <ondrej.profant@gmail.com>
// 
//  Copyright (c) 2011 Ondřej Profant
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using Gtk;

namespace Scrabble.Game
{
	public static class MainClass
	{
		public static void Main ()
		{
			Gtk.Application.Init();
			var startwin = new Scrabble.GUI.StartWindow();
			startwin.Show();
			Gtk.Application.Run();
			/*
			if( Scrabble.Game.InitialConfig.allDone ) {
				var game = new Scrabble.Game.Game( Scrabble.Game.InitialConfig.players, Scrabble.Game.InitialConfig.dictionary);
				game.CreateMainWindowLoop();			
			}*/
#if DEBUG
			Console.WriteLine("[INFO]\tBYE");
#endif
			Gtk.Application.Quit();
		}
	}
}

