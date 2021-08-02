/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Franz
 * Datum: 14.02.2017
 * Zeit: 15:02
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Cookie_Clicker_Beta
{
	
	public partial class MainForm : Form
	{
		double Cookies=0;
		double Faktor=1;
		int [] Upgrade = new int [1000];
		int [] Gekauft = new int [1000];
		//Shop#1
		int kosten1 =15;
		double UP1;
		
		//Shop#2
		int kosten2 =100;
		double UP2;
		int Gekauft2 =0;
		
		//Shop#3
		int kosten3 =1000;
		double UP3;
		int Gekauft3 =0;
		
		//Shop#4
		int kosten4 =5000;
		double UP5;
		int Gekauft4 =0;
		
				
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		
		void CookiesClickMouseClick(object sender, MouseEventArgs e)
		{
			
			
				Cookies = Cookies + Faktor;
				TbCookies.Text = Convert.ToString(Cookies);
				TbFaktor.Text = Convert.ToString(Faktor);
				
		}
		
		void Upgrade1Click(object sender, EventArgs e)
		{
		
			//Upgrade1
			if (Cookies >= 15)
			{
				Cookies = Cookies - kosten1;
				TbCookies.Text = Convert.ToString(Cookies);
				Faktor= Faktor +0.25;
				Upgrade[1]=Upgrade[1]+1;
				Up1.Text = Convert.ToString(Upgrade[1]);
				TbFaktor.Text = Convert.ToString(Faktor);
				Gekauft[1]++;
				
				//Clicks per Sec
				UP1 = 0.001 * Gekauft[1];
				
			}
			else
			{
				MessageBox.Show("Not enough Cookies!");
			}
			Upgrade_I.Interval=1500;
			Upgrade_I.Start();
			
		}
		
		void TbSpeichernClick(object sender, EventArgs e)
		{
			
			StreamWriter datei = new StreamWriter("Saves.txt");
			
			{
			
			datei.WriteLine(Faktor);
			datei.WriteLine(Upgrade[1]);
			datei.WriteLine(Upgrade[2]);
			datei.WriteLine(Upgrade[3]);
			datei.WriteLine(Upgrade[4]);
			datei.WriteLine(Cookies);
			datei.WriteLine(Gekauft[1]);
			datei.WriteLine(Gekauft[2]);
			datei.WriteLine(Gekauft[3]);
			datei.WriteLine(Gekauft[4]);
			}
			datei.Close();
		}
			
		
		void Button1Click(object sender, EventArgs e)
		{
			
			StreamReader datei = new StreamReader("Saves.txt");
			
			Faktor = Convert.ToDouble(datei.ReadLine());
			//Upgrades
			Upgrade[1] = Convert.ToInt32(datei.ReadLine());
			Upgrade[2] = Convert.ToInt32(datei.ReadLine());
			Upgrade[3] = Convert.ToInt32(datei.ReadLine());
			Cookies = Convert.ToInt32(datei.ReadLine());
			TbFaktor.Text = Convert.ToString(Faktor);
			Up1.Text = Convert.ToString(Upgrade[1]);
			Up2.Text = Convert.ToString(Upgrade[2]);
			Up3.Text = Convert.ToString(Upgrade[3]);
			TbCookies.Text = Convert.ToString(Cookies);
			
			datei.ReadLine();
			datei.Close();
		}
		
		void Upgrade2Click(object sender, EventArgs e)
		{
			//Upgrade2
			if (Cookies >= 100)
			{
				Cookies = Cookies - kosten2;
				TbCookies.Text = Convert.ToString(Cookies);
				Faktor= Faktor +0.5;
				Upgrade[2]=Upgrade[2]+1;
				Up2.Text = Convert.ToString(Upgrade[2]);
				TbFaktor.Text = Convert.ToString(Faktor);
			}
			else
			{
				MessageBox.Show("Not enough Cookies!");
			}
		}
		
		void Upgrade3Click(object sender, EventArgs e)
		{
			//Upgrade3
			if (Cookies >= 1000)
			{
				Cookies = Cookies - kosten1;
				TbCookies.Text = Convert.ToString(Cookies);
				Faktor= Faktor +1;
				Upgrade[3]=Upgrade[3]+1;
				Up3.Text = Convert.ToString(Upgrade[3]);
				TbFaktor.Text = Convert.ToString(Faktor);
			}
			else
			{
				MessageBox.Show("Not enough Cookies!");
			}	
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			StreamWriter datei = new StreamWriter("Saves.txt");
			
			{
			
			datei.WriteLine(Faktor);
			datei.WriteLine(Upgrade[1]);
			datei.WriteLine(Upgrade[2]);
			datei.WriteLine(Upgrade[3]);
			datei.WriteLine(Cookies);
			}
			datei.Close();
			
			new Form1().Show();
			
			
			
			
		}
		
		void Upgrade_ITick(object sender, EventArgs e)
		{
			
			
			if(Upgrade_I.Interval>10)
			{
				Upgrade_I.Interval=Upgrade_I.Interval-10;
				Cookies = Cookies + UP1;
				TbCookies.Text=Convert.ToString(Cookies);
			}
			
			
		}
	}
}
