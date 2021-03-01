using System;
using System.Windows.Forms;
using EasyTensor.Controls;
using Cursor = System.Windows.Forms.Cursor;

namespace EasyTensor
{
    public partial class MainForm : Form
    {
        private readonly ILayerControlFactory _layerControlFactory;

        public MainForm(ILayerControlFactory layerControlFactory)
        {
            InitializeComponent();
            _layerControlFactory = layerControlFactory;
            _btnConvLayer.Click += GenerateLayerClickEvent;
            _btnMaxPoolingLayer.Click += GenerateLayerClickEvent;
        }

        private void GenerateLayerClickEvent(object? sender, EventArgs e)
        {
            var control = sender as Control;
            if (control?.Tag == null) return;
            var type = control.Tag as string;
            var layerControl = _layerControlFactory.CreateLayerControl(type!, control.BackColor, control.Text);
            _drawPanel.Controls.Add(layerControl);
        }
    }
}
