/*
 * Created by SharpDevelop.
 * User: C1-B05
 * Date: 1/8/2019
 * Time: 8:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NguyenHungKhanhDuy1706020016
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pbDraw = new System.Windows.Forms.PictureBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbLine = new System.Windows.Forms.ToolStripButton();
			this.tsb2 = new System.Windows.Forms.ToolStripButton();
			this.tsb3 = new System.Windows.Forms.ToolStripButton();
			this.btSave = new System.Windows.Forms.Button();
			this.btLoad = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbDraw)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbDraw
			// 
			this.pbDraw.BackColor = System.Drawing.Color.White;
			this.pbDraw.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbDraw.Location = new System.Drawing.Point(0, 0);
			this.pbDraw.Name = "pbDraw";
			this.pbDraw.Size = new System.Drawing.Size(399, 299);
			this.pbDraw.TabIndex = 0;
			this.pbDraw.TabStop = false;
			this.pbDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbDrawMouseDown);
			this.pbDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbDrawMouseMove);
			this.pbDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbDrawMouseUp);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tsbLine,
									this.tsb2,
									this.tsb3});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(399, 38);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbLine
			// 
			this.tsbLine.CheckOnClick = true;
			this.tsbLine.Image = ((System.Drawing.Image)(resources.GetObject("tsbLine.Image")));
			this.tsbLine.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbLine.Name = "tsbLine";
			this.tsbLine.Size = new System.Drawing.Size(80, 35);
			this.tsbLine.Text = "đường thẳng";
			this.tsbLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsbLine.Click += new System.EventHandler(this.TsbLineClick);
			// 
			// tsb2
			// 
			this.tsb2.Image = ((System.Drawing.Image)(resources.GetObject("tsb2.Image")));
			this.tsb2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb2.Name = "tsb2";
			this.tsb2.Size = new System.Drawing.Size(57, 35);
			this.tsb2.Text = "tam giác";
			this.tsb2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// tsb3
			// 
			this.tsb3.Image = ((System.Drawing.Image)(resources.GetObject("tsb3.Image")));
			this.tsb3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb3.Name = "tsb3";
			this.tsb3.Size = new System.Drawing.Size(59, 35);
			this.tsb3.Text = "hình thoi";
			this.tsb3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// btSave
			// 
			this.btSave.Location = new System.Drawing.Point(231, 12);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(75, 23);
			this.btSave.TabIndex = 2;
			this.btSave.Text = "Save";
			this.btSave.UseVisualStyleBackColor = true;
			// 
			// btLoad
			// 
			this.btLoad.Location = new System.Drawing.Point(312, 12);
			this.btLoad.Name = "btLoad";
			this.btLoad.Size = new System.Drawing.Size(75, 23);
			this.btLoad.TabIndex = 3;
			this.btLoad.Text = "Load";
			this.btLoad.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(399, 299);
			this.Controls.Add(this.btLoad);
			this.Controls.Add(this.btSave);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.pbDraw);
			this.Name = "MainForm";
			this.Text = "NguyenHungKhanhDuy1706020016";
			((System.ComponentModel.ISupportInitialize)(this.pbDraw)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripButton tsb3;
		private System.Windows.Forms.ToolStripButton tsb2;
		private System.Windows.Forms.Button btLoad;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.ToolStripButton tsbLine;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.PictureBox pbDraw;
		
		
	}
}
