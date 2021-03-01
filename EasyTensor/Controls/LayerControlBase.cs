using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EasyTensor.Controls
{
    public abstract partial class LayerControlBase : UserControl
    {
        private const int AnchorPointSize = 8;
        private bool _drawAnchorFlag;
        public ControlMoveEventContext MoveEventContext { get; }

        protected LayerControlBase(Color backColor, string text)
        {
            InitializeComponent();
            BackColor = backColor;
            Text = text;
            Location = new Point(20, 20);
            MoveEventContext = new ControlMoveEventContext(this);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            MoveEventContext.StopMoveControl();
            base.OnMouseUp(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            MoveEventContext.SetMouseStartupPoint(e.Location);
            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            MoveEventContext.MoveControl(e.Location);
            base.OnMouseMove(e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            _drawAnchorFlag = true;
            Cursor = Cursors.SizeAll;
            base.OnMouseEnter(e);
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            _drawAnchorFlag = false;
            Cursor = Cursors.Default;
            base.OnMouseLeave(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var graphics = e.Graphics;
            if (_drawAnchorFlag)
                DrawAnchorPoints(graphics);
            else
                ClearAnchorPoints(graphics);
            
            base.OnPaint(e);
        }

        private void DrawAnchorPoints(Graphics graphics)
        {
            var anchorSize = new Size(AnchorPointSize, AnchorPointSize);
            var anchorPoints = new[]
            {
                new Point(Width / 2, 0),
                new Point(Width / 2, Height - AnchorPointSize),
                new Point(Width - AnchorPointSize, Height / 2),
                new Point(0, Height / 2)
            };
            foreach (var anchorPoint in anchorPoints)
            {
                graphics.FillRectangle(Brushes.DarkSlateGray, new Rectangle(anchorPoint, anchorSize));
            }
        }

        private void ClearAnchorPoints(Graphics graphics)
        {
            graphics.Clear(BackColor);
        }
    }

    public class ConvLayerControl : LayerControlBase
    {
        public ConvLayerControl(Color backColor, string text) : base(backColor, text)
        {
        }
    }

    public class MaxPoolingLayerControl : LayerControlBase
    {
        public MaxPoolingLayerControl(Color backColor, string text) : base(backColor, text)
        {
        }
    }
}
