
namespace AulaBd
{
    partial class Consulta
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
            this.txtCpfBuscar = new System.Windows.Forms.TextBox();
            this.txtNomeBuscar = new System.Windows.Forms.TextBox();
            this.txtNome_C = new System.Windows.Forms.TextBox();
            this.txtCpf_C = new System.Windows.Forms.TextBox();
            this.txtEndereco_C = new System.Windows.Forms.TextBox();
            this.rdButtonNome = new System.Windows.Forms.RadioButton();
            this.rdButtonCPF = new System.Windows.Forms.RadioButton();
            this.lblNome_C = new System.Windows.Forms.Label();
            this.lblCPF_C = new System.Windows.Forms.Label();
            this.lblEndereco_C = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCpfBuscar
            // 
            this.txtCpfBuscar.Location = new System.Drawing.Point(272, 69);
            this.txtCpfBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCpfBuscar.Name = "txtCpfBuscar";
            this.txtCpfBuscar.Size = new System.Drawing.Size(132, 22);
            this.txtCpfBuscar.TabIndex = 0;
            // 
            // txtNomeBuscar
            // 
            this.txtNomeBuscar.Location = new System.Drawing.Point(272, 118);
            this.txtNomeBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeBuscar.Name = "txtNomeBuscar";
            this.txtNomeBuscar.Size = new System.Drawing.Size(132, 22);
            this.txtNomeBuscar.TabIndex = 1;
            // 
            // txtNome_C
            // 
            this.txtNome_C.Location = new System.Drawing.Point(272, 254);
            this.txtNome_C.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome_C.Name = "txtNome_C";
            this.txtNome_C.Size = new System.Drawing.Size(132, 22);
            this.txtNome_C.TabIndex = 2;
            // 
            // txtCpf_C
            // 
            this.txtCpf_C.Location = new System.Drawing.Point(272, 310);
            this.txtCpf_C.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCpf_C.Name = "txtCpf_C";
            this.txtCpf_C.Size = new System.Drawing.Size(132, 22);
            this.txtCpf_C.TabIndex = 3;
            // 
            // txtEndereco_C
            // 
            this.txtEndereco_C.Location = new System.Drawing.Point(272, 361);
            this.txtEndereco_C.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEndereco_C.Name = "txtEndereco_C";
            this.txtEndereco_C.Size = new System.Drawing.Size(132, 22);
            this.txtEndereco_C.TabIndex = 4;
            // 
            // rdButtonNome
            // 
            this.rdButtonNome.AutoSize = true;
            this.rdButtonNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.rdButtonNome.Location = new System.Drawing.Point(105, 113);
            this.rdButtonNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdButtonNome.Name = "rdButtonNome";
            this.rdButtonNome.Size = new System.Drawing.Size(129, 35);
            this.rdButtonNome.TabIndex = 10;
            this.rdButtonNome.TabStop = true;
            this.rdButtonNome.Text = "NOME:";
            this.rdButtonNome.UseVisualStyleBackColor = true;
            this.rdButtonNome.CheckedChanged += new System.EventHandler(this.rdButtonNome_CheckedChanged);
            // 
            // rdButtonCPF
            // 
            this.rdButtonCPF.AutoSize = true;
            this.rdButtonCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.rdButtonCPF.Location = new System.Drawing.Point(105, 69);
            this.rdButtonCPF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdButtonCPF.Name = "rdButtonCPF";
            this.rdButtonCPF.Size = new System.Drawing.Size(102, 35);
            this.rdButtonCPF.TabIndex = 11;
            this.rdButtonCPF.TabStop = true;
            this.rdButtonCPF.Text = "CPF:";
            this.rdButtonCPF.UseVisualStyleBackColor = true;
            this.rdButtonCPF.CheckedChanged += new System.EventHandler(this.rdButtonCPF_CheckedChanged);
            // 
            // lblNome_C
            // 
            this.lblNome_C.AutoSize = true;
            this.lblNome_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome_C.Location = new System.Drawing.Point(99, 246);
            this.lblNome_C.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome_C.Name = "lblNome_C";
            this.lblNome_C.Size = new System.Drawing.Size(99, 31);
            this.lblNome_C.TabIndex = 13;
            this.lblNome_C.Text = "Nome:";
            // 
            // lblCPF_C
            // 
            this.lblCPF_C.AutoSize = true;
            this.lblCPF_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF_C.Location = new System.Drawing.Point(99, 303);
            this.lblCPF_C.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF_C.Name = "lblCPF_C";
            this.lblCPF_C.Size = new System.Drawing.Size(72, 31);
            this.lblCPF_C.TabIndex = 14;
            this.lblCPF_C.Text = "CPF";
            // 
            // lblEndereco_C
            // 
            this.lblEndereco_C.AutoSize = true;
            this.lblEndereco_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco_C.Location = new System.Drawing.Point(99, 361);
            this.lblEndereco_C.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndereco_C.Name = "lblEndereco_C";
            this.lblEndereco_C.Size = new System.Drawing.Size(138, 31);
            this.lblEndereco_C.TabIndex = 15;
            this.lblEndereco_C.Text = "Endereço";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location = new System.Drawing.Point(583, 69);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(129, 74);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblEndereco_C);
            this.Controls.Add(this.lblCPF_C);
            this.Controls.Add(this.lblNome_C);
            this.Controls.Add(this.rdButtonCPF);
            this.Controls.Add(this.rdButtonNome);
            this.Controls.Add(this.txtEndereco_C);
            this.Controls.Add(this.txtCpf_C);
            this.Controls.Add(this.txtNome_C);
            this.Controls.Add(this.txtNomeBuscar);
            this.Controls.Add(this.txtCpfBuscar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCpfBuscar;
        private System.Windows.Forms.TextBox txtNomeBuscar;
        private System.Windows.Forms.TextBox txtNome_C;
        private System.Windows.Forms.TextBox txtCpf_C;
        private System.Windows.Forms.TextBox txtEndereco_C;
        private System.Windows.Forms.RadioButton rdButtonNome;
        private System.Windows.Forms.RadioButton rdButtonCPF;
        private System.Windows.Forms.Label lblNome_C;
        private System.Windows.Forms.Label lblCPF_C;
        private System.Windows.Forms.Label lblEndereco_C;
        private System.Windows.Forms.Button btnBuscar;
    }
}