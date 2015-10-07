namespace HelloWorld
{
    partial class HelloWorld
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
            this.frmHelloWorld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // frmHelloWorld
            // 
            this.frmHelloWorld.AutoSize = true;
            this.frmHelloWorld.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmHelloWorld.Location = new System.Drawing.Point(72, 100);
            this.frmHelloWorld.Name = "frmHelloWorld";
            this.frmHelloWorld.Size = new System.Drawing.Size(107, 22);
            this.frmHelloWorld.TabIndex = 0;
            this.frmHelloWorld.Text = "Hello World";
            // 
            // HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.frmHelloWorld);
            this.Name = "HelloWorld";
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frmHelloWorld;
    }
}

