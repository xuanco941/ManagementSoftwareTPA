using Syncfusion.Windows.Forms.Tools;

namespace ManagementSoftware
{
    partial class FormTest
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
            this.doubleTextBox1 = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.integerTextBox1 = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.doubleTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // doubleTextBox1
            // 
            this.doubleTextBox1.BeforeTouchSize = new System.Drawing.Size(100, 23);
            this.doubleTextBox1.DoubleValue = 0D;
            this.doubleTextBox1.Location = new System.Drawing.Point(528, 165);
            this.doubleTextBox1.Name = "doubleTextBox1";
            this.doubleTextBox1.Size = new System.Drawing.Size(100, 23);
            this.doubleTextBox1.TabIndex = 0;
            this.doubleTextBox1.Text = "0,00";
            // 
            // integerTextBox1
            // 
            this.integerTextBox1.BeforeTouchSize = new System.Drawing.Size(100, 23);
            this.integerTextBox1.IntegerValue = 0;
            this.integerTextBox1.Location = new System.Drawing.Point(800, 190);
            this.integerTextBox1.Name = "integerTextBox1";
            this.integerTextBox1.Size = new System.Drawing.Size(100, 23);
            this.integerTextBox1.TabIndex = 1;
            this.integerTextBox1.Text = "0";
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doubleTextBox1);
            this.Controls.Add(this.integerTextBox1);
            this.Name = "FormTest";
            this.Text = "FormTest";
            ((System.ComponentModel.ISupportInitialize)(this.doubleTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerTextBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.DoubleTextBox doubleTextBox1;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox integerTextBox1;
    }
}