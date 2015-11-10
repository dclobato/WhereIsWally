namespace OEW
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
            this.txtlocalizar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblestado2 = new System.Windows.Forms.Label();
            this.lblestado1 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtlocalizar
            // 
            this.txtlocalizar.Location = new System.Drawing.Point(5, 7);
            this.txtlocalizar.Name = "txtlocalizar";
            this.txtlocalizar.Size = new System.Drawing.Size(405, 20);
            this.txtlocalizar.TabIndex = 0;
            this.txtlocalizar.Text = "C:\\Users\\Victor\\Desktop\\foursquare.xml";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(487, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 20);
            this.button3.TabIndex = 3;
            this.button3.Text = "Matriz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblnome);
            this.groupBox1.Controls.Add(this.lblestado2);
            this.groupBox1.Controls.Add(this.lblestado1);
            this.groupBox1.Location = new System.Drawing.Point(5, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 93);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(50, 17);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(46, 13);
            this.lblnome.TabIndex = 13;
            this.lblnome.Text = "Usuário:";
            // 
            // lblestado2
            // 
            this.lblestado2.AutoSize = true;
            this.lblestado2.Location = new System.Drawing.Point(14, 67);
            this.lblestado2.Name = "lblestado2";
            this.lblestado2.Size = new System.Drawing.Size(82, 13);
            this.lblestado2.TabIndex = 12;
            this.lblestado2.Text = "Estado Anterior:";
            // 
            // lblestado1
            // 
            this.lblestado1.AutoSize = true;
            this.lblestado1.Location = new System.Drawing.Point(26, 43);
            this.lblestado1.Name = "lblestado1";
            this.lblestado1.Size = new System.Drawing.Size(70, 13);
            this.lblestado1.TabIndex = 11;
            this.lblestado1.Text = "Estado Atual:";
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Porc});
            this.grid.Location = new System.Drawing.Point(5, 132);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(552, 518);
            this.grid.TabIndex = 12;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Estado";
            this.Nome.Name = "Nome";
            this.Nome.Width = 400;
            // 
            // Porc
            // 
            this.Porc.HeaderText = "Probabilidade";
            this.Porc.Name = "Porc";
            this.Porc.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 662);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtlocalizar);
            this.Name = "Form1";
            this.Text = "Onde Estará Wally ? (n-MMC)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtlocalizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porc;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblestado2;
        private System.Windows.Forms.Label lblestado1;
    }
}

