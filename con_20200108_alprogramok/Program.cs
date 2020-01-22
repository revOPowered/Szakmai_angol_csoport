//O.K. rendben...(Jámbor)﻿
/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 2020. 01. 08.
 * Time: 12:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace con_20200108_alprogramok
{
	class Program
	{
		static int[] tomb = new int[25];
		static void init()
		{
			Random vsz = new Random();
			for(int i = 0; i < 25; i++)
			{
				tomb[i] = vsz.Next(-15,16);
			}
		}
		static void kiir()
		{
			for (int i = 0; i < 25; i++)
			{
				Console.Write("{0,4}", tomb[i]);
				if(i % 5 == 4)
				{
					Console.WriteLine();
				}
			}
		}
		static void rendez_minimum()
		{
			int min = 0, sorszam = 0, csere = 0, i = 0, j = 0;
			Console.WriteLine("\nSzámok a minimum elvű rendezés után:");
			for(i = 0; i < 24; i++)
			{
				min = tomb[i];
				sorszam = i;
				for(j = i + 1; j < 25; j++)
				{
					if(min>tomb[j])
					{
						min = tomb[j];
						sorszam = j;
					}
				}
				csere = tomb[i];
				tomb[i] = tomb[sorszam];
				tomb[sorszam] = csere;
				
			}
		}
		static void rendez_buborek()
		{
			int i = 0, j = 0;
			Console.WriteLine("\nSzámok a buborék rendezés után:");
			for(i = 0; i < 24; i++)
			{
				for(j = 0; j < 24; j++)
				{
					if(tomb[j] > tomb[j+1])
					{
						tomb[j] = tomb[j+1];
					}
				}
			}
		}
		public static void Main(string[] args)
		{
			init();
			Console.WriteLine("\nSzámok a rendezés előtt:");
			kiir();
			rendez_minimum();
			kiir();
			rendez_buborek();
			kiir();
			Console.ReadKey(true);
		}
	}
}
