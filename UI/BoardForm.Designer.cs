using System.Windows.Forms;
namespace UI
{
    partial class FormBoard6x6 
    {
        PictureBox[,] m_DiscsArray = null;
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
        private void InitializeComponent() //being called by the BoardForm c'tor.
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoard6x6));
            this.PictureBox6E = new System.Windows.Forms.PictureBox();
            this.PictureBox6F = new System.Windows.Forms.PictureBox();
            this.PictureBox6D = new System.Windows.Forms.PictureBox();
            this.PictureBox6A = new System.Windows.Forms.PictureBox();
            this.PictureBox6B = new System.Windows.Forms.PictureBox();
            this.PictureBox6C = new System.Windows.Forms.PictureBox();
            this.PictureBox5E = new System.Windows.Forms.PictureBox();
            this.PictureBox5F = new System.Windows.Forms.PictureBox();
            this.PictureBox5D = new System.Windows.Forms.PictureBox();
            this.PictureBox5A = new System.Windows.Forms.PictureBox();
            this.PictureBox5B = new System.Windows.Forms.PictureBox();
            this.PictureBox5C = new System.Windows.Forms.PictureBox();
            this.PictureBox4E = new System.Windows.Forms.PictureBox();
            this.PictureBox4F = new System.Windows.Forms.PictureBox();
            this.PictureBox4D = new System.Windows.Forms.PictureBox();
            this.PictureBox4A = new System.Windows.Forms.PictureBox();
            this.PictureBox4B = new System.Windows.Forms.PictureBox();
            this.PictureBox4C = new System.Windows.Forms.PictureBox();
            this.PictureBox3E = new System.Windows.Forms.PictureBox();
            this.PictureBox3F = new System.Windows.Forms.PictureBox();
            this.PictureBox3D = new System.Windows.Forms.PictureBox();
            this.PictureBox3A = new System.Windows.Forms.PictureBox();
            this.PictureBox3B = new System.Windows.Forms.PictureBox();
            this.PictureBox3C = new System.Windows.Forms.PictureBox();
            this.PictureBox2E = new System.Windows.Forms.PictureBox();
            this.PictureBox2F = new System.Windows.Forms.PictureBox();
            this.PictureBox2D = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.PictureBox2A = new System.Windows.Forms.PictureBox();
            this.PictureBox2B = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.PictureBox2C = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.PictureBox1E = new System.Windows.Forms.PictureBox();
            this.PictureBox1F = new System.Windows.Forms.PictureBox();
            this.PictureBox1D = new System.Windows.Forms.PictureBox();
            this.PictureBox1A = new System.Windows.Forms.PictureBox();
            this.PictureBox1B = new System.Windows.Forms.PictureBox();
            this.PictureBox1C = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6E)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6F)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5E)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5F)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4E)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4F)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3E)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3F)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2E)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2F)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1E)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1F)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1C)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox6E
            // 
            this.PictureBox6E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox6E, "PictureBox6E");
            this.PictureBox6E.Name = "PictureBox6E";
            this.PictureBox6E.TabStop = false;
            this.PictureBox6E.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox6F
            // 
            this.PictureBox6F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox6F, "PictureBox6F");
            this.PictureBox6F.Name = "PictureBox6F";
            this.PictureBox6F.TabStop = false;
            this.PictureBox6F.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox6D
            // 
            this.PictureBox6D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox6D, "PictureBox6D");
            this.PictureBox6D.Name = "PictureBox6D";
            this.PictureBox6D.TabStop = false;
            this.PictureBox6D.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox6A
            // 
            this.PictureBox6A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox6A, "PictureBox6A");
            this.PictureBox6A.Name = "PictureBox6A";
            this.PictureBox6A.TabStop = false;
            this.PictureBox6A.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox6B
            // 
            this.PictureBox6B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox6B, "PictureBox6B");
            this.PictureBox6B.Name = "PictureBox6B";
            this.PictureBox6B.TabStop = false;
            this.PictureBox6B.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox6C
            // 
            this.PictureBox6C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox6C, "PictureBox6C");
            this.PictureBox6C.Name = "PictureBox6C";
            this.PictureBox6C.TabStop = false;
            this.PictureBox6C.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox5E
            // 
            this.PictureBox5E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox5E, "PictureBox5E");
            this.PictureBox5E.Name = "PictureBox5E";
            this.PictureBox5E.TabStop = false;
            this.PictureBox5E.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox5F
            // 
            this.PictureBox5F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox5F, "PictureBox5F");
            this.PictureBox5F.Name = "PictureBox5F";
            this.PictureBox5F.TabStop = false;
            this.PictureBox5F.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox5D
            // 
            this.PictureBox5D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox5D, "PictureBox5D");
            this.PictureBox5D.Name = "PictureBox5D";
            this.PictureBox5D.TabStop = false;
            this.PictureBox5D.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox5A
            // 
            this.PictureBox5A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox5A, "PictureBox5A");
            this.PictureBox5A.Name = "PictureBox5A";
            this.PictureBox5A.TabStop = false;
            this.PictureBox5A.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox5B
            // 
            this.PictureBox5B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox5B, "PictureBox5B");
            this.PictureBox5B.Name = "PictureBox5B";
            this.PictureBox5B.TabStop = false;
            this.PictureBox5B.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox5C
            // 
            this.PictureBox5C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox5C, "PictureBox5C");
            this.PictureBox5C.Name = "PictureBox5C";
            this.PictureBox5C.TabStop = false;
            this.PictureBox5C.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox4E
            // 
            this.PictureBox4E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox4E, "PictureBox4E");
            this.PictureBox4E.Name = "PictureBox4E";
            this.PictureBox4E.TabStop = false;
            this.PictureBox4E.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox4F
            // 
            this.PictureBox4F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox4F, "PictureBox4F");
            this.PictureBox4F.Name = "PictureBox4F";
            this.PictureBox4F.TabStop = false;
            this.PictureBox4F.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox4D
            // 
            this.PictureBox4D.BackgroundImage = global::UI.Properties.Resources.CoinRed1;
            resources.ApplyResources(this.PictureBox4D, "PictureBox4D");
            this.PictureBox4D.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox4D.Name = "PictureBox4D";
            this.PictureBox4D.TabStop = false;
            this.PictureBox4D.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox4A
            // 
            this.PictureBox4A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox4A, "PictureBox4A");
            this.PictureBox4A.Name = "PictureBox4A";
            this.PictureBox4A.TabStop = false;
            this.PictureBox4A.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox4B
            // 
            this.PictureBox4B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox4B, "PictureBox4B");
            this.PictureBox4B.Name = "PictureBox4B";
            this.PictureBox4B.TabStop = false;
            this.PictureBox4B.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox4C
            // 
            this.PictureBox4C.BackgroundImage = global::UI.Properties.Resources.CoinYellow1;
            resources.ApplyResources(this.PictureBox4C, "PictureBox4C");
            this.PictureBox4C.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox4C.Name = "PictureBox4C";
            this.PictureBox4C.TabStop = false;
            this.PictureBox4C.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox3E
            // 
            this.PictureBox3E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox3E, "PictureBox3E");
            this.PictureBox3E.Name = "PictureBox3E";
            this.PictureBox3E.TabStop = false;
            this.PictureBox3E.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox3F
            // 
            this.PictureBox3F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox3F, "PictureBox3F");
            this.PictureBox3F.Name = "PictureBox3F";
            this.PictureBox3F.TabStop = false;
            this.PictureBox3F.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox3D
            // 
            this.PictureBox3D.BackgroundImage = global::UI.Properties.Resources.CoinYellow1;
            resources.ApplyResources(this.PictureBox3D, "PictureBox3D");
            this.PictureBox3D.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox3D.Name = "PictureBox3D";
            this.PictureBox3D.TabStop = false;
            this.PictureBox3D.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox3A
            // 
            this.PictureBox3A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox3A, "PictureBox3A");
            this.PictureBox3A.Name = "PictureBox3A";
            this.PictureBox3A.TabStop = false;
            this.PictureBox3A.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox3B
            // 
            this.PictureBox3B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox3B, "PictureBox3B");
            this.PictureBox3B.Name = "PictureBox3B";
            this.PictureBox3B.TabStop = false;
            this.PictureBox3B.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox3C
            // 
            this.PictureBox3C.BackgroundImage = global::UI.Properties.Resources.CoinRed1;
            resources.ApplyResources(this.PictureBox3C, "PictureBox3C");
            this.PictureBox3C.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox3C.Name = "PictureBox3C";
            this.PictureBox3C.TabStop = false;
            this.PictureBox3C.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox2E
            // 
            this.PictureBox2E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox2E, "PictureBox2E");
            this.PictureBox2E.Name = "PictureBox2E";
            this.PictureBox2E.TabStop = false;
            this.PictureBox2E.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox2F
            // 
            this.PictureBox2F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox2F, "PictureBox2F");
            this.PictureBox2F.Name = "PictureBox2F";
            this.PictureBox2F.TabStop = false;
            this.PictureBox2F.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox2D
            // 
            this.PictureBox2D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox2D, "PictureBox2D");
            this.PictureBox2D.Name = "PictureBox2D";
            this.PictureBox2D.TabStop = false;
            this.PictureBox2D.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pictureBox9, "pictureBox9");
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox2A
            // 
            this.PictureBox2A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox2A, "PictureBox2A");
            this.PictureBox2A.Name = "PictureBox2A";
            this.PictureBox2A.TabStop = false;
            this.PictureBox2A.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox2B
            // 
            this.PictureBox2B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox2B, "PictureBox2B");
            this.PictureBox2B.Name = "PictureBox2B";
            this.PictureBox2B.TabStop = false;
            this.PictureBox2B.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pictureBox10, "pictureBox10");
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox2C
            // 
            this.PictureBox2C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox2C, "PictureBox2C");
            this.PictureBox2C.Name = "PictureBox2C";
            this.PictureBox2C.TabStop = false;
            this.PictureBox2C.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pictureBox11, "pictureBox11");
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pictureBox12, "pictureBox12");
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox1E
            // 
            this.PictureBox1E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox1E, "PictureBox1E");
            this.PictureBox1E.Name = "PictureBox1E";
            this.PictureBox1E.TabStop = false;
            this.PictureBox1E.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox1F
            // 
            this.PictureBox1F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox1F, "PictureBox1F");
            this.PictureBox1F.Name = "PictureBox1F";
            this.PictureBox1F.TabStop = false;
            this.PictureBox1F.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox1D
            // 
            this.PictureBox1D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox1D, "PictureBox1D");
            this.PictureBox1D.Name = "PictureBox1D";
            this.PictureBox1D.TabStop = false;
            this.PictureBox1D.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox1A
            // 
            this.PictureBox1A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox1A, "PictureBox1A");
            this.PictureBox1A.Name = "PictureBox1A";
            this.PictureBox1A.TabStop = false;
            this.PictureBox1A.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox1B
            // 
            this.PictureBox1B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox1B, "PictureBox1B");
            this.PictureBox1B.Name = "PictureBox1B";
            this.PictureBox1B.TabStop = false;
            this.PictureBox1B.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // PictureBox1C
            // 
            this.PictureBox1C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.PictureBox1C, "PictureBox1C");
            this.PictureBox1C.Name = "PictureBox1C";
            this.PictureBox1C.TabStop = false;
            this.PictureBox1C.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // FormBoard6x6
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PictureBox6E);
            this.Controls.Add(this.PictureBox6F);
            this.Controls.Add(this.PictureBox6D);
            this.Controls.Add(this.PictureBox6A);
            this.Controls.Add(this.PictureBox6B);
            this.Controls.Add(this.PictureBox6C);
            this.Controls.Add(this.PictureBox5E);
            this.Controls.Add(this.PictureBox5F);
            this.Controls.Add(this.PictureBox5D);
            this.Controls.Add(this.PictureBox5A);
            this.Controls.Add(this.PictureBox5B);
            this.Controls.Add(this.PictureBox5C);
            this.Controls.Add(this.PictureBox4E);
            this.Controls.Add(this.PictureBox4F);
            this.Controls.Add(this.PictureBox4D);
            this.Controls.Add(this.PictureBox4A);
            this.Controls.Add(this.PictureBox4B);
            this.Controls.Add(this.PictureBox4C);
            this.Controls.Add(this.PictureBox3E);
            this.Controls.Add(this.PictureBox3F);
            this.Controls.Add(this.PictureBox3D);
            this.Controls.Add(this.PictureBox3A);
            this.Controls.Add(this.PictureBox3B);
            this.Controls.Add(this.PictureBox3C);
            this.Controls.Add(this.PictureBox2E);
            this.Controls.Add(this.PictureBox2F);
            this.Controls.Add(this.PictureBox2D);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.PictureBox2A);
            this.Controls.Add(this.PictureBox2B);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.PictureBox2C);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.PictureBox1E);
            this.Controls.Add(this.PictureBox1F);
            this.Controls.Add(this.PictureBox1D);
            this.Controls.Add(this.PictureBox1A);
            this.Controls.Add(this.PictureBox1B);
            this.Controls.Add(this.PictureBox1C);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormBoard6x6";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.BoardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6E)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6F)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox6C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5E)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5F)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox5C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4E)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4F)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox4C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3E)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3F)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2E)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2F)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1E)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1F)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1C)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox PictureBox1C;
        private PictureBox PictureBox1B;
        private PictureBox PictureBox1A;
        private PictureBox PictureBox1D;
        private PictureBox PictureBox1F;
        private PictureBox PictureBox1E;
        private PictureBox PictureBox2E;
        private PictureBox PictureBox2F;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox PictureBox3E;
        private PictureBox PictureBox3F;
        private PictureBox PictureBox3D;
        private PictureBox PictureBox3A;
        private PictureBox PictureBox3B;
        private PictureBox PictureBox3C;
        private PictureBox PictureBox4E;
        private PictureBox PictureBox4F;
        private PictureBox PictureBox4D;
        private PictureBox PictureBox4A;
        private PictureBox PictureBox4B;
        private PictureBox PictureBox4C;
        private PictureBox PictureBox5E;
        private PictureBox PictureBox5F;
        private PictureBox PictureBox5D;
        private PictureBox PictureBox5A;
        private PictureBox PictureBox5B;
        private PictureBox PictureBox5C;
        private PictureBox PictureBox6E;
        private PictureBox PictureBox6F;
        private PictureBox PictureBox6D;
        private PictureBox PictureBox6A;
        private PictureBox PictureBox6B;
        private PictureBox PictureBox6C;
        private PictureBox PictureBox2C;
        private PictureBox PictureBox2B;
        private PictureBox PictureBox2A;
        private PictureBox PictureBox2D;
    }
}