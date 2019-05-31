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
    /// <summary>
    /// メインフォーム
    /// </summary>
    public partial class frmMain : Form
    {
        #region メンバメソッド

        /// <summary>
        /// ドラッグ中かどうか
        /// </summary>
        private bool m_isDragging;

        /// <summary>
        /// ポインタのクライアント座標
        /// </summary>
        private Point m_pointerAbsoluteLocation;

        #endregion


        #region メソッド

        /// <summary>
        /// ポインタの座標を pictureBoxの範囲内に収める
        /// </summary>
        /// <param name="pointerLocation"> ポインタの画面座標 </param>
        /// <param name="xRange"> 左右の余白 </param>
        /// <param name="yRange"> 上下の余白 </param>
        /// <returns> 修正後のポインタのクライアント座標 </returns>
        private Point FitPointerRange(Point pointerLocation, int xRange, int yRange)
        {
            pointerLocation = PointToClient(pointerLocation);
            Point _correctedPointerLocation = Point.Empty;

            // X座標の最適化
            if (pointerLocation.X < 0)
            {
                _correctedPointerLocation.X = xRange;
            }
            else if (picDrawLine.Width < pointerLocation.X)
            {
                _correctedPointerLocation.X = (picDrawLine.Width - xRange);
            }
            else
            {
                _correctedPointerLocation.X = pointerLocation.X;
            }

            // Y座標の最適化
            if (pointerLocation.Y < 0)
            {
                _correctedPointerLocation.Y = yRange;
            }
            else if (picDrawLine.Height < pointerLocation.Y)
            {
                _correctedPointerLocation.Y = (picDrawLine.Height - yRange);
            }
            else
            {
                _correctedPointerLocation.Y = pointerLocation.Y;
            }

            return _correctedPointerLocation;
        }

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
                Control _sender = (Control)sender;

                // 現在のポインタのクライアント座標
                Point _correctedPointerLocation = 
                        FitPointerRange(Cursor.Position, _sender.Width, _sender.Height);

                // 直前のポインタのクライアント座標があるか
                if (m_pointerAbsoluteLocation != Point.Empty)
                {
                    // 現在と直前のポインタの差分
                    Point _pointerDiffernce =
                        new Point(m_pointerAbsoluteLocation.X - _correctedPointerLocation.X,
                                  m_pointerAbsoluteLocation.Y - _correctedPointerLocation.Y);

                    // ポインタの差分を考慮して、ラベル位置を仮決めする
                    Point _tempLocation =
                        new Point(_sender.Location.X - _pointerDiffernce.X,
                                  _sender.Location.Y - _pointerDiffernce.Y);

                    _sender.Location = _tempLocation;
                }

                m_pointerAbsoluteLocation = _correctedPointerLocation;
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
