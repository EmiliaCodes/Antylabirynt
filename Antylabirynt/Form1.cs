using Antylabirynt.Properties;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Antylabirynt
{
    public partial class GameForm : Form
    {
        private int[,] stateMatrix;
        private int[,] lastFrameMatrix;
        private int gameState; //0-idle 1-moving

        private Queue<Tuple<int, int>> moveQueue;
        private Tuple<int, int> playerPosition;
        private Dictionary<int, Bitmap> resources;
        private List<Tuple<int, int>> toolboxState;

        private int levelNumber;
        private string level;
        private int score;
        private string[] passwords = {"pleaseLvl2", "pleaseLvl3"};

        int empty = 1;
        int playerIcon = 0;
        int box = 2;
        int final = 100;
        int burger = 5;
        int trap = 30;
        int death = -1;

        private string lvlNumberToString(int lvlNumber)
        {
            return "level" + lvlNumber + ".txt"; ;
        }

        public GameForm(int level)
        {
            InitializeComponent();
            moveQueue = new Queue<Tuple<int, int>>();
            resources = new Dictionary<int, Bitmap>();
            toolboxState = new List<Tuple<int, int>>();

            score = 0;
            gameState = 0;
            this.levelNumber = level;
            this.level = lvlNumberToString(this.levelNumber);

            int squareSize = 35;

            // Defining new elements
            Bitmap greySquare = new Bitmap(squareSize, squareSize);
            Graphics g = Graphics.FromImage(greySquare);
            g.Clear(Color.White);

            resources.Add(empty, greySquare); //pusty
            resources.Add(playerIcon, new Bitmap(Resources.overkill, new Size(squareSize, squareSize)));//ludek
            resources.Add(box, new Bitmap(Resources.wooden_crate, new Size(squareSize, squareSize))); //skrzynka
            resources.Add(final, new Bitmap(Resources.checkered_flag, new Size(squareSize, squareSize))); //flaga
            resources.Add(burger, new Bitmap(Resources.hamburger, new Size(squareSize, squareSize))); //burgar
            resources.Add(trap, new Bitmap(Resources.unlit_bomb, new Size(squareSize, squareSize))); //bomba
            resources.Add(death, new Bitmap(Resources.chewed_skull, new Size(squareSize, squareSize))); //death

            loadLevel(this.level); 
            
        }

        private void gameTimer_tick(object sender, EventArgs e)
        {
            updateGameLogic();
            for(int i = 0; i < stateMatrix.GetLength(0);i++)
                for(int j = 0; j < stateMatrix.GetLength(1);j++)
                    if (stateMatrix[i,j] != lastFrameMatrix[i,j])
                        gameMap.Rows[i].Cells[j].Value = resources[stateMatrix[i,j]];
            Array.Copy(stateMatrix, lastFrameMatrix, stateMatrix.Length);
            for (int i = 0; i<toolboxState.Count; i++)
            {
                toolbox.Rows[i].Cells[0].Value = resources[toolboxState[i].Item1];
                toolbox.Rows[i].Cells[1].Value = toolboxState[i].Item2.ToString();
            }
            textBox1.Text = score.ToString();
        }

        private void loadLevel(string fileName)
        {
            string input = File.ReadAllText(fileName);
            var rows = input.Split('\n');
            stateMatrix = new int[rows.Length, rows[0].Split(' ').Length];
            lastFrameMatrix = new int[stateMatrix.GetLength(0), stateMatrix.GetLength(1)];
            Array.Copy(stateMatrix, lastFrameMatrix, stateMatrix.Length);
            int i = 0;
            foreach (var row in rows)
            {
                int j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    var num = int.Parse(col.Trim());
                    if (num == 0)
                        playerPosition = new Tuple<int, int>(i, j);
                    stateMatrix[i, j] = num;
                    j++;
                }
                i++;
            }
            
            toolboxState = new List<Tuple<int, int>>();

            if (levelNumber == 1)
                toolboxState.Add(new Tuple<int, int>(2, 6));

            else if (levelNumber == 2)
            {
                toolboxState.Add(new Tuple<int, int>(2, 10));
            }
            else if (levelNumber == 3)
            {
                toolboxState.Add(new Tuple<int, int>(2, 16));
                toolboxState.Add(new Tuple<int, int>(5, 1));
            }

            playButton.Enabled = true;
        }
        private void initialize(object sender, EventArgs e)
        {
            gameMap.ColumnHeadersVisible = false;
            gameMap.RowHeadersVisible = false;
            gameMap.AllowUserToResizeRows = false;
            gameMap.AllowUserToResizeColumns = false;
            gameMap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            gameMap.AutoSizeRowsMode= DataGridViewAutoSizeRowsMode.DisplayedCells;
            gameMap.ClearSelection();

            for (int i = 0; i < stateMatrix.GetLength(1); i++)
                gameMap.Columns.Add(new DataGridViewImageColumn());
            for (int i = 0; i < stateMatrix.GetLength(0); i++)
                gameMap.Rows.Add();
            for (int i = 0; i < stateMatrix.GetLength(0); i++)
                for (int j = 0; j < stateMatrix.GetLength(1); j++)
                    gameMap.Rows[i].Cells[j].Value = resources[stateMatrix[i, j]];

            toolbox.ColumnHeadersVisible = false;
            toolbox.RowHeadersVisible = false;
            toolbox.AllowUserToResizeRows = false;
            toolbox.AllowUserToResizeColumns = false;
            toolbox.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            toolbox.AutoSizeRowsMode= DataGridViewAutoSizeRowsMode.DisplayedCells;
            toolbox.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            toolbox.ClearSelection();

            toolbox.Columns.Add(new DataGridViewImageColumn());
            toolbox.Columns.Add(new DataGridViewTextBoxColumn());
            toolbox.Columns[1].DefaultCellStyle.Font = new Font("Times New Roman", 15);
            toolbox.Columns[1].DefaultCellStyle.BackColor = Color.DarkGray;


            for (int i = 1; i<toolboxState.Count; i++)
                toolbox.Rows.Add();
            for(int i = 0; i<toolboxState.Count; i++)
            {
                toolbox.Rows[i].Cells[0].Value = resources[toolboxState[i].Item1];
                toolbox.Rows[i].Cells[1].Value = toolboxState[i].Item2.ToString();
            }
        }
        private void updateGameLogic()
        {
            if(gameState == 1)
            {
                if (moveQueue == null || moveQueue.Count == 0)
                {
                    if (findEnd(final) == null)
                        gameState = 2;
                    else gameState = 0;
                }
                else
                {
                    stateMatrix[playerPosition.Item1, playerPosition.Item2] = empty;
                    var nextPos = moveQueue.Dequeue();
                    if (stateMatrix[nextPos.Item1, nextPos.Item2] == trap) // if got into the bomb
                    {
                        stateMatrix[nextPos.Item1, nextPos.Item2] = death;
                        gameState = 3;
                        return;
                    }
                    stateMatrix[nextPos.Item1, nextPos.Item2] = playerIcon;
                    playerPosition = nextPos;
                    score += 10;
                }
            }
            if(gameState == 2) // wygrana
            {
                gameState = 0;
                if (levelNumber == 3) // ostatni poziom
                {
                    MessageBox.Show("Gratulacje! Udało Ci się przejść całą grę!",
                        "Wygrana", MessageBoxButtons.OK);
                    this.Close();
                    return;
                } else
                {
                    DialogResult dr = MessageBox.Show("Wow wygrałeś dobra robota brachu, zdobyłeś " + score + " punktów. \n\n" +
                            "Hasło do kolejnego poziomu to : " + passwords[levelNumber - 1] +
                             "\n\nChcesz zagrać w kolejny poziom?",
                                "Wygrana", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        this.Close();
                        this.Hide();
                        Form gameForm = new GameForm(levelNumber + 1);
                        gameForm.ShowDialog();
                    }
                    else if (dr == DialogResult.No)
                    {
                        this.Close();
                        return;
                    }
                }

            }
            if(gameState == 3) // Game over
            {
                gameState = 0;
                MessageBox.Show("Game over! Spróbuj ponownie.", 
                    "Game over", MessageBoxButtons.OK);
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Tuple<int, int> currentPosition = playerPosition;
            Queue<Tuple<int, int>> queueToBurger = new Queue<Tuple<int, int>>();
            if (ifBurger())
            {
                queueToBurger = LeeAlgorithm.getTheShortestPath(stateMatrix, playerPosition, findEnd(burger));
                if(queueToBurger == null)
                {
                    gameState = 3;
                    return;
                }
                currentPosition = findEnd(burger);
            } 
            else
            {
                queueToBurger = null;
            }
            Queue<Tuple<int, int>> queueToFinal = LeeAlgorithm.getTheShortestPath(stateMatrix, currentPosition, findEnd(final));
            moveQueue = mergeQueues(queueToBurger, queueToFinal);
            if (moveQueue == null)
            {
                gameState = 3;
                return;
            }
            gameState = 1;
            playButton.Enabled = false;
        }
        private Queue<Tuple<int, int>> mergeQueues(Queue<Tuple<int, int>> queue1, Queue<Tuple<int, int>> queue2)
        {
            if(queue1 == null)
            {
                if (queue2 == null)
                {
                    return null;
                }
                queue2.Dequeue();
                return queue2;
            }

            Queue<Tuple<int, int>> result = new Queue<Tuple<int, int>>();

            queue1.Dequeue();
            queue2.Dequeue();

            while(queue1.Count > 0)
                result.Enqueue(queue1.Dequeue());

            while (queue2.Count > 0)
                result.Enqueue(queue2.Dequeue());

            return result;
        }
        private bool ifBurger()
        {
            for (int i = 0; i < stateMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < stateMatrix.GetLength(1); j++)
                {
                    if (stateMatrix[i, j] == 5)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private Tuple<int, int> findEnd(int number)
        {
            for(int i = 0;i<stateMatrix.GetLength(0);i++)
            {
                for(int j = 0;j<stateMatrix.GetLength(1);j++)
                {
                    if (stateMatrix[i,j] == number)
                    {
                        return new Tuple<int, int>(i,j);
                    }
                }
            }
            return null;
        }

        private void gameMap_SelectionChanged(object sender, EventArgs e)
        {
            gameMap.ClearSelection();
        }

        private void gameMap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (toolbox.SelectedRows.Count > 0 && gameState == 0)
            {
                int index = toolbox.SelectedRows[0].Index;
                int avail = toolboxState[index].Item2;
                if (avail > 0)
                {
                    int x = e.RowIndex;
                    int y = e.ColumnIndex;
                    int sel = toolboxState[index].Item1;
                    if (stateMatrix[x, y] == 1)
                        stateMatrix[x, y] = sel;
                    toolboxState[index] = new Tuple<int, int>(sel,avail-1);
                }
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            gameState = 0;
            loadLevel(level);
            score = 0;

            for (int i = 0; i < stateMatrix.GetLength(0); i++)
                for (int j = 0; j < stateMatrix.GetLength(1); j++)
                    gameMap.Rows[i].Cells[j].Value = resources[stateMatrix[i, j]];
        }

        private void chooseLevelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form openingForm = new OpeningForm();
            openingForm.ShowDialog();
            openingForm = null;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
