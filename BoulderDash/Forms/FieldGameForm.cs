using BoulderDash.Utils;
using BoulderDashCore.GameObjects.Managers;
using BoulderDashCore.Managers.InputManagers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoulderDash.Forms
{
    public partial class FieldGameForm: Form
    {
        private readonly GameManager _game;
        private readonly InputManager _inputManager;
        private readonly bool _isGameActive = true;
        private System.Windows.Forms.Timer _renderTimer;
        private Bitmap _backBuffer;

        public bool GameEndMBOpened { get; set; }

        public FieldGameForm(GameManager game, InputManager inputManager)
        {
            _game = game;
            _inputManager = inputManager;

            this.DoubleBuffered = true;

            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            SetupRendering();

            SubscriveGameEvents();
        }

        private void SetupRendering()
        {
            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null,
            panelPlay,
            new object[] { true });
            _renderTimer = new System.Windows.Forms.Timer { Interval = 16 };
            _renderTimer.Tick += (s, e) => RenderGameField();
            _renderTimer.Start();
            this.Resize += (s, e) => CreateBackBuffer();
            this.Load += (s, e) => CreateBackBuffer();
        }

        private void CreateBackBuffer()
        {
            if (panelPlay.ClientSize.Width <= 0 || panelPlay.ClientSize.Height <= 0)
                return;
            _backBuffer?.Dispose();
            _backBuffer = new Bitmap(
                panelPlay.ClientSize.Width,
                panelPlay.ClientSize.Height
            );
        }

        private void RenderGameField()
        {
            if (this.IsDisposed || !this.IsHandleCreated) return;

            if (_backBuffer == null || _game == null)
                return;

            using (var g = Graphics.FromImage(_backBuffer))
            {
                g.Clear(Color.Black);
                DrawGameField(g);
            }

            this.Invoke((System.Windows.Forms.MethodInvoker)delegate
            {
                panelPlay.Invalidate();
                UpdateGameInfo();
            });
        }
        private void DrawGameField(Graphics g)
        {
            lock (_game.FieldLock)
            {
                int cellSize = CalculateCellSize();
                int offsetX = (panelPlay.Width - _game.FieldWidth * cellSize) / 2;
                int offsetY = (panelPlay.Height - _game.FieldHeight * cellSize) / 2;

                using (var gridPen = new Pen(Color.Gray))
                using (var backgroundBrush = new SolidBrush(Color.Black))
                using (var font = new System.Drawing.Font("Consolas", cellSize * 0.7f))
                {
                    var format = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };

                    for (int y = 0; y < _game.FieldHeight; y++)
                    {
                        //skip empty rows
                        if (_game.Field[y] == null) continue;
                        for (int x = 0; x < _game.FieldWidth; x++)
                        {
                            var entity = _game.Field[y][x];
                            var rect = new Rectangle(
                                offsetX + x * cellSize,
                                offsetY + y * cellSize,
                                cellSize,
                                cellSize
                            );

                            g.FillRectangle(backgroundBrush, rect);

                            //if the entity is null
                            if (entity == null)
                            {
                                g.DrawRectangle(gridPen, rect);
                                continue;
                            }

                            using (var brush = new SolidBrush(entity.Foreground))
                            {
                                g.DrawString(
                                    entity.View.ToString(),
                                    font,
                                    brush,
                                    rect,
                                    format
                                );
                            }

                            g.DrawRectangle(gridPen, rect);
                        }
                    }
                }

                DrawBorder(g, offsetX, offsetY, cellSize);
            }
        }
        private int CalculateCellSize()
        {
            int maxWidth = this.ClientSize.Width / _game.FieldWidth;
            int maxHeight = (this.ClientSize.Height - 100) / _game.FieldHeight; // Учет панели информации
            return Math.Min(maxWidth, maxHeight);
        }

        private void DrawBorder(Graphics g, int offsetX, int offsetY, int cellSize)
        {
            int width = _game.FieldWidth * cellSize;
            int height = _game.FieldHeight * cellSize;

            using (var pen = new Pen(Color.White, 3))
            {
                g.DrawRectangle(pen,
                    offsetX - 2,
                    offsetY - 2,
                    width + 4,
                    height + 4
                );
            }
        }

        private void GameEnd(string text, string caption)
        {
            if (!GameEndMBOpened)
            {
                GameEndMBOpened = true;
                _renderTimer?.Stop();
                MessageBox.Show(text, text, MessageBoxButtons.OK);
                DenyGameEvents();
                this.Close();
            }

        }
        private void GameOver()
        {
            GameEnd("Game Over", "You have loosed, try again");
        }

        private void GameWin()
        {
            GameEnd("Game Win", "Congratulations!!!");
        }

        private void DenyGameEvents()
        {
            _inputManager.OnGameOver -= GameOver;
            _inputManager.OnGameWin -= GameWin;
        }

        private void SubscriveGameEvents()
        {
            _inputManager.OnGameOver += GameOver;
            _inputManager.OnGameWin += GameWin;
        }


        private void UpdateGameInfo()
        {
            lblScore.Text = $"Score: {_game.Player.Score}";
            lblLives.Text = $"Lives: {_game.Player.Lives}";
            lblStoneMoves.Text = $"Stone moves: {_game.Player.RestStoneMoves}";
            lblJumps.Text = $"Jumps: {_game.Player.RestJumps}";
            lblBombUsed.Text = $"Bombs used: {_game.Player.BombsUsed}";
        }

        private void infoPanel_Paint(object sender, PaintEventArgs e)
        {
            if (_backBuffer != null)
            {
                e.Graphics.DrawImage(
                    _backBuffer,
                    Point.Empty
                );
            }
        }

        private void panelPlay_Paint(object sender, PaintEventArgs e)
        {
            if (_backBuffer != null)
            {
                e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;

                e.Graphics.DrawImage(
                _backBuffer,
                new Rectangle(0, 0, panelPlay.Width, panelPlay.Height),
                0, 0, _backBuffer.Width, _backBuffer.Height,
                GraphicsUnit.Pixel
                );
            }
            base.OnPaint(e);
        }

        private void GameField_KeyDown(object sender, KeyEventArgs e)
        {
            if (_isGameActive)
            {
                var key = KeyInterpreter.WinFormsKeyToGameKey(e);
                if (key != null)
                {
                    _inputManager?.CommitKeyPressed(key.Value);
                }
            }
        }

        private void GameField_FormClosing(object sender, FormClosingEventArgs e)
        {
            _renderTimer?.Stop();
            _renderTimer?.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentMB = MessageBox.Show("Are you sure you want to leave the game?", "Game end", MessageBoxButtons.YesNoCancel);
            if (currentMB.Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }
    }
}

