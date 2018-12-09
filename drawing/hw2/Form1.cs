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
        DrawingModel.Model _model;
        PresentationModel.PresentationModel _presentationModel;
        Panel _canvas = new DoubleBufferedPanel();

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
            _presentationModel._modelChanged += HandleModelChanged;
            _clearButton.Click += HandleClearButtonClick;
            _lineButton.Click += HandleLineButtonClick;
            _daimondButton.Click += HandleDaimondButtonClick;
        }

        // daimond 按鈕按下
        public void HandleDaimondButtonClick(object sender, EventArgs e)
        {
            _presentationModel.Mode = "daimond";
        }

        // Line 按鈕按下
        public void HandleLineButtonClick(object sender, EventArgs e)
        {
            _presentationModel.Mode = "line";
        }

        // clear 按鈕按下
        public void HandleClearButtonClick(object sender, EventArgs e)
        {
            _presentationModel.Clear();
        }

        // 滑鼠按下
        public void HandleCanvasPressed(object sender, MouseEventArgs e)
        {
            _presentationModel.PointerPressed(e.X, e.Y);
        }

        // 滑鼠放開
        public void HandleCanvasReleased(object sender, MouseEventArgs e)
        {
            _presentationModel.PointerReleased(e.X, e.Y);
        }

        // 滑鼠移動
        public void HandleCanvasMoved(object sender, MouseEventArgs e)
        {
            _presentationModel.PointerMoved(e.X, e.Y);
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
