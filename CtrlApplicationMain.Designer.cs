namespace WFA230110_2
{
    partial class CtrlApplicationMain
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHello.Location = new System.Drawing.Point(0, 0);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(479, 284);
            this.lblHello.TabIndex = 0;
            this.lblHello.Text = "Hello, ###!";
            this.lblHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CtrlApplicationMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHello);
            this.Name = "CtrlApplicationMain";
            this.Size = new System.Drawing.Size(479, 284);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblHello;
    }
}
