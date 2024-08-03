namespace MansionInvestigation
{
    partial class Creature
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creature));
            this.creatureStory = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.creaturePic = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Run = new System.Windows.Forms.Button();
            this.Fight = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creaturePic)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // creatureStory
            // 
            this.creatureStory.BackColor = System.Drawing.Color.LightSlateGray;
            this.creatureStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatureStory.Location = new System.Drawing.Point(3, 3);
            this.creatureStory.Multiline = true;
            this.creatureStory.Name = "creatureStory";
            this.creatureStory.ReadOnly = true;
            this.creatureStory.Size = new System.Drawing.Size(766, 84);
            this.creatureStory.TabIndex = 3;
            this.creatureStory.Text = "Implemented in code.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.creatureStory, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(772, 90);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.creaturePic, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(213, 144);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(378, 196);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // creaturePic
            // 
            this.creaturePic.Image = ((System.Drawing.Image)(resources.GetObject("creaturePic.Image")));
            this.creaturePic.Location = new System.Drawing.Point(10, 10);
            this.creaturePic.Margin = new System.Windows.Forms.Padding(10);
            this.creaturePic.Name = "creaturePic";
            this.creaturePic.Size = new System.Drawing.Size(358, 176);
            this.creaturePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.creaturePic.TabIndex = 1;
            this.creaturePic.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Run, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Fight, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 361);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(776, 54);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // Run
            // 
            this.Run.BackColor = System.Drawing.Color.LightSlateGray;
            this.Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Run.ForeColor = System.Drawing.Color.DarkRed;
            this.Run.Location = new System.Drawing.Point(391, 3);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(382, 48);
            this.Run.TabIndex = 5;
            this.Run.Text = "RUN";
            this.Run.UseVisualStyleBackColor = false;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Fight
            // 
            this.Fight.BackColor = System.Drawing.Color.LightSlateGray;
            this.Fight.FlatAppearance.BorderSize = 0;
            this.Fight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fight.ForeColor = System.Drawing.Color.DarkRed;
            this.Fight.Location = new System.Drawing.Point(3, 3);
            this.Fight.Name = "Fight";
            this.Fight.Size = new System.Drawing.Size(382, 48);
            this.Fight.TabIndex = 4;
            this.Fight.Text = "FIGHT";
            this.Fight.UseVisualStyleBackColor = false;
            this.Fight.Click += new System.EventHandler(this.Fight_Click);
            // 
            // Creature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Creature";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creature";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.creaturePic)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox creatureStory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox creaturePic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Button Fight;
    }
}