
namespace ParcialDeJohnDoe.Windows
{
    partial class frmEsferaAE
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
            this.RellenoComboBox = new System.Windows.Forms.ComboBox();
            this.RadioTextBox = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RayasRadioButton = new System.Windows.Forms.RadioButton();
            this.ContinuoRadioButton = new System.Windows.Forms.RadioButton();
            this.PuntosRadioButton = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // RellenoComboBox
            // 
            this.RellenoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RellenoComboBox.FormattingEnabled = true;
            this.RellenoComboBox.Location = new System.Drawing.Point(128, 58);
            this.RellenoComboBox.Name = "RellenoComboBox";
            this.RellenoComboBox.Size = new System.Drawing.Size(279, 21);
            this.RellenoComboBox.TabIndex = 58;
            // 
            // RadioTextBox
            // 
            this.RadioTextBox.Location = new System.Drawing.Point(128, 29);
            this.RadioTextBox.MaxLength = 50;
            this.RadioTextBox.Name = "RadioTextBox";
            this.RadioTextBox.Size = new System.Drawing.Size(279, 20);
            this.RadioTextBox.TabIndex = 53;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(319, 184);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 61);
            this.btnCancelar.TabIndex = 55;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(25, 184);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 61);
            this.btnOK.TabIndex = 54;
            this.btnOK.Text = "OK";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Relleno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Radio:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PuntosRadioButton);
            this.groupBox1.Controls.Add(this.RayasRadioButton);
            this.groupBox1.Controls.Add(this.ContinuoRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(128, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 65);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Trazo ";
            // 
            // RayasRadioButton
            // 
            this.RayasRadioButton.AutoSize = true;
            this.RayasRadioButton.Location = new System.Drawing.Point(79, 19);
            this.RayasRadioButton.Name = "RayasRadioButton";
            this.RayasRadioButton.Size = new System.Drawing.Size(55, 17);
            this.RayasRadioButton.TabIndex = 1;
            this.RayasRadioButton.Text = "Rayas";
            this.RayasRadioButton.UseVisualStyleBackColor = true;
            // 
            // ContinuoRadioButton
            // 
            this.ContinuoRadioButton.AutoSize = true;
            this.ContinuoRadioButton.Checked = true;
            this.ContinuoRadioButton.Location = new System.Drawing.Point(6, 19);
            this.ContinuoRadioButton.Name = "ContinuoRadioButton";
            this.ContinuoRadioButton.Size = new System.Drawing.Size(67, 17);
            this.ContinuoRadioButton.TabIndex = 0;
            this.ContinuoRadioButton.TabStop = true;
            this.ContinuoRadioButton.Text = "Continuo";
            this.ContinuoRadioButton.UseVisualStyleBackColor = true;
            // 
            // PuntosRadioButton
            // 
            this.PuntosRadioButton.AutoSize = true;
            this.PuntosRadioButton.Location = new System.Drawing.Point(140, 19);
            this.PuntosRadioButton.Name = "PuntosRadioButton";
            this.PuntosRadioButton.Size = new System.Drawing.Size(58, 17);
            this.PuntosRadioButton.TabIndex = 1;
            this.PuntosRadioButton.Text = "Puntos";
            this.PuntosRadioButton.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEsferaAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 302);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RellenoComboBox);
            this.Controls.Add(this.RadioTextBox);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "frmEsferaAE";
            this.Text = "frmEsferaAE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RellenoComboBox;
        private System.Windows.Forms.TextBox RadioTextBox;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PuntosRadioButton;
        private System.Windows.Forms.RadioButton RayasRadioButton;
        private System.Windows.Forms.RadioButton ContinuoRadioButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}