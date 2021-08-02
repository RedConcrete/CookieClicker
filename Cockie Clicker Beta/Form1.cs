/*
 * Erstellt mit SharpDevelop.
 * Benutzer: franz.klose
 * Datum: 20.02.2017
 * Zeit: 11:23
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Cookie_Clicker_Beta
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		double Cookies=0;
		double Faktor=1;
		int [] Upgrade = new int [1000];
		
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			StreamReader datei = new StreamReader("Saves.txt");
			
			Faktor = Convert.ToDouble(datei.ReadLine());
			//Upgrades
			Upgrade[1] = Convert.ToInt32(datei.ReadLine());
			Upgrade[2] = Convert.ToInt32(datei.ReadLine());
			Upgrade[3] = Convert.ToInt32(datei.ReadLine());
			Cookies = Convert.ToInt32(datei.ReadLine());
			TbFaktor.Text = Convert.ToString(Faktor);
			TbCookies.Text = Convert.ToString(Cookies);
			
			datei.ReadLine();
			datei.Close();
			
		}
	}
}
