namespace Pizzaria_Update
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
            this.lblSabores = new System.Windows.Forms.Label();
            this.grpIngredientes = new System.Windows.Forms.GroupBox();
            this.cboSabores = new System.Windows.Forms.ComboBox();
            this.grpBorda = new System.Windows.Forms.GroupBox();
            this.chkCebola = new System.Windows.Forms.CheckBox();
            this.rdbSemBorda = new System.Windows.Forms.RadioButton();
            this.chkAzeitona = new System.Windows.Forms.CheckBox();
            this.rdbComBorda = new System.Windows.Forms.RadioButton();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.grpIngredientes.SuspendLayout();
            this.grpBorda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSabores
            // 
            this.lblSabores.AutoSize = true;
            this.lblSabores.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabores.Location = new System.Drawing.Point(58, 21);
            this.lblSabores.Name = "lblSabores";
            this.lblSabores.Size = new System.Drawing.Size(123, 36);
            this.lblSabores.TabIndex = 0;
            this.lblSabores.Text = "Sabores";
            this.lblSabores.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpIngredientes
            // 
            this.grpIngredientes.Controls.Add(this.chkAzeitona);
            this.grpIngredientes.Controls.Add(this.chkCebola);
            this.grpIngredientes.Location = new System.Drawing.Point(22, 119);
            this.grpIngredientes.Name = "grpIngredientes";
            this.grpIngredientes.Size = new System.Drawing.Size(200, 100);
            this.grpIngredientes.TabIndex = 1;
            this.grpIngredientes.TabStop = false;
            this.grpIngredientes.Text = "Ingredientes Adicionais";
            // 
            // cboSabores
            // 
            this.cboSabores.BackColor = System.Drawing.SystemColors.Control;
            this.cboSabores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSabores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSabores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboSabores.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cboSabores.FormattingEnabled = true;
            this.cboSabores.Location = new System.Drawing.Point(192, 36);
            this.cboSabores.Margin = new System.Windows.Forms.Padding(8, 15, 3, 8);
            this.cboSabores.Name = "cboSabores";
            this.cboSabores.Size = new System.Drawing.Size(137, 21);
            this.cboSabores.Sorted = true;
            this.cboSabores.TabIndex = 2;
            this.cboSabores.SelectedIndexChanged += new System.EventHandler(this.cboSabores_SelectedIndexChanged);
            // 
            // grpBorda
            // 
            this.grpBorda.Controls.Add(this.rdbComBorda);
            this.grpBorda.Controls.Add(this.rdbSemBorda);
            this.grpBorda.Location = new System.Drawing.Point(282, 119);
            this.grpBorda.Name = "grpBorda";
            this.grpBorda.Size = new System.Drawing.Size(200, 100);
            this.grpBorda.TabIndex = 2;
            this.grpBorda.TabStop = false;
            this.grpBorda.Text = "Borda";
            // 
            // chkCebola
            // 
            this.chkCebola.AutoSize = true;
            this.chkCebola.Location = new System.Drawing.Point(6, 30);
            this.chkCebola.Name = "chkCebola";
            this.chkCebola.Size = new System.Drawing.Size(59, 17);
            this.chkCebola.TabIndex = 3;
            this.chkCebola.Text = "Cebola";
            this.chkCebola.UseVisualStyleBackColor = true;
            this.chkCebola.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rdbSemBorda
            // 
            this.rdbSemBorda.AutoSize = true;
            this.rdbSemBorda.Location = new System.Drawing.Point(6, 29);
            this.rdbSemBorda.Name = "rdbSemBorda";
            this.rdbSemBorda.Size = new System.Drawing.Size(77, 17);
            this.rdbSemBorda.TabIndex = 4;
            this.rdbSemBorda.TabStop = true;
            this.rdbSemBorda.Text = "Sem Borda";
            this.rdbSemBorda.UseVisualStyleBackColor = true;
            // 
            // chkAzeitona
            // 
            this.chkAzeitona.AutoSize = true;
            this.chkAzeitona.Location = new System.Drawing.Point(6, 64);
            this.chkAzeitona.Name = "chkAzeitona";
            this.chkAzeitona.Size = new System.Drawing.Size(67, 17);
            this.chkAzeitona.TabIndex = 4;
            this.chkAzeitona.Text = "Azeitona";
            this.chkAzeitona.UseVisualStyleBackColor = true;
            // 
            // rdbComBorda
            // 
            this.rdbComBorda.AutoSize = true;
            this.rdbComBorda.Location = new System.Drawing.Point(6, 63);
            this.rdbComBorda.Name = "rdbComBorda";
            this.rdbComBorda.Size = new System.Drawing.Size(77, 17);
            this.rdbComBorda.TabIndex = 5;
            this.rdbComBorda.TabStop = true;
            this.rdbComBorda.Text = "Com Borda";
            this.rdbComBorda.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(64, 225);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(117, 33);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar Pedido";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(315, 225);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(132, 32);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir Pedido";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 271);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.grpBorda);
            this.Controls.Add(this.cboSabores);
            this.Controls.Add(this.grpIngredientes);
            this.Controls.Add(this.lblSabores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpIngredientes.ResumeLayout(false);
            this.grpIngredientes.PerformLayout();
            this.grpBorda.ResumeLayout(false);
            this.grpBorda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSabores;
        private System.Windows.Forms.GroupBox grpIngredientes;
        private System.Windows.Forms.CheckBox chkAzeitona;
        private System.Windows.Forms.CheckBox chkCebola;
        private System.Windows.Forms.ComboBox cboSabores;
        private System.Windows.Forms.GroupBox grpBorda;
        private System.Windows.Forms.RadioButton rdbComBorda;
        private System.Windows.Forms.RadioButton rdbSemBorda;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnImprimir;
    }
}

