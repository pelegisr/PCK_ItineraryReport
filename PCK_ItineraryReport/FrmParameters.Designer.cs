namespace Peleg.PCK_ItineraryReport
{
    partial class FrmParameters
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPnr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPckName = new System.Windows.Forms.Label();
            this.rbHebrew = new System.Windows.Forms.RadioButton();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.lblPckCode = new System.Windows.Forms.Label();
            this.lblPckID = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PNR:";
            // 
            // lblPnr
            // 
            this.lblPnr.AutoSize = true;
            this.lblPnr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPnr.Location = new System.Drawing.Point(73, 68);
            this.lblPnr.Name = "lblPnr";
            this.lblPnr.Size = new System.Drawing.Size(37, 15);
            this.lblPnr.TabIndex = 3;
            this.lblPnr.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Package:";
            // 
            // lblPckName
            // 
            this.lblPckName.AutoSize = true;
            this.lblPckName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPckName.Location = new System.Drawing.Point(317, 90);
            this.lblPckName.Name = "lblPckName";
            this.lblPckName.Size = new System.Drawing.Size(37, 15);
            this.lblPckName.TabIndex = 5;
            this.lblPckName.Text = "label3";
            // 
            // rbHebrew
            // 
            this.rbHebrew.AutoSize = true;
            this.rbHebrew.Location = new System.Drawing.Point(15, 115);
            this.rbHebrew.Name = "rbHebrew";
            this.rbHebrew.Size = new System.Drawing.Size(62, 17);
            this.rbHebrew.TabIndex = 6;
            this.rbHebrew.TabStop = true;
            this.rbHebrew.Text = "Hebrew";
            this.rbHebrew.UseVisualStyleBackColor = true;
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.Location = new System.Drawing.Point(83, 115);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(59, 17);
            this.rbEnglish.TabIndex = 7;
            this.rbEnglish.TabStop = true;
            this.rbEnglish.Text = "English";
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // lblPckCode
            // 
            this.lblPckCode.AutoSize = true;
            this.lblPckCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPckCode.Location = new System.Drawing.Point(154, 90);
            this.lblPckCode.Name = "lblPckCode";
            this.lblPckCode.Size = new System.Drawing.Size(37, 15);
            this.lblPckCode.TabIndex = 9;
            this.lblPckCode.Text = "label3";
            // 
            // lblPckID
            // 
            this.lblPckID.AutoSize = true;
            this.lblPckID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPckID.Location = new System.Drawing.Point(73, 90);
            this.lblPckID.Name = "lblPckID";
            this.lblPckID.Size = new System.Drawing.Size(37, 15);
            this.lblPckID.TabIndex = 10;
            this.lblPckID.Text = "label3";
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::Peleg.PCK_ItineraryReport.Properties.Resources.printer;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrint.Location = new System.Drawing.Point(661, 74);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(61, 60);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::Peleg.PCK_ItineraryReport.Properties.Resources.Exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(661, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 62);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 143);
            this.Controls.Add(this.lblPckID);
            this.Controls.Add(this.lblPckCode);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.rbEnglish);
            this.Controls.Add(this.rbHebrew);
            this.Controls.Add(this.lblPckName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPnr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.UP);
            this.Name = "FrmParameters";
            this.Text = "Print package itinerary: parameters";
            this.Load += new System.EventHandler(this.FrmParameters_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Peleg.UPanelInfo.UPanel UP;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPnr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPckName;
        private System.Windows.Forms.RadioButton rbHebrew;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblPckCode;
        private System.Windows.Forms.Label lblPckID;
    }
}