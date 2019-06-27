namespace CoffeShopForm
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
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lbxCustomer = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.lbxCustomerOrdered = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCusNDel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(47, 282);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(104, 66);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lbxCustomer
            // 
            this.lbxCustomer.FormattingEnabled = true;
            this.lbxCustomer.ItemHeight = 12;
            this.lbxCustomer.Location = new System.Drawing.Point(12, 31);
            this.lbxCustomer.Name = "lbxCustomer";
            this.lbxCustomer.Size = new System.Drawing.Size(552, 208);
            this.lbxCustomer.TabIndex = 1;
            this.lbxCustomer.SelectedIndexChanged += new System.EventHandler(this.lbxCustomer_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "Edit Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(333, 282);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(106, 66);
            this.btnAddOrder.TabIndex = 3;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // lbxCustomerOrdered
            // 
            this.lbxCustomerOrdered.FormattingEnabled = true;
            this.lbxCustomerOrdered.ItemHeight = 12;
            this.lbxCustomerOrdered.Location = new System.Drawing.Point(570, 31);
            this.lbxCustomerOrdered.Name = "lbxCustomerOrdered";
            this.lbxCustomerOrdered.Size = new System.Drawing.Size(449, 208);
            this.lbxCustomerOrdered.TabIndex = 4;
            this.lbxCustomerOrdered.SelectedIndexChanged += new System.EventHandler(this.lbxCustomerOrdered_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(928, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 64);
            this.button2.TabIndex = 5;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Order";
            // 
            // btnCusNDel
            // 
            this.btnCusNDel.Location = new System.Drawing.Point(757, 282);
            this.btnCusNDel.Name = "btnCusNDel";
            this.btnCusNDel.Size = new System.Drawing.Size(137, 64);
            this.btnCusNDel.TabIndex = 8;
            this.btnCusNDel.Text = "Customers With Orders Not Delivered";
            this.btnCusNDel.UseVisualStyleBackColor = true;
            this.btnCusNDel.Click += new System.EventHandler(this.btnCusNDel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(505, 282);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(505, 325);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(505, 264);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(59, 12);
            this.lblStartDate.TabIndex = 11;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(508, 306);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(56, 12);
            this.lblEnd.TabIndex = 12;
            this.lblEnd.Text = "End Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 407);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCusNDel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbxCustomerOrdered);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbxCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.ListBox lbxCustomer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.ListBox lbxCustomerOrdered;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCusNDel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEnd;
    }
}