namespace hw1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.AddButton = new System.Windows.Forms.Button();
            this.MealsGroupBox = new System.Windows.Forms.GroupBox();
            this.NextPageButton = new System.Windows.Forms.Button();
            this.PreviousPageButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PageLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.MealsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.AddButton.Location = new System.Drawing.Point(362, 571);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(141, 31);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // MealsGroupBox
            // 
            this.MealsGroupBox.Controls.Add(this.button12);
            this.MealsGroupBox.Controls.Add(this.button11);
            this.MealsGroupBox.Controls.Add(this.button10);
            this.MealsGroupBox.Controls.Add(this.button9);
            this.MealsGroupBox.Controls.Add(this.button8);
            this.MealsGroupBox.Controls.Add(this.button7);
            this.MealsGroupBox.Controls.Add(this.button6);
            this.MealsGroupBox.Controls.Add(this.button5);
            this.MealsGroupBox.Controls.Add(this.button3);
            this.MealsGroupBox.Controls.Add(this.PageLabel);
            this.MealsGroupBox.Controls.Add(this.PreviousPageButton);
            this.MealsGroupBox.Controls.Add(this.NextPageButton);
            this.MealsGroupBox.Controls.Add(this.AddButton);
            this.MealsGroupBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MealsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.MealsGroupBox.Name = "MealsGroupBox";
            this.MealsGroupBox.Size = new System.Drawing.Size(536, 651);
            this.MealsGroupBox.TabIndex = 7;
            this.MealsGroupBox.TabStop = false;
            this.MealsGroupBox.Text = "Meals";
            // 
            // NextPageButton
            // 
            this.NextPageButton.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.NextPageButton.Location = new System.Drawing.Point(362, 608);
            this.NextPageButton.Name = "NextPageButton";
            this.NextPageButton.Size = new System.Drawing.Size(141, 31);
            this.NextPageButton.TabIndex = 4;
            this.NextPageButton.Text = "Next Page";
            this.NextPageButton.UseVisualStyleBackColor = true;
            // 
            // PreviousPageButton
            // 
            this.PreviousPageButton.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.PreviousPageButton.Location = new System.Drawing.Point(215, 608);
            this.PreviousPageButton.Name = "PreviousPageButton";
            this.PreviousPageButton.Size = new System.Drawing.Size(141, 31);
            this.PreviousPageButton.TabIndex = 5;
            this.PreviousPageButton.Text = "Previos Page";
            this.PreviousPageButton.UseVisualStyleBackColor = true;
            this.PreviousPageButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(592, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(606, 572);
            this.dataGridView1.TabIndex = 8;
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.PageLabel.Location = new System.Drawing.Point(20, 610);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(93, 24);
            this.PageLabel.TabIndex = 6;
            this.PageLabel.Text = "Page: 1/2";
            this.PageLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.TotalLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.TotalLabel.Location = new System.Drawing.Point(1014, 613);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(184, 38);
            this.TotalLabel.TabIndex = 7;
            this.TotalLabel.Text = "Total: 200元";
            this.TotalLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 127);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(192, 41);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 127);
            this.button5.TabIndex = 8;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(362, 41);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(141, 127);
            this.button6.TabIndex = 9;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(24, 205);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(141, 127);
            this.button7.TabIndex = 10;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(192, 205);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(141, 127);
            this.button8.TabIndex = 11;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(362, 205);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(141, 127);
            this.button9.TabIndex = 12;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(24, 377);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(141, 127);
            this.button10.TabIndex = 13;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(192, 377);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(141, 127);
            this.button11.TabIndex = 14;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(362, 377);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(141, 127);
            this.button12.TabIndex = 15;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 675);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MealsGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MealsGroupBox.ResumeLayout(false);
            this.MealsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.GroupBox MealsGroupBox;
        private System.Windows.Forms.Button PreviousPageButton;
        private System.Windows.Forms.Button NextPageButton;
        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
    }
}

