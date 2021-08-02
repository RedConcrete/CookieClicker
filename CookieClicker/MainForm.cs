/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Franz
 * Datum: 11.10.2016
 * Zeit: 13:54
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Clicker
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		//Click Function
		double Clicks = 1;
		double Plus = 1;
		
		
		//Items 1
		int Gekauft1 = 0;
		double Upgrade1 = 10; //50
		double Cps;
		
		//Items 2
		int Gekauft2 = 0;
		double Upgrade2 = 10; //1000
		double Cps2;
		
		//Items 3
		int Gekauft3 = 0;
		double Upgrade3 = 10; //100000
		double Cps3;
		
		//Items 4
		int Gekauft4 = 0;
		double Upgrade4 = 10; //10000000
		double Cps4;
		
		//Items 5
		int Gekauft5 = 0;
		double Upgrade5 = 10; //1000000000
		double Cps5;
		
		
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			//
			
		}
		
		void ClickClick(object sender, EventArgs e)
		{
				
			Clicks = Clicks + Plus;
			
			TbClick.Text=Convert.ToString(Clicks);
		}
		
		void Buy1Click(object sender, EventArgs e)
		{
			if (Clicks < Upgrade1) //50
			{
				MessageBox.Show("Das kannst du nicht kaufen!!!!!");
			}
			else 
			{
				double	Upgrades = 0.25;
				//Die Kosten
				Clicks = Clicks - Upgrade1;
				Upgrade1 = Upgrade1 + 5;
				//Upgrade um 0.25
				Plus = Upgrades + Plus;
				//Anzeige
				Gekauft1 = Gekauft1 + 1;
				U1.Text= Convert.ToString(Gekauft1);
				TbClick.Text=Convert.ToString(Clicks);
				Cost1.Text=Convert.ToString(Upgrade1);
				
				//Clicks per Sec
				Cps = 0.001 * Gekauft1;
				CpS1.Text=Convert.ToString(Cps);
			}
			
			U1timer.Interval=1500;
			U1timer.Start();
			
			
			}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			if(U1timer.Interval>10)
			{
				U1timer.Interval=U1timer.Interval-10;
				Clicks = Clicks + Cps;
				TbClick.Text=Convert.ToString(Clicks);
			}
			
			
		}
		
		void Buy2Click(object sender, EventArgs e)
		{
			
			if (Clicks < Upgrade2) //1000
			{
				MessageBox.Show("Das kannst du nicht kaufen!!!!!");
			}
			else 
			{
				double	Upgrades2 = 1;
				//Die Kosten
				Clicks = Clicks - Upgrade2;
				Upgrade2 = Upgrade2 + 5; //50
				//Upgrade um 1
				Plus = Upgrades2 + Plus;
				//Anzeige
				Gekauft2 = Gekauft2 + 1;
				U2.Text = Convert.ToString(Gekauft2);
				TbClick.Text = Convert.ToString(Clicks);
				Cost2.Text=Convert.ToString(Upgrade2);
				//Clicks per Sec
				Cps2 = 0.025 * Gekauft2;
				CsP2.Text=Convert.ToString(Cps2);
			}
			
			U2timer.Interval=1500;
			U2timer.Start();
			
			
			
		}
		
		void U2timerTick(object sender, EventArgs e)
		{
			if(U2timer.Interval>10)
			{
				U3timer.Interval=U1timer.Interval-10;
				Clicks = Clicks + Cps2;
				TbClick.Text=Convert.ToString(Clicks);
			}
			
		}
		
		
		
		void Buy3Click(object sender, EventArgs e)
		{
			if (Clicks < Upgrade3 ) //100000
			{
				MessageBox.Show("Das kannst du nicht kaufen!!!!!");
			}
			else 
			{
				double	Upgrades3 = 5;
				//Die Kosten
				Clicks = Clicks - Upgrade3;
				Upgrade3 = Upgrade3 + 5; //500
				//Upgrade um 1
				Plus = Upgrades3 + Plus;
				//Anzeige
				Gekauft3 = Gekauft3 + 1;
				U3.Text = Convert.ToString(Gekauft3);
				TbClick.Text = Convert.ToString(Clicks);
				Cost3.Text=Convert.ToString(Upgrade3);
				//Clicks per Sec
				Cps3 = 0.05 * Gekauft3;
				cpps.Text=Convert.ToString(Cps3);
				
			}
			
			U3timer.Interval=1500;
			U3timer.Start();
			
			
		}
		
		void U3timerTick(object sender, EventArgs e)
		{
			if(U3timer.Interval>10)
			{
				U3timer.Interval=U1timer.Interval-10;
				Clicks = Clicks + Cps3;
				TbClick.Text=Convert.ToString(Clicks);
		}
		}
		
		
		void Buy4Click(object sender, EventArgs e)
		{
			if (Clicks < Upgrade4 ) //100000
			{
				MessageBox.Show("Das kannst du nicht kaufen!!!!!");
			}
			else 
			{
				double	Upgrades4 = 10;
				//Die Kosten
				Clicks = Clicks - Upgrade4;
				Upgrade4 = Upgrade4 + 5; //500
				//Upgrade um 1
				Plus = Upgrades4 + Plus;
				//Anzeige
				Gekauft4 = Gekauft4 + 1;
				U4.Text = Convert.ToString(Gekauft4);
				TbClick.Text = Convert.ToString(Clicks);
				Cost4.Text=Convert.ToString(Upgrade4);
				//Clicks per Sec
				Cps4 = 0.5 * Gekauft4;
				cppps.Text=Convert.ToString(Cps4);
				
			}
			
			U4timer.Interval=1500;
			U4timer.Start();
			
		}
		
		void U4timerTick(object sender, EventArgs e)
		{
			if(U4timer.Interval>10)
			{
				U4timer.Interval=U1timer.Interval-10;
				Clicks = Clicks + Cps4;
				TbClick.Text=Convert.ToString(Clicks);
		}
	}
		
		void Buy5Click(object sender, EventArgs e)
		{
			if (Clicks < Upgrade5 ) //10000000
			{
				MessageBox.Show("Das kannst du nicht kaufen!!!!!");
			}
			else 
			{
				double	Upgrades5 = 20;
				//Die Kosten
				Clicks = Clicks - Upgrade5;
				Upgrade5 = Upgrade5 + 5; //1000
				//Upgrade um 1
				Plus = Upgrades5 + Plus;
				//Anzeige
				Gekauft5 = Gekauft5 + 1;
				U5.Text = Convert.ToString(Gekauft5);
				TbClick.Text = Convert.ToString(Clicks);
				Cost5.Text=Convert.ToString(Upgrade5);
				//Clicks per Sec
				Cps5 = 1 * Gekauft5;
				cpppps.Text=Convert.ToString(Cps5);
				
			}
			
			U5timer.Interval=1500;
			U5timer.Start();
		}
		
		void U5timerTick(object sender, EventArgs e)
		{
			if(U5timer.Interval>10)
			{
				U5timer.Interval=U1timer.Interval-10;
				Clicks = Clicks + Cps5;
				TbClick.Text=Convert.ToString(Clicks);
		}
}
}
}