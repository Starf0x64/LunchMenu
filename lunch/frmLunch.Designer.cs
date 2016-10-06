namespace lunch
{
    partial class frmLunch
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
            this.grpCourse = new System.Windows.Forms.GroupBox();
            this.rdoSalad = new System.Windows.Forms.RadioButton();
            this.rdoPizza = new System.Windows.Forms.RadioButton();
            this.rdoBurger = new System.Windows.Forms.RadioButton();
            this.grpAddOn = new System.Windows.Forms.GroupBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.grpTotal = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlace = new System.Windows.Forms.Button();
            this.btnTax = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpCourse.SuspendLayout();
            this.grpAddOn.SuspendLayout();
            this.grpTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCourse
            // 
            this.grpCourse.Controls.Add(this.rdoSalad);
            this.grpCourse.Controls.Add(this.rdoPizza);
            this.grpCourse.Controls.Add(this.rdoBurger);
            this.grpCourse.Location = new System.Drawing.Point(13, 13);
            this.grpCourse.Name = "grpCourse";
            this.grpCourse.Size = new System.Drawing.Size(168, 100);
            this.grpCourse.TabIndex = 0;
            this.grpCourse.TabStop = false;
            this.grpCourse.Text = "Main Course";
            // 
            // rdoSalad
            // 
            this.rdoSalad.AutoSize = true;
            this.rdoSalad.Location = new System.Drawing.Point(7, 68);
            this.rdoSalad.Name = "rdoSalad";
            this.rdoSalad.Size = new System.Drawing.Size(88, 17);
            this.rdoSalad.TabIndex = 2;
            this.rdoSalad.TabStop = true;
            this.rdoSalad.Text = "Salad - $4.95";
            this.rdoSalad.UseVisualStyleBackColor = true;
            this.rdoSalad.CheckedChanged += new System.EventHandler(this.rdoSalad_CheckedChanged);
            // 
            // rdoPizza
            // 
            this.rdoPizza.AutoSize = true;
            this.rdoPizza.Location = new System.Drawing.Point(7, 44);
            this.rdoPizza.Name = "rdoPizza";
            this.rdoPizza.Size = new System.Drawing.Size(86, 17);
            this.rdoPizza.TabIndex = 1;
            this.rdoPizza.TabStop = true;
            this.rdoPizza.Text = "Pizza - $5.95";
            this.rdoPizza.UseVisualStyleBackColor = true;
            this.rdoPizza.CheckedChanged += new System.EventHandler(this.rdoPizza_CheckedChanged);
            // 
            // rdoBurger
            // 
            this.rdoBurger.AutoSize = true;
            this.rdoBurger.Location = new System.Drawing.Point(7, 20);
            this.rdoBurger.Name = "rdoBurger";
            this.rdoBurger.Size = new System.Drawing.Size(113, 17);
            this.rdoBurger.TabIndex = 0;
            this.rdoBurger.TabStop = true;
            this.rdoBurger.Text = "Hamburger - $6.95";
            this.rdoBurger.UseVisualStyleBackColor = true;
            this.rdoBurger.CheckedChanged += new System.EventHandler(this.rdoBurger_CheckedChanged);
            // 
            // grpAddOn
            // 
            this.grpAddOn.Controls.Add(this.cb3);
            this.grpAddOn.Controls.Add(this.cb2);
            this.grpAddOn.Controls.Add(this.cb1);
            this.grpAddOn.Location = new System.Drawing.Point(188, 13);
            this.grpAddOn.Name = "grpAddOn";
            this.grpAddOn.Size = new System.Drawing.Size(200, 100);
            this.grpAddOn.TabIndex = 1;
            this.grpAddOn.TabStop = false;
            this.grpAddOn.Text = "Add-on Items ($.75/each)";
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(7, 68);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(48, 17);
            this.cb3.TabIndex = 5;
            this.cb3.Text = "Fries";
            this.cb3.UseVisualStyleBackColor = true;
            this.cb3.CheckedChanged += new System.EventHandler(this.cb3_CheckedChanged);
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(7, 44);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(142, 17);
            this.cb2.TabIndex = 4;
            this.cb2.Text = "Ketchup, Mustard, Mayo";
            this.cb2.UseVisualStyleBackColor = true;
            this.cb2.CheckedChanged += new System.EventHandler(this.cb2_CheckedChanged_1);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(7, 20);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(143, 17);
            this.cb1.TabIndex = 3;
            this.cb1.Text = "Lettuce, Tomato, Onions";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // grpTotal
            // 
            this.grpTotal.Controls.Add(this.txtTotal);
            this.grpTotal.Controls.Add(this.txtTax);
            this.grpTotal.Controls.Add(this.txtSubtotal);
            this.grpTotal.Controls.Add(this.label3);
            this.grpTotal.Controls.Add(this.lblTax);
            this.grpTotal.Controls.Add(this.label1);
            this.grpTotal.Location = new System.Drawing.Point(13, 146);
            this.grpTotal.Name = "grpTotal";
            this.grpTotal.Size = new System.Drawing.Size(200, 100);
            this.grpTotal.TabIndex = 2;
            this.grpTotal.TabStop = false;
            this.grpTotal.Text = "Group Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(85, 73);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(85, 46);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 4;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(85, 20);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order Total:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(8, 49);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(66, 13);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "Tax (7.75%):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // btnPlace
            // 
            this.btnPlace.Location = new System.Drawing.Point(220, 146);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(75, 23);
            this.btnPlace.TabIndex = 6;
            this.btnPlace.Text = "Place Order";
            this.btnPlace.UseVisualStyleBackColor = true;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // btnTax
            // 
            this.btnTax.Location = new System.Drawing.Point(220, 176);
            this.btnTax.Name = "btnTax";
            this.btnTax.Size = new System.Drawing.Size(75, 23);
            this.btnTax.TabIndex = 7;
            this.btnTax.Text = "Set Tax Rate";
            this.btnTax.UseVisualStyleBackColor = true;
            this.btnTax.Click += new System.EventHandler(this.btnTax_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(220, 206);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 262);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTax);
            this.Controls.Add(this.btnPlace);
            this.Controls.Add(this.grpTotal);
            this.Controls.Add(this.grpAddOn);
            this.Controls.Add(this.grpCourse);
            this.Name = "frmLunch";
            this.Text = "Lunch Order";
            this.Load += new System.EventHandler(this.frmLunch_Load);
            this.grpCourse.ResumeLayout(false);
            this.grpCourse.PerformLayout();
            this.grpAddOn.ResumeLayout(false);
            this.grpAddOn.PerformLayout();
            this.grpTotal.ResumeLayout(false);
            this.grpTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCourse;
        private System.Windows.Forms.RadioButton rdoSalad;
        private System.Windows.Forms.RadioButton rdoPizza;
        private System.Windows.Forms.RadioButton rdoBurger;
        private System.Windows.Forms.GroupBox grpAddOn;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.GroupBox grpTotal;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.Button btnTax;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label label1;
    }
}

