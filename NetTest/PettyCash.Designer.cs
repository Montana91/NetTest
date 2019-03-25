namespace NetTest
{
    partial class PettyCash
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
            this.ucLoginF = new NetTest.UserControls.ucLogin();
            this.ucLoggedInF = new NetTest.UserControls.ucLoggedIn();
            this.ucCashSpendF = new NetTest.UserControls.ucCashSpend();
            this.SuspendLayout();
            // 
            // ucLoginF
            // 
            this.ucLoginF.Location = new System.Drawing.Point(82, 56);
            this.ucLoginF.Name = "ucLoginF";
            this.ucLoginF.Size = new System.Drawing.Size(430, 165);
            this.ucLoginF.TabIndex = 0;
            // 
            // ucLoggedInF
            // 
            this.ucLoggedInF.Location = new System.Drawing.Point(82, 58);
            this.ucLoggedInF.Name = "ucLoggedInF";
            this.ucLoggedInF.Size = new System.Drawing.Size(433, 163);
            this.ucLoggedInF.TabIndex = 1;
            // 
            // ucCashSpendF
            // 
            this.ucCashSpendF.Location = new System.Drawing.Point(82, 58);
            this.ucCashSpendF.Name = "ucCashSpendF";
            this.ucCashSpendF.Size = new System.Drawing.Size(428, 165);
            this.ucCashSpendF.TabIndex = 2;
            // 
            // PettyCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucCashSpendF);
            this.Controls.Add(this.ucLoggedInF);
            this.Controls.Add(this.ucLoginF);
            this.Name = "PettyCash";
            this.Text = "PettyCash";
            this.Load += new System.EventHandler(this.PettyCash_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucLogin ucLoginF;
        private UserControls.ucLoggedIn ucLoggedInF;
        private UserControls.ucCashSpend ucCashSpendF;
    }
}