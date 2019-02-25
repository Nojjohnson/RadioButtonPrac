using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonPrac
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

      textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      
    }

    private void lbl_TextChange_Click(object sender, EventArgs e)
    {
     
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      
      lbl_TextChange.Text = String.Format("{0}", textBox1.Text);
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
      pictureBox1.Visible = true;
      pictureBox1.Load("strat.jpg");
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
      pictureBox1.Visible = true;
      pictureBox1.Load("les_paul.jpg");
    }

    private void radioButton5_CheckedChanged(object sender, EventArgs e)
    {
      lbl_TextChange.ForeColor = System.Drawing.Color.Black;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      pictureBox1.Visible = false;
    }

    private void radioButton3_CheckedChanged(object sender, EventArgs e)
    {
      pictureBox1.Visible = true;
      pictureBox1.Load("explorer.jpg");
    }

    private void radioButton4_CheckedChanged(object sender, EventArgs e)
    {
      pictureBox1.Visible = true;
      pictureBox1.Load("firebird.jpg");
    }

    private void radioButton6_CheckedChanged(object sender, EventArgs e)
    {
      lbl_TextChange.ForeColor = System.Drawing.Color.Blue;
    }

    private void radioButton7_CheckedChanged(object sender, EventArgs e)
    {
      lbl_TextChange.ForeColor = System.Drawing.Color.Red;
    }

    private void radioButton8_CheckedChanged(object sender, EventArgs e)
    {
      lbl_TextChange.ForeColor = System.Drawing.Color.Green;
    }

    private void rb_UpperCase_CheckedChanged(object sender, EventArgs e)
    {
      lbl_TextChange.Text = lbl_TextChange.Text.ToUpper();
    }

    private void rb_LowerCase_CheckedChanged(object sender, EventArgs e)
    {
      lbl_TextChange.Text = lbl_TextChange.Text.ToLower();
    }

    private void rb_NormalCase_CheckedChanged(object sender, EventArgs e)
    {
      lbl_TextChange.Text = textBox1.Text;
    }
  }
}
