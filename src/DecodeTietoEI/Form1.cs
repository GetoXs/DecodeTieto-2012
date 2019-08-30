using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DecodeTietoEI.Zad;
using System.Xml;
using System.Xml.Schema;
using System.IO;

namespace DecodeTietoEI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnZad1_Click(object sender, EventArgs e)
		{
			Zad1 zad = new Zad1();
			zad.Run();
			this.lblZad1.Text = zad.result.ToString();
		}

		private void buttonZad2_Click(object sender, EventArgs e)
		{
			Zad2 zad = new Zad2();
			zad.Run();
			this.labelZad2.Text = zad.result.ToString();
		}

		private void buttonZad3_Click(object sender, EventArgs e)
		{
			Zad3 zad = new Zad3();
			zad.Run();
			this.labelZad3.Text = zad.result.ToString();
		}

		private void buttonZad4_Click(object sender, EventArgs e)
		{
			Zad4 zad = new Zad4();
			zad.Run();
			this.labelZad4.Text = zad.result.ToString();
		}

		private void buttonZad5_Click(object sender, EventArgs e)
		{
			Zad5 zad = new Zad5();
			zad.Run();
			this.labelZad5.Text = zad.result.ToString();
		}

		private void buttonZad6_Click(object sender, EventArgs e)
		{
			Zad6 zad = new Zad6();
			zad.Run();
			this.labelZad6.Text = zad.result.ToString();
		}

		private void buttonZad7_Click(object sender, EventArgs e)
		{
			Zad7 zad = new Zad7();
			zad.Run();
			this.labelZad7.Text = zad.result.ToString();
		}

		private void buttonZad8_Click(object sender, EventArgs e)
		{
			Zad8 zad = new Zad8();
			zad.Run();
			this.labelZad8.Text = zad.result.ToString();
		}

		private void buttonZad9_Click(object sender, EventArgs e)
		{
			Zad9 zad = new Zad9();
			zad.Run();
			this.labelZad9.Text = zad.result.ToString();
		}

		private void buttonZad10_Click(object sender, EventArgs e)
		{
			Zad10 zad = new Zad10();
			zad.Run();
			this.labelZad10.Text = zad.result.ToString();
		}

		private void buttonZad11_Click(object sender, EventArgs e)
		{
			Zad11 zad = new Zad11();
			zad.Run();
			this.labelZad11.Text = zad.result.ToString();
		}

		private void buttonZad12_Click(object sender, EventArgs e)
		{
			Zad12 zad = new Zad12();
			zad.Run();
			this.labelZad12.Text = zad.result.ToString();
		}

		private void buttonZad13_Click(object sender, EventArgs e)
		{
			Zad14 zad = new Zad14();
			zad.Run();
			this.labelZad14.Text = zad.result.ToString();
		}

		private void buttonZad15_Click(object sender, EventArgs e)
		{
			Zad15 zad = new Zad15();
			zad.Run();
			this.labelZad15.Text = zad.result.ToString();
		}

		private void buttonZad16_Click(object sender, EventArgs e)
		{
			Zad16 zad = new Zad16();
			zad.Run();
			this.labelZad16.Text = zad.result.ToString();
		}

		private void buttonZad17_Click(object sender, EventArgs e)
		{
			Zad17 zad = new Zad17();
			zad.Run();
			this.labelZad17.Text = zad.result.ToString();
		}

		private void buttonZad18_Click(object sender, EventArgs e)
		{
			Zad18 zad = new Zad18();
			zad.Run();
			this.labelZad18.Text = zad.result.ToString();
		}

		private void buttonZad19_Click(object sender, EventArgs e)
		{
			Zad19 zad = new Zad19();
			zad.Run();
			this.labelZad19.Text = zad.result.ToString();
		}

		private void buttonZad20_Click(object sender, EventArgs e)
		{
			Zad20 zad = new Zad20();
			zad.Run();
			this.labelZad20.Text = zad.result.ToString();
		}

		private void buttonZad21_Click(object sender, EventArgs e)
		{
			Zad21 zad = new Zad21();
			zad.Run();
			this.labelZad21.Text = zad.result.ToString();
		}

		private void buttonZad22_Click(object sender, EventArgs e)
		{
			Zad22 zad = new Zad22();
			zad.Run();
			this.labelZad22.Text = zad.result.ToString();
		}

		private void buttonZad23_Click(object sender, EventArgs e)
		{
			Zad23 zad = new Zad23();
			zad.Run();
			this.labelZad23.Text = zad.result.ToString();
		}

		private void buttonZad26_Click(object sender, EventArgs e)
		{
			Zad26 zad = new Zad26();
			zad.Run();
			this.labelZad26.Text = zad.result.ToString();
		}

		private void buttonZad27_Click(object sender, EventArgs e)
		{
			Zad27 zad = new Zad27();
			zad.Run();
			this.labelZad27.Text = zad.result.ToString();
		}

		private void button33_Click(object sender, EventArgs e)
		{
			Zad33 zad = new Zad33();
			zad.Run();
			this.label33.Text = zad.result.ToString();
		}

		private void button36_Click(object sender, EventArgs e)
		{
			Zad36 zad = new Zad36();
			zad.Run();
			this.label36.Text = zad.result.ToString();
		}

		private void button39_Click(object sender, EventArgs e)
		{
			Zad39 zad = new Zad39();
			zad.Run();
			this.label39.Text = zad.result.ToString();
		}

		private void button40_Click(object sender, EventArgs e)
		{
			Zad40 zad = new Zad40();
			zad.Run();
			this.label40.Text = zad.result.ToString();
		}

		private void button41_Click(object sender, EventArgs e)
		{
			Zad41 zad = new Zad41();
			zad.Run();
			this.label41.Text = zad.result.ToString();
		}

		private void button42_Click(object sender, EventArgs e)
		{
			Zad42 zad = new Zad42();
			zad.Run();
			this.label42.Text = zad.result.ToString();
		}

		private void button45_Click(object sender, EventArgs e)
		{
			Zad45 zad = new Zad45();
			zad.Run();
			this.label45.Text = zad.result.ToString();
		}

		private void button46_Click(object sender, EventArgs e)
		{
			Zad46 zad = new Zad46();
			zad.Run();
			this.label46.Text = zad.result.ToString();
		}

		private void button47_Click(object sender, EventArgs e)
		{
			Zad47 zad = new Zad47();
			zad.Run();
			this.label47.Text = zad.result.ToString();
		}

		private void button50_Click(object sender, EventArgs e)
		{
			Zad50 zad = new Zad50();
			zad.Run();
			this.label50.Text = zad.result.ToString();
		}

		private void button49_Click(object sender, EventArgs e)
		{
			Zad49 zad = new Zad49();
			zad.Run();
			this.label49.Text = zad.result.ToString();
		}

		private void button44_Click(object sender, EventArgs e)
		{
			Zad44 zad = new Zad44();
			zad.Run();
			this.label44.Text = zad.result.ToString();
		}

		private void button37_Click(object sender, EventArgs e)
		{
			Zad37 zad = new Zad37();
			zad.Run();
			this.label37.Text = zad.result.ToString();
		}

		private void button34_Click(object sender, EventArgs e)
		{
			Zad34 zad = new Zad34();
			zad.Run();
			this.label34.Text = zad.result.ToString();
		}

		private void button31_Click(object sender, EventArgs e)
		{
			Zad31 zad = new Zad31();
			zad.Run();
			this.label31.Text = zad.result.ToString();
		}

		private void buttonZad30_Click(object sender, EventArgs e)
		{
			Zad30 zad = new Zad30();
			zad.Run();
			this.labelZad30.Text = zad.result.ToString();
		}

		private void buttonZad25_Click(object sender, EventArgs e)
		{
			Zad25 zad = new Zad25();
			zad.Run();
			this.labelZad25.Text = zad.result.ToString();
		}

		private void buttonZad24_Click(object sender, EventArgs e)
		{
			Zad24 zad = new Zad24();
			zad.Run();
			this.labelZad24.Text = zad.result.ToString();
		}
	}
}
