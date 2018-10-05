namespace POSCustomerSide
{
    partial class RestaurantSideForm
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
            this._okButton = new System.Windows.Forms.Button();
            this._notice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _okButton
            // 
            this._okButton.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._okButton.Location = new System.Drawing.Point(280, 180);
            this._okButton.Name = "_OkButton";
            this._okButton.Size = new System.Drawing.Size(101, 27);
            this._okButton.TabIndex = 0;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // _notice
            // 
            this._notice.AutoSize = true;
            this._notice.Font = new System.Drawing.Font("標楷體", 50F, System.Drawing.FontStyle.Bold);
            this._notice.Location = new System.Drawing.Point(92, 65);
            this._notice.Name = "_notification";
            this._notice.Size = new System.Drawing.Size(484, 67);
            this._notice.TabIndex = 1;
            this._notice.Text = "Comming Soon!";
            // 
            // RestaurantSideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 268);
            this.Controls.Add(this._notice);
            this.Controls.Add(this._okButton);
            this.Name = "RestaurantSideForm";
            this.Text = "POS-Restaurant Side";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Label _notice;
    }
}