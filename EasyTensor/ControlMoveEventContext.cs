using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EasyTensor
{
    public class ControlMoveEventContext
    {
        private Control _control;
        private Point _mouseStartupPoint;
        private bool _canMoveControl;

        public ControlMoveEventContext(Control control)
        {
            _control = control;
        }


        public void SetMouseStartupPoint(Point mouseStartupPoint)
        {
            _mouseStartupPoint = mouseStartupPoint;
            _canMoveControl = true;
        }

        public void MoveControl(Point moveTo)
        {
            if (!_canMoveControl) return;

            var deltaX = moveTo.X - _mouseStartupPoint.X;
            var deltaY = moveTo.Y - _mouseStartupPoint.Y;
            
            if (IsHitBorder(deltaX, deltaY)) return;

            _control.Left += deltaX;
            _control.Top += deltaY;
        }

        private bool IsHitBorder(int deltaX, int deltaY)
        {
            var isHitLeftBorder = _control.Left + deltaX <= 0;
            var isHitRightBorder = _control.Right + deltaX >= _control.Parent.Width;
            var isHitTopBorder = _control.Top + deltaY <= 0;
            var isHitBottomBorder = _control.Bottom + deltaY >= _control.Parent.Height;
            return isHitTopBorder || isHitLeftBorder || isHitRightBorder || isHitBottomBorder;
        }

        public void StopMoveControl()
        {
            _canMoveControl = false;
        }

    }
}
