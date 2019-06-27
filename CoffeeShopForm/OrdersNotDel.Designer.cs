namespace CoffeeShopForm
{
    partial class OrdersNotDel
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
            this.lbxNotDel = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxNotDel
            // 
            this.lbxNotDel.FormattingEnabled = true;
            this.lbxNotDel.ItemHeight = 12;
            this.lbxNotDel.Location = new System.Drawing.Point(13, 13);
            this.lbxNotDel.Name = "lbxNotDel";
            this.lbxNotDel.Size = new System.Drawing.Size(740, 292);
            this.lbxNotDel.TabIndex = 0;
            // 
            // OrdersNotDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxNotDel);
            this.Name = "OrdersNotDel";
            this.Text = "OrdersNotDel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxNotDel;
    }
}