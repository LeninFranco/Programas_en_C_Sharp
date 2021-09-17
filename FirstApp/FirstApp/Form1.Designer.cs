
namespace FirstApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbIn = new System.Windows.Forms.ComboBox();
            this.cbOut = new System.Windows.Forms.ComboBox();
            this.botonCalcular = new System.Windows.Forms.Button();
            this.nudIn = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudIn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor de Temperatura";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtOut
            // 
            this.txtOut.Enabled = false;
            this.txtOut.Location = new System.Drawing.Point(228, 59);
            this.txtOut.MaxLength = 20;
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(159, 23);
            this.txtOut.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(176, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbIn
            // 
            this.cbIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbIn.FormattingEnabled = true;
            this.cbIn.Items.AddRange(new object[] {
            "CELSIUS",
            "FAHRENHEIT",
            "KELVIN"});
            this.cbIn.Location = new System.Drawing.Point(12, 88);
            this.cbIn.Name = "cbIn";
            this.cbIn.Size = new System.Drawing.Size(158, 23);
            this.cbIn.TabIndex = 4;
            this.cbIn.Text = "CELSIUS";
            this.cbIn.SelectedIndexChanged += new System.EventHandler(this.cbIn_SelectedIndexChanged);
            // 
            // cbOut
            // 
            this.cbOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbOut.FormattingEnabled = true;
            this.cbOut.Items.AddRange(new object[] {
            "CELSIUS",
            "FAHRENHEIT",
            "KELVIN"});
            this.cbOut.Location = new System.Drawing.Point(228, 88);
            this.cbOut.Name = "cbOut";
            this.cbOut.Size = new System.Drawing.Size(158, 23);
            this.cbOut.TabIndex = 5;
            this.cbOut.Text = "FAHRENHEIT";
            this.cbOut.SelectedIndexChanged += new System.EventHandler(this.cbOut_SelectedIndexChanged);
            // 
            // botonCalcular
            // 
            this.botonCalcular.BackColor = System.Drawing.Color.White;
            this.botonCalcular.Location = new System.Drawing.Point(12, 132);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(374, 33);
            this.botonCalcular.TabIndex = 6;
            this.botonCalcular.Text = "CALCULAR";
            this.botonCalcular.UseVisualStyleBackColor = false;
            this.botonCalcular.Click += new System.EventHandler(this.boton_Calcular);
            // 
            // nudIn
            // 
            this.nudIn.Location = new System.Drawing.Point(12, 60);
            this.nudIn.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudIn.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nudIn.Name = "nudIn";
            this.nudIn.Size = new System.Drawing.Size(158, 23);
            this.nudIn.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(399, 191);
            this.Controls.Add(this.nudIn);
            this.Controls.Add(this.botonCalcular);
            this.Controls.Add(this.cbOut);
            this.Controls.Add(this.cbIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primera App";
            ((System.ComponentModel.ISupportInitialize)(this.nudIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbIn;
        private System.Windows.Forms.ComboBox cbOut;
        private System.Windows.Forms.Button botonCalcular;
        private System.Windows.Forms.NumericUpDown nudIn;
    }
}

