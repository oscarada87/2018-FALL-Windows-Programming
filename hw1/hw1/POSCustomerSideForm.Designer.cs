namespace hw1
{
    partial class POSCustomerSideForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            this._add_button = new System.Windows.Forms.Button();
            this._meals_groupbo1 = new System.Windows.Forms.GroupBox();
            this._next_page_button = new System.Windows.Forms.Button();
            this._meal_button_9 = new System.Windows.Forms.Button();
            this._meal_button_8 = new System.Windows.Forms.Button();
            this._meal_button_7 = new System.Windows.Forms.Button();
            this._meal_button_6 = new System.Windows.Forms.Button();
            this._meal_button_5 = new System.Windows.Forms.Button();
            this._meal_button_4 = new System.Windows.Forms.Button();
            this._meal_button_3 = new System.Windows.Forms.Button();
            this._meal_button_2 = new System.Windows.Forms.Button();
            this._meal_button_1 = new System.Windows.Forms.Button();
            this._page_label = new System.Windows.Forms.Label();
            this._previous_page_button = new System.Windows.Forms.Button();
            this._record_datagridview = new System.Windows.Forms.DataGridView();
            this.MealsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MealsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._total_label = new System.Windows.Forms.Label();
            this._meals_groupbo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._record_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // _add_button
            // 
            this._add_button.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._add_button.Location = new System.Drawing.Point(362, 571);
            this._add_button.Name = "_add_button";
            this._add_button.Size = new System.Drawing.Size(141, 31);
            this._add_button.TabIndex = 3;
            this._add_button.Text = "Add";
            this._add_button.UseVisualStyleBackColor = true;
            this._add_button.Click += new System.EventHandler(this._add_button_Click);
            // 
            // _meals_groupbo1
            // 
            this._meals_groupbo1.Controls.Add(this._next_page_button);
            this._meals_groupbo1.Controls.Add(this._add_button);
            this._meals_groupbo1.Controls.Add(this._meal_button_9);
            this._meals_groupbo1.Controls.Add(this._meal_button_8);
            this._meals_groupbo1.Controls.Add(this._meal_button_7);
            this._meals_groupbo1.Controls.Add(this._meal_button_6);
            this._meals_groupbo1.Controls.Add(this._meal_button_5);
            this._meals_groupbo1.Controls.Add(this._meal_button_4);
            this._meals_groupbo1.Controls.Add(this._meal_button_3);
            this._meals_groupbo1.Controls.Add(this._meal_button_2);
            this._meals_groupbo1.Controls.Add(this._meal_button_1);
            this._meals_groupbo1.Controls.Add(this._page_label);
            this._meals_groupbo1.Controls.Add(this._previous_page_button);
            this._meals_groupbo1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._meals_groupbo1.Location = new System.Drawing.Point(12, 12);
            this._meals_groupbo1.Name = "_meals_groupbo1";
            this._meals_groupbo1.Size = new System.Drawing.Size(536, 651);
            this._meals_groupbo1.TabIndex = 7;
            this._meals_groupbo1.TabStop = false;
            this._meals_groupbo1.Text = "Meals";
            // 
            // _next_page_button
            // 
            this._next_page_button.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._next_page_button.Location = new System.Drawing.Point(362, 608);
            this._next_page_button.Name = "_next_page_button";
            this._next_page_button.Size = new System.Drawing.Size(141, 31);
            this._next_page_button.TabIndex = 4;
            this._next_page_button.Text = "Next Page";
            this._next_page_button.UseVisualStyleBackColor = true;
            // 
            // _meal_button_9
            // 
            this._meal_button_9.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._meal_button_9.Location = new System.Drawing.Point(362, 367);
            this._meal_button_9.Name = "_meal_button_9";
            this._meal_button_9.Size = new System.Drawing.Size(150, 150);
            this._meal_button_9.TabIndex = 15;
            this._meal_button_9.Text = "麥脆雞 （2塊）\r\n$ 104元";
            this._meal_button_9.UseVisualStyleBackColor = true;
            this._meal_button_9.Click += new System.EventHandler(this._meal_button_9_Click);
            // 
            // _meal_button_8
            // 
            this._meal_button_8.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._meal_button_8.Location = new System.Drawing.Point(190, 367);
            this._meal_button_8.Name = "_meal_button_8";
            this._meal_button_8.Size = new System.Drawing.Size(150, 150);
            this._meal_button_8.TabIndex = 14;
            this._meal_button_8.Text = "勁辣雞腿堡\r\n$ 69元";
            this._meal_button_8.UseVisualStyleBackColor = true;
            this._meal_button_8.Click += new System.EventHandler(this._meal_button_8_Click);
            // 
            // _meal_button_7
            // 
            this._meal_button_7.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._meal_button_7.Location = new System.Drawing.Point(19, 367);
            this._meal_button_7.Name = "_meal_button_7";
            this._meal_button_7.Size = new System.Drawing.Size(150, 150);
            this._meal_button_7.TabIndex = 13;
            this._meal_button_7.Text = "麥克雞塊（9塊）\r\n$ 89元";
            this._meal_button_7.UseVisualStyleBackColor = true;
            this._meal_button_7.Click += new System.EventHandler(this._meal_button_7_Click);
            // 
            // _meal_button_6
            // 
            this._meal_button_6.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._meal_button_6.Location = new System.Drawing.Point(362, 205);
            this._meal_button_6.Name = "_meal_button_6";
            this._meal_button_6.Size = new System.Drawing.Size(150, 150);
            this._meal_button_6.TabIndex = 12;
            this._meal_button_6.Text = "麥克雞塊 （6塊）\r\n$ 59元";
            this._meal_button_6.UseVisualStyleBackColor = true;
            this._meal_button_6.Click += new System.EventHandler(this._meal_button_6_Click);
            // 
            // _meal_button_5
            // 
            this._meal_button_5.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._meal_button_5.Location = new System.Drawing.Point(190, 205);
            this._meal_button_5.Name = "_meal_button_5";
            this._meal_button_5.Size = new System.Drawing.Size(150, 150);
            this._meal_button_5.TabIndex = 11;
            this._meal_button_5.Text = "麥香雞\r\n$ 49元";
            this._meal_button_5.UseVisualStyleBackColor = true;
            this._meal_button_5.Click += new System.EventHandler(this._meal_button_5_Click);
            // 
            // _meal_button_4
            // 
            this._meal_button_4.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._meal_button_4.Location = new System.Drawing.Point(19, 205);
            this._meal_button_4.Name = "_meal_button_4";
            this._meal_button_4.Size = new System.Drawing.Size(150, 150);
            this._meal_button_4.TabIndex = 10;
            this._meal_button_4.Text = "嫩煎雞腿堡\r\n$ 79元";
            this._meal_button_4.UseVisualStyleBackColor = true;
            this._meal_button_4.Click += new System.EventHandler(this._meal_button_4_Click);
            // 
            // _meal_button_3
            // 
            this._meal_button_3.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._meal_button_3.Location = new System.Drawing.Point(362, 41);
            this._meal_button_3.Name = "_meal_button_3";
            this._meal_button_3.Size = new System.Drawing.Size(150, 150);
            this._meal_button_3.TabIndex = 9;
            this._meal_button_3.Text = "安格斯黑牛堡\r\n$ 99元";
            this._meal_button_3.UseVisualStyleBackColor = true;
            this._meal_button_3.Click += new System.EventHandler(this._meal_button_3_Click);
            // 
            // _meal_button_2
            // 
            this._meal_button_2.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._meal_button_2.Location = new System.Drawing.Point(190, 41);
            this._meal_button_2.Name = "_meal_button_2";
            this._meal_button_2.Size = new System.Drawing.Size(150, 150);
            this._meal_button_2.TabIndex = 8;
            this._meal_button_2.Text = "雙層牛肉吉事堡\r\n$ 59元";
            this._meal_button_2.UseVisualStyleBackColor = true;
            this._meal_button_2.Click += new System.EventHandler(this._meal_button_2_Click);
            // 
            // _meal_button_1
            // 
            this._meal_button_1.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._meal_button_1.Location = new System.Drawing.Point(19, 41);
            this._meal_button_1.Name = "_meal_button_1";
            this._meal_button_1.Size = new System.Drawing.Size(150, 150);
            this._meal_button_1.TabIndex = 7;
            this._meal_button_1.Text = "大麥克\r\n$ 69元";
            this._meal_button_1.UseVisualStyleBackColor = true;
            this._meal_button_1.Click += new System.EventHandler(this._meal_button_1_Click);
            // 
            // _page_label
            // 
            this._page_label.AutoSize = true;
            this._page_label.ForeColor = System.Drawing.Color.SteelBlue;
            this._page_label.Location = new System.Drawing.Point(20, 610);
            this._page_label.Name = "_page_label";
            this._page_label.Size = new System.Drawing.Size(93, 24);
            this._page_label.TabIndex = 6;
            this._page_label.Text = "Page: 1/2";
            // 
            // _previous_page_button
            // 
            this._previous_page_button.Cursor = System.Windows.Forms.Cursors.Default;
            this._previous_page_button.Enabled = false;
            this._previous_page_button.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this._previous_page_button.Location = new System.Drawing.Point(215, 608);
            this._previous_page_button.Name = "_previous_page_button";
            this._previous_page_button.Size = new System.Drawing.Size(141, 31);
            this._previous_page_button.TabIndex = 5;
            this._previous_page_button.Text = "Previos Page";
            this._previous_page_button.UseVisualStyleBackColor = true;
            // 
            // _record_datagridview
            // 
            this._record_datagridview.AllowUserToAddRows = false;
            this._record_datagridview.AllowUserToDeleteRows = false;
            this._record_datagridview.AllowUserToResizeColumns = false;
            this._record_datagridview.AllowUserToResizeRows = false;
            this._record_datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._record_datagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this._record_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._record_datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MealsName,
            this.MealsPrice});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._record_datagridview.DefaultCellStyle = dataGridViewCellStyle26;
            this._record_datagridview.Location = new System.Drawing.Point(592, 24);
            this._record_datagridview.Name = "_record_datagridview";
            this._record_datagridview.RowHeadersVisible = false;
            this._record_datagridview.RowTemplate.Height = 24;
            this._record_datagridview.Size = new System.Drawing.Size(606, 572);
            this._record_datagridview.TabIndex = 8;
            // 
            // MealsName
            // 
            this.MealsName.HeaderText = "Name";
            this.MealsName.Name = "MealsName";
            // 
            // MealsPrice
            // 
            this.MealsPrice.HeaderText = "Unit Price";
            this.MealsPrice.Name = "MealsPrice";
            // 
            // _total_label
            // 
            this._total_label.AutoSize = true;
            this._total_label.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this._total_label.ForeColor = System.Drawing.Color.SaddleBrown;
            this._total_label.Location = new System.Drawing.Point(1014, 613);
            this._total_label.Name = "_total_label";
            this._total_label.Size = new System.Drawing.Size(150, 38);
            this._total_label.TabIndex = 7;
            this._total_label.Text = "Total: 0元";
            // 
            // POSCustomerSideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 680);
            this.Controls.Add(this._total_label);
            this.Controls.Add(this._record_datagridview);
            this.Controls.Add(this._meals_groupbo1);
            this.Name = "POSCustomerSideForm";
            this.Text = "Form1";
            this._meals_groupbo1.ResumeLayout(false);
            this._meals_groupbo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._record_datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _add_button;
        private System.Windows.Forms.GroupBox _meals_groupbo1;
        private System.Windows.Forms.Button _previous_page_button;
        private System.Windows.Forms.Button _next_page_button;
        private System.Windows.Forms.Label _page_label;
        private System.Windows.Forms.DataGridView _record_datagridview;
        private System.Windows.Forms.Label _total_label;
        private System.Windows.Forms.Button _meal_button_9;
        private System.Windows.Forms.Button _meal_button_8;
        private System.Windows.Forms.Button _meal_button_7;
        private System.Windows.Forms.Button _meal_button_6;
        private System.Windows.Forms.Button _meal_button_5;
        private System.Windows.Forms.Button _meal_button_4;
        private System.Windows.Forms.Button _meal_button_3;
        private System.Windows.Forms.Button _meal_button_2;
        private System.Windows.Forms.Button _meal_button_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealsPrice;
    }

}

