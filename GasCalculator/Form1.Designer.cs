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
            this.costButton = new System.Windows.Forms.Button();
            this.regular = new System.Windows.Forms.Button();
            this.mid = new System.Windows.Forms.Button();
            this.premium = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.gasType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.option1 = new System.Windows.Forms.Label();
            this.option2 = new System.Windows.Forms.Label();
            this.regularBox = new System.Windows.Forms.TextBox();
            this.premiumBox = new System.Windows.Forms.TextBox();
            this.midBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.carType = new System.Windows.Forms.Label();
            this.carPic = new System.Windows.Forms.Button();
            this.vanPic = new System.Windows.Forms.Button();
            this.truckPic = new System.Windows.Forms.Button();
            this.pathType = new System.Windows.Forms.Label();
            this.fuelNeeded = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fuelAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // costButton
            // 
            this.costButton.Location = new System.Drawing.Point(222, 380);
            this.costButton.Name = "costButton";
            this.costButton.Size = new System.Drawing.Size(100, 23);
            this.costButton.TabIndex = 4;
            this.costButton.Text = "Show Bill";
            this.costButton.UseVisualStyleBackColor = true;
            this.costButton.Click += new System.EventHandler(this.costButton_Click);
            // 
            // regular
            // 
            this.regular.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.regular.FlatAppearance.BorderSize = 2;
            this.regular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regular.ForeColor = System.Drawing.Color.White;
            this.regular.Location = new System.Drawing.Point(8, 77);
            this.regular.Name = "regular";
            this.regular.Size = new System.Drawing.Size(257, 36);
            this.regular.TabIndex = 5;
            this.regular.Text = "Regular ";
            this.regular.UseVisualStyleBackColor = true;
            this.regular.MouseLeave += new System.EventHandler(this.regular_MouseLeave);
            this.regular.MouseHover += new System.EventHandler(this.regular_MouseHover);
            // 
            // mid
            // 
            this.mid.BackColor = System.Drawing.Color.RoyalBlue;
            this.mid.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.mid.FlatAppearance.BorderSize = 2;
            this.mid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mid.ForeColor = System.Drawing.Color.White;
            this.mid.Location = new System.Drawing.Point(8, 119);
            this.mid.Name = "mid";
            this.mid.Size = new System.Drawing.Size(257, 36);
            this.mid.TabIndex = 6;
            this.mid.Text = "Mid - Grade";
            this.mid.UseVisualStyleBackColor = false;
            this.mid.MouseLeave += new System.EventHandler(this.mid_MouseLeave);
            this.mid.MouseHover += new System.EventHandler(this.mid_MouseHover);
            // 
            // premium
            // 
            this.premium.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.premium.FlatAppearance.BorderSize = 2;
            this.premium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.premium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premium.ForeColor = System.Drawing.Color.White;
            this.premium.Location = new System.Drawing.Point(9, 161);
            this.premium.Name = "premium";
            this.premium.Size = new System.Drawing.Size(257, 36);
            this.premium.TabIndex = 7;
            this.premium.Text = "Premium";
            this.premium.UseVisualStyleBackColor = true;
            this.premium.MouseLeave += new System.EventHandler(this.premium_MouseLeave);
            this.premium.MouseHover += new System.EventHandler(this.premium_MouseHover);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Courier New", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(80, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(297, 37);
            this.title.TabIndex = 8;
            this.title.Text = "The Corner Gas";
            // 
            // gasType
            // 
            this.gasType.AutoSize = true;
            this.gasType.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasType.ForeColor = System.Drawing.Color.White;
            this.gasType.Location = new System.Drawing.Point(5, 57);
            this.gasType.Name = "gasType";
            this.gasType.Size = new System.Drawing.Size(260, 17);
            this.gasType.TabIndex = 9;
            this.gasType.Text = "Step 1: Select your gas type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "remember the nickle round";
            // 
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.Location = new System.Drawing.Point(353, 246);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(226, 13);
            this.option1.TabIndex = 11;
            this.option1.Text = "Option 1: How full do yo want your tank to be?";
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.Location = new System.Drawing.Point(353, 327);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(176, 13);
            this.option2.TabIndex = 12;
            this.option2.Text = "Option 2: How full will your tank be?";
            // 
            // regularBox
            // 
            this.regularBox.Location = new System.Drawing.Point(222, 87);
            this.regularBox.Name = "regularBox";
            this.regularBox.Size = new System.Drawing.Size(100, 20);
            this.regularBox.TabIndex = 13;
            this.regularBox.Text = "$ 0.75 per liter";
            // 
            // premiumBox
            // 
            this.premiumBox.Location = new System.Drawing.Point(222, 171);
            this.premiumBox.Name = "premiumBox";
            this.premiumBox.Size = new System.Drawing.Size(100, 20);
            this.premiumBox.TabIndex = 14;
            this.premiumBox.Text = "$ 0.95 per liter";
            // 
            // midBox
            // 
            this.midBox.Location = new System.Drawing.Point(222, 129);
            this.midBox.Name = "midBox";
            this.midBox.Size = new System.Drawing.Size(100, 20);
            this.midBox.TabIndex = 15;
            this.midBox.Text = "$ 0.85 per liter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 16;
            // 
            // carType
            // 
            this.carType.AutoSize = true;
            this.carType.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carType.ForeColor = System.Drawing.Color.White;
            this.carType.Location = new System.Drawing.Point(5, 208);
            this.carType.Name = "carType";
            this.carType.Size = new System.Drawing.Size(296, 17);
            this.carType.TabIndex = 17;
            this.carType.Text = "Step 2: Select your vehicel type";
            // 
            // carPic
            // 
            this.carPic.Location = new System.Drawing.Point(8, 228);
            this.carPic.Name = "carPic";
            this.carPic.Size = new System.Drawing.Size(98, 90);
            this.carPic.TabIndex = 18;
            this.carPic.Text = "car";
            this.carPic.UseVisualStyleBackColor = true;
            // 
            // vanPic
            // 
            this.vanPic.Location = new System.Drawing.Point(216, 228);
            this.vanPic.Name = "vanPic";
            this.vanPic.Size = new System.Drawing.Size(98, 90);
            this.vanPic.TabIndex = 19;
            this.vanPic.Text = "Van";
            this.vanPic.UseVisualStyleBackColor = true;
            // 
            // truckPic
            // 
            this.truckPic.Location = new System.Drawing.Point(112, 228);
            this.truckPic.Name = "truckPic";
            this.truckPic.Size = new System.Drawing.Size(98, 90);
            this.truckPic.TabIndex = 20;
            this.truckPic.Text = "Truck";
            this.truckPic.UseVisualStyleBackColor = true;
            // 
            // pathType
            // 
            this.pathType.AutoSize = true;
            this.pathType.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathType.ForeColor = System.Drawing.Color.White;
            this.pathType.Location = new System.Drawing.Point(353, 213);
            this.pathType.Name = "pathType";
            this.pathType.Size = new System.Drawing.Size(224, 17);
            this.pathType.TabIndex = 21;
            this.pathType.Text = "Step 4: Select your path";
            // 
            // fuelNeeded
            // 
            this.fuelNeeded.Location = new System.Drawing.Point(457, 284);
            this.fuelNeeded.Name = "fuelNeeded";
            this.fuelNeeded.Size = new System.Drawing.Size(100, 20);
            this.fuelNeeded.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(355, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Step 3: How full is your tank?";
            // 
            // fuelAmount
            // 
            this.fuelAmount.Location = new System.Drawing.Point(533, 116);
            this.fuelAmount.Name = "fuelAmount";
            this.fuelAmount.Size = new System.Drawing.Size(100, 20);
            this.fuelAmount.TabIndex = 24;
            // 
            // storeInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(705, 445);
            this.Controls.Add(this.fuelAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fuelNeeded);
            this.Controls.Add(this.pathType);
            this.Controls.Add(this.truckPic);
            this.Controls.Add(this.vanPic);
            this.Controls.Add(this.carPic);
            this.Controls.Add(this.carType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.midBox);
            this.Controls.Add(this.premiumBox);
            this.Controls.Add(this.regularBox);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gasType);
            this.Controls.Add(this.title);
            this.Controls.Add(this.premium);
            this.Controls.Add(this.mid);
            this.Controls.Add(this.regular);
            this.Controls.Add(this.costButton);
            this.Name = "storeInterface";
            this.Text = "The Corner Gas";
            this.Load += new System.EventHandler(this.storeInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button costButton;
        private System.Windows.Forms.Button regular;
        private System.Windows.Forms.Button mid;
        private System.Windows.Forms.Button premium;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label gasType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label option1;
        private System.Windows.Forms.Label option2;
        private System.Windows.Forms.TextBox regularBox;
        private System.Windows.Forms.TextBox premiumBox;
        private System.Windows.Forms.TextBox midBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label carType;
        private System.Windows.Forms.Button carPic;
        private System.Windows.Forms.Button vanPic;
        private System.Windows.Forms.Button truckPic;
        private System.Windows.Forms.Label pathType;
        private System.Windows.Forms.TextBox fuelNeeded;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fuelAmount;
    }
}

