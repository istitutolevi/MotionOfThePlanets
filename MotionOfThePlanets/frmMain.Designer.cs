﻿namespace MotionOfThePlanets
{
    partial class frmMain
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnSetTimer = new System.Windows.Forms.Button();
            this.numTimer = new System.Windows.Forms.MaskedTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbSistema = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnSetTimer
            // 
            this.btnSetTimer.Location = new System.Drawing.Point(118, 12);
            this.btnSetTimer.Name = "btnSetTimer";
            this.btnSetTimer.Size = new System.Drawing.Size(75, 23);
            this.btnSetTimer.TabIndex = 0;
            this.btnSetTimer.Text = "Set timer";
            this.btnSetTimer.UseVisualStyleBackColor = true;
            this.btnSetTimer.Click += new System.EventHandler(this.btnSetTimer_Click);
            // 
            // numTimer
            // 
            this.numTimer.Location = new System.Drawing.Point(12, 13);
            this.numTimer.Name = "numTimer";
            this.numTimer.Size = new System.Drawing.Size(100, 22);
            this.numTimer.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(199, 13);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbSistema
            // 
            this.cmbSistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSistema.FormattingEnabled = true;
            this.cmbSistema.Location = new System.Drawing.Point(12, 42);
            this.cmbSistema.Name = "cmbSistema";
            this.cmbSistema.Size = new System.Drawing.Size(262, 24);
            this.cmbSistema.TabIndex = 3;
            this.cmbSistema.SelectedIndexChanged += new System.EventHandler(this.cmbSistema_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 456);
            this.Controls.Add(this.cmbSistema);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.numTimer);
            this.Controls.Add(this.btnSetTimer);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnSetTimer;
        private System.Windows.Forms.MaskedTextBox numTimer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbSistema;
    }
}

