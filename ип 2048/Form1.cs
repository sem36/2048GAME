using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ип_2048
{
    public partial class fMain : Form
    {
        int WH = 0, RowCount = 0, ColCount = 0, x = 0, y = 0, Record = 0, Schet = 0;
        Random rnd = new Random();//переменная для генерации чисел
        //масив меток
        Label[,] mas;
        //функция вывода информации о текущем счёте и рекорде
        private void UpdateSchet()
        {
            //вывод данных в метку
            ISchet.Text = Schet.ToString();
            //если это новый рекорд то выводим в рекорд
            if (Schet > Record)
            {
                Record = Schet;
                IRecord.Text = Record.ToString();

            }
        }
        //Сохраняем настройки в файл settinsgs.txt
        private void SaveSettings()
        {
            StreamWriter sw = null;
            try
            {
                //новый файл с настройками
                sw = File.CreateText(Application.StartupPath + "\\settinsgs.txt");
                //записываем в файл существующие данные
                sw.WriteLine(WH.ToString());//размер клетки
                sw.WriteLine(RowCount.ToString());//количесво строк
                sw.WriteLine(ColCount.ToString());//количесво столбиков
                sw.WriteLine(x.ToString());//отступ по х
                sw.WriteLine(y.ToString());//отсутп по у
                sw.WriteLine(Record.ToString());//рекорд           
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения настроек", "Носитель не поддерживает операцию записи данных");
            }
            finally
            {
                sw.Close();
            }

        }

        //чтение настроек из файла settinsgs.txt
        private void LoadSettings()
        {
            StreamReader sr = null;
            try
            {
                //открытие файла
                sr = File.OpenText(Application.StartupPath + "\\settinsgs.txt");
                //чтение данных
                string s;
                s = sr.ReadLine();//размер клетки
                WH = Convert.ToInt32(s);
                s = sr.ReadLine();//количесво строк
                RowCount = Convert.ToInt32(s);
                s = sr.ReadLine();//количесво столбиков
                ColCount = Convert.ToInt32(s);
                s = sr.ReadLine();//отступ по х
                x = Convert.ToInt32(s);
                s = sr.ReadLine();//отсутп по у
                y = Convert.ToInt32(s);
                s = sr.ReadLine();//рекорд    
                Record = Convert.ToInt32(s);
            }
            catch
            {
                WH = 80;
                RowCount = 4;
                ColCount = 4;
                x = 10;
                y = 10;
                Record = 0;
                if (MessageBox.Show("Ошибка чтения данных", "ВЫ хотите записать данные по умолчанию", MessageBoxButtons.YesNo) == DialogResult.OK)
                    SaveSettings();
            }
            finally
            {
                sr.Close();
            }
        }

        private void SetColorElement(Label Kv)
        {
            int d = Convert.ToInt32(Kv.Text);
            Color TextColor, BackColor;
            switch (d)
            {
                case 2:
                    TextColor = Color.Blue;
                    BackColor = Color.DeepSkyBlue;
                    break;
                case 4:
                    TextColor = Color.Yellow;
                    BackColor = Color.Chocolate;
                    break;
                case 8:
                    TextColor = Color.Black;
                    BackColor = Color.Orange;
                    break;
                case 16:
                    TextColor = Color.Black;
                    BackColor = Color.Gold;
                    break;
                case 32:
                    TextColor = Color.Black;
                    BackColor = Color.GreenYellow;
                    break;
                case 64:
                    TextColor = Color.Black;
                    BackColor = Color.MediumSpringGreen;
                    break;
                case 128:
                    TextColor = Color.Black;
                    BackColor = Color.Cyan;
                    break;
                case 256:
                    TextColor = Color.Navy;
                    BackColor = Color.DeepSkyBlue;
                    break;
                case 512:
                    TextColor = Color.Yellow;
                    BackColor = Color.Blue;
                    break;
                case 1024:
                    TextColor = Color.LightSkyBlue;
                    BackColor = Color.BlueViolet;
                    break;
                case 2048:
                    TextColor = Color.Black;
                    BackColor = Color.Violet;
                    break;
                case 4096:
                    TextColor = Color.White;
                    BackColor = Color.Magenta;
                    break;
                case 8192:
                    TextColor = Color.DarkRed;
                    BackColor = Color.Pink;
                    break;
                default:
                    TextColor = Color.DarkRed;
                    BackColor = Color.LavenderBlush;
                    break;
            }
            Kv.BackColor = BackColor;
            Kv.ForeColor = ForeColor;

        }

        //обработчик события создания формы
        private void fMain_Load(object sender, EventArgs e)
        {
            //проверяем: если существует файл с настройками, то читаем из него данные
            if (File.Exists(Application.StartupPath + "\\settings.txt")) LoadSettings();
            else
            {
                //если файла с настройками не существуетто задаем настройки по умолчанию
                WH = 80;
                RowCount = 4;
                ColCount = 4;
                x = 10;
                y = 10;
                Record = 0;
                SaveSettings();//метод сохранения настроек в файле
            }
            // память под массив квадратиков
            mas = new Label[8, 8];
            NewGame();

        }

        private void MainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //добовляем новый элемент в котором к-количество пустых клеток
        private void AddElement(int k)
        {
            int i, j;
            //если есть пустые клетки 
            if (k > 0)
            {
                //случайно определяем (n-номер клетки) в которую будет добавлен новый квадратик
                int n = rnd.Next(k) + 1;
                //выбираем  a=2 c шансом 90%  и а=4 с шансом 10%
                int a;
                if (Math.Abs(rnd.Next(-5, 5)) / 10 < 0.9) a = 2; else a = 4;
                //отсчет от начала поля n клетку и поместим в неё квадратик
                k = 0;//в начале к=0
                //перебирвем клетки пока не  найдём до клетки n
                i = 0;
                bool f = true;
                while (i < RowCount && f)
                {
                    j = 0;
                    while (j < ColCount && f)
                    {
                        //если клетка пустая то К увеличиваем на 1
                        if (mas[i, j] == null) k++;
                        //если достигли клетки с номером n то помещаем в неё квадратик
                        if (k == n)
                        {
                            mas[i, j] = new Label();//новая клетка
                            mas[i, j].AutoSize = false;//выключаем авто изменение размеров
                            mas[i, j].Font = new Font("Times New Roman", 16, FontStyle.Bold);
                            mas[i, j].Text = a.ToString();//помещаем случайное выбраное число (2или4)
                            mas[i, j].Width = WH;//высота
                            mas[i, j].Height = WH;//ширина
                            mas[i, j].TextAlign = ContentAlignment.MiddleCenter;//выравнивание текста в клетке по центру
                            //помещаем клетку вс координатами i,j
                            mas[i, j].Left = j * (WH + 1) + 1;
                            mas[i, j].Top = i * (WH + 1) + 1;
                            //определяем цвет клетки
                            SetColorElement(mas[i, j]);
                            pPole.Controls.Add(mas[i, j]);//добовляем клетку на панель pPole
                        }
                        j++;
                    }
                    i++;
                }
            }
        }
        void NewGame()
        {
            //Устанавливаем отступы слева и сверху для игрового поля
            pPole.Left = x;
            pPole.Top = mainMenu.Height + y;
            //Устанавливаем ширину и высоту игрового поля
            pPole.Width = (WH + 1) * ColCount + 1;
            pPole.Height = (WH + 1) * RowCount + 1;
            //устанавливаем ширину и высоту формы
            //определяем толщину границы формы по горизонтали
            int BorderWidth = this.Width - this.ClientSize.Width;
            //устанавливаем ширину формы с учетом границы по горизонтали
            this.Width = pPole.Width + 2 * x + BorderWidth;
            //определяем толщину границы формы по вертикали
            int BorderHeiht = this.Height - this.ClientSize.Height + 4;
            //устанавливаем высоту формы с учетом границы по вертикали
            this.Height = mainMenu.Height + pPole.Height + (2 * y) + 20 + label1.Height + ISchet.Height + BorderHeiht;
            //надпись Счет располагаем под игровым полем слева
            label1.Top = pPole.Top + pPole.Height + 10;
            label1.Left = pPole.Left + 10;
            //метку, в которую выводится текущий счет располагаем под
            //надписью Счет
            ISchet.Top = label1.Top + label1.Height + 10;
            ISchet.Left = label1.Left;
            //надпись Рекорд располагаем под игровым полем от центра9
            label2.Top = pPole.Top + pPole.Height + 10;
            label2.Left = pPole.Left + pPole.Width / 2;
            //метку в которую выводится текущий рекорд располагаем под надписью рекорд
            IRecord.Top = label2.Top + label2.Height + 10;
            IRecord.Left = label2.Left;
            //вызывае функцию очистки массива
            ClearMas();
            //Обнуляется счет
            Schet = 0;
            //обновляются надписи на экране
            UpdateSchet();
            // добавляем первый элемент
            AddElement(RowCount * ColCount);
            // добавляем второй элемент
            AddElement(RowCount * ColCount - 1);
        }

        private void mmAbout_Click(object sender, EventArgs e)
        {

        }

        private void mmGame_Click(object sender, EventArgs e)
        {

        }

        private void mmSettings_Click(object sender, EventArgs e)
        {

        }

        private void mmNewGame_Click(object sender, EventArgs e)
        {

        }

        private void fMain_KeyDown(object sender, KeyEventArgs e)
        {
            //флаг отвечающий за новый элемент
            bool fAdd = false;
            int i, j;
            //координаты в которой были сложены клетки
            int ki = -1, kj = -1;
            //если нажата клавиша Вверх
            if (e.KeyCode == Keys.Up)
            {
                //перебираем ящейки сверху вних
                for (j = 0; j < ColCount; j++)
                    for (i = 1; i < RowCount; i++)
                        if (mas[i, j] != null)
                        {
                            //будем двигать ячейки из строки i вверх
                            int t = i;
                            bool f = true;//переменная отвечает за продолжение движения если f=true, то квадратик не уперся в границу и не дошел до верхне границы
                            do//движение квадратика
                            {
                                if (t > 0)//если стоит не в первой строке
                                {
                                    if (mas[t - 1, j] == null)
                                    {
                                        t = t - 1;//номер уменьшился на 1
                                        mas[t, j] = mas[t + 1, j];//переместить квадратик на одну строку массива
                                        mas[t, j].Top = (WH + 1) * t + 1;//новый отступ сверху
                                        mas[t + 1, j] = null;//из ячейки  сквадратиком перевести ячейку в null
                                        fAdd = true;//переменную, отвечающую за добавление нового элемента в true
                                    }
                                    else f = false;//квадратик "уперся" в препятствие. Остановить движение
                                }
                                else f = false; //квадратик в верхней строке. Остановить движение                        
                            } while (f);//конец цикла движения шара
                            if (t > 0)//Если квадратик остановился не в первой строке если квадратик сверху такой же и сложение в нем выполняется первый раз
                            {
                                if (mas[t - 1, j].Text == mas[t, j].Text && !(ki == t - 1 && kj == j))
                                {
                                    //запомнить координаты клетки в которой будут сложены дыва квадрата
                                    ki = t - 1;
                                    kj = j;
                                    //удвоить  число на квадратике сверху
                                    mas[t - 1, j].Text = (Convert.ToInt32(mas[t - 1, j].Text) * 2).ToString();
                                    SetColorElement(mas[t - 1, j]);//поменять цвет
                                    Schet += Convert.ToInt32(mas[t - 1, j].Text);//увеличить счёт
                                    UpdateSchet();
                                    mas[t, j].Dispose();//умножить квадратик который соединился с верхнем
                                    mas[t, j] = null;//ссылка на уничтоженый квадратик
                                    fAdd = true;//переменную отвечаюую за добовление нового квадратик установить значение true
                                }
                            }
                        }

            }
            if (e.KeyCode == Keys.Down)
            {
                //перебираем ящейки снизу вверх
                for (j = 1; j < ColCount; j++)
                {
                    for (i = RowCount - 1; i >= 0; i--)
                        if (mas[i, j] != null)
                        {
                            //будем двигать ячейки из строки i вверх
                            int t = i;
                            bool f = true;//переменная отвечает за продолжение движения если f=true, то квадратик не уперся в границу и не дошел до верхне границы
                            do//движение квадратика
                            {
                                if (t < RowCount - 1)//если стоит не в последней строке
                                {
                                    if (mas[t + 1, j] == null)
                                    {
                                        t = t + 1;//номер уменьшился на 1
                                        mas[t, j] = mas[t - 1, j];//переместить квадратик на одну строку массива
                                        mas[t, j].Top = (WH + 1) * t + 1;//новый отступ сверху
                                        mas[t - 1, j] = null;//из ячейки  сквадратиком перевести ячейку в null
                                        fAdd = true;//переменную, отвечающую за добавление нового элемента в true
                                    }
                                    else f = false;//квадратик "уперся" в препятствие. Остановить движение
                                }
                                else f = false; //квадратик в нижней строке. Остановить движение
                            } while (f);
                            if (t < RowCount - 1)//Если квадратик остановился не в последней строке если квадратик снизу такой же и сложение в нем выполняется первый раз
                            {
                                if (mas[t + 1, j].Text == mas[t, j].Text && !(ki == t + 1 && kj == j))
                                {
                                    //запомнить координаты клетки в которой будут сложены два квадрата
                                    ki = t + 1;
                                    kj = j;
                                    //удвоить  число на квадратике снизу
                                    mas[t + 1, j].Text = (Convert.ToInt32(mas[t + 1, j].Text) * 2).ToString();
                                    SetColorElement(mas[t + 1, j]);//поменять цвет
                                    Schet += Convert.ToInt32(mas[t + 1, j].Text);//увеличить счёт
                                    UpdateSchet();
                                    mas[t, j].Dispose();//умножить квадратик который соединился с верхнем
                                    mas[t, j] = null;//ссылка на уничтоженый квадратик
                                    fAdd = true;//переменную отвечаюую за добовление нового квадратик установить значение true
                                }
                            }
                        }
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                //перебираем ящейки сверху вних
                for (i = 0; i < ColCount; i++)
                    for (j = 1; j < RowCount; j++)
                        if (mas[i, j] != null)
                        {
                            //будем двигать ячейки из строки i вверх
                            int t = j;
                            bool f = true;//переменная отвечает за продолжение движения если f=true, то квадратик не уперся в границу и не дошел до верхне границы
                            do//движение квадратика
                            {
                                if (t > 0)//если стоит не в первой строке
                                {
                                    if (mas[i, t - 1] == null)
                                    {
                                        t = t - 1;//номер уменьшился на 1
                                        mas[i, t] = mas[i, t + 1];//переместить квадратик на одну строку массива
                                        mas[i, t].Left = (WH + 1) * t + 1;//новый отступ сверху
                                        mas[i, t + 1] = null;//из ячейки  сквадратиком перевести ячейку в null
                                        fAdd = true;//переменную, отвечающую за добавление нового элемента в true
                                    }
                                    else f = false;//квадратик "уперся" в препятствие. Остановить движение
                                }
                                else f = false; //квадратик в верхней строке. Остановить движение                        
                            }
                            while (f);//конец цыкла движения шара
                            if (t > 0)//Если квадратик остановился не в первой строке если квадратик сверху такой же и сложение в нем выполняется первый раз
                            {
                                if (mas[i, t - 1].Text == mas[i, t].Text && !(ki == i && kj == t - 1))
                                {
                                    //запомнить координаты клетки в которой будут сложены дыва квадрата
                                    ki = i;
                                    kj = t - 1;
                                    //удвоить  число на квадратике сверху
                                    mas[i, t - 1].Text = (Convert.ToInt32(mas[i, t - 1].Text) * 2).ToString();
                                    SetColorElement(mas[i, t - 1]);//поменять цвет
                                    Schet += Convert.ToInt32(mas[i, t - 1].Text);//увеличить счёт
                                    UpdateSchet();
                                    mas[i, t].Dispose();//умножить квадратик который соединился с верхнем
                                    mas[i, t] = null;//ссылка на уничтоженый квадратик
                                    fAdd = true;//переменную отвечаюую за добовление нового квадратик установить значение true
                                }
                            }
                        }
            }
            if (e.KeyCode == Keys.Right)
            {
                //перебираем ящейки снизу вверх
                for (i = 0; i < RowCount; i++)
                {
                    for (j = ColCount - 1; j >= 0; j--)
                        if (mas[i, j] != null)
                        {
                            //будем двигать ячейки из строки i вверх
                            int t = j;
                            bool f = true;//переменная отвечает за продолжение движения если f=true, то квадратик не уперся в границу и не дошел до верхне границы
                            do//движение квадратика
                            {
                                if (t < ColCount - 1)//если стоит не в первой строке
                                {
                                    if (mas[i, t + 1] == null)
                                    {
                                        t = t + 1;//номер уменьшился на 1
                                        mas[i, t] = mas[i, t - 1];//переместить квадратик на одну строку массива
                                        mas[i, t].Left = (WH + 1) * t + 1;//новый отступ сверху
                                        mas[i, t - 1] = null;//из ячейки  сквадратиком перевести ячейку в null
                                        fAdd = true;//переменную, отвечающую за добавление нового элемента в true
                                    }
                                    else f = false;//квадратик "уперся" в препятствие. Остановить движение
                                }
                                else f = false; //квадратик в верхней строке. Остановить движение
                            }
                            while (f);
                            if (t < ColCount - 1)//Если квадратик остановился не в первой строке если квадратик сверху такой же и сложение в нем выполняется первый раз
                            {
                                if (mas[i, t + 1].Text == mas[i, t].Text && !(ki == i && kj == t + 1))
                                {
                                    //запомнить координаты клетки в которой будут сложены дыва квадрата
                                    ki = i;
                                    kj = t + 1;
                                    //удвоить  число на квадратике сверху
                                    mas[i, t + 1].Text = (Convert.ToInt32(mas[i, t + 1].Text) * 2).ToString();
                                    SetColorElement(mas[i, t + 1]);//поменять цвет
                                    Schet += Convert.ToInt32(mas[i, t + 1].Text);//увеличить счёт
                                    UpdateSchet();
                                    mas[i, t].Dispose();//умножить квадратик который соединился с верхнем
                                    mas[i, t] = null;//ссылка на уничтоженый квадратик
                                    fAdd = true;//переменную отвечаюую за добовление нового квадратик установить значение true
                                }
                            }
                        }
                }
                
                //вызываем функцыю проверки игры
                Checkings(fAdd);
            }

        }

        private void mmExit_Click(object sender, EventArgs e)
        {

        }

        private void ClearMas()
        {
            //throw new NotImplementedException();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //прорисовка игрового поля 
            Graphics g = pPole.CreateGraphics();
            //заливаем (очищаем) поверхность g выбраным цветом
            g.Clear(Color.AntiqueWhite);
            //создаем новое перо и устанавиливаем цвет пера
            Pen p = new Pen(Color.Black);
            //вокруг игрового поля рисуем рамку
            g.DrawRectangle(p, 0, 0, pPole.Width - 1, pPole.Height - 1);
            //рисуем на игровом поле линии по горизонтале
            int i;
            for (i = 1; i <= RowCount; i++)
            {
                //pt1 точка из которой выходит линия
                //pt2 точка в которую приходит линия
                Point pt1, pt2;
                //определяем координаты точек
                pt1 = new Point(0, i * (WH + 1));
                pt2 = new Point(pPole.Width - 1, i * (WH + 1));
                g.DrawLine(p, pt1, pt2);//рисуем линию по координатам
            }
            //линии на игровом поле вертикально (аналагично)
            for (i = 1; i <= ColCount; i++)
            {
                //pt1 точка из которой выходит линия
                //pt2 точка в которую приходит линия
                Point pt1, pt2;
                //определяем координаты точек
                pt1 = new Point(i * (WH + 1), 0);
                pt2 = new Point(i * (WH + 1), pPole.Height - 1);
                g.DrawLine(p, pt1, pt2);//рисуем линию по координатам
            }
        }

        public fMain()
        {
            InitializeComponent();
        }

        private void Checkings(bool f)
        {
            //считаем количество клеток
            // k -коглличество,   i,j-вспомогательные переменные
            int k = 0, i, j;
            // считаем колличесво пустых
            for (i = 0; i < RowCount; i++)
                for (j = 0; j < ColCount; j++)
                    if (mas[i, j] == null) k++;
            //если был ход и в игровом поле есть пустые клетки ,то
            if (f && k > 0)
            {
                //вызываем функцыю добавления элемента в игровое поле
                AddElement(k);
                //количество пустых клеток уменьшаетсмя на 1
                k--;
            }

            //Проверяем заполнено ли все игровое поле и нужно определить закончена ли игра для этого введем переменную WillSum
            bool WillSum = false;
            for (i = 0; i < RowCount; i++)
                for (j = 0; j < ColCount - 1; j++)
                    //если две соседние клетки не пустые
                    if (mas[i, j] != null && mas[i, j + 1] != null)
                        //если текущая клетка и клетка справа одинаковые то их можно сложить
                        if (mas[i, j].Text == mas[i, j + 1].Text) WillSum = true;
            //перебираем игровое поле и проверяем: есть ли клетки, которые можно сложить по вертикали
            for (j = 0; j < ColCount; j++)
                for (i = 0; i < RowCount - 1; i++)
                    //если две соседние клетки не пустые
                    if (mas[i, j] != null && mas[i + 1, j] != null)
                        //если текущая клетка и клетка снизу одинаковые то их можно сложить
                        if (mas[i, j].Text == mas[i + 1, j].Text) WillSum = true;
            //если нет соседних клеток, которые могут быть сложены и количество пустых клеток равно нулю то игра закончена
            if (!WillSum && k == 0)
                //показать диалоговое окно с сообщением о завершении игры и предожением начать новую игру.
                if (MessageBox.Show("Начать новую игру?",
                "Игра окончена", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    NewGame(); //начать новую игру
                }
        }
    }
}
