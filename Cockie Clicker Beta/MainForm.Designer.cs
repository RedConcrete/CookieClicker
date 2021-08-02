/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Franz
 * Datum: 14.02.2017
 * Zeit: 15:02
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
namespace Cookie_Clicker_Beta
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.CookiesClick = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.Up1 = new System.Windows.Forms.TextBox();
			this.Up2 = new System.Windows.Forms.TextBox();
			this.Up3 = new System.Windows.Forms.TextBox();
			this.Up4 = new System.Windows.Forms.TextBox();
			this.Up5 = new System.Windows.Forms.TextBox();
			this.Up6 = new System.Windows.Forms.TextBox();
			this.Up7 = new System.Windows.Forms.TextBox();
			this.Up8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.TbCookies = new System.Windows.Forms.TextBox();
			this.Upgrade1 = new System.Windows.Forms.Button();
			this.Upgrade2 = new System.Windows.Forms.Button();
			this.Upgrade3 = new System.Windows.Forms.Button();
			this.Upgrade4 = new System.Windows.Forms.Button();
			this.Upgrade5 = new System.Windows.Forms.Button();
			this.Upgrade6 = new System.Windows.Forms.Button();
			this.Upgrade7 = new System.Windows.Forms.Button();
			this.Upgrade8 = new System.Windows.Forms.Button();
			this.TbFaktor = new System.Windows.Forms.TextBox();
			this.TbSpeichern = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.Upgrade_I = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// CookiesClick
			// 
			this.CookiesClick.Location = new System.Drawing.Point(35, 29);
			this.CookiesClick.Name = "CookiesClick";
			this.CookiesClick.Size = new System.Drawing.Size(166, 150);
			this.CookiesClick.TabIndex = 0;
			this.CookiesClick.Text = "button1";
			this.CookiesClick.UseVisualStyleBackColor = true;
			this.CookiesClick.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CookiesClickMouseClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(310, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Upgrade 1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(310, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 21);
			this.label2.TabIndex = 2;
			this.label2.Text = "Upgrade 2";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(310, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 21);
			this.label3.TabIndex = 3;
			this.label3.Text = "Upgrade 3";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(310, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 21);
			this.label4.TabIndex = 4;
			this.label4.Text = "Upgrade 4";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(310, 121);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 21);
			this.label5.TabIndex = 5;
			this.label5.Text = "Upgrade 5";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(310, 144);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 21);
			this.label6.TabIndex = 6;
			this.label6.Text = "Upgrade 6";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(310, 167);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 21);
			this.label7.TabIndex = 7;
			this.label7.Text = "Upgrade 7";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(310, 189);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 21);
			this.label8.TabIndex = 8;
			this.label8.Text = "Upgrade 8";
			// 
			// Up1
			// 
			this.Up1.Location = new System.Drawing.Point(374, 26);
			this.Up1.Name = "Up1";
			this.Up1.Size = new System.Drawing.Size(100, 20);
			this.Up1.TabIndex = 9;
			// 
			// Up2
			// 
			this.Up2.Location = new System.Drawing.Point(374, 49);
			this.Up2.Name = "Up2";
			this.Up2.Size = new System.Drawing.Size(100, 20);
			this.Up2.TabIndex = 10;
			// 
			// Up3
			// 
			this.Up3.Location = new System.Drawing.Point(374, 72);
			this.Up3.Name = "Up3";
			this.Up3.Size = new System.Drawing.Size(100, 20);
			this.Up3.TabIndex = 11;
			// 
			// Up4
			// 
			this.Up4.Location = new System.Drawing.Point(374, 95);
			this.Up4.Name = "Up4";
			this.Up4.Size = new System.Drawing.Size(100, 20);
			this.Up4.TabIndex = 12;
			// 
			// Up5
			// 
			this.Up5.Location = new System.Drawing.Point(374, 118);
			this.Up5.Name = "Up5";
			this.Up5.Size = new System.Drawing.Size(100, 20);
			this.Up5.TabIndex = 13;
			// 
			// Up6
			// 
			this.Up6.Location = new System.Drawing.Point(374, 141);
			this.Up6.Name = "Up6";
			this.Up6.Size = new System.Drawing.Size(100, 20);
			this.Up6.TabIndex = 14;
			// 
			// Up7
			// 
			this.Up7.Location = new System.Drawing.Point(374, 164);
			this.Up7.Name = "Up7";
			this.Up7.Size = new System.Drawing.Size(100, 20);
			this.Up7.TabIndex = 15;
			// 
			// Up8
			// 
			this.Up8.Location = new System.Drawing.Point(374, 186);
			this.Up8.Name = "Up8";
			this.Up8.Size = new System.Drawing.Size(100, 20);
			this.Up8.TabIndex = 16;
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(548, 26);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(100, 20);
			this.textBox9.TabIndex = 17;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(480, 29);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(41, 21);
			this.label9.TabIndex = 18;
			this.label9.Text = "label9";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(480, 52);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(41, 21);
			this.label10.TabIndex = 19;
			this.label10.Text = "label10";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(480, 75);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(41, 21);
			this.label11.TabIndex = 20;
			this.label11.Text = "label11";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(480, 98);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(41, 21);
			this.label12.TabIndex = 21;
			this.label12.Text = "label12";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(480, 121);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(41, 21);
			this.label13.TabIndex = 22;
			this.label13.Text = "label13";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(480, 144);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(41, 21);
			this.label14.TabIndex = 23;
			this.label14.Text = "label14";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(480, 167);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(41, 21);
			this.label15.TabIndex = 24;
			this.label15.Text = "label15";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(480, 189);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(41, 21);
			this.label16.TabIndex = 25;
			this.label16.Text = "label16";
			// 
			// TbCookies
			// 
			this.TbCookies.Location = new System.Drawing.Point(58, 186);
			this.TbCookies.Name = "TbCookies";
			this.TbCookies.Size = new System.Drawing.Size(123, 20);
			this.TbCookies.TabIndex = 26;
			// 
			// Upgrade1
			// 
			this.Upgrade1.Location = new System.Drawing.Point(289, 28);
			this.Upgrade1.Name = "Upgrade1";
			this.Upgrade1.Size = new System.Drawing.Size(15, 15);
			this.Upgrade1.TabIndex = 27;
			this.Upgrade1.UseVisualStyleBackColor = true;
			this.Upgrade1.Click += new System.EventHandler(this.Upgrade1Click);
			// 
			// Upgrade2
			// 
			this.Upgrade2.Location = new System.Drawing.Point(289, 51);
			this.Upgrade2.Name = "Upgrade2";
			this.Upgrade2.Size = new System.Drawing.Size(15, 15);
			this.Upgrade2.TabIndex = 28;
			this.Upgrade2.UseVisualStyleBackColor = true;
			this.Upgrade2.Click += new System.EventHandler(this.Upgrade2Click);
			// 
			// Upgrade3
			// 
			this.Upgrade3.Location = new System.Drawing.Point(289, 74);
			this.Upgrade3.Name = "Upgrade3";
			this.Upgrade3.Size = new System.Drawing.Size(15, 15);
			this.Upgrade3.TabIndex = 29;
			this.Upgrade3.UseVisualStyleBackColor = true;
			this.Upgrade3.Click += new System.EventHandler(this.Upgrade3Click);
			// 
			// Upgrade4
			// 
			this.Upgrade4.Location = new System.Drawing.Point(289, 97);
			this.Upgrade4.Name = "Upgrade4";
			this.Upgrade4.Size = new System.Drawing.Size(15, 15);
			this.Upgrade4.TabIndex = 30;
			this.Upgrade4.UseVisualStyleBackColor = true;
			// 
			// Upgrade5
			// 
			this.Upgrade5.Location = new System.Drawing.Point(289, 120);
			this.Upgrade5.Name = "Upgrade5";
			this.Upgrade5.Size = new System.Drawing.Size(15, 15);
			this.Upgrade5.TabIndex = 31;
			this.Upgrade5.UseVisualStyleBackColor = true;
			// 
			// Upgrade6
			// 
			this.Upgrade6.Location = new System.Drawing.Point(289, 143);
			this.Upgrade6.Name = "Upgrade6";
			this.Upgrade6.Size = new System.Drawing.Size(15, 15);
			this.Upgrade6.TabIndex = 32;
			this.Upgrade6.UseVisualStyleBackColor = true;
			// 
			// Upgrade7
			// 
			this.Upgrade7.Location = new System.Drawing.Point(289, 166);
			this.Upgrade7.Name = "Upgrade7";
			this.Upgrade7.Size = new System.Drawing.Size(15, 15);
			this.Upgrade7.TabIndex = 33;
			this.Upgrade7.UseVisualStyleBackColor = true;
			// 
			// Upgrade8
			// 
			this.Upgrade8.Location = new System.Drawing.Point(289, 188);
			this.Upgrade8.Name = "Upgrade8";
			this.Upgrade8.Size = new System.Drawing.Size(15, 15);
			this.Upgrade8.TabIndex = 34;
			this.Upgrade8.UseVisualStyleBackColor = true;
			// 
			// TbFaktor
			// 
			this.TbFaktor.Location = new System.Drawing.Point(69, 3);
			this.TbFaktor.Name = "TbFaktor";
			this.TbFaktor.Size = new System.Drawing.Size(100, 20);
			this.TbFaktor.TabIndex = 35;
			// 
			// TbSpeichern
			// 
			this.TbSpeichern.Location = new System.Drawing.Point(399, 329);
			this.TbSpeichern.Name = "TbSpeichern";
			this.TbSpeichern.Size = new System.Drawing.Size(75, 23);
			this.TbSpeichern.TabIndex = 36;
			this.TbSpeichern.Text = "Save";
			this.TbSpeichern.UseVisualStyleBackColor = true;
			this.TbSpeichern.Click += new System.EventHandler(this.TbSpeichernClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(480, 329);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 37;
			this.button1.Text = "Load";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(157, 333);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 38;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// Upgrade_I
			// 
			this.Upgrade_I.Interval = 2000;
			this.Upgrade_I.Tick += new System.EventHandler(this.Upgrade_ITick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(658, 364);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.TbSpeichern);
			this.Controls.Add(this.TbFaktor);
			this.Controls.Add(this.Upgrade8);
			this.Controls.Add(this.Upgrade7);
			this.Controls.Add(this.Upgrade6);
			this.Controls.Add(this.Upgrade5);
			this.Controls.Add(this.Upgrade4);
			this.Controls.Add(this.Upgrade3);
			this.Controls.Add(this.Upgrade2);
			this.Controls.Add(this.Upgrade1);
			this.Controls.Add(this.TbCookies);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.Up8);
			this.Controls.Add(this.Up7);
			this.Controls.Add(this.Up6);
			this.Controls.Add(this.Up5);
			this.Controls.Add(this.Up4);
			this.Controls.Add(this.Up3);
			this.Controls.Add(this.Up2);
			this.Controls.Add(this.Up1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CookiesClick);
			this.Name = "MainForm";
			this.Text = "Cockie Clicker Beta";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Timer Upgrade_I;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button TbSpeichern;
		private System.Windows.Forms.TextBox TbFaktor;
		private System.Windows.Forms.Button Upgrade8;
		private System.Windows.Forms.Button Upgrade7;
		private System.Windows.Forms.Button Upgrade6;
		private System.Windows.Forms.Button Upgrade5;
		private System.Windows.Forms.Button Upgrade4;
		private System.Windows.Forms.Button Upgrade3;
		private System.Windows.Forms.Button Upgrade2;
		private System.Windows.Forms.Button Upgrade1;
		private System.Windows.Forms.TextBox TbCookies;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox Up8;
		private System.Windows.Forms.TextBox Up7;
		private System.Windows.Forms.TextBox Up6;
		private System.Windows.Forms.TextBox Up5;
		private System.Windows.Forms.TextBox Up4;
		private System.Windows.Forms.TextBox Up3;
		private System.Windows.Forms.TextBox Up2;
		private System.Windows.Forms.TextBox Up1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button CookiesClick;
	}
}
