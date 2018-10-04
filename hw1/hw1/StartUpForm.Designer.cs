namespace POSCustomerSide
{
    partial class StartUpForm
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
            this._frontEndButton = new System.Windows.Forms.Button();
            this._backEndButton = new System.Windows.Forms.Button();
            this._exitButton = new System.Windows.Forms.Button();
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _frontEndButton
            // 
            this._frontEndButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._frontEndButton.AutoSize = true;
            this._tableLayoutPanel.SetColumnSpan(this._frontEndButton, 2);
            this._frontEndButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._frontEndButton.Location = new System.Drawing.Point(3, 3);
            this._frontEndButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this._frontEndButton.Name = "_frontEndButton";
            this._frontEndButton.Size = new System.Drawing.Size(678, 107);
            this._frontEndButton.TabIndex = 0;
            this._frontEndButton.Text = "Start the Cutomer Program (Frontend)";
            this._frontEndButton.UseVisualStyleBackColor = true;
            this._frontEndButton.Click += new System.EventHandler(this.ClickFrontEndButton);
            // 
            // _backEndButton
            // 
            this._backEndButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._backEndButton.AutoSize = true;
            this._tableLayoutPanel.SetColumnSpan(this._backEndButton, 2);
            this._backEndButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._backEndButton.Location = new System.Drawing.Point(3, 130);
            this._backEndButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this._backEndButton.Name = "_backEndButton";
            this._backEndButton.Size = new System.Drawing.Size(678, 100);
            this._backEndButton.TabIndex = 1;
            this._backEndButton.Text = "Start the Restaurant Program (Backend)";
            this._backEndButton.UseVisualStyleBackColor = true;
            this._backEndButton.Click += new System.EventHandler(this.ClickBackEndButton);
            // 
            // _exitButton
            // 
            this._exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._exitButton.AutoSize = true;
            this._exitButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._exitButton.Location = new System.Drawing.Point(481, 250);
            this._exitButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this._exitButton.MinimumSize = new System.Drawing.Size(0, 40);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(200, 108);
            this._exitButton.TabIndex = 2;
            this._exitButton.Text = "Exit";
            this._exitButton.UseVisualStyleBackColor = true;
            this._exitButton.Click += new System.EventHandler(this.ClickExitButton);
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.ColumnCount = 2;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._tableLayoutPanel.Controls.Add(this._frontEndButton, 0, 0);
            this._tableLayoutPanel.Controls.Add(this._exitButton, 1, 2);
            this._tableLayoutPanel.Controls.Add(this._backEndButton, 0, 1);
            this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.RowCount = 3;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(684, 361);
            this._tableLayoutPanel.TabIndex = 3;
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this._tableLayoutPanel);
            this.Name = "StartUpForm";
            this.Text = "StartUp";
            this._tableLayoutPanel.ResumeLayout(false);
            this._tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _frontEndButton;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private System.Windows.Forms.Button _exitButton;
        private System.Windows.Forms.Button _backEndButton;
    }
}