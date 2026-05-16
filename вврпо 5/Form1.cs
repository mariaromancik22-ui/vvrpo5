using System;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace вврпо_5   // замените на своё пространство имён
{
    public partial class Form1 : Form
    {
        // Игровое поле (0-пусто, 1-игрок X, 2-компьютер O)
        private int[] board = new int[9];
        private Button[] cellButtons = new Button[9];
        private Random random = new Random();

        // Флаги состояния
        private bool isPlayerTurn;    // true - игрок, false - компьютер
        private bool gameActive;      // игра активна (идёт)
        private bool gameOver;        // партия окончена
        private bool nextFirstPlayer; // кто начнёт следующую игру: true-игрок, false-компьютер

        public Form1()
        {
            InitializeComponent();
            InitializeCustom();
            InitializeGameState();

            // Настройка видимости кнопок
            exitButton.Visible = true;
            exitButton.Enabled = true;
            newGameButton.Visible = false;  // сначала скрыта
            startButton.Visible = true;
            startButton.Enabled = true;
        }

        private void InitializeGameState()
        {
            nextFirstPlayer = true;   // первая игра – игрок ходит первым
            ResetBoard();             // поле очищено и заблокировано
            gameActive = false;
            gameOver = false;
            statusLabel.Text = "Нажмите 'Начать игру'";
        }

        private void ResetBoard()
        {
            for (int i = 0; i < 9; i++) board[i] = 0;
            foreach (Button btn in cellButtons) btn.Text = "";
            gameActive = false;
            gameOver = false;
            SetButtonsEnabled(false);
        }

        private void SetButtonsEnabled(bool enabled)
        {
            foreach (Button btn in cellButtons) btn.Enabled = enabled;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ResetBoard();
            gameActive = true;
            gameOver = false;
            isPlayerTurn = nextFirstPlayer;
            SetButtonsEnabled(true);
            startButton.Visible = false;   // скрываем после первого старта
            newGameButton.Visible = true;  // показываем кнопку "Новая игра"
            statusLabel.Text = isPlayerTurn ? "Ваш ход (X)" : "Ход компьютера (O)...";
            if (!isPlayerTurn) ComputerMove();
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            // Сразу начинаем новую игру
            ResetBoard();
            gameActive = true;
            gameOver = false;
            isPlayerTurn = nextFirstPlayer;
            SetButtonsEnabled(true);
            statusLabel.Text = isPlayerTurn ? "Ваш ход (X)" : "Ход компьютера (O)...";
            if (!isPlayerTurn) ComputerMove();
        }

        private void CellClick(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            if (!gameActive || gameOver || !isPlayerTurn) return;

            int index = -1;
            for (int i = 0; i < 9; i++)
                if (cellButtons[i] == clicked) { index = i; break; }
            if (index == -1) return;
            if (board[index] != 0) return;

            board[index] = 1;
            clicked.Text = "X";
            if (CheckGameOver()) return;

            isPlayerTurn = false;
            statusLabel.Text = "Ход компьютера (O)...";
            ComputerMove();
        }

        private async void ComputerMove()
        {
            if (!gameActive || gameOver || isPlayerTurn) return;

            statusLabel.Text = "Ход компьютера (O)...";
            await Task.Delay(500);

            if (!gameActive || gameOver || isPlayerTurn) return;

            // Сбор свободных клеток
            var freeIndices = new System.Collections.Generic.List<int>();
            for (int i = 0; i < 9; i++) if (board[i] == 0) freeIndices.Add(i);

            if (freeIndices.Count == 0)
            {
                CheckGameOver();
                return;
            }

            int move = freeIndices[random.Next(freeIndices.Count)];
            board[move] = 2;
            cellButtons[move].Text = "O";

            if (CheckGameOver()) return;

            isPlayerTurn = true;
            statusLabel.Text = "Ваш ход (X)";
        }

        private bool CheckGameOver()
        {
            string winner = GetWinner();
            if (winner != null)
            {
                EndGame(winner);
                return true;
            }
            bool hasEmpty = false;
            for (int i = 0; i < 9; i++) if (board[i] == 0) { hasEmpty = true; break; }
            if (!hasEmpty)
            {
                EndGame("Draw");
                return true;
            }
            return false;
        }

        private string GetWinner()
        {
            int[][] winLines = {
                new int[] {0,1,2}, new int[] {3,4,5}, new int[] {6,7,8},
                new int[] {0,3,6}, new int[] {1,4,7}, new int[] {2,5,8},
                new int[] {0,4,8}, new int[] {2,4,6}
            };
            foreach (var line in winLines)
            {
                int a = board[line[0]], b = board[line[1]], c = board[line[2]];
                if (a != 0 && a == b && b == c)
                    return a == 1 ? "Player" : "Computer";
            }
            return null;
        }

        private void EndGame(string winner)
        {
            gameActive = false;
            gameOver = true;
            SetButtonsEnabled(false);
            if (winner == "Player")
            {
                statusLabel.Text = "Игрок победил!";
                nextFirstPlayer = false; // компьютер начинает следующую
            }
            else if (winner == "Computer")
            {
                statusLabel.Text = "Компьютер победил!";
                nextFirstPlayer = true;  // игрок начинает следующую
            }
            else
            {
                statusLabel.Text = "Ничья!";
                // nextFirstPlayer не меняется
            }
            // Кнопка "Начать игру" уже скрыта, "Новая игра" видна, "Выход" виден всегда
        }

        private void SaveButton_Click(object sender, EventArgs e) => SaveGame();
        private void LoadButton_Click(object sender, EventArgs e) => LoadGame();

        [Serializable]
        private class GameSaveData
        {
            public int[] Board { get; set; }
            public bool IsPlayerTurn { get; set; }
            public bool IsGameOver { get; set; }
            public string GameOverMessage { get; set; }
            public bool NextFirstPlayer { get; set; }
        }

        private void SaveGame()
        {
            try
            {
                var data = new GameSaveData
                {
                    Board = board,
                    IsPlayerTurn = isPlayerTurn,
                    IsGameOver = gameOver,
                    GameOverMessage = gameOver ? statusLabel.Text : null,
                    NextFirstPlayer = nextFirstPlayer
                };
                string json = JsonSerializer.Serialize(data);
                File.WriteAllText("savegame.json", json);
                MessageBox.Show("Сохранено в savegame.json", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}");
            }
        }

        private void LoadGame()
        {
            if (!File.Exists("savegame.json"))
            {
                MessageBox.Show("Файл не найден.");
                return;
            }
            try
            {
                string json = File.ReadAllText("savegame.json");
                var data = JsonSerializer.Deserialize<GameSaveData>(json);
                if (data == null) throw new Exception("Неверный формат");

                board = data.Board;
                isPlayerTurn = data.IsPlayerTurn;
                gameOver = data.IsGameOver;
                nextFirstPlayer = data.NextFirstPlayer;

                for (int i = 0; i < 9; i++)
                {
                    if (board[i] == 1) cellButtons[i].Text = "X";
                    else if (board[i] == 2) cellButtons[i].Text = "O";
                    else cellButtons[i].Text = "";
                }

                if (gameOver)
                {
                    gameActive = false;
                    SetButtonsEnabled(false);
                    statusLabel.Text = data.GameOverMessage ?? "Игра окончена";
                    startButton.Visible = false;
                    newGameButton.Visible = true;
                    // exitButton.Visible оставляем как есть (true)
                }
                else
                {
                    gameActive = true;
                    SetButtonsEnabled(true);
                    statusLabel.Text = isPlayerTurn ? "Ваш ход (X)" : "Ход компьютера (O)...";
                    startButton.Visible = false;
                    newGameButton.Visible = true;
                    if (!isPlayerTurn) ComputerMove();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}");
            }
        }

        // Этот метод должен быть реализован, если вы используете TableLayoutPanel для поиска кнопок
        private void InitializeCustom()
        {
            // Если вы используете способ поиска кнопок через TableLayoutPanel:
            int index = 0;
            foreach (Control ctrl in gameTable.Controls) // замените на реальное имя таблицы
            {
                if (ctrl is Button btn)
                {
                    cellButtons[index++] = btn;
                    btn.Click += CellClick;
                }
            }
            // Если вы переименовали кнопки как button00...button22, то можно и так:
            // cellButtons[0] = button00;
            // ... и так далее, но тогда нужно заполнить все 9.

            // Подписка на события кнопок управления
            startButton.Click += StartButton_Click;
            saveButton.Click += SaveButton_Click;
            loadButton.Click += LoadButton_Click;
            newGameButton.Click += NewGameButton_Click;
            exitButton.Click += (s, e) => Application.Exit();
        }
    }
}
