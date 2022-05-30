namespace Restaurante
{
    partial class F_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Maria",
            "1x Calabresa[M](s/ arroz)",
            "R$ 16,00",
            "Cartão",
            "-",
            "12:00",
            "13:10",
            "-"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "2", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "João", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "1x Frango a Passarinho[P]", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "R$20,99"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "Dinheiro", System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "R$ 50,00"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "13:00"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "pendente"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "13:40")}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "Fulano",
            "2x Filé d Peixe[G]",
            "R$ 24,00",
            "PIX",
            "-",
            "13:10",
            "pendente",
            "14:00"}, -1);
            this.lb_1 = new System.Windows.Forms.Label();
            this.cb_1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_6 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.cb_2 = new System.Windows.Forms.ComboBox();
            this.lv_pedidos = new System.Windows.Forms.ListView();
            this.col_id = new System.Windows.Forms.ColumnHeader();
            this.col_nome = new System.Windows.Forms.ColumnHeader();
            this.col_pedido = new System.Windows.Forms.ColumnHeader();
            this.col_valor = new System.Windows.Forms.ColumnHeader();
            this.col_fp = new System.Windows.Forms.ColumnHeader();
            this.col_troco = new System.Windows.Forms.ColumnHeader();
            this.col_entrada = new System.Windows.Forms.ColumnHeader();
            this.col_saida = new System.Windows.Forms.ColumnHeader();
            this.col_limite = new System.Windows.Forms.ColumnHeader();
            this.tp_btn_add = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.BackColor = System.Drawing.SystemColors.Control;
            this.lb_1.Location = new System.Drawing.Point(6, 19);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(40, 15);
            this.lb_1.TabIndex = 0;
            this.lb_1.Text = "Nome";
            // 
            // cb_1
            // 
            this.cb_1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_1.BackColor = System.Drawing.SystemColors.Info;
            this.cb_1.FormattingEnabled = true;
            this.cb_1.Location = new System.Drawing.Point(6, 37);
            this.cb_1.Name = "cb_1";
            this.cb_1.Size = new System.Drawing.Size(350, 23);
            this.cb_1.TabIndex = 0;
            this.cb_1.SelectedIndexChanged += new System.EventHandler(this.CB_1e2_SelectedIndexChanged);
            this.cb_1.TextChanged += new System.EventHandler(this.cb_1e2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rua";
            // 
            // tb_3
            // 
            this.tb_3.Location = new System.Drawing.Point(118, 81);
            this.tb_3.Name = "tb_3";
            this.tb_3.Size = new System.Drawing.Size(238, 23);
            this.tb_3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bairro";
            // 
            // tb_4
            // 
            this.tb_4.Location = new System.Drawing.Point(6, 125);
            this.tb_4.Name = "tb_4";
            this.tb_4.Size = new System.Drawing.Size(238, 23);
            this.tb_4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "N°";
            // 
            // tb_5
            // 
            this.tb_5.Location = new System.Drawing.Point(250, 125);
            this.tb_5.Name = "tb_5";
            this.tb_5.Size = new System.Drawing.Size(106, 23);
            this.tb_5.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Informações";
            // 
            // tb_6
            // 
            this.tb_6.Location = new System.Drawing.Point(6, 169);
            this.tb_6.Multiline = true;
            this.tb_6.Name = "tb_6";
            this.tb_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_6.Size = new System.Drawing.Size(350, 70);
            this.tb_6.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.cb_2);
            this.groupBox1.Controls.Add(this.tb_6);
            this.groupBox1.Controls.Add(this.lb_1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_1);
            this.groupBox1.Controls.Add(this.tb_5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(747, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 609);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(31, 428);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "Test";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnzoado_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 361);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 23);
            this.textBox1.TabIndex = 12;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Location = new System.Drawing.Point(6, 245);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 30);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            this.btn_add.MouseHover += new System.EventHandler(this.btn_add_MouseHover);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.Location = new System.Drawing.Point(256, 245);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 30);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Limpar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Enabled = false;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_edit.Location = new System.Drawing.Point(131, 245);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(100, 30);
            this.btn_edit.TabIndex = 11;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // cb_2
            // 
            this.cb_2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_2.BackColor = System.Drawing.SystemColors.Info;
            this.cb_2.FormattingEnabled = true;
            this.cb_2.ItemHeight = 15;
            this.cb_2.Location = new System.Drawing.Point(6, 81);
            this.cb_2.MaxLength = 8;
            this.cb_2.Name = "cb_2";
            this.cb_2.Size = new System.Drawing.Size(106, 23);
            this.cb_2.TabIndex = 1;
            this.cb_2.SelectedIndexChanged += new System.EventHandler(this.CB_1e2_SelectedIndexChanged);
            this.cb_2.TextChanged += new System.EventHandler(this.cb_1e2_TextChanged);
            this.cb_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_2_KeyPress);
            // 
            // lv_pedidos
            // 
            this.lv_pedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_pedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_nome,
            this.col_pedido,
            this.col_valor,
            this.col_fp,
            this.col_troco,
            this.col_entrada,
            this.col_saida,
            this.col_limite});
            this.lv_pedidos.FullRowSelect = true;
            listViewItem2.StateImageIndex = 0;
            listViewItem2.UseItemStyleForSubItems = false;
            this.lv_pedidos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lv_pedidos.Location = new System.Drawing.Point(0, 0);
            this.lv_pedidos.MultiSelect = false;
            this.lv_pedidos.Name = "lv_pedidos";
            this.lv_pedidos.Size = new System.Drawing.Size(747, 609);
            this.lv_pedidos.TabIndex = 11;
            this.lv_pedidos.UseCompatibleStateImageBehavior = false;
            this.lv_pedidos.View = System.Windows.Forms.View.Details;
            // 
            // col_id
            // 
            this.col_id.Text = "ID";
            this.col_id.Width = 30;
            // 
            // col_nome
            // 
            this.col_nome.Text = "Nome";
            this.col_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_nome.Width = 110;
            // 
            // col_pedido
            // 
            this.col_pedido.Text = "Pedido";
            this.col_pedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_pedido.Width = 230;
            // 
            // col_valor
            // 
            this.col_valor.Text = "Valor";
            this.col_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // col_fp
            // 
            this.col_fp.Text = "Pagamento";
            this.col_fp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_fp.Width = 73;
            // 
            // col_troco
            // 
            this.col_troco.Text = "Troco";
            this.col_troco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // col_entrada
            // 
            this.col_entrada.Text = "Entrada";
            this.col_entrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // col_saida
            // 
            this.col_saida.Text = "Saída";
            this.col_saida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // col_limite
            // 
            this.col_limite.Text = "Limite";
            this.col_limite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tp_btn_add
            // 
            this.tp_btn_add.AutoPopDelay = 5000;
            this.tp_btn_add.InitialDelay = 3000;
            this.tp_btn_add.ReshowDelay = 100;
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 609);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lv_pedidos);
            this.MinimumSize = new System.Drawing.Size(1126, 0);
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.F_Principal_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lb_1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private ListView lv_pedidos;
        private ColumnHeader col_id;
        private ColumnHeader col_nome;
        private ColumnHeader col_pedido;
        private ColumnHeader col_valor;
        private ColumnHeader col_fp;
        private ColumnHeader col_troco;
        private ColumnHeader col_entrada;
        private ColumnHeader col_saida;
        private ColumnHeader col_limite;
        private Button btn_clear;
        private Button btn_edit;
        private Button btn1;
        private Button btn_add;
        private ToolTip tp_btn_add;
        internal ComboBox cb_1;
        internal TextBox tb_3;
        internal TextBox tb_4;
        internal TextBox tb_5;
        internal TextBox tb_6;
        internal ComboBox cb_2;
        private TextBox textBox1;
    }
}