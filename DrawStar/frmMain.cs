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
    public partial class frmMain : Form
    {
        #region メンバメソッド
        
        /// <summary>
        /// ドラッグ中かどうか
        /// </summary>
        private bool m_isDragging;

        /// <summary>
        /// ポインタの絶対座標
        /// </summary>
        private Point m_pointerAbsoluteLocation;

        #endregion


        #region メソッド

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// マウスが押された際に呼ばれる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblVertex_MouseDown(object sender, MouseEventArgs e)
        {
            m_isDragging = true;
        }

        /// <summary>
        /// ポインタがラベル上にあれば、ポインタの種類を変える
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblVertex_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.SizeAll;
        }

        /// <summary>
        /// ポインタがラベル上になければ、ポインタの種類を変える
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblVertex_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        /// <summary>
        /// ラベルの移動を行う
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblVertex_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_isDragging == true)
            {
                Point _pointerDiffernce;
                Label _lblVertex = (Label)sender;

                Point _newAbsoluteLocation = 
                        new Point(_lblVertex.Location.X + e.Location.X,
                                  _lblVertex.Location.Y + e.Location.Y);

                if (m_pointerAbsoluteLocation != Point.Empty)
                {
                    _pointerDiffernce =
                        new Point(m_pointerAbsoluteLocation.X - _newAbsoluteLocation.X,
                                  m_pointerAbsoluteLocation.Y - _newAbsoluteLocation.Y);

                    _lblVertex.Location =
                        new Point(_lblVertex.Location.X - _pointerDiffernce.X,
                                  _lblVertex.Location.Y - _pointerDiffernce.Y);
                }

                m_pointerAbsoluteLocation = _newAbsoluteLocation;
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// マウスボタンが離された際に呼ばれる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblVertex_MouseUp(object sender, MouseEventArgs e)
        {
            m_isDragging = false;
            m_pointerAbsoluteLocation = Point.Empty;
        }

        /// <summary>
        /// コントロールの中心点の座標を探す
        /// </summary>
        /// <param name="control"> 中心点を探すコントロール </param>
        /// <returns> コントロールの中心点の座標 </returns>
        private Point SearchCenterPoint(Control control)
        {
            Point _startPos = control.Location;
            Point _endPos = new Point(control.Location.X + control.Width,
                                     control.Location.Y + control.Height);
            Point _centerPos = new Point((_startPos.X + _endPos.X) / 2,
                                        (_startPos.Y + _endPos.Y) / 2);
            return _centerPos;
        }

        /// <summary>
        /// 再描画が必要な際に呼ばれる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picDrawLine_Paint(object sender, PaintEventArgs e)
        {
            picDrawLine.Image = null;

            Pen _drawPen = new Pen(Color.Yellow, 3);

            e.Graphics.DrawLine(_drawPen, SearchCenterPoint(lblVertex1), 
                                SearchCenterPoint(lblVertex2));
            e.Graphics.DrawLine(_drawPen, SearchCenterPoint(lblVertex2), 
                                SearchCenterPoint(lblVertex3));
            e.Graphics.DrawLine(_drawPen, SearchCenterPoint(lblVertex3), 
                                SearchCenterPoint(lblVertex4));
            e.Graphics.DrawLine(_drawPen, SearchCenterPoint(lblVertex4),
                                SearchCenterPoint(lblVertex5));
            e.Graphics.DrawLine(_drawPen, SearchCenterPoint(lblVertex5),
                                SearchCenterPoint(lblVertex1));
        }

        #endregion
    }
}
