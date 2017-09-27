namespace GUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pbMaze = new System.Windows.Forms.PictureBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lblUnexplored = new System.Windows.Forms.Label();
            this.lblOpen = new System.Windows.Forms.Label();
            this.lblClosed = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnMaze = new System.Windows.Forms.Button();
            this.lblOperations = new System.Windows.Forms.Label();
            this.lblAlgorithm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaze)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMaze
            // 
            this.pbMaze.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaze.Location = new System.Drawing.Point(6, 46);
            this.pbMaze.Margin = new System.Windows.Forms.Padding(2);
            this.pbMaze.Name = "pbMaze";
            this.pbMaze.Size = new System.Drawing.Size(889, 431);
            this.pbMaze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMaze.TabIndex = 0;
            this.pbMaze.TabStop = false;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGo.Location = new System.Drawing.Point(86, 610);
            this.btnGo.Margin = new System.Windows.Forms.Padding(2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(55, 24);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblUnexplored
            // 
            this.lblUnexplored.AutoSize = true;
            this.lblUnexplored.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnexplored.Location = new System.Drawing.Point(12, 503);
            this.lblUnexplored.Name = "lblUnexplored";
            this.lblUnexplored.Size = new System.Drawing.Size(154, 24);
            this.lblUnexplored.TabIndex = 2;
            this.lblUnexplored.Text = "Unexplored: ";
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpen.Location = new System.Drawing.Point(12, 527);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(130, 24);
            this.lblOpen.TabIndex = 3;
            this.lblOpen.Text = "Open List:";
            // 
            // lblClosed
            // 
            this.lblClosed.AutoSize = true;
            this.lblClosed.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClosed.Location = new System.Drawing.Point(12, 551);
            this.lblClosed.Name = "lblClosed";
            this.lblClosed.Size = new System.Drawing.Size(154, 24);
            this.lblClosed.TabIndex = 4;
            this.lblClosed.Text = "Closed List:";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(12, 575);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(154, 24);
            this.lblPath.TabIndex = 5;
            this.lblPath.Text = "Path Length:";
            // 
            // btnMaze
            // 
            this.btnMaze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMaze.Location = new System.Drawing.Point(6, 610);
            this.btnMaze.Name = "btnMaze";
            this.btnMaze.Size = new System.Drawing.Size(75, 24);
            this.btnMaze.TabIndex = 6;
            this.btnMaze.Text = "Generate";
            this.btnMaze.UseVisualStyleBackColor = true;
            this.btnMaze.Click += new System.EventHandler(this.btnMaze_Click);
            // 
            // lblOperations
            // 
            this.lblOperations.AutoSize = true;
            this.lblOperations.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperations.Location = new System.Drawing.Point(12, 479);
            this.lblOperations.Name = "lblOperations";
            this.lblOperations.Size = new System.Drawing.Size(142, 24);
            this.lblOperations.TabIndex = 1;
            this.lblOperations.Text = "Operations:";
            // 
            // lblAlgorithm
            // 
            this.lblAlgorithm.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlgorithm.Location = new System.Drawing.Point(269, 9);
            this.lblAlgorithm.Name = "lblAlgorithm";
            this.lblAlgorithm.Size = new System.Drawing.Size(319, 24);
            this.lblAlgorithm.TabIndex = 0;
            this.lblAlgorithm.Text = "Algorithm";
            this.lblAlgorithm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(902, 645);
            this.Controls.Add(this.lblAlgorithm);
            this.Controls.Add(this.lblOperations);
            this.Controls.Add(this.btnMaze);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblClosed);
            this.Controls.Add(this.lblOpen);
            this.Controls.Add(this.lblUnexplored);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.pbMaze);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Path Finding";
            ((System.ComponentModel.ISupportInitialize)(this.pbMaze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMaze;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblUnexplored;
        private System.Windows.Forms.Label lblOpen;
        private System.Windows.Forms.Label lblClosed;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnMaze;
        private System.Windows.Forms.Label lblOperations;
        private System.Windows.Forms.Label lblAlgorithm;
    }
}

