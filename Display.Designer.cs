namespace AWFAWS
{
    partial class Display
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
            this.rbObservedDataSelect = new System.Windows.Forms.RadioButton();
            this.rbForecastDataSelect = new System.Windows.Forms.RadioButton();
            this.pnlDataModeSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrevData
            // 
            this.btnPrevData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevData.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevData.Location = new System.Drawing.Point(12, 12);
            this.btnPrevData.Name = "btnPrevData";
            this.btnPrevData.Size = new System.Drawing.Size(36, 36);
            this.btnPrevData.TabIndex = 0;
            this.btnPrevData.Text = "◄";
            this.btnPrevData.UseVisualStyleBackColor = true;
            // 
            // btnNextData
            // 
            this.btnNextData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextData.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextData.Location = new System.Drawing.Point(320, 11);
            this.btnNextData.Name = "btnNextData";
            this.btnNextData.Size = new System.Drawing.Size(36, 36);
            this.btnNextData.TabIndex = 1;
            this.btnNextData.Text = "►";
            this.btnNextData.UseVisualStyleBackColor = true;
            // 
            // lblDataDateTime
            // 
            this.lblDataDateTime.AutoSize = true;
            this.lblDataDateTime.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDateTime.Location = new System.Drawing.Point(54, 15);
            this.lblDataDateTime.Name = "lblDataDateTime";
            this.lblDataDateTime.Size = new System.Drawing.Size(260, 30);
            this.lblDataDateTime.TabIndex = 2;
            this.lblDataDateTime.Text = "12/30/2022   09:16:40 PM";
            // 
            // cbDataCategorySelect
            // 
            this.cbDataCategorySelect.BackColor = System.Drawing.Color.Black;
            this.cbDataCategorySelect.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDataCategorySelect.ForeColor = System.Drawing.Color.White;
            this.cbDataCategorySelect.FormattingEnabled = true;
            this.cbDataCategorySelect.Items.AddRange(new object[] {
            "test",
            "test 2",
            "test 3",
            "pesokg"});
            this.cbDataCategorySelect.Location = new System.Drawing.Point(362, 15);
            this.cbDataCategorySelect.Name = "cbDataCategorySelect";
            this.cbDataCategorySelect.Size = new System.Drawing.Size(239, 24);
            this.cbDataCategorySelect.TabIndex = 3;
            // 
            // pnlDataModeSelect
            // 
            this.pnlDataModeSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlDataModeSelect.Controls.Add(this.rbForecastDataSelect);
            this.pnlDataModeSelect.Controls.Add(this.rbObservedDataSelect);
            this.pnlDataModeSelect.Location = new System.Drawing.Point(607, 11);
            this.pnlDataModeSelect.Name = "pnlDataModeSelect";
            this.pnlDataModeSelect.Size = new System.Drawing.Size(181, 37);
            this.pnlDataModeSelect.TabIndex = 4;
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
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDataModeSelect);
            this.Controls.Add(this.cbDataCategorySelect);
            this.Controls.Add(this.lblDataDateTime);
            this.Controls.Add(this.btnNextData);
            this.Controls.Add(this.btnPrevData);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Display";
            this.Text = "Display";
            this.pnlDataModeSelect.ResumeLayout(false);
            this.pnlDataModeSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrevData;
        private System.Windows.Forms.Button btnNextData;
        private System.Windows.Forms.Label lblDataDateTime;
        private System.Windows.Forms.ComboBox cbDataCategorySelect;
        private System.Windows.Forms.Panel pnlDataModeSelect;
        private System.Windows.Forms.RadioButton rbForecastDataSelect;
        private System.Windows.Forms.RadioButton rbObservedDataSelect;
    }
}

