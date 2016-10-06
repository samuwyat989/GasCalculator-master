namespace GasCalculator
{
    partial class storeInterface
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
            this.tendered = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.costButton = new System.Windows.Forms.Button();
            this.regular = new System.Windows.Forms.Button();
            this.super = new System.Windows.Forms.Button();
            this.premium = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.gasType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.regularBox = new System.Windows.Forms.TextBox();
            this.premiumBox = new System.Windows.Forms.TextBox();
            this.superBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tendered
            // 
            this.tendered.Location = new System.Drawing.Point(15, 234);
            this.tendered.Name = "tendered";
            this.tendered.Size = new System.Drawing.Size(100, 20);
            this.tendered.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 181);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 181);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(15, 208);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // costButton
            // 
            this.costButton.Location = new System.Drawing.Point(121, 208);
            this.costButton.Name = "costButton";
            this.costButton.Size = new System.Drawing.Size(100, 23);
            this.costButton.TabIndex = 4;
            this.costButton.Text = "Show Bill";
            this.costButton.UseVisualStyleBackColor = true;
            this.costButton.Click += new System.EventHandler(this.costButton_Click);
            // 
            // regular
            // 
            this.regular.Location = new System.Drawing.Point(15, 61);
            this.regular.Name = "regular";
            this.regular.Size = new System.Drawing.Size(100, 23);
            this.regular.TabIndex = 5;
            this.regular.Text = "Regular ";
            this.regular.UseVisualStyleBackColor = true;
            this.regular.MouseLeave += new System.EventHandler(this.regular_MouseLeave);
            this.regular.MouseHover += new System.EventHandler(this.regular_MouseHover);
            // 
            // super
            // 
            this.super.Location = new System.Drawing.Point(15, 90);
            this.super.Name = "super";
            this.super.Size = new System.Drawing.Size(100, 23);
            this.super.TabIndex = 6;
            this.super.Text = "Super";
            this.super.UseVisualStyleBackColor = true;
            this.super.MouseLeave += new System.EventHandler(this.super_MouseLeave);
            this.super.MouseHover += new System.EventHandler(this.super_MouseHover);
            // 
            // premium
            // 
            this.premium.Location = new System.Drawing.Point(15, 119);
            this.premium.Name = "premium";
            this.premium.Size = new System.Drawing.Size(100, 23);
            this.premium.TabIndex = 7;
            this.premium.Text = "Premium";
            this.premium.UseVisualStyleBackColor = true;
            this.premium.MouseLeave += new System.EventHandler(this.premium_MouseLeave);
            this.premium.MouseHover += new System.EventHandler(this.premium_MouseHover);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(176, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(82, 13);
            this.title.TabIndex = 8;
            this.title.Text = "The Corner Gas";
            // 
            // gasType
            // 
            this.gasType.AutoSize = true;
            this.gasType.Location = new System.Drawing.Point(12, 34);
            this.gasType.Name = "gasType";
            this.gasType.Size = new System.Drawing.Size(103, 13);
            this.gasType.TabIndex = 9;
            this.gasType.Text = "Select your gas type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "remember the nickle round";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Option 1 how full do you want your tank to be ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Option 2 how much money do you want to spend";
            // 
            // regularBox
            // 
            this.regularBox.Location = new System.Drawing.Point(75, 52);
            this.regularBox.Name = "regularBox";
            this.regularBox.Size = new System.Drawing.Size(100, 20);
            this.regularBox.TabIndex = 13;
            this.regularBox.Text = "$ 0.75 per liter";
            // 
            // premiumBox
            // 
            this.premiumBox.Location = new System.Drawing.Point(75, 104);
            this.premiumBox.Name = "premiumBox";
            this.premiumBox.Size = new System.Drawing.Size(100, 20);
            this.premiumBox.TabIndex = 14;
            this.premiumBox.Text = "$ 0.95 per liter";
            // 
            // superBox
            // 
            this.superBox.Location = new System.Drawing.Point(75, 78);
            this.superBox.Name = "superBox";
            this.superBox.Size = new System.Drawing.Size(100, 20);
            this.superBox.TabIndex = 15;
            this.superBox.Text = "$ 0.85 per liter";
            // 
            // storeInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 359);
            this.Controls.Add(this.superBox);
            this.Controls.Add(this.premiumBox);
            this.Controls.Add(this.regularBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gasType);
            this.Controls.Add(this.title);
            this.Controls.Add(this.premium);
            this.Controls.Add(this.super);
            this.Controls.Add(this.regular);
            this.Controls.Add(this.costButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tendered);
            this.Name = "storeInterface";
            this.Text = "The Corner Gas";
            this.Load += new System.EventHandler(this.storeInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tendered;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button costButton;
        private System.Windows.Forms.Button regular;
        private System.Windows.Forms.Button super;
        private System.Windows.Forms.Button premium;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label gasType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox regularBox;
        private System.Windows.Forms.TextBox premiumBox;
        private System.Windows.Forms.TextBox superBox;
    }
}

