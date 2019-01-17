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
        const string ELLIPSE = "ellipse";

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
            _diamondButton.Enabled = false;
            _presentationModel = new PresentationModel.PresentationModel(_canvas);
            _presentationModel._presentaionModelChanged += HandleModelChanged;
            _clearButton.Click += HandleClearButtonClick;
            _lineButton.Click += HandleLineButtonClick;
            _diamondButton.Click += HandleDiamondButtonClick;
            _ellipseButton.Click += HandleEllipseButtonClick;
            _undoButton.Click += HandleUndoButtonClick;
            _redoButton.Click += HandleRedoButtonClick;
        }

        // daimond 按鈕按下
        public void HandleDiamondButtonClick(object sender, EventArgs e)
        {
            _presentationModel.Mode = DIAMOND;
            _diamondButton.Enabled = false;
            _lineButton.Enabled = true;
            _ellipseButton.Enabled = true;
        }

        // Line 按鈕按下
        public void HandleLineButtonClick(object sender, EventArgs e)
        {
            _presentationModel.Mode = LINE;
            _diamondButton.Enabled = true;
            _lineButton.Enabled = false;
            _ellipseButton.Enabled = true;
        }

        // Line 按鈕按下
        public void HandleEllipseButtonClick(object sender, EventArgs e)
        {
            _presentationModel.Mode = ELLIPSE;
            _diamondButton.Enabled = true;
            _lineButton.Enabled = true;
            _ellipseButton.Enabled = false;
        }

        // clear 按鈕按下
        public void HandleClearButtonClick(object sender, EventArgs e)
        {
            _presentationModel.Clear();
        }

        // Undo 按鈕按下
        public void HandleUndoButtonClick(object sender, EventArgs e)
        {
            _presentationModel.Undo();
            UpdateRedoUndoButton();
        }

        // Redo 按鈕按下
        public void HandleRedoButtonClick(object sender, EventArgs e)
        {
            _presentationModel.Redo();
            UpdateRedoUndoButton();
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
            UpdateRedoUndoButton();
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

        // 更新Redo Undo 按鈕
        private void UpdateRedoUndoButton()
        {
            _redoButton.Enabled = _presentationModel.ButtonRedoEnabled;
            _undoButton.Enabled = _presentationModel.ButtonUndoEnabled;
        }
    }
}
