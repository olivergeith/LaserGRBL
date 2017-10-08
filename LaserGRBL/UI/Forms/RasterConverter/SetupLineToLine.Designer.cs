﻿namespace LaserGRBL.UI.Forms.RasterConverter
{
	partial class SetupLineToLine
	{
		/// <summary> 
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Liberare le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Codice generato da Progettazione componenti

		/// <summary> 
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupLineToLine));
			this.TLP = new System.Windows.Forms.TableLayoutPanel();
			this.CbDirections = new LaserGRBL.UserControls.EnumComboBox();
			this.UDQuality = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.BtnQualityInfo = new LaserGRBL.UserControls.ImageButton();
			this.TLP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.UDQuality)).BeginInit();
			this.SuspendLayout();
			// 
			// TLP
			// 
			this.TLP.AutoSize = true;
			this.TLP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TLP.ColumnCount = 4;
			this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TLP.Controls.Add(this.CbDirections, 1, 0);
			this.TLP.Controls.Add(this.UDQuality, 1, 1);
			this.TLP.Controls.Add(this.label5, 0, 1);
			this.TLP.Controls.Add(this.label27, 0, 0);
			this.TLP.Controls.Add(this.label8, 2, 1);
			this.TLP.Controls.Add(this.BtnQualityInfo, 3, 1);
			this.TLP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TLP.Location = new System.Drawing.Point(0, 0);
			this.TLP.Name = "TLP";
			this.TLP.RowCount = 2;
			this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
			this.TLP.Size = new System.Drawing.Size(196, 49);
			this.TLP.TabIndex = 1;
			// 
			// CbDirections
			// 
			this.CbDirections.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TLP.SetColumnSpan(this.CbDirections, 3);
			this.CbDirections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbDirections.FormattingEnabled = true;
			this.CbDirections.Location = new System.Drawing.Point(57, 2);
			this.CbDirections.Margin = new System.Windows.Forms.Padding(2);
			this.CbDirections.Name = "CbDirections";
			this.CbDirections.SelectedItem = null;
			this.CbDirections.Size = new System.Drawing.Size(137, 21);
			this.CbDirections.TabIndex = 14;
			this.CbDirections.SelectedIndexChanged += new System.EventHandler(this.CbDirectionsSelectedIndexChanged);
			// 
			// UDQuality
			// 
			this.UDQuality.DecimalPlaces = 3;
			this.UDQuality.Location = new System.Drawing.Point(57, 27);
			this.UDQuality.Margin = new System.Windows.Forms.Padding(2);
			this.UDQuality.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.UDQuality.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.UDQuality.Name = "UDQuality";
			this.UDQuality.Size = new System.Drawing.Size(55, 20);
			this.UDQuality.TabIndex = 7;
			this.UDQuality.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.UDQuality.ValueChanged += new System.EventHandler(this.UDQuality_ValueChanged);
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label5.AutoSize = true;
			this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label5.Location = new System.Drawing.Point(3, 30);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Quality";
			// 
			// label27
			// 
			this.label27.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label27.AutoSize = true;
			this.label27.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label27.Location = new System.Drawing.Point(3, 6);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(49, 13);
			this.label27.TabIndex = 13;
			this.label27.Text = "Direction";
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label8.AutoSize = true;
			this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label8.Location = new System.Drawing.Point(117, 30);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(53, 13);
			this.label8.TabIndex = 15;
			this.label8.Text = "Lines/mm";
			// 
			// BtnQualityInfo
			// 
			this.BtnQualityInfo.AltImage = null;
			this.BtnQualityInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.BtnQualityInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BtnQualityInfo.Coloration = System.Drawing.Color.Empty;
			this.BtnQualityInfo.Image = ((System.Drawing.Image)(resources.GetObject("BtnQualityInfo.Image")));
			this.BtnQualityInfo.Location = new System.Drawing.Point(176, 28);
			this.BtnQualityInfo.Name = "BtnQualityInfo";
			this.BtnQualityInfo.Size = new System.Drawing.Size(17, 17);
			this.BtnQualityInfo.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
			this.BtnQualityInfo.TabIndex = 23;
			this.BtnQualityInfo.UseAltImage = false;
			// 
			// SetupLineToLine
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.TLP);
			this.Name = "SetupLineToLine";
			this.Size = new System.Drawing.Size(196, 49);
			this.TLP.ResumeLayout(false);
			this.TLP.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.UDQuality)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel TLP;
		private UserControls.EnumComboBox CbDirections;
		private System.Windows.Forms.NumericUpDown UDQuality;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label8;
		private UserControls.ImageButton BtnQualityInfo;
	}
}