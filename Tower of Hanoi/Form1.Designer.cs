namespace Tower_of_Hanoi
{
	partial class frmMain
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            this.picMain = new System.Windows.Forms.PictureBox();
            this.lstActions = new System.Windows.Forms.ListBox();
            this.updHeight = new System.Windows.Forms.NumericUpDown();
            this.cmbToBox = new System.Windows.Forms.ComboBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblActions = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.updSpeed = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.Location = new System.Drawing.Point(213, 12);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(1002, 600);
            this.picMain.TabIndex = 0;
            this.picMain.TabStop = false;
            this.picMain.Paint += new System.Windows.Forms.PaintEventHandler(this.picMain_Paint);
            // 
            // lstActions
            // 
            this.lstActions.FormattingEnabled = true;
            this.lstActions.Location = new System.Drawing.Point(12, 230);
            this.lstActions.Name = "lstActions";
            this.lstActions.Size = new System.Drawing.Size(195, 316);
            this.lstActions.TabIndex = 1;
            // 
            // updHeight
            // 
            this.updHeight.Location = new System.Drawing.Point(12, 95);
            this.updHeight.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.updHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updHeight.Name = "updHeight";
            this.updHeight.Size = new System.Drawing.Size(78, 20);
            this.updHeight.TabIndex = 2;
            this.updHeight.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // cmbToBox
            // 
            this.cmbToBox.FormattingEnabled = true;
            this.cmbToBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbToBox.Location = new System.Drawing.Point(12, 25);
            this.cmbToBox.Name = "cmbToBox";
            this.cmbToBox.Size = new System.Drawing.Size(78, 21);
            this.cmbToBox.TabIndex = 3;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(12, 164);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(195, 23);
            this.btnExecute.TabIndex = 4;
            this.btnExecute.Text = "Éxecuter";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(12, 9);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(85, 13);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "Bouger à la tour:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(12, 79);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(63, 13);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Hauteur de:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(12, 576);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(89, 13);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "Nombre d\'actions";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(15, 592);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(192, 20);
            this.txtCount.TabIndex = 8;
            this.txtCount.Text = "0";
            // 
            // lblActions
            // 
            this.lblActions.AutoSize = true;
            this.lblActions.Location = new System.Drawing.Point(12, 214);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(77, 13);
            this.lblActions.TabIndex = 9;
            this.lblActions.Text = "Liste d\'actions:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(118, 23);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Réinitialiser";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(122, 79);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(63, 13);
            this.lblSpeed.TabIndex = 11;
            this.lblSpeed.Text = "Rapidité (s):";
            // 
            // updSpeed
            // 
            this.updSpeed.DecimalPlaces = 2;
            this.updSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.updSpeed.Location = new System.Drawing.Point(118, 95);
            this.updSpeed.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.updSpeed.Name = "updSpeed";
            this.updSpeed.Size = new System.Drawing.Size(78, 20);
            this.updSpeed.TabIndex = 12;
            this.updSpeed.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 624);
            this.Controls.Add(this.updSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblActions);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.cmbToBox);
            this.Controls.Add(this.updHeight);
            this.Controls.Add(this.lstActions);
            this.Controls.Add(this.picMain);
            this.Name = "frmMain";
            this.Text = "Tour de Hanoi";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picMain;
		private System.Windows.Forms.ListBox lstActions;
		private System.Windows.Forms.NumericUpDown updHeight;
		private System.Windows.Forms.ComboBox cmbToBox;
		private System.Windows.Forms.Button btnExecute;
		private System.Windows.Forms.Label lblTo;
		private System.Windows.Forms.Label lblHeight;
		private System.Windows.Forms.Label lblCount;
		private System.Windows.Forms.TextBox txtCount;
		private System.Windows.Forms.Label lblActions;
		private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.NumericUpDown updSpeed;
    }
}

