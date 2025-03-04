namespace ProyectoFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playerCharacter = new System.Windows.Forms.PictureBox();
            this.pnlCajaDeDialogo = new System.Windows.Forms.Panel();
            this.lblPista = new System.Windows.Forms.Label();
            this.pnlUML = new System.Windows.Forms.Panel();
            this.rbMetodoPoli2 = new System.Windows.Forms.RadioButton();
            this.rbMetodoPoli1 = new System.Windows.Forms.RadioButton();
            this.cbCapsulaA3 = new System.Windows.Forms.CheckBox();
            this.cbCapsulaA2 = new System.Windows.Forms.CheckBox();
            this.cbCapsulaA1 = new System.Windows.Forms.CheckBox();
            this.btnHerencia = new System.Windows.Forms.Button();
            this.txtUMLMetodo2 = new System.Windows.Forms.TextBox();
            this.txtUMLAtributo3 = new System.Windows.Forms.TextBox();
            this.txtUMLAtributo2 = new System.Windows.Forms.TextBox();
            this.txtUMLAtributo1 = new System.Windows.Forms.TextBox();
            this.btnSolucionar = new System.Windows.Forms.Button();
            this.txtUMLMetodo1 = new System.Windows.Forms.TextBox();
            this.lblUMLTitulo = new System.Windows.Forms.Label();
            this.btn_ObjetoInteractuable = new System.Windows.Forms.Button();
            this.enemyCharacter = new System.Windows.Forms.PictureBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.pnlUMLHerencia = new System.Windows.Forms.Panel();
            this.cmbHerenciaUMLTitulo = new System.Windows.Forms.ComboBox();
            this.txtHerenciaMetodo2 = new System.Windows.Forms.TextBox();
            this.txtHerenciaAtributo3 = new System.Windows.Forms.TextBox();
            this.txtHerenciaAtributo2 = new System.Windows.Forms.TextBox();
            this.txtHerenciaAtributo1 = new System.Windows.Forms.TextBox();
            this.txtHerenciaMetodo1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHerencia = new System.Windows.Forms.Panel();
            this.pb_TitleScreen = new System.Windows.Forms.PictureBox();
            this.btn_Comenzar = new System.Windows.Forms.Button();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerCharacter)).BeginInit();
            this.pnlCajaDeDialogo.SuspendLayout();
            this.pnlUML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyCharacter)).BeginInit();
            this.pnlUMLHerencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHerencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TitleScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // playerCharacter
            // 
            this.playerCharacter.BackColor = System.Drawing.Color.Transparent;
            this.playerCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerCharacter.Image = global::ProyectoFinal.Properties.Resources.sprite_Duck;
            this.playerCharacter.Location = new System.Drawing.Point(333, 349);
            this.playerCharacter.Name = "playerCharacter";
            this.playerCharacter.Size = new System.Drawing.Size(90, 90);
            this.playerCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerCharacter.TabIndex = 0;
            this.playerCharacter.TabStop = false;
            this.playerCharacter.Click += new System.EventHandler(this.playerCharacter_Click);
            // 
            // pnlCajaDeDialogo
            // 
            this.pnlCajaDeDialogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCajaDeDialogo.BackColor = System.Drawing.Color.Transparent;
            this.pnlCajaDeDialogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCajaDeDialogo.BackgroundImage")));
            this.pnlCajaDeDialogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCajaDeDialogo.Controls.Add(this.lblPista);
            this.pnlCajaDeDialogo.Location = new System.Drawing.Point(5, 8);
            this.pnlCajaDeDialogo.Name = "pnlCajaDeDialogo";
            this.pnlCajaDeDialogo.Size = new System.Drawing.Size(1254, 81);
            this.pnlCajaDeDialogo.TabIndex = 1;
            this.pnlCajaDeDialogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblPista
            // 
            this.lblPista.AutoSize = true;
            this.lblPista.Font = new System.Drawing.Font("Dogica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPista.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPista.Location = new System.Drawing.Point(8, 13);
            this.lblPista.Name = "lblPista";
            this.lblPista.Size = new System.Drawing.Size(169, 20);
            this.lblPista.TabIndex = 0;
            this.lblPista.Text = "lblPista";
            // 
            // pnlUML
            // 
            this.pnlUML.BackColor = System.Drawing.Color.Transparent;
            this.pnlUML.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlUML.BackgroundImage")));
            this.pnlUML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlUML.Controls.Add(this.rbMetodoPoli2);
            this.pnlUML.Controls.Add(this.rbMetodoPoli1);
            this.pnlUML.Controls.Add(this.cbCapsulaA3);
            this.pnlUML.Controls.Add(this.cbCapsulaA2);
            this.pnlUML.Controls.Add(this.cbCapsulaA1);
            this.pnlUML.Controls.Add(this.btnHerencia);
            this.pnlUML.Controls.Add(this.txtUMLMetodo2);
            this.pnlUML.Controls.Add(this.txtUMLAtributo3);
            this.pnlUML.Controls.Add(this.txtUMLAtributo2);
            this.pnlUML.Controls.Add(this.txtUMLAtributo1);
            this.pnlUML.Controls.Add(this.btnSolucionar);
            this.pnlUML.Controls.Add(this.txtUMLMetodo1);
            this.pnlUML.Controls.Add(this.lblUMLTitulo);
            this.pnlUML.Location = new System.Drawing.Point(856, 216);
            this.pnlUML.Name = "pnlUML";
            this.pnlUML.Size = new System.Drawing.Size(224, 284);
            this.pnlUML.TabIndex = 2;
            this.pnlUML.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUML_Paint);
            // 
            // rbMetodoPoli2
            // 
            this.rbMetodoPoli2.AutoSize = true;
            this.rbMetodoPoli2.Location = new System.Drawing.Point(7, 203);
            this.rbMetodoPoli2.Name = "rbMetodoPoli2";
            this.rbMetodoPoli2.Size = new System.Drawing.Size(17, 16);
            this.rbMetodoPoli2.TabIndex = 14;
            this.rbMetodoPoli2.UseVisualStyleBackColor = true;
            this.rbMetodoPoli2.CheckedChanged += new System.EventHandler(this.rbMetodoPoli2_CheckedChanged);
            // 
            // rbMetodoPoli1
            // 
            this.rbMetodoPoli1.AutoSize = true;
            this.rbMetodoPoli1.Location = new System.Drawing.Point(7, 176);
            this.rbMetodoPoli1.Name = "rbMetodoPoli1";
            this.rbMetodoPoli1.Size = new System.Drawing.Size(17, 16);
            this.rbMetodoPoli1.TabIndex = 10;
            this.rbMetodoPoli1.UseVisualStyleBackColor = true;
            this.rbMetodoPoli1.CheckedChanged += new System.EventHandler(this.rbMetodoPoli1_CheckedChanged);
            // 
            // cbCapsulaA3
            // 
            this.cbCapsulaA3.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbCapsulaA3.AutoSize = true;
            this.cbCapsulaA3.BackColor = System.Drawing.Color.Transparent;
            this.cbCapsulaA3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cbCapsulaA3.FlatAppearance.BorderSize = 0;
            this.cbCapsulaA3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cbCapsulaA3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cbCapsulaA3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cbCapsulaA3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCapsulaA3.Image = global::ProyectoFinal.Properties.Resources.GUI_Private;
            this.cbCapsulaA3.Location = new System.Drawing.Point(2, 126);
            this.cbCapsulaA3.Name = "cbCapsulaA3";
            this.cbCapsulaA3.Size = new System.Drawing.Size(22, 22);
            this.cbCapsulaA3.TabIndex = 13;
            this.cbCapsulaA3.UseVisualStyleBackColor = false;
            this.cbCapsulaA3.CheckedChanged += new System.EventHandler(this.cbCapsulaA3_CheckedChanged);
            // 
            // cbCapsulaA2
            // 
            this.cbCapsulaA2.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbCapsulaA2.AutoSize = true;
            this.cbCapsulaA2.BackColor = System.Drawing.Color.Transparent;
            this.cbCapsulaA2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cbCapsulaA2.FlatAppearance.BorderSize = 0;
            this.cbCapsulaA2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cbCapsulaA2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cbCapsulaA2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cbCapsulaA2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCapsulaA2.Image = global::ProyectoFinal.Properties.Resources.GUI_Private;
            this.cbCapsulaA2.Location = new System.Drawing.Point(2, 94);
            this.cbCapsulaA2.Name = "cbCapsulaA2";
            this.cbCapsulaA2.Size = new System.Drawing.Size(22, 22);
            this.cbCapsulaA2.TabIndex = 12;
            this.cbCapsulaA2.UseVisualStyleBackColor = false;
            this.cbCapsulaA2.CheckedChanged += new System.EventHandler(this.cbCapsulaA2_CheckedChanged);
            // 
            // cbCapsulaA1
            // 
            this.cbCapsulaA1.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbCapsulaA1.AutoSize = true;
            this.cbCapsulaA1.BackColor = System.Drawing.Color.Transparent;
            this.cbCapsulaA1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cbCapsulaA1.FlatAppearance.BorderSize = 0;
            this.cbCapsulaA1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cbCapsulaA1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cbCapsulaA1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cbCapsulaA1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCapsulaA1.Image = global::ProyectoFinal.Properties.Resources.GUI_Private;
            this.cbCapsulaA1.Location = new System.Drawing.Point(2, 63);
            this.cbCapsulaA1.Name = "cbCapsulaA1";
            this.cbCapsulaA1.Size = new System.Drawing.Size(22, 22);
            this.cbCapsulaA1.TabIndex = 11;
            this.cbCapsulaA1.UseVisualStyleBackColor = false;
            this.cbCapsulaA1.CheckedChanged += new System.EventHandler(this.cbCapsulaA1_CheckedChanged);
            // 
            // btnHerencia
            // 
            this.btnHerencia.BackColor = System.Drawing.Color.Black;
            this.btnHerencia.BackgroundImage = global::ProyectoFinal.Properties.Resources.GUI_HerenciaButton;
            this.btnHerencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHerencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHerencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHerencia.ForeColor = System.Drawing.Color.Black;
            this.btnHerencia.Location = new System.Drawing.Point(1, 3);
            this.btnHerencia.Name = "btnHerencia";
            this.btnHerencia.Size = new System.Drawing.Size(40, 40);
            this.btnHerencia.TabIndex = 7;
            this.btnHerencia.UseVisualStyleBackColor = false;
            this.btnHerencia.Click += new System.EventHandler(this.btnHerencia_Click);
            // 
            // txtUMLMetodo2
            // 
            this.txtUMLMetodo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUMLMetodo2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUMLMetodo2.Font = new System.Drawing.Font("Dogica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUMLMetodo2.ForeColor = System.Drawing.Color.White;
            this.txtUMLMetodo2.Location = new System.Drawing.Point(27, 203);
            this.txtUMLMetodo2.Name = "txtUMLMetodo2";
            this.txtUMLMetodo2.Size = new System.Drawing.Size(183, 12);
            this.txtUMLMetodo2.TabIndex = 5;
            // 
            // txtUMLAtributo3
            // 
            this.txtUMLAtributo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUMLAtributo3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUMLAtributo3.Font = new System.Drawing.Font("Dogica", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUMLAtributo3.ForeColor = System.Drawing.Color.White;
            this.txtUMLAtributo3.Location = new System.Drawing.Point(32, 128);
            this.txtUMLAtributo3.Name = "txtUMLAtributo3";
            this.txtUMLAtributo3.Size = new System.Drawing.Size(166, 15);
            this.txtUMLAtributo3.TabIndex = 3;
            // 
            // txtUMLAtributo2
            // 
            this.txtUMLAtributo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUMLAtributo2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUMLAtributo2.Font = new System.Drawing.Font("Dogica", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUMLAtributo2.ForeColor = System.Drawing.Color.White;
            this.txtUMLAtributo2.Location = new System.Drawing.Point(32, 97);
            this.txtUMLAtributo2.Name = "txtUMLAtributo2";
            this.txtUMLAtributo2.Size = new System.Drawing.Size(166, 15);
            this.txtUMLAtributo2.TabIndex = 2;
            // 
            // txtUMLAtributo1
            // 
            this.txtUMLAtributo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUMLAtributo1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUMLAtributo1.Font = new System.Drawing.Font("Dogica", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUMLAtributo1.ForeColor = System.Drawing.Color.White;
            this.txtUMLAtributo1.Location = new System.Drawing.Point(32, 66);
            this.txtUMLAtributo1.Name = "txtUMLAtributo1";
            this.txtUMLAtributo1.Size = new System.Drawing.Size(166, 15);
            this.txtUMLAtributo1.TabIndex = 1;
            // 
            // btnSolucionar
            // 
            this.btnSolucionar.BackColor = System.Drawing.Color.Black;
            this.btnSolucionar.BackgroundImage = global::ProyectoFinal.Properties.Resources.GUI_CheckButton;
            this.btnSolucionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSolucionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSolucionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolucionar.ForeColor = System.Drawing.Color.Black;
            this.btnSolucionar.Location = new System.Drawing.Point(91, 234);
            this.btnSolucionar.Name = "btnSolucionar";
            this.btnSolucionar.Size = new System.Drawing.Size(40, 40);
            this.btnSolucionar.TabIndex = 6;
            this.btnSolucionar.UseVisualStyleBackColor = false;
            this.btnSolucionar.Click += new System.EventHandler(this.btnSolucionar_Click);
            // 
            // txtUMLMetodo1
            // 
            this.txtUMLMetodo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUMLMetodo1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUMLMetodo1.Font = new System.Drawing.Font("Dogica", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUMLMetodo1.ForeColor = System.Drawing.Color.White;
            this.txtUMLMetodo1.Location = new System.Drawing.Point(27, 178);
            this.txtUMLMetodo1.Name = "txtUMLMetodo1";
            this.txtUMLMetodo1.Size = new System.Drawing.Size(183, 12);
            this.txtUMLMetodo1.TabIndex = 4;
            // 
            // lblUMLTitulo
            // 
            this.lblUMLTitulo.AutoSize = true;
            this.lblUMLTitulo.Font = new System.Drawing.Font("Dogica", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUMLTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUMLTitulo.Location = new System.Drawing.Point(42, 27);
            this.lblUMLTitulo.Name = "lblUMLTitulo";
            this.lblUMLTitulo.Size = new System.Drawing.Size(116, 17);
            this.lblUMLTitulo.TabIndex = 0;
            this.lblUMLTitulo.Text = "Titulo";
            this.lblUMLTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ObjetoInteractuable
            // 
            this.btn_ObjetoInteractuable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ObjetoInteractuable.BackColor = System.Drawing.Color.Transparent;
            this.btn_ObjetoInteractuable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ObjetoInteractuable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ObjetoInteractuable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ObjetoInteractuable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ObjetoInteractuable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ObjetoInteractuable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ObjetoInteractuable.Location = new System.Drawing.Point(1058, 95);
            this.btn_ObjetoInteractuable.Name = "btn_ObjetoInteractuable";
            this.btn_ObjetoInteractuable.Size = new System.Drawing.Size(201, 69);
            this.btn_ObjetoInteractuable.TabIndex = 4;
            this.btn_ObjetoInteractuable.Text = "HitBox";
            this.btn_ObjetoInteractuable.UseVisualStyleBackColor = false;
            this.btn_ObjetoInteractuable.Click += new System.EventHandler(this.btn_ObjetoInteractuable_Click_1);
            // 
            // enemyCharacter
            // 
            this.enemyCharacter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enemyCharacter.BackColor = System.Drawing.Color.Transparent;
            this.enemyCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enemyCharacter.Image = global::ProyectoFinal.Properties.Resources.sprite_BugPurple;
            this.enemyCharacter.Location = new System.Drawing.Point(1102, 429);
            this.enemyCharacter.MaximumSize = new System.Drawing.Size(180, 180);
            this.enemyCharacter.MinimumSize = new System.Drawing.Size(90, 90);
            this.enemyCharacter.Name = "enemyCharacter";
            this.enemyCharacter.Size = new System.Drawing.Size(90, 90);
            this.enemyCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyCharacter.TabIndex = 5;
            this.enemyCharacter.TabStop = false;
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargar.BackColor = System.Drawing.Color.Black;
            this.btnCargar.BackgroundImage = global::ProyectoFinal.Properties.Resources.GUI_RetryButton;
            this.btnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.ForeColor = System.Drawing.Color.Black;
            this.btnCargar.Location = new System.Drawing.Point(1179, 592);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(60, 60);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // pnlUMLHerencia
            // 
            this.pnlUMLHerencia.BackColor = System.Drawing.Color.Transparent;
            this.pnlUMLHerencia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlUMLHerencia.BackgroundImage")));
            this.pnlUMLHerencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlUMLHerencia.Controls.Add(this.cmbHerenciaUMLTitulo);
            this.pnlUMLHerencia.Controls.Add(this.txtHerenciaMetodo2);
            this.pnlUMLHerencia.Controls.Add(this.txtHerenciaAtributo3);
            this.pnlUMLHerencia.Controls.Add(this.txtHerenciaAtributo2);
            this.pnlUMLHerencia.Controls.Add(this.txtHerenciaAtributo1);
            this.pnlUMLHerencia.Controls.Add(this.txtHerenciaMetodo1);
            this.pnlUMLHerencia.Location = new System.Drawing.Point(21, 21);
            this.pnlUMLHerencia.Name = "pnlUMLHerencia";
            this.pnlUMLHerencia.Size = new System.Drawing.Size(224, 284);
            this.pnlUMLHerencia.TabIndex = 7;
            // 
            // cmbHerenciaUMLTitulo
            // 
            this.cmbHerenciaUMLTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbHerenciaUMLTitulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHerenciaUMLTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHerenciaUMLTitulo.Font = new System.Drawing.Font("Dogica", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHerenciaUMLTitulo.ForeColor = System.Drawing.Color.White;
            this.cmbHerenciaUMLTitulo.FormattingEnabled = true;
            this.cmbHerenciaUMLTitulo.Location = new System.Drawing.Point(12, 22);
            this.cmbHerenciaUMLTitulo.Name = "cmbHerenciaUMLTitulo";
            this.cmbHerenciaUMLTitulo.Size = new System.Drawing.Size(199, 25);
            this.cmbHerenciaUMLTitulo.TabIndex = 8;
            this.cmbHerenciaUMLTitulo.SelectedIndexChanged += new System.EventHandler(this.cmbHerenciaUMLTitulo_SelectedIndexChanged);
            // 
            // txtHerenciaMetodo2
            // 
            this.txtHerenciaMetodo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHerenciaMetodo2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHerenciaMetodo2.Enabled = false;
            this.txtHerenciaMetodo2.Font = new System.Drawing.Font("Dogica", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHerenciaMetodo2.ForeColor = System.Drawing.Color.White;
            this.txtHerenciaMetodo2.Location = new System.Drawing.Point(12, 203);
            this.txtHerenciaMetodo2.Name = "txtHerenciaMetodo2";
            this.txtHerenciaMetodo2.Size = new System.Drawing.Size(200, 15);
            this.txtHerenciaMetodo2.TabIndex = 6;
            // 
            // txtHerenciaAtributo3
            // 
            this.txtHerenciaAtributo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHerenciaAtributo3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHerenciaAtributo3.Enabled = false;
            this.txtHerenciaAtributo3.Font = new System.Drawing.Font("Dogica", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHerenciaAtributo3.ForeColor = System.Drawing.Color.White;
            this.txtHerenciaAtributo3.Location = new System.Drawing.Point(12, 124);
            this.txtHerenciaAtributo3.Name = "txtHerenciaAtributo3";
            this.txtHerenciaAtributo3.Size = new System.Drawing.Size(200, 15);
            this.txtHerenciaAtributo3.TabIndex = 5;
            // 
            // txtHerenciaAtributo2
            // 
            this.txtHerenciaAtributo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHerenciaAtributo2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHerenciaAtributo2.Enabled = false;
            this.txtHerenciaAtributo2.Font = new System.Drawing.Font("Dogica", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHerenciaAtributo2.ForeColor = System.Drawing.Color.White;
            this.txtHerenciaAtributo2.Location = new System.Drawing.Point(12, 95);
            this.txtHerenciaAtributo2.Name = "txtHerenciaAtributo2";
            this.txtHerenciaAtributo2.Size = new System.Drawing.Size(200, 15);
            this.txtHerenciaAtributo2.TabIndex = 4;
            // 
            // txtHerenciaAtributo1
            // 
            this.txtHerenciaAtributo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHerenciaAtributo1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHerenciaAtributo1.Enabled = false;
            this.txtHerenciaAtributo1.Font = new System.Drawing.Font("Dogica", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHerenciaAtributo1.ForeColor = System.Drawing.Color.White;
            this.txtHerenciaAtributo1.Location = new System.Drawing.Point(13, 67);
            this.txtHerenciaAtributo1.Name = "txtHerenciaAtributo1";
            this.txtHerenciaAtributo1.Size = new System.Drawing.Size(200, 15);
            this.txtHerenciaAtributo1.TabIndex = 3;
            // 
            // txtHerenciaMetodo1
            // 
            this.txtHerenciaMetodo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHerenciaMetodo1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHerenciaMetodo1.Enabled = false;
            this.txtHerenciaMetodo1.Font = new System.Drawing.Font("Dogica", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHerenciaMetodo1.ForeColor = System.Drawing.Color.White;
            this.txtHerenciaMetodo1.Location = new System.Drawing.Point(12, 176);
            this.txtHerenciaMetodo1.Name = "txtHerenciaMetodo1";
            this.txtHerenciaMetodo1.Size = new System.Drawing.Size(200, 15);
            this.txtHerenciaMetodo1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.GUI_FlechaHerencia;
            this.pictureBox1.Location = new System.Drawing.Point(251, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pnlHerencia
            // 
            this.pnlHerencia.BackColor = System.Drawing.Color.Transparent;
            this.pnlHerencia.Controls.Add(this.pnlUMLHerencia);
            this.pnlHerencia.Controls.Add(this.pictureBox1);
            this.pnlHerencia.Location = new System.Drawing.Point(474, 195);
            this.pnlHerencia.Name = "pnlHerencia";
            this.pnlHerencia.Size = new System.Drawing.Size(377, 319);
            this.pnlHerencia.TabIndex = 9;
            // 
            // pb_TitleScreen
            // 
            this.pb_TitleScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_TitleScreen.BackColor = System.Drawing.Color.Transparent;
            this.pb_TitleScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_TitleScreen.Location = new System.Drawing.Point(0, -2);
            this.pb_TitleScreen.Name = "pb_TitleScreen";
            this.pb_TitleScreen.Size = new System.Drawing.Size(1264, 677);
            this.pb_TitleScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_TitleScreen.TabIndex = 10;
            this.pb_TitleScreen.TabStop = false;
            // 
            // btn_Comenzar
            // 
            this.btn_Comenzar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Comenzar.BackColor = System.Drawing.Color.Black;
            this.btn_Comenzar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Comenzar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Comenzar.FlatAppearance.BorderSize = 0;
            this.btn_Comenzar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Comenzar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Comenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Comenzar.Font = new System.Drawing.Font("Dogica", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Comenzar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Comenzar.Location = new System.Drawing.Point(20, 587);
            this.btn_Comenzar.Name = "btn_Comenzar";
            this.btn_Comenzar.Size = new System.Drawing.Size(160, 40);
            this.btn_Comenzar.TabIndex = 11;
            this.btn_Comenzar.Text = "Jugar";
            this.btn_Comenzar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Comenzar.UseVisualStyleBackColor = false;
            this.btn_Comenzar.Click += new System.EventHandler(this.btn_Comenzar_Click);
            // 
            // btnLeaderboard
            // 
            this.btnLeaderboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLeaderboard.BackColor = System.Drawing.Color.Black;
            this.btnLeaderboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLeaderboard.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLeaderboard.FlatAppearance.BorderSize = 0;
            this.btnLeaderboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLeaderboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaderboard.Font = new System.Drawing.Font("Dogica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaderboard.ForeColor = System.Drawing.Color.White;
            this.btnLeaderboard.Location = new System.Drawing.Point(20, 625);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Size = new System.Drawing.Size(291, 40);
            this.btnLeaderboard.TabIndex = 12;
            this.btnLeaderboard.Text = "Puntuaciones";
            this.btnLeaderboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeaderboard.UseVisualStyleBackColor = false;
            this.btnLeaderboard.Click += new System.EventHandler(this.btnLeaderboard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.Screen_Level3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pnlHerencia);
            this.Controls.Add(this.btnLeaderboard);
            this.Controls.Add(this.pnlUML);
            this.Controls.Add(this.btn_ObjetoInteractuable);
            this.Controls.Add(this.enemyCharacter);
            this.Controls.Add(this.btn_Comenzar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.pnlCajaDeDialogo);
            this.Controls.Add(this.playerCharacter);
            this.Controls.Add(this.pb_TitleScreen);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter The Codegeon()";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerCharacter)).EndInit();
            this.pnlCajaDeDialogo.ResumeLayout(false);
            this.pnlCajaDeDialogo.PerformLayout();
            this.pnlUML.ResumeLayout(false);
            this.pnlUML.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyCharacter)).EndInit();
            this.pnlUMLHerencia.ResumeLayout(false);
            this.pnlUMLHerencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHerencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_TitleScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playerCharacter;
        private System.Windows.Forms.Panel pnlCajaDeDialogo;
        private System.Windows.Forms.Label lblPista;
        private System.Windows.Forms.Panel pnlUML;
        private System.Windows.Forms.TextBox txtUMLMetodo1;
        private System.Windows.Forms.Label lblUMLTitulo;
        private System.Windows.Forms.Button btnSolucionar;
        private System.Windows.Forms.TextBox txtUMLMetodo2;
        private System.Windows.Forms.TextBox txtUMLAtributo3;
        private System.Windows.Forms.TextBox txtUMLAtributo2;
        private System.Windows.Forms.TextBox txtUMLAtributo1;
        private System.Windows.Forms.Button btn_ObjetoInteractuable;
        private System.Windows.Forms.PictureBox enemyCharacter;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Panel pnlUMLHerencia;
        private System.Windows.Forms.TextBox txtHerenciaMetodo2;
        private System.Windows.Forms.TextBox txtHerenciaAtributo3;
        private System.Windows.Forms.TextBox txtHerenciaAtributo2;
        private System.Windows.Forms.TextBox txtHerenciaAtributo1;
        private System.Windows.Forms.TextBox txtHerenciaMetodo1;
        private System.Windows.Forms.ComboBox cmbHerenciaUMLTitulo;
        private System.Windows.Forms.Button btnHerencia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlHerencia;
        private System.Windows.Forms.CheckBox cbCapsulaA1;
        private System.Windows.Forms.CheckBox cbCapsulaA3;
        private System.Windows.Forms.CheckBox cbCapsulaA2;
        private System.Windows.Forms.RadioButton rbMetodoPoli2;
        private System.Windows.Forms.RadioButton rbMetodoPoli1;
        private System.Windows.Forms.PictureBox pb_TitleScreen;
        private System.Windows.Forms.Button btn_Comenzar;
        private System.Windows.Forms.Button btnLeaderboard;
    }
}

