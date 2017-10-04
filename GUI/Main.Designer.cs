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
            this.lblDijkstra = new System.Windows.Forms.Label();
            this.lblAStar = new System.Windows.Forms.Label();
            this.lblBreadthFirst = new System.Windows.Forms.Label();
            this.lblDepthFirst = new System.Windows.Forms.Label();
            this.btnMaze = new System.Windows.Forms.Button();
            this.lblOperations = new System.Windows.Forms.Label();
            this.lblAlgorithm = new System.Windows.Forms.Label();
            this.lblUnexplored = new System.Windows.Forms.Label();
            this.lblOpen = new System.Windows.Forms.Label();
            this.lblClosed = new System.Windows.Forms.Label();
            this.lblPathLength = new System.Windows.Forms.Label();
            this.lblDijkstraOperations = new System.Windows.Forms.Label();
            this.lblDijkstraUnexplored = new System.Windows.Forms.Label();
            this.lblDijkstraOpen = new System.Windows.Forms.Label();
            this.lblDijkstraClosed = new System.Windows.Forms.Label();
            this.lblDijkstraPathLength = new System.Windows.Forms.Label();
            this.lblAStarPathLength = new System.Windows.Forms.Label();
            this.lblAStarClosed = new System.Windows.Forms.Label();
            this.lblAStarOpen = new System.Windows.Forms.Label();
            this.lblAStarUnexplored = new System.Windows.Forms.Label();
            this.lblAStarOperations = new System.Windows.Forms.Label();
            this.lblBreadthFirstPathLength = new System.Windows.Forms.Label();
            this.lblBreadthFirstClosed = new System.Windows.Forms.Label();
            this.lblBreadthFirstOpen = new System.Windows.Forms.Label();
            this.lblBreadthFirstUnexplored = new System.Windows.Forms.Label();
            this.lblBreadthFirstOperations = new System.Windows.Forms.Label();
            this.lblDepthFirstPathLength = new System.Windows.Forms.Label();
            this.lblDepthFirstClosed = new System.Windows.Forms.Label();
            this.lblDepthFirstOpen = new System.Windows.Forms.Label();
            this.lblDepthFirstUnexplored = new System.Windows.Forms.Label();
            this.lblDepthFirstOperations = new System.Windows.Forms.Label();
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
            this.btnGo.TabIndex = 31;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // lblDijkstra
            // 
            this.lblDijkstra.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDijkstra.Location = new System.Drawing.Point(12, 503);
            this.lblDijkstra.Name = "lblDijkstra";
            this.lblDijkstra.Size = new System.Drawing.Size(174, 24);
            this.lblDijkstra.TabIndex = 6;
            this.lblDijkstra.Text = "Dijkstra:";
            this.lblDijkstra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAStar
            // 
            this.lblAStar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAStar.Location = new System.Drawing.Point(12, 527);
            this.lblAStar.Name = "lblAStar";
            this.lblAStar.Size = new System.Drawing.Size(174, 24);
            this.lblAStar.TabIndex = 12;
            this.lblAStar.Text = "A*:";
            this.lblAStar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBreadthFirst
            // 
            this.lblBreadthFirst.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadthFirst.Location = new System.Drawing.Point(8, 551);
            this.lblBreadthFirst.Name = "lblBreadthFirst";
            this.lblBreadthFirst.Size = new System.Drawing.Size(178, 24);
            this.lblBreadthFirst.TabIndex = 18;
            this.lblBreadthFirst.Text = "Breadth-First:";
            this.lblBreadthFirst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDepthFirst
            // 
            this.lblDepthFirst.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepthFirst.Location = new System.Drawing.Point(12, 575);
            this.lblDepthFirst.Name = "lblDepthFirst";
            this.lblDepthFirst.Size = new System.Drawing.Size(174, 24);
            this.lblDepthFirst.TabIndex = 24;
            this.lblDepthFirst.Text = "Depth-First:";
            this.lblDepthFirst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMaze
            // 
            this.btnMaze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMaze.Location = new System.Drawing.Point(6, 610);
            this.btnMaze.Name = "btnMaze";
            this.btnMaze.Size = new System.Drawing.Size(75, 24);
            this.btnMaze.TabIndex = 30;
            this.btnMaze.Text = "Generate";
            this.btnMaze.UseVisualStyleBackColor = true;
            this.btnMaze.Click += new System.EventHandler(this.BtnMaze_Click);
            // 
            // lblOperations
            // 
            this.lblOperations.AutoSize = true;
            this.lblOperations.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperations.Location = new System.Drawing.Point(182, 479);
            this.lblOperations.Name = "lblOperations";
            this.lblOperations.Size = new System.Drawing.Size(130, 24);
            this.lblOperations.TabIndex = 1;
            this.lblOperations.Text = "Operations";
            // 
            // lblAlgorithm
            // 
            this.lblAlgorithm.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlgorithm.Location = new System.Drawing.Point(269, 9);
            this.lblAlgorithm.Name = "lblAlgorithm";
            this.lblAlgorithm.Size = new System.Drawing.Size(319, 24);
            this.lblAlgorithm.TabIndex = 0;
            this.lblAlgorithm.Text = "Algorithm";
            this.lblAlgorithm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnexplored
            // 
            this.lblUnexplored.AutoSize = true;
            this.lblUnexplored.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnexplored.Location = new System.Drawing.Point(322, 479);
            this.lblUnexplored.Name = "lblUnexplored";
            this.lblUnexplored.Size = new System.Drawing.Size(130, 24);
            this.lblUnexplored.TabIndex = 2;
            this.lblUnexplored.Text = "Unexplored";
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpen.Location = new System.Drawing.Point(490, 479);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(58, 24);
            this.lblOpen.TabIndex = 3;
            this.lblOpen.Text = "Open";
            // 
            // lblClosed
            // 
            this.lblClosed.AutoSize = true;
            this.lblClosed.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClosed.Location = new System.Drawing.Point(577, 479);
            this.lblClosed.Name = "lblClosed";
            this.lblClosed.Size = new System.Drawing.Size(82, 24);
            this.lblClosed.TabIndex = 4;
            this.lblClosed.Text = "Closed";
            // 
            // lblPathLength
            // 
            this.lblPathLength.AutoSize = true;
            this.lblPathLength.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathLength.Location = new System.Drawing.Point(688, 479);
            this.lblPathLength.Name = "lblPathLength";
            this.lblPathLength.Size = new System.Drawing.Size(202, 24);
            this.lblPathLength.TabIndex = 5;
            this.lblPathLength.Text = "Path Length/Cost";
            // 
            // lblDijkstraOperations
            // 
            this.lblDijkstraOperations.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDijkstraOperations.Location = new System.Drawing.Point(182, 503);
            this.lblDijkstraOperations.Name = "lblDijkstraOperations";
            this.lblDijkstraOperations.Size = new System.Drawing.Size(130, 24);
            this.lblDijkstraOperations.TabIndex = 7;
            this.lblDijkstraOperations.Text = "0";
            this.lblDijkstraOperations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDijkstraUnexplored
            // 
            this.lblDijkstraUnexplored.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDijkstraUnexplored.Location = new System.Drawing.Point(322, 503);
            this.lblDijkstraUnexplored.Name = "lblDijkstraUnexplored";
            this.lblDijkstraUnexplored.Size = new System.Drawing.Size(130, 24);
            this.lblDijkstraUnexplored.TabIndex = 8;
            this.lblDijkstraUnexplored.Text = "0";
            this.lblDijkstraUnexplored.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDijkstraOpen
            // 
            this.lblDijkstraOpen.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDijkstraOpen.Location = new System.Drawing.Point(477, 503);
            this.lblDijkstraOpen.Name = "lblDijkstraOpen";
            this.lblDijkstraOpen.Size = new System.Drawing.Size(84, 24);
            this.lblDijkstraOpen.TabIndex = 9;
            this.lblDijkstraOpen.Text = "0";
            this.lblDijkstraOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDijkstraClosed
            // 
            this.lblDijkstraClosed.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDijkstraClosed.Location = new System.Drawing.Point(581, 503);
            this.lblDijkstraClosed.Name = "lblDijkstraClosed";
            this.lblDijkstraClosed.Size = new System.Drawing.Size(78, 24);
            this.lblDijkstraClosed.TabIndex = 10;
            this.lblDijkstraClosed.Text = "0";
            this.lblDijkstraClosed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDijkstraPathLength
            // 
            this.lblDijkstraPathLength.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDijkstraPathLength.Location = new System.Drawing.Point(717, 503);
            this.lblDijkstraPathLength.Name = "lblDijkstraPathLength";
            this.lblDijkstraPathLength.Size = new System.Drawing.Size(133, 24);
            this.lblDijkstraPathLength.TabIndex = 11;
            this.lblDijkstraPathLength.Text = "?/?";
            this.lblDijkstraPathLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAStarPathLength
            // 
            this.lblAStarPathLength.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAStarPathLength.Location = new System.Drawing.Point(717, 527);
            this.lblAStarPathLength.Name = "lblAStarPathLength";
            this.lblAStarPathLength.Size = new System.Drawing.Size(133, 24);
            this.lblAStarPathLength.TabIndex = 17;
            this.lblAStarPathLength.Text = "?/?";
            this.lblAStarPathLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAStarClosed
            // 
            this.lblAStarClosed.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAStarClosed.Location = new System.Drawing.Point(581, 527);
            this.lblAStarClosed.Name = "lblAStarClosed";
            this.lblAStarClosed.Size = new System.Drawing.Size(78, 24);
            this.lblAStarClosed.TabIndex = 16;
            this.lblAStarClosed.Text = "0";
            this.lblAStarClosed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAStarOpen
            // 
            this.lblAStarOpen.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAStarOpen.Location = new System.Drawing.Point(477, 527);
            this.lblAStarOpen.Name = "lblAStarOpen";
            this.lblAStarOpen.Size = new System.Drawing.Size(84, 24);
            this.lblAStarOpen.TabIndex = 15;
            this.lblAStarOpen.Text = "0";
            this.lblAStarOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAStarUnexplored
            // 
            this.lblAStarUnexplored.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAStarUnexplored.Location = new System.Drawing.Point(322, 527);
            this.lblAStarUnexplored.Name = "lblAStarUnexplored";
            this.lblAStarUnexplored.Size = new System.Drawing.Size(130, 24);
            this.lblAStarUnexplored.TabIndex = 14;
            this.lblAStarUnexplored.Text = "0";
            this.lblAStarUnexplored.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAStarOperations
            // 
            this.lblAStarOperations.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAStarOperations.Location = new System.Drawing.Point(182, 527);
            this.lblAStarOperations.Name = "lblAStarOperations";
            this.lblAStarOperations.Size = new System.Drawing.Size(130, 24);
            this.lblAStarOperations.TabIndex = 13;
            this.lblAStarOperations.Text = "0";
            this.lblAStarOperations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBreadthFirstPathLength
            // 
            this.lblBreadthFirstPathLength.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadthFirstPathLength.Location = new System.Drawing.Point(717, 551);
            this.lblBreadthFirstPathLength.Name = "lblBreadthFirstPathLength";
            this.lblBreadthFirstPathLength.Size = new System.Drawing.Size(133, 24);
            this.lblBreadthFirstPathLength.TabIndex = 23;
            this.lblBreadthFirstPathLength.Text = "?/?";
            this.lblBreadthFirstPathLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBreadthFirstClosed
            // 
            this.lblBreadthFirstClosed.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadthFirstClosed.Location = new System.Drawing.Point(581, 551);
            this.lblBreadthFirstClosed.Name = "lblBreadthFirstClosed";
            this.lblBreadthFirstClosed.Size = new System.Drawing.Size(78, 24);
            this.lblBreadthFirstClosed.TabIndex = 22;
            this.lblBreadthFirstClosed.Text = "0";
            this.lblBreadthFirstClosed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBreadthFirstOpen
            // 
            this.lblBreadthFirstOpen.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadthFirstOpen.Location = new System.Drawing.Point(477, 551);
            this.lblBreadthFirstOpen.Name = "lblBreadthFirstOpen";
            this.lblBreadthFirstOpen.Size = new System.Drawing.Size(84, 24);
            this.lblBreadthFirstOpen.TabIndex = 21;
            this.lblBreadthFirstOpen.Text = "0";
            this.lblBreadthFirstOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBreadthFirstUnexplored
            // 
            this.lblBreadthFirstUnexplored.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadthFirstUnexplored.Location = new System.Drawing.Point(322, 551);
            this.lblBreadthFirstUnexplored.Name = "lblBreadthFirstUnexplored";
            this.lblBreadthFirstUnexplored.Size = new System.Drawing.Size(130, 24);
            this.lblBreadthFirstUnexplored.TabIndex = 20;
            this.lblBreadthFirstUnexplored.Text = "0";
            this.lblBreadthFirstUnexplored.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBreadthFirstOperations
            // 
            this.lblBreadthFirstOperations.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadthFirstOperations.Location = new System.Drawing.Point(182, 551);
            this.lblBreadthFirstOperations.Name = "lblBreadthFirstOperations";
            this.lblBreadthFirstOperations.Size = new System.Drawing.Size(130, 24);
            this.lblBreadthFirstOperations.TabIndex = 19;
            this.lblBreadthFirstOperations.Text = "0";
            this.lblBreadthFirstOperations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepthFirstPathLength
            // 
            this.lblDepthFirstPathLength.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepthFirstPathLength.Location = new System.Drawing.Point(717, 575);
            this.lblDepthFirstPathLength.Name = "lblDepthFirstPathLength";
            this.lblDepthFirstPathLength.Size = new System.Drawing.Size(133, 24);
            this.lblDepthFirstPathLength.TabIndex = 29;
            this.lblDepthFirstPathLength.Text = "?/?";
            this.lblDepthFirstPathLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepthFirstClosed
            // 
            this.lblDepthFirstClosed.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepthFirstClosed.Location = new System.Drawing.Point(581, 575);
            this.lblDepthFirstClosed.Name = "lblDepthFirstClosed";
            this.lblDepthFirstClosed.Size = new System.Drawing.Size(78, 24);
            this.lblDepthFirstClosed.TabIndex = 28;
            this.lblDepthFirstClosed.Text = "0";
            this.lblDepthFirstClosed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepthFirstOpen
            // 
            this.lblDepthFirstOpen.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepthFirstOpen.Location = new System.Drawing.Point(477, 575);
            this.lblDepthFirstOpen.Name = "lblDepthFirstOpen";
            this.lblDepthFirstOpen.Size = new System.Drawing.Size(84, 24);
            this.lblDepthFirstOpen.TabIndex = 27;
            this.lblDepthFirstOpen.Text = "0";
            this.lblDepthFirstOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepthFirstUnexplored
            // 
            this.lblDepthFirstUnexplored.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepthFirstUnexplored.Location = new System.Drawing.Point(322, 575);
            this.lblDepthFirstUnexplored.Name = "lblDepthFirstUnexplored";
            this.lblDepthFirstUnexplored.Size = new System.Drawing.Size(130, 24);
            this.lblDepthFirstUnexplored.TabIndex = 26;
            this.lblDepthFirstUnexplored.Text = "0";
            this.lblDepthFirstUnexplored.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepthFirstOperations
            // 
            this.lblDepthFirstOperations.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepthFirstOperations.Location = new System.Drawing.Point(182, 575);
            this.lblDepthFirstOperations.Name = "lblDepthFirstOperations";
            this.lblDepthFirstOperations.Size = new System.Drawing.Size(130, 24);
            this.lblDepthFirstOperations.TabIndex = 25;
            this.lblDepthFirstOperations.Text = "0";
            this.lblDepthFirstOperations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(902, 645);
            this.Controls.Add(this.lblDepthFirstPathLength);
            this.Controls.Add(this.lblDepthFirstClosed);
            this.Controls.Add(this.lblDepthFirstOpen);
            this.Controls.Add(this.lblDepthFirstUnexplored);
            this.Controls.Add(this.lblDepthFirstOperations);
            this.Controls.Add(this.lblBreadthFirstPathLength);
            this.Controls.Add(this.lblBreadthFirstClosed);
            this.Controls.Add(this.lblBreadthFirstOpen);
            this.Controls.Add(this.lblBreadthFirstUnexplored);
            this.Controls.Add(this.lblBreadthFirstOperations);
            this.Controls.Add(this.lblAStarPathLength);
            this.Controls.Add(this.lblAStarClosed);
            this.Controls.Add(this.lblAStarOpen);
            this.Controls.Add(this.lblAStarUnexplored);
            this.Controls.Add(this.lblAStarOperations);
            this.Controls.Add(this.lblDijkstraPathLength);
            this.Controls.Add(this.lblDijkstraClosed);
            this.Controls.Add(this.lblDijkstraOpen);
            this.Controls.Add(this.lblDijkstraUnexplored);
            this.Controls.Add(this.lblDijkstraOperations);
            this.Controls.Add(this.lblPathLength);
            this.Controls.Add(this.lblClosed);
            this.Controls.Add(this.lblOpen);
            this.Controls.Add(this.lblUnexplored);
            this.Controls.Add(this.lblAlgorithm);
            this.Controls.Add(this.lblOperations);
            this.Controls.Add(this.btnMaze);
            this.Controls.Add(this.lblDepthFirst);
            this.Controls.Add(this.lblBreadthFirst);
            this.Controls.Add(this.lblAStar);
            this.Controls.Add(this.lblDijkstra);
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
        private System.Windows.Forms.Label lblDijkstra;
        private System.Windows.Forms.Label lblAStar;
        private System.Windows.Forms.Label lblBreadthFirst;
        private System.Windows.Forms.Label lblDepthFirst;
        private System.Windows.Forms.Button btnMaze;
        private System.Windows.Forms.Label lblOperations;
        private System.Windows.Forms.Label lblAlgorithm;
        private System.Windows.Forms.Label lblUnexplored;
        private System.Windows.Forms.Label lblOpen;
        private System.Windows.Forms.Label lblClosed;
        private System.Windows.Forms.Label lblPathLength;
        private System.Windows.Forms.Label lblDijkstraOperations;
        private System.Windows.Forms.Label lblDijkstraUnexplored;
        private System.Windows.Forms.Label lblDijkstraOpen;
        private System.Windows.Forms.Label lblDijkstraClosed;
        private System.Windows.Forms.Label lblDijkstraPathLength;
        private System.Windows.Forms.Label lblAStarPathLength;
        private System.Windows.Forms.Label lblAStarClosed;
        private System.Windows.Forms.Label lblAStarOpen;
        private System.Windows.Forms.Label lblAStarUnexplored;
        private System.Windows.Forms.Label lblAStarOperations;
        private System.Windows.Forms.Label lblBreadthFirstPathLength;
        private System.Windows.Forms.Label lblBreadthFirstClosed;
        private System.Windows.Forms.Label lblBreadthFirstOpen;
        private System.Windows.Forms.Label lblBreadthFirstUnexplored;
        private System.Windows.Forms.Label lblBreadthFirstOperations;
        private System.Windows.Forms.Label lblDepthFirstPathLength;
        private System.Windows.Forms.Label lblDepthFirstClosed;
        private System.Windows.Forms.Label lblDepthFirstOpen;
        private System.Windows.Forms.Label lblDepthFirstUnexplored;
        private System.Windows.Forms.Label lblDepthFirstOperations;
    }
}

