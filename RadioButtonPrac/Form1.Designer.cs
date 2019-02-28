namespace RadioButtonPrac
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.lbl_TextChange = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.gb_ImageChange = new System.Windows.Forms.GroupBox();
      this.radioButton4 = new System.Windows.Forms.RadioButton();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.radioButton3 = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.gb_ColorChange = new System.Windows.Forms.GroupBox();
      this.radioButton8 = new System.Windows.Forms.RadioButton();
      this.radioButton7 = new System.Windows.Forms.RadioButton();
      this.radioButton6 = new System.Windows.Forms.RadioButton();
      this.radioButton5 = new System.Windows.Forms.RadioButton();
      this.gb_CaseChange = new System.Windows.Forms.GroupBox();
      this.rb_LowerCase = new System.Windows.Forms.RadioButton();
      this.rb_UpperCase = new System.Windows.Forms.RadioButton();
      this.rb_NormalCase = new System.Windows.Forms.RadioButton();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.img_TextBox = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.gb_ImageChange.SuspendLayout();
      this.gb_ColorChange.SuspendLayout();
      this.gb_CaseChange.SuspendLayout();
      this.SuspendLayout();
      // 
      // lbl_TextChange
      // 
      this.lbl_TextChange.AutoSize = true;
      this.lbl_TextChange.Location = new System.Drawing.Point(81, 76);
      this.lbl_TextChange.Name = "lbl_TextChange";
      this.lbl_TextChange.Size = new System.Drawing.Size(96, 13);
      this.lbl_TextChange.TabIndex = 0;
      this.lbl_TextChange.Text = "Text Appears Here";
      this.lbl_TextChange.Click += new System.EventHandler(this.lbl_TextChange_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackgroundImage = global::RadioButtonPrac.Properties.Resources.strat;
      this.pictureBox1.Location = new System.Drawing.Point(529, 41);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(200, 200);
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
      this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
      this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(328, 221);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(150, 20);
      this.textBox1.TabIndex = 2;
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // gb_ImageChange
      // 
      this.gb_ImageChange.Controls.Add(this.radioButton4);
      this.gb_ImageChange.Controls.Add(this.radioButton1);
      this.gb_ImageChange.Controls.Add(this.radioButton3);
      this.gb_ImageChange.Controls.Add(this.radioButton2);
      this.gb_ImageChange.Location = new System.Drawing.Point(26, 309);
      this.gb_ImageChange.Name = "gb_ImageChange";
      this.gb_ImageChange.Size = new System.Drawing.Size(200, 109);
      this.gb_ImageChange.TabIndex = 3;
      this.gb_ImageChange.TabStop = false;
      this.gb_ImageChange.Text = "Image";
      // 
      // radioButton4
      // 
      this.radioButton4.AutoSize = true;
      this.radioButton4.Location = new System.Drawing.Point(6, 83);
      this.radioButton4.Name = "radioButton4";
      this.radioButton4.Size = new System.Drawing.Size(60, 17);
      this.radioButton4.TabIndex = 9;
      this.radioButton4.TabStop = true;
      this.radioButton4.Text = "FireBird";
      this.radioButton4.UseVisualStyleBackColor = true;
      this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
      // 
      // radioButton1
      // 
      this.radioButton1.AutoSize = true;
      this.radioButton1.Location = new System.Drawing.Point(6, 19);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(47, 17);
      this.radioButton1.TabIndex = 6;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "Strat";
      this.radioButton1.UseVisualStyleBackColor = true;
      this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
      // 
      // radioButton3
      // 
      this.radioButton3.AutoSize = true;
      this.radioButton3.Location = new System.Drawing.Point(6, 60);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new System.Drawing.Size(63, 17);
      this.radioButton3.TabIndex = 8;
      this.radioButton3.TabStop = true;
      this.radioButton3.Text = "Explorer";
      this.radioButton3.UseVisualStyleBackColor = true;
      this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
      // 
      // radioButton2
      // 
      this.radioButton2.AutoSize = true;
      this.radioButton2.Location = new System.Drawing.Point(6, 37);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(66, 17);
      this.radioButton2.TabIndex = 7;
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "Les Paul";
      this.radioButton2.UseVisualStyleBackColor = true;
      this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
      // 
      // gb_ColorChange
      // 
      this.gb_ColorChange.Controls.Add(this.radioButton8);
      this.gb_ColorChange.Controls.Add(this.radioButton7);
      this.gb_ColorChange.Controls.Add(this.radioButton6);
      this.gb_ColorChange.Controls.Add(this.radioButton5);
      this.gb_ColorChange.Location = new System.Drawing.Point(264, 309);
      this.gb_ColorChange.Name = "gb_ColorChange";
      this.gb_ColorChange.Size = new System.Drawing.Size(200, 109);
      this.gb_ColorChange.TabIndex = 4;
      this.gb_ColorChange.TabStop = false;
      this.gb_ColorChange.Text = "Text Colour";
      // 
      // radioButton8
      // 
      this.radioButton8.AutoSize = true;
      this.radioButton8.Location = new System.Drawing.Point(6, 83);
      this.radioButton8.Name = "radioButton8";
      this.radioButton8.Size = new System.Drawing.Size(54, 17);
      this.radioButton8.TabIndex = 3;
      this.radioButton8.TabStop = true;
      this.radioButton8.Text = "Green";
      this.radioButton8.UseVisualStyleBackColor = true;
      this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
      // 
      // radioButton7
      // 
      this.radioButton7.AutoSize = true;
      this.radioButton7.Location = new System.Drawing.Point(6, 60);
      this.radioButton7.Name = "radioButton7";
      this.radioButton7.Size = new System.Drawing.Size(45, 17);
      this.radioButton7.TabIndex = 2;
      this.radioButton7.TabStop = true;
      this.radioButton7.Text = "Red";
      this.radioButton7.UseVisualStyleBackColor = true;
      this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
      // 
      // radioButton6
      // 
      this.radioButton6.AutoSize = true;
      this.radioButton6.Location = new System.Drawing.Point(6, 42);
      this.radioButton6.Name = "radioButton6";
      this.radioButton6.Size = new System.Drawing.Size(46, 17);
      this.radioButton6.TabIndex = 1;
      this.radioButton6.TabStop = true;
      this.radioButton6.Text = "Blue";
      this.radioButton6.UseVisualStyleBackColor = true;
      this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
      // 
      // radioButton5
      // 
      this.radioButton5.AutoSize = true;
      this.radioButton5.Location = new System.Drawing.Point(6, 19);
      this.radioButton5.Name = "radioButton5";
      this.radioButton5.Size = new System.Drawing.Size(52, 17);
      this.radioButton5.TabIndex = 0;
      this.radioButton5.TabStop = true;
      this.radioButton5.Text = "Black";
      this.radioButton5.UseVisualStyleBackColor = true;
      this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
      // 
      // gb_CaseChange
      // 
      this.gb_CaseChange.Controls.Add(this.rb_LowerCase);
      this.gb_CaseChange.Controls.Add(this.rb_UpperCase);
      this.gb_CaseChange.Controls.Add(this.rb_NormalCase);
      this.gb_CaseChange.Location = new System.Drawing.Point(500, 309);
      this.gb_CaseChange.Name = "gb_CaseChange";
      this.gb_CaseChange.Size = new System.Drawing.Size(200, 100);
      this.gb_CaseChange.TabIndex = 5;
      this.gb_CaseChange.TabStop = false;
      this.gb_CaseChange.Text = "Text Case";
      // 
      // rb_LowerCase
      // 
      this.rb_LowerCase.AutoSize = true;
      this.rb_LowerCase.Location = new System.Drawing.Point(6, 77);
      this.rb_LowerCase.Name = "rb_LowerCase";
      this.rb_LowerCase.Size = new System.Drawing.Size(54, 17);
      this.rb_LowerCase.TabIndex = 2;
      this.rb_LowerCase.TabStop = true;
      this.rb_LowerCase.Text = "Lower";
      this.rb_LowerCase.UseVisualStyleBackColor = true;
      this.rb_LowerCase.CheckedChanged += new System.EventHandler(this.rb_LowerCase_CheckedChanged);
      // 
      // rb_UpperCase
      // 
      this.rb_UpperCase.AutoSize = true;
      this.rb_UpperCase.Location = new System.Drawing.Point(6, 54);
      this.rb_UpperCase.Name = "rb_UpperCase";
      this.rb_UpperCase.Size = new System.Drawing.Size(54, 17);
      this.rb_UpperCase.TabIndex = 1;
      this.rb_UpperCase.TabStop = true;
      this.rb_UpperCase.Text = "Upper";
      this.rb_UpperCase.UseVisualStyleBackColor = true;
      this.rb_UpperCase.CheckedChanged += new System.EventHandler(this.rb_UpperCase_CheckedChanged);
      // 
      // rb_NormalCase
      // 
      this.rb_NormalCase.AutoSize = true;
      this.rb_NormalCase.Location = new System.Drawing.Point(6, 31);
      this.rb_NormalCase.Name = "rb_NormalCase";
      this.rb_NormalCase.Size = new System.Drawing.Size(58, 17);
      this.rb_NormalCase.TabIndex = 0;
      this.rb_NormalCase.TabStop = true;
      this.rb_NormalCase.Text = "Normal";
      this.rb_NormalCase.UseVisualStyleBackColor = true;
      this.rb_NormalCase.CheckedChanged += new System.EventHandler(this.rb_NormalCase_CheckedChanged);
      // 
      // toolTip1
      // 
      this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
      // 
      // img_TextBox
      // 
      this.img_TextBox.Location = new System.Drawing.Point(529, 247);
      this.img_TextBox.Name = "img_TextBox";
      this.img_TextBox.Size = new System.Drawing.Size(200, 20);
      this.img_TextBox.TabIndex = 6;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.img_TextBox);
      this.Controls.Add(this.gb_CaseChange);
      this.Controls.Add(this.gb_ColorChange);
      this.Controls.Add(this.gb_ImageChange);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.lbl_TextChange);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.gb_ImageChange.ResumeLayout(false);
      this.gb_ImageChange.PerformLayout();
      this.gb_ColorChange.ResumeLayout(false);
      this.gb_ColorChange.PerformLayout();
      this.gb_CaseChange.ResumeLayout(false);
      this.gb_CaseChange.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbl_TextChange;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.GroupBox gb_ImageChange;
    private System.Windows.Forms.GroupBox gb_ColorChange;
    private System.Windows.Forms.GroupBox gb_CaseChange;
    private System.Windows.Forms.RadioButton radioButton4;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.RadioButton radioButton3;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.RadioButton radioButton8;
    private System.Windows.Forms.RadioButton radioButton7;
    private System.Windows.Forms.RadioButton radioButton6;
    private System.Windows.Forms.RadioButton radioButton5;
    private System.Windows.Forms.RadioButton rb_LowerCase;
    private System.Windows.Forms.RadioButton rb_UpperCase;
    private System.Windows.Forms.RadioButton rb_NormalCase;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.TextBox img_TextBox;
  }
}

