namespace ActividadBusquedaSecuencial
{
    partial class FormDatos
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
            tbValor = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // tbValor
            // 
            tbValor.Location = new Point(141, 116);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(240, 23);
            tbValor.TabIndex = 0;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(141, 243);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.OK;
            button2.Location = new Point(306, 243);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Aceptar";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 402);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbValor);
            Name = "FormDatos";
            Text = "FormDatos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox tbValor;
        private Button button1;
        private Button button2;
    }
}