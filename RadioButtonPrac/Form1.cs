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

      lbl_TextChange.Text = textBox1.Text;
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
      pictureBox1.Visible = true;
      pictureBox1.Image = Properties.Resources.strat;
      img_TextBox.Visible = false;
      img_TextBox.BackColor = Color.White;
      img_TextBox.BorderStyle = BorderStyle.None;
      img_TextBox.Text = "Name: strat.jpg, Type: jpg, Size: 4KB";
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
      pictureBox1.Visible = true;
      pictureBox1.Image = Properties.Resources.les_paul;
      img_TextBox.Visible = false;
      img_TextBox.BackColor = Color.White;
      img_TextBox.BorderStyle = BorderStyle.None;
      img_TextBox.Text = "Name: les_paul.jpg, Type: jpg, Size: 4KB";
    }

    private void radioButton5_CheckedChanged(object sender, EventArgs e)
    {
      lbl_TextChange.ForeColor = System.Drawing.Color.Black;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      pictureBox1.Visible = false;
      img_TextBox.Visible = false;
    }

    private void radioButton3_CheckedChanged(object sender, EventArgs e)
    {
      pictureBox1.Visible = true;
      pictureBox1.Image = Properties.Resources.explorer;
      img_TextBox.Visible = false;
      img_TextBox.BackColor = Color.White;
      img_TextBox.BorderStyle = BorderStyle.None;
      img_TextBox.Text = "Name: explorer.jpg, Type: jpg, Size: 4KB";
    }

    private void radioButton4_CheckedChanged(object sender, EventArgs e)
    {
      pictureBox1.Visible = true;
      pictureBox1.Image = Properties.Resources.firebird;
      img_TextBox.Visible = false;
      img_TextBox.BackColor = Color.White;
      img_TextBox.BorderStyle = BorderStyle.None;
      img_TextBox.Text = "Name: firebird.jpg, Type: jpg, Size: 4KB";
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

    private void toolTip1_Popup(object sender, PopupEventArgs e)
    {
     
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox1_MouseEnter(object sender, EventArgs e)
    {
      img_TextBox.Visible = true;
    }

    private void pictureBox1_MouseLeave(object sender, EventArgs e)
    {
      img_TextBox.Visible = false;
    }
  }
}
