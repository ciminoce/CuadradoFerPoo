namespace CuadradoFerPoo.Windows
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            btnSalir = new Button();
            btnCancelar = new Button();
            btnOk = new Button();
            txtLado = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            txtRechazados = new TextBox();
            label3 = new Label();
            txtAceptados = new TextBox();
            label2 = new Label();
            dgvDatos = new DataGridView();
            colCuadrado = new DataGridViewTextBoxColumn();
            colValido = new DataGridViewCheckBoxColumn();
            colPerimetro = new DataGridViewTextBoxColumn();
            colSuperficie = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnSalir);
            splitContainer1.Panel1.Controls.Add(btnCancelar);
            splitContainer1.Panel1.Controls.Add(btnOk);
            splitContainer1.Panel1.Controls.Add(txtLado);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(dgvDatos);
            splitContainer1.Size = new Size(800, 564);
            splitContainer1.SplitterDistance = 138;
            splitContainer1.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(713, 38);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 63);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Sair";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(195, 78);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(47, 78);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtLado
            // 
            txtLado.Location = new Point(170, 27);
            txtLado.Name = "txtLado";
            txtLado.Size = new Size(100, 23);
            txtLado.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 30);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Lado del Cuadrado:";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtRechazados);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtAceptados);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 332);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 90);
            panel1.TabIndex = 1;
            // 
            // txtRechazados
            // 
            txtRechazados.BackColor = SystemColors.InactiveCaption;
            txtRechazados.Enabled = false;
            txtRechazados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtRechazados.Location = new Point(116, 54);
            txtRechazados.Name = "txtRechazados";
            txtRechazados.Size = new Size(100, 23);
            txtRechazados.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 54);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 0;
            label3.Text = "Rechazados:";
            // 
            // txtAceptados
            // 
            txtAceptados.BackColor = SystemColors.InactiveCaption;
            txtAceptados.Enabled = false;
            txtAceptados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtAceptados.Location = new Point(116, 25);
            txtAceptados.Name = "txtAceptados";
            txtAceptados.Size = new Size(100, 23);
            txtAceptados.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 25);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 0;
            label2.Text = "Aceptados:";
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colCuadrado, colValido, colPerimetro, colSuperficie });
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(800, 336);
            dgvDatos.TabIndex = 0;
            // 
            // colCuadrado
            // 
            colCuadrado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCuadrado.HeaderText = "Cuadrado";
            colCuadrado.Name = "colCuadrado";
            colCuadrado.ReadOnly = true;
            // 
            // colValido
            // 
            colValido.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colValido.HeaderText = "Válido";
            colValido.Name = "colValido";
            colValido.ReadOnly = true;
            colValido.Resizable = DataGridViewTriState.True;
            colValido.SortMode = DataGridViewColumnSortMode.Automatic;
            colValido.Width = 64;
            // 
            // colPerimetro
            // 
            colPerimetro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            colPerimetro.DefaultCellStyle = dataGridViewCellStyle2;
            colPerimetro.HeaderText = "Perímetro";
            colPerimetro.Name = "colPerimetro";
            colPerimetro.ReadOnly = true;
            // 
            // colSuperficie
            // 
            colSuperficie.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            colSuperficie.DefaultCellStyle = dataGridViewCellStyle3;
            colSuperficie.HeaderText = "Superficie";
            colSuperficie.Name = "colSuperficie";
            colSuperficie.ReadOnly = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 564);
            ControlBox = false;
            Controls.Add(splitContainer1);
            MaximumSize = new Size(816, 603);
            MinimumSize = new Size(816, 603);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnOk;
        private TextBox txtLado;
        private Label label1;
        private Button btnCancelar;
        private DataGridView dgvDatos;
        private Button btnSalir;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn colCuadrado;
        private DataGridViewCheckBoxColumn colValido;
        private DataGridViewTextBoxColumn colPerimetro;
        private DataGridViewTextBoxColumn colSuperficie;
        private Panel panel1;
        private TextBox txtRechazados;
        private Label label3;
        private TextBox txtAceptados;
        private Label label2;
    }
}