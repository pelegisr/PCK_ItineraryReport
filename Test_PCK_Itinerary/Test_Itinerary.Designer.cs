namespace Peleg.Test_PCK_Itinerary
{
    partial class FrmTest_Itinerary
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
            this.UP = new Peleg.UPanelInfo.UPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPNR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UP
            // 
            this.UP.ChangeParentIcon = true;
            this.UP.ChangeSystemLogo = true;
            this.UP.Location = new System.Drawing.Point(0, 0);
            this.UP.Mode = "";
            this.UP.Name = "UP";
            this.UP.Size = new System.Drawing.Size(642, 52);
            this.UP.TabIndex = 0;
            this.UP.TranslateParent = false;
            this.UP.WindowLess = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(176, 62);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(285, 62);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PNR";
            // 
            // txtPNR
            // 
            this.txtPNR.Location = new System.Drawing.Point(48, 65);
            this.txtPNR.Name = "txtPNR";
            this.txtPNR.Size = new System.Drawing.Size(77, 20);
            this.txtPNR.TabIndex = 4;
            this.txtPNR.Text = "305695";
            // 
            // FrmTest_Itinerary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 101);
            this.Controls.Add(this.txtPNR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.UP);
            this.Name = "FrmTest_Itinerary";
            this.Text = "Test pck_Itinerary";
            this.Load += new System.EventHandler(this.FrmTest_Itinerary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Peleg.UPanelInfo.UPanel UP;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPNR;
    }
}

