using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw2
{
    public partial class Form1 : Form
    {
        PresentationModel.PresentationModel _presentationModel;
        Panel _canvas = new DoubleBufferedPanel();
        const string DIAMOND = "diamond";
        const string LINE = "line";

        public Form1()
        {
            InitializeComponent();
            _canvas.Dock = DockStyle.Fill;
            _canvas.BackColor = Color.LightYellow;
            _canvas.MouseDown += HandleCanvasPressed;
            _canvas.MouseUp += HandleCanvasReleased;
            _canvas.MouseMove += HandleCanvasMoved;
            _canvas.Paint += HandleCanvasPaint;
            Controls.Add(_canvas);
            _presentationModel = new PresentationModel.PresentationModel(_canvas);
            _presentationModel._presentaionModelChanged += HandleModelChanged;
            _clearButton.Click += HandleClearButtonClick;
            _lineButton.Click += HandleLineButtonClick;
            _diamondButton.Click += HandleDiamondButtonClick;
        }

        // daimond 按鈕按下
        public void HandleDiamondButtonClick(object sender, EventArgs e)
        {
            _presentationModel.Mode = DIAMOND;
        }

        // Line 按鈕按下
        public void HandleLineButtonClick(object sender, EventArgs e)
        {
            _presentationModel.Mode = LINE;
        }

        // clear 按鈕按下
        public void HandleClearButtonClick(object sender, EventArgs e)
        {
            _presentationModel.Clear();
        }

        // 滑鼠按下
        public void HandleCanvasPressed(object sender, MouseEventArgs e)
        {
            _presentationModel.PressPointer(e.X, e.Y);
        }

        // 滑鼠放開
        public void HandleCanvasReleased(object sender, MouseEventArgs e)
        {
            _presentationModel.ReleasePointer(e.X, e.Y);
        }

        // 滑鼠移動
        public void HandleCanvasMoved(object sender, MouseEventArgs e)
        {
            _presentationModel.MovePointer(e.X, e.Y);
        }

        // 畫
        public void HandleCanvasPaint(object sender, PaintEventArgs e)
        {
            _presentationModel.Draw(e.Graphics);
        }

        // 畫面更動
        public void HandleModelChanged()
        {
            Invalidate(true);
        }
    }
}
