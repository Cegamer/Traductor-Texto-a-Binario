
namespace Traductor_Texto_a_Binario
{
    partial class Conversor
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
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.textInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(58, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Convertir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.ForeColor = System.Drawing.Color.Lime;
            this.result.Location = new System.Drawing.Point(3, 9);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(59, 15);
            this.result.TabIndex = 1;
            this.result.Text = "Resultado";
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // textInput
            // 
            this.textInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textInput.Location = new System.Drawing.Point(12, 12);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(265, 29);
            this.textInput.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.result);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.panel1.Location = new System.Drawing.Point(12, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 268);
            this.panel1.TabIndex = 3;
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(289, 378);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(305, 417);
            this.MinimumSize = new System.Drawing.Size(305, 417);
            this.Name = "Conversor";
            this.Text = "Conversor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Panel panel1;
    }
}

