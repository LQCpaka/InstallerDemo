namespace TRTInstaller
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btBrowseB = new System.Windows.Forms.Button();
            this.btBrowseM = new System.Windows.Forms.Button();
            this.btInstallB = new System.Windows.Forms.Button();
            this.btInstallM = new System.Windows.Forms.Button();
            this.lbfolderPath = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pWrongpath = new System.Windows.Forms.PictureBox();
            this.pSucceded = new System.Windows.Forms.PictureBox();
            this.pFail = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pWrongpath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSucceded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFail)).BeginInit();
            this.SuspendLayout();
            // 
            // btBrowseB
            // 
            this.btBrowseB.BackColor = System.Drawing.Color.Transparent;
            this.btBrowseB.FlatAppearance.BorderSize = 0;
            this.btBrowseB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btBrowseB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btBrowseB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBrowseB.Location = new System.Drawing.Point(411, 603);
            this.btBrowseB.Name = "btBrowseB";
            this.btBrowseB.Size = new System.Drawing.Size(53, 41);
            this.btBrowseB.TabIndex = 0;
            this.btBrowseB.UseVisualStyleBackColor = false;
            this.btBrowseB.MouseEnter += new System.EventHandler(this.btBrowseB_MouseEnter);
            // 
            // btBrowseM
            // 
            this.btBrowseM.BackColor = System.Drawing.Color.Transparent;
            this.btBrowseM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBrowseM.FlatAppearance.BorderSize = 0;
            this.btBrowseM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btBrowseM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btBrowseM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBrowseM.Image = global::TRTInstaller.Properties.Resources.folder_button;
            this.btBrowseM.Location = new System.Drawing.Point(411, 603);
            this.btBrowseM.Name = "btBrowseM";
            this.btBrowseM.Size = new System.Drawing.Size(53, 41);
            this.btBrowseM.TabIndex = 1;
            this.btBrowseM.UseVisualStyleBackColor = false;
            this.btBrowseM.Visible = false;
            this.btBrowseM.Click += new System.EventHandler(this.btBrowseM_Click);
            this.btBrowseM.MouseLeave += new System.EventHandler(this.btBrowseM_MouseLeave);
            // 
            // btInstallB
            // 
            this.btInstallB.BackColor = System.Drawing.Color.Transparent;
            this.btInstallB.FlatAppearance.BorderSize = 0;
            this.btInstallB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btInstallB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btInstallB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInstallB.Location = new System.Drawing.Point(407, 531);
            this.btInstallB.Name = "btInstallB";
            this.btInstallB.Size = new System.Drawing.Size(463, 61);
            this.btInstallB.TabIndex = 2;
            this.btInstallB.UseVisualStyleBackColor = false;
            this.btInstallB.MouseEnter += new System.EventHandler(this.btInstallB_MouseEnter);
            // 
            // btInstallM
            // 
            this.btInstallM.BackColor = System.Drawing.Color.Transparent;
            this.btInstallM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btInstallM.FlatAppearance.BorderSize = 0;
            this.btInstallM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btInstallM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btInstallM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInstallM.Image = global::TRTInstaller.Properties.Resources.install_button;
            this.btInstallM.Location = new System.Drawing.Point(407, 531);
            this.btInstallM.Name = "btInstallM";
            this.btInstallM.Size = new System.Drawing.Size(463, 61);
            this.btInstallM.TabIndex = 3;
            this.btInstallM.UseVisualStyleBackColor = false;
            this.btInstallM.Visible = false;
            this.btInstallM.Click += new System.EventHandler(this.btInstallM_Click);
            this.btInstallM.MouseLeave += new System.EventHandler(this.btInstallM_MouseLeave);
            // 
            // lbfolderPath
            // 
            this.lbfolderPath.BackColor = System.Drawing.Color.Transparent;
            this.lbfolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfolderPath.Location = new System.Drawing.Point(469, 615);
            this.lbfolderPath.Name = "lbfolderPath";
            this.lbfolderPath.Size = new System.Drawing.Size(242, 23);
            this.lbfolderPath.TabIndex = 4;
            this.lbfolderPath.MouseHover += new System.EventHandler(this.lbfolderPath_MouseHover);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Location = new System.Drawing.Point(1219, 22);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(41, 36);
            this.btClose.TabIndex = 5;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pWrongpath
            // 
            this.pWrongpath.BackColor = System.Drawing.Color.Transparent;
            this.pWrongpath.Image = global::TRTInstaller.Properties.Resources.wrong_path;
            this.pWrongpath.Location = new System.Drawing.Point(348, 288);
            this.pWrongpath.Name = "pWrongpath";
            this.pWrongpath.Size = new System.Drawing.Size(610, 142);
            this.pWrongpath.TabIndex = 6;
            this.pWrongpath.TabStop = false;
            this.pWrongpath.Visible = false;
            // 
            // pSucceded
            // 
            this.pSucceded.BackColor = System.Drawing.Color.Transparent;
            this.pSucceded.Image = global::TRTInstaller.Properties.Resources.succeded;
            this.pSucceded.Location = new System.Drawing.Point(348, 288);
            this.pSucceded.Name = "pSucceded";
            this.pSucceded.Size = new System.Drawing.Size(610, 142);
            this.pSucceded.TabIndex = 7;
            this.pSucceded.TabStop = false;
            this.pSucceded.Visible = false;
            // 
            // pFail
            // 
            this.pFail.BackColor = System.Drawing.Color.Transparent;
            this.pFail.Image = global::TRTInstaller.Properties.Resources.fail;
            this.pFail.Location = new System.Drawing.Point(348, 287);
            this.pFail.Name = "pFail";
            this.pFail.Size = new System.Drawing.Size(610, 142);
            this.pFail.TabIndex = 8;
            this.pFail.TabStop = false;
            this.pFail.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TRTInstaller.Properties.Resources.overview;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pFail);
            this.Controls.Add(this.pSucceded);
            this.Controls.Add(this.pWrongpath);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lbfolderPath);
            this.Controls.Add(this.btInstallM);
            this.Controls.Add(this.btInstallB);
            this.Controls.Add(this.btBrowseM);
            this.Controls.Add(this.btBrowseB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoonlighterVH";
            ((System.ComponentModel.ISupportInitialize)(this.pWrongpath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSucceded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBrowseB;
        private System.Windows.Forms.Button btBrowseM;
        private System.Windows.Forms.Button btInstallB;
        private System.Windows.Forms.Button btInstallM;
        private System.Windows.Forms.Label lbfolderPath;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pWrongpath;
        private System.Windows.Forms.PictureBox pSucceded;
        private System.Windows.Forms.PictureBox pFail;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

