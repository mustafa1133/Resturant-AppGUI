namespace CoffeeShopForm
{
    partial class AddOrder
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
            this.lbxOrders = new System.Windows.Forms.ListBox();
            this.lbxAdditions = new System.Windows.Forms.ListBox();
            this.lbxOrdered = new System.Windows.Forms.ListBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbxConfirmed = new System.Windows.Forms.ListBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxOrders
            // 
            this.lbxOrders.FormattingEnabled = true;
            this.lbxOrders.ItemHeight = 12;
            this.lbxOrders.Location = new System.Drawing.Point(12, 27);
            this.lbxOrders.Name = "lbxOrders";
            this.lbxOrders.Size = new System.Drawing.Size(260, 232);
            this.lbxOrders.TabIndex = 0;
            this.lbxOrders.SelectedIndexChanged += new System.EventHandler(this.lbxOrders_SelectedIndexChanged);
            // 
            // lbxAdditions
            // 
            this.lbxAdditions.FormattingEnabled = true;
            this.lbxAdditions.ItemHeight = 12;
            this.lbxAdditions.Location = new System.Drawing.Point(322, 27);
            this.lbxAdditions.Name = "lbxAdditions";
            this.lbxAdditions.Size = new System.Drawing.Size(292, 232);
            this.lbxAdditions.TabIndex = 1;
            this.lbxAdditions.SelectedIndexChanged += new System.EventHandler(this.lbxAdditions_SelectedIndexChanged);
            // 
            // lbxOrdered
            // 
            this.lbxOrdered.FormattingEnabled = true;
            this.lbxOrdered.ItemHeight = 12;
            this.lbxOrdered.Location = new System.Drawing.Point(12, 286);
            this.lbxOrdered.Name = "lbxOrdered";
            this.lbxOrdered.Size = new System.Drawing.Size(705, 28);
            this.lbxOrdered.TabIndex = 2;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(652, 143);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(652, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbxConfirmed
            // 
            this.lbxConfirmed.FormattingEnabled = true;
            this.lbxConfirmed.ItemHeight = 12;
            this.lbxConfirmed.Location = new System.Drawing.Point(12, 338);
            this.lbxConfirmed.Name = "lbxConfirmed";
            this.lbxConfirmed.Size = new System.Drawing.Size(705, 100);
            this.lbxConfirmed.TabIndex = 5;
            this.lbxConfirmed.SelectedIndexChanged += new System.EventHandler(this.lbxConfirmed_SelectedIndexChanged);
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(652, 238);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 6;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(652, 38);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 75);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Menu Items";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Additions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Current Order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Confirmed Order";
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.lbxConfirmed);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lbxOrdered);
            this.Controls.Add(this.lbxAdditions);
            this.Controls.Add(this.lbxOrders);
            this.Name = "AddOrder";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxOrders;
        private System.Windows.Forms.ListBox lbxAdditions;
        private System.Windows.Forms.ListBox lbxOrdered;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lbxConfirmed;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}