
namespace EasyTensor
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this._tabComponent = new System.Windows.Forms.TabPage();
            this._btnMaxPoolingLayer = new System.Windows.Forms.Button();
            this._btnConvLayer = new System.Windows.Forms.Button();
            this._drawPanel = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this._tabProperties = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this._tabComponent.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this._tabComponent);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(263, 856);
            this.tabControl1.TabIndex = 0;
            // 
            // _tabComponent
            // 
            this._tabComponent.Controls.Add(this._btnMaxPoolingLayer);
            this._tabComponent.Controls.Add(this._btnConvLayer);
            this._tabComponent.Location = new System.Drawing.Point(4, 28);
            this._tabComponent.Name = "_tabComponent";
            this._tabComponent.Padding = new System.Windows.Forms.Padding(3);
            this._tabComponent.Size = new System.Drawing.Size(255, 824);
            this._tabComponent.TabIndex = 0;
            this._tabComponent.Text = "layer component";
            this._tabComponent.UseVisualStyleBackColor = true;
            // 
            // _btnMaxPoolingLayer
            // 
            this._btnMaxPoolingLayer.BackColor = System.Drawing.Color.Cyan;
            this._btnMaxPoolingLayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnMaxPoolingLayer.Location = new System.Drawing.Point(20, 92);
            this._btnMaxPoolingLayer.Name = "_btnMaxPoolingLayer";
            this._btnMaxPoolingLayer.Size = new System.Drawing.Size(217, 60);
            this._btnMaxPoolingLayer.TabIndex = 0;
            this._btnMaxPoolingLayer.Tag = "MaxPooling";
            this._btnMaxPoolingLayer.Text = "Max Pooling Layer";
            this._btnMaxPoolingLayer.UseVisualStyleBackColor = false;
            // 
            // _btnConvLayer
            // 
            this._btnConvLayer.BackColor = System.Drawing.Color.Gold;
            this._btnConvLayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._btnConvLayer.Location = new System.Drawing.Point(20, 13);
            this._btnConvLayer.Name = "_btnConvLayer";
            this._btnConvLayer.Size = new System.Drawing.Size(217, 60);
            this._btnConvLayer.TabIndex = 0;
            this._btnConvLayer.Tag = "Conv";
            this._btnConvLayer.Text = "Conv Layer";
            this._btnConvLayer.UseVisualStyleBackColor = false;
            // 
            // _drawPanel
            // 
            this._drawPanel.AutoScroll = true;
            this._drawPanel.BackColor = System.Drawing.Color.AliceBlue;
            this._drawPanel.Location = new System.Drawing.Point(265, -1);
            this._drawPanel.Margin = new System.Windows.Forms.Padding(4);
            this._drawPanel.Name = "_drawPanel";
            this._drawPanel.Size = new System.Drawing.Size(1072, 852);
            this._drawPanel.TabIndex = 1;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this._tabProperties);
            this.tabControl2.Location = new System.Drawing.Point(1344, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(231, 839);
            this.tabControl2.TabIndex = 2;
            // 
            // _tabProperties
            // 
            this._tabProperties.Location = new System.Drawing.Point(4, 28);
            this._tabProperties.Name = "_tabProperties";
            this._tabProperties.Padding = new System.Windows.Forms.Padding(3);
            this._tabProperties.Size = new System.Drawing.Size(223, 807);
            this._tabProperties.TabIndex = 0;
            this._tabProperties.Text = "Properties";
            this._tabProperties.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this._drawPanel);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "EasyTensor";
            this.tabControl1.ResumeLayout(false);
            this._tabComponent.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage _tabComponent;
        private System.Windows.Forms.Panel _drawPanel;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage _tabProperties;
        private System.Windows.Forms.Button _btnConvLayer;
        private System.Windows.Forms.Button _btnMaxPoolingLayer;
    }
}