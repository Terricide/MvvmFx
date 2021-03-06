﻿namespace SimpleParameters.UI
{
    partial class ShellView
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
            this.showButtonTest = new System.Windows.Forms.Button();
            this.showButtonParameterTest = new System.Windows.Forms.Button();
            this.showMenuStripTest = new System.Windows.Forms.Button();
            this.showToolStripTest = new System.Windows.Forms.Button();
            this.ActiveItem = new MvvmFx.CaliburnMicro.ContentContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._buttonNr = new System.Windows.Forms.Label();
            this._model_buttonDescription = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // showButtonTest
            // 
            this.showButtonTest.Location = new System.Drawing.Point(13, 13);
            this.showButtonTest.Name = "showButtonTest";
            this.showButtonTest.Size = new System.Drawing.Size(100, 23);
            this.showButtonTest.TabIndex = 0;
            this.showButtonTest.Text = "Button test";
            this.showButtonTest.UseVisualStyleBackColor = true;
            // 
            // showButtonParameterTest
            // 
            this.showButtonParameterTest.Location = new System.Drawing.Point(143, 13);
            this.showButtonParameterTest.Name = "showButtonParameterTest";
            this.showButtonParameterTest.Size = new System.Drawing.Size(100, 23);
            this.showButtonParameterTest.TabIndex = 0;
            this.showButtonParameterTest.Text = "Button Parameter test";
            this.showButtonParameterTest.UseVisualStyleBackColor = true;
            // 
            // showMenuStripTest
            // 
            this.showMenuStripTest.Location = new System.Drawing.Point(273, 13);
            this.showMenuStripTest.Name = "showMenuStripTest";
            this.showMenuStripTest.Size = new System.Drawing.Size(100, 23);
            this.showMenuStripTest.TabIndex = 1;
            this.showMenuStripTest.Text = "MenuStrip test";
            this.showMenuStripTest.UseVisualStyleBackColor = true;
            // 
            // showToolStripTest
            // 
            this.showToolStripTest.Location = new System.Drawing.Point(403, 13);
            this.showToolStripTest.Name = "showToolStripTest";
            this.showToolStripTest.Size = new System.Drawing.Size(100, 23);
            this.showToolStripTest.TabIndex = 2;
            this.showToolStripTest.Text = "ToolStrip test";
            this.showToolStripTest.UseVisualStyleBackColor = true;
            // 
            // ActiveItem
            // 
            this.ActiveItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActiveItem.Location = new System.Drawing.Point(0, 49);
            this.ActiveItem.Name = "ActiveItem";
            this.ActiveItem.Size = new System.Drawing.Size(1003, 438);
            this.ActiveItem.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1003, 49);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // _buttonNr
            // 
            this._buttonNr.AutoSize = true;
            this._buttonNr.Location = new System.Drawing.Point(533, 18);
            this._buttonNr.Name = "_buttonNr";
            this._buttonNr.Size = new System.Drawing.Size(0, 13);
            this._buttonNr.TabIndex = 5;
            this.toolTip1.SetToolTip(this._buttonNr, "ViewModel property");
            // 
            // _model_buttonDescription
            // 
            this._model_buttonDescription.AutoSize = true;
            this._model_buttonDescription.Location = new System.Drawing.Point(563, 18);
            this._model_buttonDescription.Name = "_model_buttonDescription";
            this._model_buttonDescription.Size = new System.Drawing.Size(0, 13);
            this._model_buttonDescription.TabIndex = 6;
            this.toolTip1.SetToolTip(this._model_buttonDescription, "ViewModel.Model object property");
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ShellView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1003, 487);
            this.Controls.Add(this._model_buttonDescription);
            this.Controls.Add(this._buttonNr);
            this.Controls.Add(this.showToolStripTest);
            this.Controls.Add(this.showMenuStripTest);
            this.Controls.Add(this.showButtonTest);
            this.Controls.Add(this.showButtonParameterTest);
            this.Controls.Add(this.ActiveItem);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ShellView";
            this.Text = "ShellView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showButtonParameterTest;
        private System.Windows.Forms.Button showButtonTest;
        private System.Windows.Forms.Button showMenuStripTest;
        private System.Windows.Forms.Button showToolStripTest;
        private MvvmFx.CaliburnMicro.ContentContainer ActiveItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label _buttonNr;
        private System.Windows.Forms.Label _model_buttonDescription;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}