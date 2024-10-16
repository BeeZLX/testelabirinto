namespace aulalabirinto
{
    partial class labirinto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(labirinto));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbx_avatar = new System.Windows.Forms.PictureBox();
            this.pbx_Labirinto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Labirinto)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbx_avatar
            // 
            this.pbx_avatar.Image = global::aulalabirinto.Properties.Resources.direita;
            resources.ApplyResources(this.pbx_avatar, "pbx_avatar");
            this.pbx_avatar.Name = "pbx_avatar";
            this.pbx_avatar.TabStop = false;
            // 
            // pbx_Labirinto
            // 
            this.pbx_Labirinto.Image = global::aulalabirinto.Properties.Resources.Labirinto;
            resources.ApplyResources(this.pbx_Labirinto, "pbx_Labirinto");
            this.pbx_Labirinto.Name = "pbx_Labirinto";
            this.pbx_Labirinto.TabStop = false;
            // 
            // labirinto
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbx_avatar);
            this.Controls.Add(this.pbx_Labirinto);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "labirinto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.labirinto_FormClosing);
            this.Load += new System.EventHandler(this.labirinto_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labirinto_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Labirinto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_Labirinto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbx_avatar;
    }
}

