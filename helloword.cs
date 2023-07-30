#hello worldcs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16 {

public partial class Form1 : Form {

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		// Creating and setting the label
		Label mylab = new Label();
		mylab.Text = "Hello Wprld C#";
		mylab.Location = new Point(222, 90);
		mylab.AutoSize = true;
		mylab.Font = new Font("Calibri", 20);
		mylab.ForeColor = Color.Green;

		// Adding this control to the form
		this.Controls.Add(mylab);
	}
}
}
