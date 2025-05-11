using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SapperMini
{
    public partial class FormGeneral : Form
    {
        public FormGeneral()
        {
            InitializeComponent();
        }

        private static int ButtonSize = 25;

        private static int FieldWidth;
        private static int FieldHeight;

        private int bombNumber;
        private int flagNumber;
        private int progressCounter;

        private SpecialButton[,] interactionButtonArray = new SpecialButton[200, 200];

        private Random     random     = new Random();
        private Difficulty difficulty = new Difficulty();
        private DateTime   timer      = new DateTime();

        private void FormGeneral_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
                for (int j = 0; j < 30; j++)
                {
                    SpecialButton button = new SpecialButton()
                    {
                        X = i,
                        Y = j,
                        Width  = ButtonSize,
                        Height = ButtonSize,
                        Location = new Point(i * ButtonSize, j * ButtonSize),

                        Filling  = InButtonObjects.Empty,
                        Coverage = OnButtonObjects.AnInteractable,
                    };

                    button.Click += (s, a) =>
                    {
                        if (button.Coverage == OnButtonObjects.Interactable)
                        {
                            if (button.Filling == InButtonObjects.Empty)
                            {
                                button.Coverage = OnButtonObjects.Activated;
                                progressCounter++;

                                button.Text = button.Number > 0 ? button.Number.ToString() : "";
                                button.ForeColor = ChoiceFontColor(button.Text);
                                button.BackColor = buttonsPresedColor;

                                if (button.Number == 0)
                                    for (int k = -1; k < 2; k++)
                                        for (int l = -1; l < 2; l++)
                                            if ((button.X + k >= 0
                                                && button.X + k < FieldWidth)
                                                && (button.Y + l >= 0
                                                && button.Y + l < FieldHeight)
                                                && !(k == 0 && l == 0))
                                                interactionButtonArray[button.X + k, button.Y + l].PerformClick();

                                if (progressCounter == FieldWidth * FieldHeight - bombNumber) Victory();
                            }
                            else if (button.Filling == InButtonObjects.Bomb)
                            {
                                Defeat();
                            }
                        }
                        else if (button.Coverage == OnButtonObjects.AnInteractable)
                        {
                            BombMap_Load(button.X, button.Y);
                            timerForTimer.Start();
                            button.PerformClick();
                        }
                    };

                    button.MouseDown += (s, a) =>
                    {
                        if (a.Button == MouseButtons.Right)
                        {
                            if (button.Coverage == OnButtonObjects.Interactable && flagNumber > 0)
                            {
                                button.ForeColor = specialMarkFontColor;
                                flagNumber--;
                                button.Text = "⚑";
                                button.BackColor = flagButtonColor;
                                button.Coverage = OnButtonObjects.Flag;
                            }
                            else if (button.Coverage == OnButtonObjects.Flag)
                            {
                                button.ForeColor = specialMarkFontColor;
                                flagNumber++;
                                button.Text = "?";
                                button.BackColor = questionButtonColor;
                                button.Coverage = OnButtonObjects.Question;
                            }
                            else if (button.Coverage == OnButtonObjects.Question)
                            {
                                button.Text = "";
                                button.BackColor = Color.White;
                                button.Coverage = OnButtonObjects.Interactable;
                            }
                            labelFlagsCount.Text = flagNumber.ToString();
                        }
                    };

                    interactionButtonArray[i, j] = button;
                    panelField.Controls.Add(interactionButtonArray[i, j]);
                }

            difficulty.SetEasy();
            SetLightTheme(); //Instead Start()
        }

        private void Field_Load()
        {
            panelField.Width  = FieldWidth  * ButtonSize;
            panelField.Height = FieldHeight * ButtonSize;

            panelInfo.Location = new Point (panelField.Width/2-panelInfo.Width/2+10, panelField.Location.Y + panelField.Height + 5);


            this.Width = 20 + panelField.Width + 20;
            this.Height = 24 + 20 + groupBoxControlers.Height + 10 + panelField.Height + 10 + panelInfo.Height + 20;
        }
        
        private void BombMap_Load(int theFirstButtonX, int theFirstButtonY)
        {
            int x = random.Next(0, FieldWidth), y = random.Next(0, FieldHeight);
            for (int i = 0; i < bombNumber; i++)
            {
                while (interactionButtonArray[x, y].Filling == InButtonObjects.Bomb || ((x >= theFirstButtonX - 1 && x <= theFirstButtonX + 1) && (y >= theFirstButtonY - 1 && y <= theFirstButtonY + 1)))
                {
                    x = random.Next(0, FieldWidth);
                    y = random.Next(0, FieldHeight);
                }
                interactionButtonArray[x, y].Filling = InButtonObjects.Bomb;

                for (int k = -1; k < 2; k++)
                    for (int l = -1; l < 2; l++)
                        if (x + k >= 0
                            && x + k < FieldWidth
                            && y + l >= 0
                            && y + l < FieldHeight)
                            interactionButtonArray[x + k, y + l].Number++;
            }
            for (int i = 0; i < FieldWidth; i++)
                for (int j = 0; j < FieldHeight; j++)
                    interactionButtonArray[i, j].Coverage = OnButtonObjects.Interactable;
        }
        private void Start()
        {
            timerForTimer.Stop();
            
            FieldWidth  = difficulty.Widht;
            FieldHeight = difficulty.Height;
            bombNumber  = difficulty.Bombs;
            flagNumber  = bombNumber;

            progressCounter = 0;

            labelFlagsCount.Text = flagNumber.ToString();
            timer = new DateTime();
            labelTimer.Text = timer.TimeOfDay.ToString();

            for (int i = 0; i < FieldWidth; i++)
                for (int j = 0; j < FieldHeight; j++)
                {
                    interactionButtonArray[i, j].BackColor = Color.White;
                    interactionButtonArray[i, j].Font = buttonFont;
                    interactionButtonArray[i, j].Text = "";
                    interactionButtonArray[i, j].Number = 0;
                    interactionButtonArray[i, j].Filling = InButtonObjects.Empty;
                    interactionButtonArray[i, j].Coverage = OnButtonObjects.AnInteractable;
                    interactionButtonArray[i, j].Enabled = true;
                }

            Field_Load();
        }

        private void Victory()
        {
            if (interactionButtonArray[0, 0].Enabled == true)
            {
                for (int i = 0; i < FieldWidth; i++)
                    for (int j = 0; j < FieldHeight; j++)
                    {
                        if (interactionButtonArray[i, j].Coverage == OnButtonObjects.Flag)
                            interactionButtonArray[i, j].BackColor = Color.FromArgb(210, 210, 210);
                        interactionButtonArray[i, j].Enabled = false;
                    }
                timerForTimer.Stop();
                DataSave();
                MessageBox.Show("Ты победил!");
            }
        }

        private void DataSave()
        {
            switch (difficulty.Type)
            {
                case Difficulty.TypeOfDifficulty.Easy:
                    Properties.Settings.Default.SmallTimeRecord = Math.Min( timer.Second + timer.Minute * 60 + timer.Hour * 3600, Properties.Settings.Default.SmallTimeRecord );
                    break;
                case Difficulty.TypeOfDifficulty.Medium:
                    Properties.Settings.Default.MediumTimeRecord = Math.Min(timer.Second + timer.Minute * 60 + timer.Hour * 3600, Properties.Settings.Default.MediumTimeRecord);
                    break;
                case Difficulty.TypeOfDifficulty.Hard:
                    Properties.Settings.Default.LargeTimeRecord = Math.Min(timer.Second + timer.Minute * 60 + timer.Hour * 3600, Properties.Settings.Default.LargeTimeRecord);
                    break;
                case Difficulty.TypeOfDifficulty.Veryhard:
                    Properties.Settings.Default.HugeTimeRecord = Math.Min(timer.Second + timer.Minute * 60 + timer.Hour * 3600, Properties.Settings.Default.HugeTimeRecord);
                    break;
                case Difficulty.TypeOfDifficulty.Nightmare:
                    Properties.Settings.Default.NightmareTimeRecord = Math.Min(timer.Second + timer.Minute * 60 + timer.Hour * 3600, Properties.Settings.Default.NightmareTimeRecord);
                    break;
            }
            
            Properties.Settings.Default.Save();
        } 

        private void Defeat()
        {
            for (int i = 0; i < FieldWidth; i++)
                for (int j = 0; j < FieldHeight; j++)
                {
                    if (interactionButtonArray[i, j].Coverage == OnButtonObjects.Flag || interactionButtonArray[i, j].Coverage == OnButtonObjects.Question)
                        interactionButtonArray[i, j].BackColor = Color.FromArgb(210, 210, 210);
                    if (interactionButtonArray[i, j].Filling == InButtonObjects.Bomb)
                    {
                        interactionButtonArray[i, j].Text = "⛯";
                        interactionButtonArray[i, j].BackColor = Color.DarkGray;
                    }
                    interactionButtonArray[i, j].Enabled = false;
                }
            timerForTimer.Stop();
            MessageBox.Show("Ты проиграл");
        }
        
        private Color ChoiceFontColor(string numb)
        {
            if (isDark)
                return Color.DarkBlue;
            else switch (numb)
            {
            case ("1"): return Color.Blue;
            case ("2"): return Color.Green;
            case ("3"): return Color.Red;
            case ("4"): return Color.DarkBlue;
            case ("5"): return Color.Pink;
            case ("6"): return Color.Brown;
            case ("7"): return Color.Black;
            case ("8"): return Color.Gold;
            }
            return Color.Black;
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private int timerIteration = 1;
        private void timerForTimer_Tick(object sender, EventArgs e)
        {
            timer = timer.AddSeconds(timerIteration);
            labelTimer.Text = timer.TimeOfDay.ToString();
        }

        private void anyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem s = (ToolStripMenuItem)sender;
            switch (s.Tag)
            {
                case "1": difficulty.SetEasy();      break;
                case "2": difficulty.SetMedium();    break;
                case "3": difficulty.SetHard();      break;
                case "4": difficulty.SetVeryhard();  break;
                case "5": difficulty.SetNightmare(); break;
            }
            Start();
        }

        private void buttonScores_Click(object sender, EventArgs e)
        {
            timerIteration = 0;
            string SR = $"\r\nSmall:      " + (Properties.Settings.Default.SmallTimeRecord % 100000).ToString() +" sec";
            string MR = $"\r\nMedium: " + (Properties.Settings.Default.MediumTimeRecord % 100000).ToString() +" sec";
            string LR = $"\r\nLarge:      " + (Properties.Settings.Default.LargeTimeRecord % 100000).ToString() +" sec";
            string HR = $"\r\nHuge:      " + (Properties.Settings.Default.HugeTimeRecord % 100000).ToString() +" sec";
            string NR = $"\r\nNightmare: " + (Properties.Settings.Default.NightmareTimeRecord % 100000).ToString() +" sec";
            MessageBox.Show("Field/TheBestTime"+ SR + MR + LR + HR + NR, "Records!");
            timerIteration = 1;
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomCreate customCreate = new FormCustomCreate();
            timerIteration = 0;
            DialogResult result = customCreate.ShowDialog();
            if (result == DialogResult.OK)
            {
                difficulty.SetCustom(Convert.ToInt16(customCreate.numericUpDownBombs.Value), Convert.ToInt16(customCreate.numericUpDownWidth.Value), Convert.ToInt16(customCreate.numericUpDownHeight.Value)); 
                Start();
            }
            timerIteration = 1;
        }

        private Color primaryColor;
        private Color secondaryColor;
        private Color buttonsColor;
        private Color buttonsPresedColor;
        private Color flagButtonColor;
        private Color questionButtonColor;
        private Color fontColor;
        private Color specialMarkFontColor;

        private Font generalFont;
        private Font auxiliaryFont;
        private Font buttonFont;

        private void SetDarkTheme()
        {
            primaryColor = Color.DarkBlue;
            secondaryColor = Color.MediumBlue;
            buttonsColor = Color.Coral;
            buttonsPresedColor = Color.FromArgb(220, 220, 220);
            flagButtonColor = Color.DarkBlue;
            questionButtonColor = Color.Blue;
            fontColor          = Color.White;
            specialMarkFontColor = Color.White;

            generalFont = new Font(new FontFamily("Georgia"), 20);
            auxiliaryFont = new Font(new FontFamily("Georgia"), 8);
            buttonFont = new Font(new FontFamily("SimSun"), ButtonSize / 2f, FontStyle.Bold);

            ThemeColors_Load();

        }
        private void SetLightTheme()
        {
            primaryColor = Color.White;
            secondaryColor = SystemColors.Control;
            buttonsColor = Color.White;
            buttonsPresedColor = Color.FromArgb(230, 230, 230);
            flagButtonColor = Color.DarkOrange;
            questionButtonColor = Color.DarkGray;
            fontColor = Color.Black;
            specialMarkFontColor = Color.Black;

            generalFont = new Font(new FontFamily("SimSun"), 24, FontStyle.Bold);
            auxiliaryFont = new Font(new FontFamily("Microsoft Sans Serif"), 8);
            buttonFont = new Font(new FontFamily("SimSun"), ButtonSize / 2f, FontStyle.Bold);

            ThemeColors_Load();
        }

        public delegate void ColorSettings();
        private void ThemeColors_Load()
        {
            this.BackColor = primaryColor;

            buttonRestart.BackColor = buttonsColor;
            buttonRestart.ForeColor = fontColor;
            buttonRestart.Font = generalFont;

            buttonScores.Font = generalFont;

            buttonScores.BackColor = buttonsColor;
            buttonScores.ForeColor = fontColor;

            labelTimerInfo.ForeColor = fontColor;
            labelTimerInfo.Font = auxiliaryFont;

            labelTimer.ForeColor = fontColor;
            //labelTimer.Font = auxiliaryFont;

            labelFlagsInfo.ForeColor = fontColor;
            labelFlagsInfo.Font = auxiliaryFont;

            labelFlagsCount.ForeColor = fontColor;
            //labelFlagsCount.Font = auxiliaryFont;

            groupBoxControlers.ForeColor = fontColor;
            groupBoxControlers.Font = auxiliaryFont;

            panelField.BackColor = primaryColor;

            menuStrip1.BackColor = secondaryColor;
            menuStrip1.ForeColor = fontColor;

            Start();
        }

        private bool isDark = false;
        private void switchThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.Cancel;
            if (interactionButtonArray[0, 0].Coverage != OnButtonObjects.AnInteractable)
            {
                result = MessageBox.Show("Данное действие перезапустит игру. \r\nВы можете потерять свой прогресс.", "Внимание!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    if (isDark) SetLightTheme();
                    else SetDarkTheme();
                    isDark = !isDark;
                }
            }
            else
            {
                if (isDark) SetLightTheme();
                else SetDarkTheme();
                isDark = !isDark;
            }
        }

        private void howPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ЛКМ: Открыть ячейку \r\nПКМ: Пометить ячейку флагом/вопросом \r\n\n\rЦифра на открытой ячейке сообщает сколько ячеек с миной соседствует с ней. Нажав на мину вы проиграете. Открыв все ячейки - выиграете.", "Правила");
        }

        private void aboutProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия: 2.2.0 \r\nby Liar", "SapperMini: Сведения");
        }
    }

    public class Difficulty
    {
        public enum TypeOfDifficulty { Easy, Medium, Hard, Veryhard, Nightmare, Custom}

        int _bombs;
        int _widht;
        int _height;
        TypeOfDifficulty _setting;
        public void SetEasy()
        {
            _bombs   = 8;
            _widht   = 8;
            _height  = 8;
            _setting = TypeOfDifficulty.Easy;
        }
        public void SetMedium()
        {
            _bombs   = 16;
            _widht   = 16;
            _height  = 8;
            _setting = TypeOfDifficulty.Medium;
        }
        public void SetHard()
        {
            _bombs   = 42;
            _widht   = 16;
            _height  = 16;
            _setting = TypeOfDifficulty.Hard;
        }
        public void SetVeryhard()
        {
            _bombs   = 72;
            _widht   = 30;
            _height  = 16;
            _setting = TypeOfDifficulty.Veryhard;
        }
        public void SetNightmare()
        {
            _bombs   = 135;
            _widht   = 30;
            _height  = 30;
            _setting = TypeOfDifficulty.Nightmare;
        }
        public void SetCustom(int b, int w, int h)
        {
            _bombs   = b;
            _widht   = w;
            _height  = h;
            _setting = TypeOfDifficulty.Custom;
        }

        public int Bombs
        {
            get => _bombs;
            set => _bombs = value;
        }
        public int Widht
        {
            get => _widht;
            set => _widht = value;
        }
        public int Height
        {
            get => _height;
            set => _height = value;
        }
        public TypeOfDifficulty Type
        {
            get => _setting;
        }

    }

}
