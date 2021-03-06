
namespace Coaxial_Cable_Impedance_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.coxialpic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unit_od = new System.Windows.Forms.ComboBox();
            this.unit_id = new System.Windows.Forms.ComboBox();
            this.kind_cont = new System.Windows.Forms.ComboBox();
            this.calculate = new System.Windows.Forms.Button();
            this.inner_diameter = new System.Windows.Forms.TextBox();
            this.outer_diameter = new System.Windows.Forms.TextBox();
            this.constxt = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.coxialpic)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // coxialpic
            // 
            this.coxialpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.coxialpic.Image = ((System.Drawing.Image)(resources.GetObject("coxialpic.Image")));
            this.coxialpic.Location = new System.Drawing.Point(385, 97);
            this.coxialpic.Margin = new System.Windows.Forms.Padding(4);
            this.coxialpic.Name = "coxialpic";
            this.coxialpic.Size = new System.Drawing.Size(243, 254);
            this.coxialpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coxialpic.TabIndex = 0;
            this.coxialpic.TabStop = false;
            this.coxialpic.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Mehr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(137, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "(Di) قطر درونی کابل کواکسیال : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Mehr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(126, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "(Do) قطر بیرونی کابل کواکسیال : ";
            this.label2.UseMnemonic = false;
            // 
            // unit_od
            // 
            this.unit_od.BackColor = System.Drawing.Color.Gold;
            this.unit_od.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unit_od.Font = new System.Drawing.Font("B Mehr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.unit_od.FormattingEnabled = true;
            this.unit_od.Items.AddRange(new object[] {
            "اینچ",
            "سانتی متر",
            "فوت",
            "میلیمتر",
            "یارد",
            "متر"});
            this.unit_od.Location = new System.Drawing.Point(20, 243);
            this.unit_od.Margin = new System.Windows.Forms.Padding(4);
            this.unit_od.Name = "unit_od";
            this.unit_od.Size = new System.Drawing.Size(132, 39);
            this.unit_od.TabIndex = 5;
            this.unit_od.Text = "میلیمتر";
            // 
            // unit_id
            // 
            this.unit_id.BackColor = System.Drawing.Color.Gold;
            this.unit_id.Cursor = System.Windows.Forms.Cursors.Default;
            this.unit_id.Font = new System.Drawing.Font("B Mehr", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.unit_id.FormattingEnabled = true;
            this.unit_id.Items.AddRange(new object[] {
            "اینچ",
            "سانتی متر",
            "فوت",
            "میلیمتر",
            "یارد",
            "متر"});
            this.unit_id.Location = new System.Drawing.Point(20, 132);
            this.unit_id.Margin = new System.Windows.Forms.Padding(4);
            this.unit_id.Name = "unit_id";
            this.unit_id.Size = new System.Drawing.Size(132, 39);
            this.unit_id.TabIndex = 4;
            this.unit_id.Text = "میلیمتر";
            // 
            // kind_cont
            // 
            this.kind_cont.BackColor = System.Drawing.Color.PaleGreen;
            this.kind_cont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kind_cont.Font = new System.Drawing.Font("B Morvarid", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.kind_cont.FormattingEnabled = true;
            this.kind_cont.Items.AddRange(new object[] {
            "ثابت دی الکتریک",
            "سرعت انتشار %"});
            this.kind_cont.Location = new System.Drawing.Point(20, 349);
            this.kind_cont.Margin = new System.Windows.Forms.Padding(4);
            this.kind_cont.Name = "kind_cont";
            this.kind_cont.Size = new System.Drawing.Size(132, 28);
            this.kind_cont.TabIndex = 6;
            this.kind_cont.Text = "ثابت دی الکتریک";
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.Tomato;
            this.calculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculate.Font = new System.Drawing.Font("B Sina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.calculate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calculate.Location = new System.Drawing.Point(419, 389);
            this.calculate.Margin = new System.Windows.Forms.Padding(4);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(137, 77);
            this.calculate.TabIndex = 3;
            this.calculate.Text = "محاسبه کن  :(";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // inner_diameter
            // 
            this.inner_diameter.Location = new System.Drawing.Point(199, 136);
            this.inner_diameter.Margin = new System.Windows.Forms.Padding(4);
            this.inner_diameter.Name = "inner_diameter";
            this.inner_diameter.Size = new System.Drawing.Size(147, 33);
            this.inner_diameter.TabIndex = 0;
            this.inner_diameter.Tag = "";
            this.inner_diameter.TextChanged += new System.EventHandler(this.inner_diameter_TextChanged);
            // 
            // outer_diameter
            // 
            this.outer_diameter.Location = new System.Drawing.Point(199, 247);
            this.outer_diameter.Margin = new System.Windows.Forms.Padding(4);
            this.outer_diameter.Name = "outer_diameter";
            this.outer_diameter.Size = new System.Drawing.Size(147, 33);
            this.outer_diameter.TabIndex = 1;
            this.outer_diameter.TextChanged += new System.EventHandler(this.inner_diameter_TextChanged);
            // 
            // constxt
            // 
            this.constxt.Location = new System.Drawing.Point(199, 347);
            this.constxt.Margin = new System.Windows.Forms.Padding(4);
            this.constxt.Name = "constxt";
            this.constxt.Size = new System.Drawing.Size(147, 33);
            this.constxt.TabIndex = 2;
            this.constxt.TextChanged += new System.EventHandler(this.inner_diameter_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(665, 31);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("B Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(94, 28);
            this.toolStripButton1.Text = "درباره نرم‌افزار";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(665, 496);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.constxt);
            this.Controls.Add(this.outer_diameter);
            this.Controls.Add(this.inner_diameter);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.unit_id);
            this.Controls.Add(this.kind_cont);
            this.Controls.Add(this.unit_od);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coxialpic);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ماشین حساب مشخصات کابل کواکسیال  ";
            this.TransparencyKey = System.Drawing.Color.SeaShell;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coxialpic)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox coxialpic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox unit_od;
        private System.Windows.Forms.ComboBox unit_id;
        private System.Windows.Forms.ComboBox kind_cont;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox inner_diameter;
        private System.Windows.Forms.TextBox outer_diameter;
        private System.Windows.Forms.TextBox constxt;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

