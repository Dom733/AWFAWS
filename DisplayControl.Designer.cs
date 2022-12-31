namespace AWFAWS
{
    partial class DisplayControl
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
            this.btnPrevData = new System.Windows.Forms.Button();
            this.btnNextData = new System.Windows.Forms.Button();
            this.lblDataDateTime = new System.Windows.Forms.Label();
            this.cbDataCategorySelect = new System.Windows.Forms.ComboBox();
            this.pnlDataModeSelect = new System.Windows.Forms.Panel();
            this.rbForecastDataSelect = new System.Windows.Forms.RadioButton();
            this.rbObservedDataSelect = new System.Windows.Forms.RadioButton();
            this.btnGoToLatest = new System.Windows.Forms.Button();
            this.pnlDataModeSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrevData
            // 
            this.btnPrevData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnPrevData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevData.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevData.Location = new System.Drawing.Point(12, 12);
            this.btnPrevData.Name = "btnPrevData";
            this.btnPrevData.Size = new System.Drawing.Size(36, 36);
            this.btnPrevData.TabIndex = 0;
            this.btnPrevData.Text = "◄";
            this.btnPrevData.UseVisualStyleBackColor = false;
            // 
            // btnNextData
            // 
            this.btnNextData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnNextData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextData.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextData.Location = new System.Drawing.Point(323, 12);
            this.btnNextData.Name = "btnNextData";
            this.btnNextData.Size = new System.Drawing.Size(36, 36);
            this.btnNextData.TabIndex = 1;
            this.btnNextData.Text = "►";
            this.btnNextData.UseVisualStyleBackColor = false;
            // 
            // lblDataDateTime
            // 
            this.lblDataDateTime.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDateTime.Location = new System.Drawing.Point(54, 16);
            this.lblDataDateTime.Name = "lblDataDateTime";
            this.lblDataDateTime.Size = new System.Drawing.Size(263, 30);
            this.lblDataDateTime.TabIndex = 2;
            this.lblDataDateTime.Text = "12/30/2022   09:16:40 PM";
            this.lblDataDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbDataCategorySelect
            // 
            this.cbDataCategorySelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.cbDataCategorySelect.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F);
            this.cbDataCategorySelect.ForeColor = System.Drawing.Color.White;
            this.cbDataCategorySelect.FormattingEnabled = true;
            this.cbDataCategorySelect.Items.AddRange(new object[] {
            "test",
            "test 2",
            "test 3",
            "pesokg"});
            this.cbDataCategorySelect.Location = new System.Drawing.Point(184, 6);
            this.cbDataCategorySelect.Name = "cbDataCategorySelect";
            this.cbDataCategorySelect.Size = new System.Drawing.Size(403, 24);
            this.cbDataCategorySelect.TabIndex = 3;
            // 
            // pnlDataModeSelect
            // 
            this.pnlDataModeSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlDataModeSelect.Controls.Add(this.rbForecastDataSelect);
            this.pnlDataModeSelect.Controls.Add(this.cbDataCategorySelect);
            this.pnlDataModeSelect.Controls.Add(this.rbObservedDataSelect);
            this.pnlDataModeSelect.Location = new System.Drawing.Point(12, 54);
            this.pnlDataModeSelect.Name = "pnlDataModeSelect";
            this.pnlDataModeSelect.Size = new System.Drawing.Size(590, 36);
            this.pnlDataModeSelect.TabIndex = 4;
            // 
            // rbForecastDataSelect
            // 
            this.rbForecastDataSelect.AutoSize = true;
            this.rbForecastDataSelect.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbForecastDataSelect.Location = new System.Drawing.Point(90, 6);
            this.rbForecastDataSelect.Name = "rbForecastDataSelect";
            this.rbForecastDataSelect.Size = new System.Drawing.Size(88, 24);
            this.rbForecastDataSelect.TabIndex = 6;
            this.rbForecastDataSelect.TabStop = true;
            this.rbForecastDataSelect.Text = "Forecasted";
            this.rbForecastDataSelect.UseVisualStyleBackColor = true;
            // 
            // rbObservedDataSelect
            // 
            this.rbObservedDataSelect.AutoSize = true;
            this.rbObservedDataSelect.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbObservedDataSelect.Location = new System.Drawing.Point(6, 6);
            this.rbObservedDataSelect.Name = "rbObservedDataSelect";
            this.rbObservedDataSelect.Size = new System.Drawing.Size(78, 24);
            this.rbObservedDataSelect.TabIndex = 5;
            this.rbObservedDataSelect.TabStop = true;
            this.rbObservedDataSelect.Text = "Observed";
            this.rbObservedDataSelect.UseVisualStyleBackColor = true;
            // 
            // btnGoToLatest
            // 
            this.btnGoToLatest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnGoToLatest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToLatest.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F);
            this.btnGoToLatest.Location = new System.Drawing.Point(365, 12);
            this.btnGoToLatest.Name = "btnGoToLatest";
            this.btnGoToLatest.Size = new System.Drawing.Size(237, 36);
            this.btnGoToLatest.TabIndex = 5;
            this.btnGoToLatest.Text = "Go to latest data";
            this.btnGoToLatest.UseVisualStyleBackColor = false;
            // 
            // DisplayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(614, 100);
            this.Controls.Add(this.btnGoToLatest);
            this.Controls.Add(this.pnlDataModeSelect);
            this.Controls.Add(this.lblDataDateTime);
            this.Controls.Add(this.btnNextData);
            this.Controls.Add(this.btnPrevData);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "DisplayControl";
            this.Text = "Display Control";
            this.pnlDataModeSelect.ResumeLayout(false);
            this.pnlDataModeSelect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrevData;
        private System.Windows.Forms.Button btnNextData;
        private System.Windows.Forms.Label lblDataDateTime;
        private System.Windows.Forms.ComboBox cbDataCategorySelect;
        private System.Windows.Forms.Panel pnlDataModeSelect;
        private System.Windows.Forms.RadioButton rbForecastDataSelect;
        private System.Windows.Forms.RadioButton rbObservedDataSelect;
        private System.Windows.Forms.Button btnGoToLatest;
    }
}

