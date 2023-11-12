namespace Modelo_EOQ_Basico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verLaAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeModeloEOQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            this.btnCalcular = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnPuntoReorden = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnDemandaDia = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnTiempoOrdenes = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnNumeroOrdenes = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnVolOrden = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnCostoTotal = new MaterialSkin.Controls.MaterialRadioButton();
            this.Card1 = new MaterialSkin.Controls.MaterialCard();
            this.checkBoxDias1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtCant1 = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.lbl1 = new MaterialSkin.Controls.MaterialLabel();
            this.Card2 = new MaterialSkin.Controls.MaterialCard();
            this.checkBoxDias2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtCant2 = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.lbl2 = new MaterialSkin.Controls.MaterialLabel();
            this.Card3 = new MaterialSkin.Controls.MaterialCard();
            this.txtCant3 = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.lbl3 = new MaterialSkin.Controls.MaterialLabel();
            this.Card4 = new MaterialSkin.Controls.MaterialCard();
            this.txtCant4 = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.lbl4 = new MaterialSkin.Controls.MaterialLabel();
            this.Card5 = new MaterialSkin.Controls.MaterialCard();
            this.txtCant5 = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.lbl5 = new MaterialSkin.Controls.MaterialLabel();
            this.Card6 = new MaterialSkin.Controls.MaterialCard();
            this.txtCant6 = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.lbl6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.lbl7 = new MaterialSkin.Controls.MaterialLabel();
            this.lblResultado = new MaterialSkin.Controls.MaterialLabel();
            this.menuStrip1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Card1.SuspendLayout();
            this.Card2.SuspendLayout();
            this.Card3.SuspendLayout();
            this.Card4.SuspendLayout();
            this.Card5.SuspendLayout();
            this.Card6.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(4, 98);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1442, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verLaAyudaToolStripMenuItem,
            this.acercaDeModeloEOQToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // verLaAyudaToolStripMenuItem
            // 
            this.verLaAyudaToolStripMenuItem.Image = global::Modelo_EOQ_Basico.Properties.Resources.icon_ayuda;
            this.verLaAyudaToolStripMenuItem.Name = "verLaAyudaToolStripMenuItem";
            this.verLaAyudaToolStripMenuItem.Size = new System.Drawing.Size(300, 34);
            this.verLaAyudaToolStripMenuItem.Text = "Ver la ayuda";
            // 
            // acercaDeModeloEOQToolStripMenuItem
            // 
            this.acercaDeModeloEOQToolStripMenuItem.Image = global::Modelo_EOQ_Basico.Properties.Resources.icon_acerca;
            this.acercaDeModeloEOQToolStripMenuItem.Name = "acercaDeModeloEOQToolStripMenuItem";
            this.acercaDeModeloEOQToolStripMenuItem.Size = new System.Drawing.Size(300, 34);
            this.acercaDeModeloEOQToolStripMenuItem.Text = "Acerca de Modelo EOQ";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnLimpiar);
            this.materialCard1.Controls.Add(this.btnCalcular);
            this.materialCard1.Controls.Add(this.groupBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(26, 157);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.materialCard1.Size = new System.Drawing.Size(572, 702);
            this.materialCard1.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLimpiar.Depth = 0;
            this.btnLimpiar.HighEmphasis = true;
            this.btnLimpiar.Icon = null;
            this.btnLimpiar.Location = new System.Drawing.Point(283, 621);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLimpiar.Size = new System.Drawing.Size(79, 36);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpiar.UseAccentColor = false;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalcular.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCalcular.Depth = 0;
            this.btnCalcular.HighEmphasis = true;
            this.btnCalcular.Icon = null;
            this.btnCalcular.Location = new System.Drawing.Point(119, 621);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnCalcular.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCalcular.Size = new System.Drawing.Size(95, 36);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCalcular.UseAccentColor = false;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnPuntoReorden);
            this.groupBox1.Controls.Add(this.rbtnDemandaDia);
            this.groupBox1.Controls.Add(this.rbtnTiempoOrdenes);
            this.groupBox1.Controls.Add(this.rbtnNumeroOrdenes);
            this.groupBox1.Controls.Add(this.rbtnVolOrden);
            this.groupBox1.Controls.Add(this.rbtnCostoTotal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(519, 569);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecciona una opcion a calcular";
            // 
            // rbtnPuntoReorden
            // 
            this.rbtnPuntoReorden.AutoSize = true;
            this.rbtnPuntoReorden.Depth = 0;
            this.rbtnPuntoReorden.Location = new System.Drawing.Point(4, 331);
            this.rbtnPuntoReorden.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnPuntoReorden.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnPuntoReorden.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnPuntoReorden.Name = "rbtnPuntoReorden";
            this.rbtnPuntoReorden.Ripple = true;
            this.rbtnPuntoReorden.Size = new System.Drawing.Size(155, 37);
            this.rbtnPuntoReorden.TabIndex = 5;
            this.rbtnPuntoReorden.TabStop = true;
            this.rbtnPuntoReorden.Text = "Punto de reorden";
            this.rbtnPuntoReorden.UseVisualStyleBackColor = true;
            this.rbtnPuntoReorden.CheckedChanged += new System.EventHandler(this.rbtnPuntoReorden_CheckedChanged);
            // 
            // rbtnDemandaDia
            // 
            this.rbtnDemandaDia.AutoSize = true;
            this.rbtnDemandaDia.Depth = 0;
            this.rbtnDemandaDia.Location = new System.Drawing.Point(4, 274);
            this.rbtnDemandaDia.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnDemandaDia.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnDemandaDia.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnDemandaDia.Name = "rbtnDemandaDia";
            this.rbtnDemandaDia.Ripple = true;
            this.rbtnDemandaDia.Size = new System.Drawing.Size(157, 37);
            this.rbtnDemandaDia.TabIndex = 4;
            this.rbtnDemandaDia.TabStop = true;
            this.rbtnDemandaDia.Text = "Demanda por dia";
            this.rbtnDemandaDia.UseVisualStyleBackColor = true;
            this.rbtnDemandaDia.CheckedChanged += new System.EventHandler(this.rbtnDemandaDia_CheckedChanged);
            // 
            // rbtnTiempoOrdenes
            // 
            this.rbtnTiempoOrdenes.AutoSize = true;
            this.rbtnTiempoOrdenes.Depth = 0;
            this.rbtnTiempoOrdenes.Location = new System.Drawing.Point(4, 217);
            this.rbtnTiempoOrdenes.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnTiempoOrdenes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnTiempoOrdenes.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnTiempoOrdenes.Name = "rbtnTiempoOrdenes";
            this.rbtnTiempoOrdenes.Ripple = true;
            this.rbtnTiempoOrdenes.Size = new System.Drawing.Size(170, 37);
            this.rbtnTiempoOrdenes.TabIndex = 3;
            this.rbtnTiempoOrdenes.TabStop = true;
            this.rbtnTiempoOrdenes.Text = "Tiempo de ordenes";
            this.rbtnTiempoOrdenes.UseVisualStyleBackColor = true;
            this.rbtnTiempoOrdenes.CheckedChanged += new System.EventHandler(this.rbtnTiempoOrdenes_CheckedChanged);
            // 
            // rbtnNumeroOrdenes
            // 
            this.rbtnNumeroOrdenes.AutoSize = true;
            this.rbtnNumeroOrdenes.Depth = 0;
            this.rbtnNumeroOrdenes.Location = new System.Drawing.Point(4, 160);
            this.rbtnNumeroOrdenes.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnNumeroOrdenes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnNumeroOrdenes.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnNumeroOrdenes.Name = "rbtnNumeroOrdenes";
            this.rbtnNumeroOrdenes.Ripple = true;
            this.rbtnNumeroOrdenes.Size = new System.Drawing.Size(230, 37);
            this.rbtnNumeroOrdenes.TabIndex = 2;
            this.rbtnNumeroOrdenes.TabStop = true;
            this.rbtnNumeroOrdenes.Text = "Numero de ordenes por año";
            this.rbtnNumeroOrdenes.UseVisualStyleBackColor = true;
            this.rbtnNumeroOrdenes.CheckedChanged += new System.EventHandler(this.rbtnNumeroOrdenes_CheckedChanged);
            // 
            // rbtnVolOrden
            // 
            this.rbtnVolOrden.AutoSize = true;
            this.rbtnVolOrden.Depth = 0;
            this.rbtnVolOrden.Location = new System.Drawing.Point(4, 103);
            this.rbtnVolOrden.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnVolOrden.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnVolOrden.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnVolOrden.Name = "rbtnVolOrden";
            this.rbtnVolOrden.Ripple = true;
            this.rbtnVolOrden.Size = new System.Drawing.Size(163, 37);
            this.rbtnVolOrden.TabIndex = 1;
            this.rbtnVolOrden.TabStop = true;
            this.rbtnVolOrden.Text = "Volumen de orden";
            this.rbtnVolOrden.UseVisualStyleBackColor = true;
            this.rbtnVolOrden.CheckedChanged += new System.EventHandler(this.rbtnVolOrden_CheckedChanged);
            // 
            // rbtnCostoTotal
            // 
            this.rbtnCostoTotal.AutoSize = true;
            this.rbtnCostoTotal.Depth = 0;
            this.rbtnCostoTotal.Location = new System.Drawing.Point(4, 46);
            this.rbtnCostoTotal.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnCostoTotal.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnCostoTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnCostoTotal.Name = "rbtnCostoTotal";
            this.rbtnCostoTotal.Ripple = true;
            this.rbtnCostoTotal.Size = new System.Drawing.Size(117, 37);
            this.rbtnCostoTotal.TabIndex = 0;
            this.rbtnCostoTotal.TabStop = true;
            this.rbtnCostoTotal.Text = "Costo Total";
            this.rbtnCostoTotal.UseVisualStyleBackColor = true;
            this.rbtnCostoTotal.CheckedChanged += new System.EventHandler(this.rbtnCostoTotal_CheckedChanged);
            // 
            // Card1
            // 
            this.Card1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Card1.Controls.Add(this.checkBoxDias1);
            this.Card1.Controls.Add(this.txtCant1);
            this.Card1.Controls.Add(this.lbl1);
            this.Card1.Depth = 0;
            this.Card1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Card1.Location = new System.Drawing.Point(615, 157);
            this.Card1.Margin = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.Card1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Card1.Name = "Card1";
            this.Card1.Padding = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.Card1.Size = new System.Drawing.Size(807, 145);
            this.Card1.TabIndex = 4;
            this.Card1.Visible = false;
            // 
            // checkBoxDias1
            // 
            this.checkBoxDias1.AutoSize = true;
            this.checkBoxDias1.Depth = 0;
            this.checkBoxDias1.Location = new System.Drawing.Point(504, 2);
            this.checkBoxDias1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDias1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxDias1.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxDias1.Name = "checkBoxDias1";
            this.checkBoxDias1.ReadOnly = false;
            this.checkBoxDias1.Ripple = true;
            this.checkBoxDias1.Size = new System.Drawing.Size(179, 37);
            this.checkBoxDias1.TabIndex = 7;
            this.checkBoxDias1.Text = "Dias personalizados";
            this.checkBoxDias1.UseVisualStyleBackColor = true;
            this.checkBoxDias1.Visible = false;
            this.checkBoxDias1.CheckedChanged += new System.EventHandler(this.checkBoxDias1_CheckedChanged);
            // 
            // txtCant1
            // 
            this.txtCant1.AnimateReadOnly = false;
            this.txtCant1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCant1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCant1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCant1.Depth = 0;
            this.txtCant1.HideSelection = true;
            this.txtCant1.Location = new System.Drawing.Point(26, 58);
            this.txtCant1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCant1.MaxLength = 32767;
            this.txtCant1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCant1.Name = "txtCant1";
            this.txtCant1.PasswordChar = '\0';
            this.txtCant1.ReadOnly = false;
            this.txtCant1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCant1.SelectedText = "";
            this.txtCant1.SelectionLength = 0;
            this.txtCant1.SelectionStart = 0;
            this.txtCant1.ShortcutsEnabled = true;
            this.txtCant1.Size = new System.Drawing.Size(756, 71);
            this.txtCant1.TabIndex = 5;
            this.txtCant1.TabStop = false;
            this.txtCant1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCant1.UseSystemPasswordChar = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Depth = 0;
            this.lbl1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl1.Location = new System.Drawing.Point(26, 22);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(27, 19);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "lbl1";
            // 
            // Card2
            // 
            this.Card2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Card2.Controls.Add(this.checkBoxDias2);
            this.Card2.Controls.Add(this.txtCant2);
            this.Card2.Controls.Add(this.lbl2);
            this.Card2.Depth = 0;
            this.Card2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Card2.Location = new System.Drawing.Point(615, 312);
            this.Card2.Margin = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.Card2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Card2.Name = "Card2";
            this.Card2.Padding = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.Card2.Size = new System.Drawing.Size(807, 145);
            this.Card2.TabIndex = 6;
            this.Card2.Visible = false;
            // 
            // checkBoxDias2
            // 
            this.checkBoxDias2.AutoSize = true;
            this.checkBoxDias2.Depth = 0;
            this.checkBoxDias2.Location = new System.Drawing.Point(504, 2);
            this.checkBoxDias2.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxDias2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxDias2.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxDias2.Name = "checkBoxDias2";
            this.checkBoxDias2.ReadOnly = false;
            this.checkBoxDias2.Ripple = true;
            this.checkBoxDias2.Size = new System.Drawing.Size(179, 37);
            this.checkBoxDias2.TabIndex = 6;
            this.checkBoxDias2.Text = "Dias personalizados";
            this.checkBoxDias2.UseVisualStyleBackColor = true;
            this.checkBoxDias2.Visible = false;
            this.checkBoxDias2.CheckedChanged += new System.EventHandler(this.checkBoxDias2_CheckedChanged);
            // 
            // txtCant2
            // 
            this.txtCant2.AnimateReadOnly = false;
            this.txtCant2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCant2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCant2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCant2.Depth = 0;
            this.txtCant2.HideSelection = true;
            this.txtCant2.Location = new System.Drawing.Point(26, 58);
            this.txtCant2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCant2.MaxLength = 32767;
            this.txtCant2.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCant2.Name = "txtCant2";
            this.txtCant2.PasswordChar = '\0';
            this.txtCant2.ReadOnly = false;
            this.txtCant2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCant2.SelectedText = "";
            this.txtCant2.SelectionLength = 0;
            this.txtCant2.SelectionStart = 0;
            this.txtCant2.ShortcutsEnabled = true;
            this.txtCant2.Size = new System.Drawing.Size(756, 71);
            this.txtCant2.TabIndex = 5;
            this.txtCant2.TabStop = false;
            this.txtCant2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCant2.UseSystemPasswordChar = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Depth = 0;
            this.lbl2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl2.Location = new System.Drawing.Point(26, 22);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(27, 19);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "lbl2";
            // 
            // Card3
            // 
            this.Card3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Card3.Controls.Add(this.txtCant3);
            this.Card3.Controls.Add(this.lbl3);
            this.Card3.Depth = 0;
            this.Card3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Card3.Location = new System.Drawing.Point(615, 468);
            this.Card3.Margin = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.Card3.MouseState = MaterialSkin.MouseState.HOVER;
            this.Card3.Name = "Card3";
            this.Card3.Padding = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.Card3.Size = new System.Drawing.Size(807, 145);
            this.Card3.TabIndex = 7;
            this.Card3.Visible = false;
            // 
            // txtCant3
            // 
            this.txtCant3.AnimateReadOnly = false;
            this.txtCant3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCant3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCant3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCant3.Depth = 0;
            this.txtCant3.HideSelection = true;
            this.txtCant3.Location = new System.Drawing.Point(26, 58);
            this.txtCant3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCant3.MaxLength = 32767;
            this.txtCant3.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCant3.Name = "txtCant3";
            this.txtCant3.PasswordChar = '\0';
            this.txtCant3.ReadOnly = false;
            this.txtCant3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCant3.SelectedText = "";
            this.txtCant3.SelectionLength = 0;
            this.txtCant3.SelectionStart = 0;
            this.txtCant3.ShortcutsEnabled = true;
            this.txtCant3.Size = new System.Drawing.Size(756, 71);
            this.txtCant3.TabIndex = 5;
            this.txtCant3.TabStop = false;
            this.txtCant3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCant3.UseSystemPasswordChar = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Depth = 0;
            this.lbl3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl3.Location = new System.Drawing.Point(26, 22);
            this.lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(27, 19);
            this.lbl3.TabIndex = 0;
            this.lbl3.Text = "lbl3";
            // 
            // Card4
            // 
            this.Card4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Card4.Controls.Add(this.txtCant4);
            this.Card4.Controls.Add(this.lbl4);
            this.Card4.Depth = 0;
            this.Card4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Card4.Location = new System.Drawing.Point(615, 623);
            this.Card4.Margin = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.Card4.MouseState = MaterialSkin.MouseState.HOVER;
            this.Card4.Name = "Card4";
            this.Card4.Padding = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.Card4.Size = new System.Drawing.Size(807, 145);
            this.Card4.TabIndex = 8;
            this.Card4.Visible = false;
            // 
            // txtCant4
            // 
            this.txtCant4.AnimateReadOnly = false;
            this.txtCant4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCant4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCant4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCant4.Depth = 0;
            this.txtCant4.HideSelection = true;
            this.txtCant4.Location = new System.Drawing.Point(26, 58);
            this.txtCant4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCant4.MaxLength = 32767;
            this.txtCant4.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCant4.Name = "txtCant4";
            this.txtCant4.PasswordChar = '\0';
            this.txtCant4.ReadOnly = false;
            this.txtCant4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCant4.SelectedText = "";
            this.txtCant4.SelectionLength = 0;
            this.txtCant4.SelectionStart = 0;
            this.txtCant4.ShortcutsEnabled = true;
            this.txtCant4.Size = new System.Drawing.Size(756, 71);
            this.txtCant4.TabIndex = 5;
            this.txtCant4.TabStop = false;
            this.txtCant4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCant4.UseSystemPasswordChar = false;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Depth = 0;
            this.lbl4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl4.Location = new System.Drawing.Point(26, 22);
            this.lbl4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl4.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(27, 19);
            this.lbl4.TabIndex = 0;
            this.lbl4.Text = "lbl4";
            // 
            // Card5
            // 
            this.Card5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Card5.Controls.Add(this.txtCant5);
            this.Card5.Controls.Add(this.lbl5);
            this.Card5.Depth = 0;
            this.Card5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Card5.Location = new System.Drawing.Point(615, 778);
            this.Card5.Margin = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.Card5.MouseState = MaterialSkin.MouseState.HOVER;
            this.Card5.Name = "Card5";
            this.Card5.Padding = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.Card5.Size = new System.Drawing.Size(807, 145);
            this.Card5.TabIndex = 9;
            this.Card5.Visible = false;
            // 
            // txtCant5
            // 
            this.txtCant5.AnimateReadOnly = false;
            this.txtCant5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCant5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCant5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCant5.Depth = 0;
            this.txtCant5.HideSelection = true;
            this.txtCant5.Location = new System.Drawing.Point(26, 58);
            this.txtCant5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCant5.MaxLength = 32767;
            this.txtCant5.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCant5.Name = "txtCant5";
            this.txtCant5.PasswordChar = '\0';
            this.txtCant5.ReadOnly = false;
            this.txtCant5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCant5.SelectedText = "";
            this.txtCant5.SelectionLength = 0;
            this.txtCant5.SelectionStart = 0;
            this.txtCant5.ShortcutsEnabled = true;
            this.txtCant5.Size = new System.Drawing.Size(756, 71);
            this.txtCant5.TabIndex = 5;
            this.txtCant5.TabStop = false;
            this.txtCant5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCant5.UseSystemPasswordChar = false;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Depth = 0;
            this.lbl5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl5.Location = new System.Drawing.Point(26, 22);
            this.lbl5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl5.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(27, 19);
            this.lbl5.TabIndex = 0;
            this.lbl5.Text = "lbl5";
            // 
            // Card6
            // 
            this.Card6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Card6.Controls.Add(this.txtCant6);
            this.Card6.Controls.Add(this.lbl6);
            this.Card6.Depth = 0;
            this.Card6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Card6.Location = new System.Drawing.Point(615, 934);
            this.Card6.Margin = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.Card6.MouseState = MaterialSkin.MouseState.HOVER;
            this.Card6.Name = "Card6";
            this.Card6.Padding = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.Card6.Size = new System.Drawing.Size(807, 145);
            this.Card6.TabIndex = 10;
            this.Card6.Visible = false;
            // 
            // txtCant6
            // 
            this.txtCant6.AnimateReadOnly = false;
            this.txtCant6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCant6.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCant6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCant6.Depth = 0;
            this.txtCant6.HideSelection = true;
            this.txtCant6.Location = new System.Drawing.Point(26, 58);
            this.txtCant6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCant6.MaxLength = 32767;
            this.txtCant6.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCant6.Name = "txtCant6";
            this.txtCant6.PasswordChar = '\0';
            this.txtCant6.ReadOnly = false;
            this.txtCant6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCant6.SelectedText = "";
            this.txtCant6.SelectionLength = 0;
            this.txtCant6.SelectionStart = 0;
            this.txtCant6.ShortcutsEnabled = true;
            this.txtCant6.Size = new System.Drawing.Size(756, 71);
            this.txtCant6.TabIndex = 5;
            this.txtCant6.TabStop = false;
            this.txtCant6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCant6.UseSystemPasswordChar = false;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Depth = 0;
            this.lbl6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl6.Location = new System.Drawing.Point(26, 22);
            this.lbl6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl6.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(27, 19);
            this.lbl6.TabIndex = 0;
            this.lbl6.Text = "lbl6";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.lblResultado);
            this.materialCard2.Controls.Add(this.lbl7);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(26, 875);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.materialCard2.Size = new System.Drawing.Size(572, 203);
            this.materialCard2.TabIndex = 11;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Depth = 0;
            this.lbl7.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl7.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lbl7.Location = new System.Drawing.Point(25, 22);
            this.lbl7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl7.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(39, 29);
            this.lbl7.TabIndex = 6;
            this.lbl7.Text = "lbl7";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Depth = 0;
            this.lblResultado.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblResultado.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblResultado.Location = new System.Drawing.Point(25, 81);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(20, 41);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1450, 1097);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.Card6);
            this.Controls.Add(this.Card5);
            this.Controls.Add(this.Card4);
            this.Controls.Add(this.Card3);
            this.Controls.Add(this.Card2);
            this.Controls.Add(this.Card1);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(4, 98, 4, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelo EOQ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Card1.ResumeLayout(false);
            this.Card1.PerformLayout();
            this.Card2.ResumeLayout(false);
            this.Card2.PerformLayout();
            this.Card3.ResumeLayout(false);
            this.Card3.PerformLayout();
            this.Card4.ResumeLayout(false);
            this.Card4.PerformLayout();
            this.Card5.ResumeLayout(false);
            this.Card5.PerformLayout();
            this.Card6.ResumeLayout(false);
            this.Card6.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verLaAyudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeModeloEOQToolStripMenuItem;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRadioButton rbtnDemandaDia;
        private MaterialSkin.Controls.MaterialRadioButton rbtnTiempoOrdenes;
        private MaterialSkin.Controls.MaterialRadioButton rbtnNumeroOrdenes;
        private MaterialSkin.Controls.MaterialRadioButton rbtnVolOrden;
        private MaterialSkin.Controls.MaterialRadioButton rbtnCostoTotal;
        private MaterialSkin.Controls.MaterialRadioButton rbtnPuntoReorden;
        private MaterialSkin.Controls.MaterialCard Card1;
        private MaterialSkin.Controls.MaterialLabel lbl1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtCant1;
        private MaterialSkin.Controls.MaterialCard Card2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtCant2;
        private MaterialSkin.Controls.MaterialLabel lbl2;
        private MaterialSkin.Controls.MaterialCard Card3;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtCant3;
        private MaterialSkin.Controls.MaterialLabel lbl3;
        private MaterialSkin.Controls.MaterialCard Card4;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtCant4;
        private MaterialSkin.Controls.MaterialLabel lbl4;
        private MaterialSkin.Controls.MaterialCard Card5;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtCant5;
        private MaterialSkin.Controls.MaterialLabel lbl5;
        private MaterialSkin.Controls.MaterialCard Card6;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtCant6;
        private MaterialSkin.Controls.MaterialLabel lbl6;
        private MaterialSkin.Controls.MaterialButton btnCalcular;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxDias2;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxDias1;
        private MaterialSkin.Controls.MaterialButton btnLimpiar;
        private MaterialSkin.Controls.MaterialLabel lblResultado;
        private MaterialSkin.Controls.MaterialLabel lbl7;
    }
}

