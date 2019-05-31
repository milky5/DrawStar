using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawStar
{
    public partial class Form1 : Form
    {
        private bool m_isDragging;
        private Point m_pointersAbsoluteLocation;

        public Form1()
        {
            InitializeComponent();

            Refresh();
            
        }

        private void lblVertex_MouseDown(object sender, MouseEventArgs e)
        {
            m_isDragging = true;
        }

        private void lblVertex_MouseMove(object sender, MouseEventArgs e)
        {
            // 場所の移動
            if (m_isDragging == true)
            {
                Point _pointersDiffernce;
                Label _vertex = (Label)sender;

                Point newAbsolute = new Point(_vertex.Location.X + e.Location.X,
                              _vertex.Location.Y + e.Location.Y);

                if (m_pointersAbsoluteLocation != Point.Empty)
                {
                    _pointersDiffernce = new Point(m_pointersAbsoluteLocation.X - newAbsolute.X,
                                                   m_pointersAbsoluteLocation.Y - newAbsolute.Y);


                    _vertex.Location = new Point(_vertex.Location.X - _pointersDiffernce.X,
                                                 _vertex.Location.Y - _pointersDiffernce.Y);
                }
                else
                {
                    
                }

                m_pointersAbsoluteLocation = newAbsolute;
            }
            else
            {
                return;
            }

            // 線の描画
            PaintEventArgs _paintE = new PaintEventArgs(pictureBox1.CreateGraphics(), new Rectangle());
            pictureBox1_Paint(sender, _paintE);
        }

        private void lblVertex_MouseUp(object sender, MouseEventArgs e)
        {
            m_isDragging = false;
            m_pointersAbsoluteLocation = Point.Empty;
        }




        private void lblVertex_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.SizeAll;
        }

        private void lblVertex_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }




        /// <summary>
        /// コントロールの中心点の座標を探す
        /// </summary>
        /// <param name="control"> 中心点を探すコントロール </param>
        /// <returns> コントロールの中心点の座標 </returns>
        private Point SearchCenterPoint(Control control)
        {
            Point startPos = control.Location;
            Point endPos = new Point(control.Location.X + control.Width, control.Location.Y + control.Height);
            Point centerPos = new Point((startPos.X + endPos.X) / 2, (startPos.Y + endPos.Y) / 2);
            return centerPos;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.Image = null;

            Pen pen = new Pen(Color.Yellow, 3);

            e.Graphics.DrawLine(pen, SearchCenterPoint(lblVertex1), SearchCenterPoint(lblVertex2));
            e.Graphics.DrawLine(pen, SearchCenterPoint(lblVertex2), SearchCenterPoint(lblVertex3));
            e.Graphics.DrawLine(pen, SearchCenterPoint(lblVertex3), SearchCenterPoint(lblVertex4));
            e.Graphics.DrawLine(pen, SearchCenterPoint(lblVertex4), SearchCenterPoint(lblVertex5));
            e.Graphics.DrawLine(pen, SearchCenterPoint(lblVertex5), SearchCenterPoint(lblVertex1));
        }
    }
}
