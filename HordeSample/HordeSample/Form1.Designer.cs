namespace HordeSample
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.inputValue_100_label = new System.Windows.Forms.Label();
			this.inputValue_10_label = new System.Windows.Forms.Label();
			this.inputValue_1_label = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.life_1_picturebox = new System.Windows.Forms.PictureBox();
			this.life_10_picturebox = new System.Windows.Forms.PictureBox();
			this.lifeMinus_picturebox = new System.Windows.Forms.PictureBox();
			this.life_100_picturebox = new System.Windows.Forms.PictureBox();
			this.lifeBG_picturebox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.life_1_picturebox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.life_10_picturebox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeMinus_picturebox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.life_100_picturebox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeBG_picturebox)).BeginInit();
			this.SuspendLayout();
			// 
			// inputValue_100_label
			// 
			this.inputValue_100_label.AutoSize = true;
			this.inputValue_100_label.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.inputValue_100_label.Location = new System.Drawing.Point(112, 168);
			this.inputValue_100_label.Name = "inputValue_100_label";
			this.inputValue_100_label.Size = new System.Drawing.Size(44, 48);
			this.inputValue_100_label.TabIndex = 1;
			this.inputValue_100_label.Text = "0";
			// 
			// inputValue_10_label
			// 
			this.inputValue_10_label.AutoSize = true;
			this.inputValue_10_label.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.inputValue_10_label.Location = new System.Drawing.Point(152, 168);
			this.inputValue_10_label.Name = "inputValue_10_label";
			this.inputValue_10_label.Size = new System.Drawing.Size(44, 48);
			this.inputValue_10_label.TabIndex = 1;
			this.inputValue_10_label.Text = "0";
			// 
			// inputValue_1_label
			// 
			this.inputValue_1_label.AutoSize = true;
			this.inputValue_1_label.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.inputValue_1_label.Location = new System.Drawing.Point(192, 168);
			this.inputValue_1_label.Name = "inputValue_1_label";
			this.inputValue_1_label.Size = new System.Drawing.Size(44, 48);
			this.inputValue_1_label.TabIndex = 1;
			this.inputValue_1_label.Text = "0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "ライフポイント";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 184);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "入力値";
			// 
			// life_1_picturebox
			// 
			this.life_1_picturebox.Image = global::HordeSample.Properties.Resources.lp_000;
			this.life_1_picturebox.Location = new System.Drawing.Point(232, 24);
			this.life_1_picturebox.Name = "life_1_picturebox";
			this.life_1_picturebox.Size = new System.Drawing.Size(32, 50);
			this.life_1_picturebox.TabIndex = 0;
			this.life_1_picturebox.TabStop = false;
			// 
			// life_10_picturebox
			// 
			this.life_10_picturebox.Image = global::HordeSample.Properties.Resources.lp_000;
			this.life_10_picturebox.Location = new System.Drawing.Point(192, 24);
			this.life_10_picturebox.Name = "life_10_picturebox";
			this.life_10_picturebox.Size = new System.Drawing.Size(32, 50);
			this.life_10_picturebox.TabIndex = 0;
			this.life_10_picturebox.TabStop = false;
			// 
			// lifeMinus_picturebox
			// 
			this.lifeMinus_picturebox.Image = global::HordeSample.Properties.Resources.minus;
			this.lifeMinus_picturebox.Location = new System.Drawing.Point(112, 24);
			this.lifeMinus_picturebox.Name = "lifeMinus_picturebox";
			this.lifeMinus_picturebox.Size = new System.Drawing.Size(32, 50);
			this.lifeMinus_picturebox.TabIndex = 0;
			this.lifeMinus_picturebox.TabStop = false;
			// 
			// life_100_picturebox
			// 
			this.life_100_picturebox.Image = global::HordeSample.Properties.Resources.lp_000;
			this.life_100_picturebox.Location = new System.Drawing.Point(152, 24);
			this.life_100_picturebox.Name = "life_100_picturebox";
			this.life_100_picturebox.Size = new System.Drawing.Size(32, 50);
			this.life_100_picturebox.TabIndex = 0;
			this.life_100_picturebox.TabStop = false;
			// 
			// lifeBG_picturebox
			// 
			this.lifeBG_picturebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.lifeBG_picturebox.Location = new System.Drawing.Point(104, 16);
			this.lifeBG_picturebox.Name = "lifeBG_picturebox";
			this.lifeBG_picturebox.Size = new System.Drawing.Size(168, 64);
			this.lifeBG_picturebox.TabIndex = 3;
			this.lifeBG_picturebox.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(372, 262);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.inputValue_1_label);
			this.Controls.Add(this.inputValue_10_label);
			this.Controls.Add(this.inputValue_100_label);
			this.Controls.Add(this.life_1_picturebox);
			this.Controls.Add(this.life_10_picturebox);
			this.Controls.Add(this.lifeMinus_picturebox);
			this.Controls.Add(this.life_100_picturebox);
			this.Controls.Add(this.lifeBG_picturebox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.life_1_picturebox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.life_10_picturebox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeMinus_picturebox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.life_100_picturebox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lifeBG_picturebox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox life_100_picturebox;
		private System.Windows.Forms.PictureBox life_10_picturebox;
		private System.Windows.Forms.PictureBox life_1_picturebox;
		private System.Windows.Forms.Label inputValue_100_label;
		private System.Windows.Forms.Label inputValue_10_label;
		private System.Windows.Forms.Label inputValue_1_label;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox lifeBG_picturebox;
		private System.Windows.Forms.PictureBox lifeMinus_picturebox;
	}
}

