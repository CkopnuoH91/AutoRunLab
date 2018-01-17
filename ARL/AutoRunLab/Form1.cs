using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication1;
using System.Windows.Forms.DataVisualization.Charting;
using Exel = Microsoft.Office.Interop.Excel;

namespace AutoRunLab
{
    public partial class Form1 : Form
    {
        //Конструктор класса
        public Form1()
        {
            InitializeComponent();
        }

        //Метод начальной инициализации при загрузке формы Form1
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowForDisconnect();
            dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            saveFileDialog1.Filter = "JPEG(*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg;*.jpeg;*.jpe;*.jfif";
            saveFileDialog1.Filter += "|PNG(*.png)|*.png";
            saveFileDialog1.Filter += "|BMP(*.bmp;*.dib)|*.bmp;*.dib";
            saveFileDialog1.Filter += "|GIF(*.gif)|*.gif";
            saveFileDialog1.Filter += "|TIFF(*.tif;*.tiff)|*.tif;*.tiff";
            saveFileDialog1.Filter += "|Все файлы|*.*";
            radioButtonDiod.Checked = true;
            checkBoxSt.Checked = true;
            radioButtonnpn.Checked = true;
            radioButtonIn.Checked = true;
        }

        //Обработчик события: нажатие кнопки "Подключение"
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            FormCOM FC = new FormCOM();
            FC.ShowDialog(this);
        }

        //Обработчик события: нажатие кнопки "Отключить"
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                checkBoxStatus.Checked = false;
                checkBoxStatus.Text = "Отключен";
                checkBoxStatus.ForeColor = Color.Red;
                buttonConnect.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Не удалось закрыть соединение", "Статус соединения",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Обработчик события: нажатие кнопки "Измерить"
        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxName.Text != "")
                {
                    chart1.Series.Add(textBoxName.Text);
                }
                else
                {
                    MessageBox.Show("Поле 'Имя серии:' не задано\nПожалуйста заполните поле и повторите попытку",
                        "Новое измерение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Серия с данным именем уже существует\nПожалуйста измените имя и повторите попытку",
                    "Новое измерение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            chart1.Series[chart1.Series.Count - 1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series[chart1.Series.Count - 1].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.None;
            chart1.Series[chart1.Series.Count - 1].BorderWidth = 1;

            string s = "";

            if (radioButtonDiod.Checked)
            {
                s = TypeMeasureString() + numericUpDownImax.Value.ToString("0000");
            }
            if (radioButtonTransistor.Checked)
            {
                s = TypeMeasureString() + (numericUpDownConst.Value * 100).ToString("0000");
            }

            s += "x";
            textBox1.Text = s;
            try
            {
                serialPort1.Write(s);
            }
            catch
            {
                MessageBox.Show("Невозможно провести измерение\nПроверьте подключение и повторите попытку", "Отправка команды на измерение",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Обработчик события: поступление данных из порта SerialPort
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort1.ReadLine();
                this.BeginInvoke(new SetTextDeleg(si_DataReceived),
                new object[] { data });
            }
            catch
            {
            }
        }

        //Метод обработки полученных данных
        private void si_DataReceived(string data)
        {
            double U, I;
            if (data.IndexOf(';') == -1)
            {
                double.TryParse(data, out U);              
                U /= 1000;
                dataGridView2.Rows.Add(U.ToString());
                return;
            }

            string[] values = data.Split(';');
            double.TryParse(values[0], out U);
            double.TryParse(values[1], out I);
            
            if (U != 0)
            {

                U /= 1000;
                if (textBox1.Text[0] == '4' || textBox1.Text[0] == '6')
                {
                    I /= 1000;
                }
                else
                {
                    I /= 100;
                }
                dataGridView1.Rows.Add(U.ToString(), I.ToString());
                chart1.Series[chart1.Series.Count - 1].Points.AddXY(U, I);
            }
            else
            {
                dataGridView1.Rows.Add(U.ToString(), I.ToString());               
                chart1.Series[chart1.Series.Count - 1].Points.AddXY(U, I);
                if (chart1.Series[chart1.Series.Count - 1].Points.Count - 1 != 0)
                {
                    chart1.Series[chart1.Series.Count - 1].Points[chart1.Series[chart1.Series.Count - 1].Points.Count - 1].IsEmpty = true;
                    chart1.Series[chart1.Series.Count - 1].Points[chart1.Series[chart1.Series.Count - 1].Points.Count - 2].IsEmpty = true;
                }
            }
        }

        //Делегат для функции si_DataReceived
        private delegate void SetTextDeleg(string text);

        //Обработчик события: нажатие кнопки "Очистить" в группе "Данные"
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
        }

        //Метод формирования команды
        private string TypeMeasureString()
        {
            string s = "";
            if (radioButtonDiod.Checked)
            {
                if (checkBoxSt.Checked && checkBoxRe.Checked)
                {
                    s = "3";
                }
                else
                {
                    if (checkBoxSt.Checked)
                    {
                        s = "1";
                    }
                    else
                    {
                        if (checkBoxRe.Checked)
                        {
                            s = "2";
                        }
                        else
                        {
                            MessageBox.Show("Ошибка выбора типа измерения", "Выбор измерения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                if (radioButtonnpn.Checked)
                {
                    if (radioButtonIn.Checked)
                    {
                        s = "4";
                    }
                    else
                    {
                        s = "5";
                    }
                }
                else
                {
                    if (radioButtonIn.Checked)
                    {
                        s = "6";
                    }
                    else
                    {
                        s = "7";
                    }
                }
            }
            return s;
        }

        //Метод изменения видимости объектов при выборе типа измерения "Двухполюсник"
        private void radioButtonDiod_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDiod.Checked)
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                labelImax.Enabled = true;
                labelmA.Enabled = true;
                numericUpDownImax.Enabled = true;
                labelConst.Enabled = false;
                labelConstV.Enabled = false;
                numericUpDownConst.Enabled = false;
                numericUpDownImax.Value = 1;
            }
        }

        //Метод изменения видимости объектов при выборе типа измерения "Четырехполюсник"
        private void radioButtonTransistor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTransistor.Checked)
            {
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                labelConst.Enabled = true;
                labelConstV.Enabled = true;
                numericUpDownConst.Enabled = true;
                labelImax.Enabled = false;
                labelmA.Enabled = false;
                numericUpDownImax.Enabled = false;
                numericUpDownConst.Value = 0;
            }
        }

        //Обработчик события: нажатие кнопки "Очистить" в группе "График"
        private void buttonClearChart_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
        }

        //Обработчик события: нажатие кнопки "Сохранить" в группе "График"
        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = @textBoxChart.Text;
            saveFileDialog1.ShowDialog(this);
            if (saveFileDialog1.FileName != "")
            {
                switch (saveFileDialog1.FilterIndex)
                {
                    case 0:
                        chart1.SaveImage(saveFileDialog1.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Jpeg);
                        break;
                    case 1:
                        chart1.SaveImage(saveFileDialog1.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                        break;
                    case 2:
                        chart1.SaveImage(saveFileDialog1.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Bmp);
                        break;
                    case 3:
                        chart1.SaveImage(saveFileDialog1.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Gif);
                        break;
                    case 4:
                        chart1.SaveImage(saveFileDialog1.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Tiff);
                        break;
                    default:
                        break;
                }
            }
        }

        //Метод настройки компонентов при изменении типа характеристики
        private void radioButtonIn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonIn.Checked)
            {
                labelConst.Text = "Uкэ:";
                labelConstV.Text = "В";
                numericUpDownConst.Maximum = 10;
                numericUpDownConst.Minimum = 0;
                numericUpDownConst.Increment = (decimal)0.1;
                numericUpDownConst.DecimalPlaces = 1;
                numericUpDownConst.Value = 0;
                dataGridView2.Columns[0].HeaderText = "Uкэ, В";
            }
            else
            {
                labelConst.Text = "Iб:";
                labelConstV.Text = "mA";
                numericUpDownConst.Maximum = 10;
                numericUpDownConst.Minimum = 0;
                numericUpDownConst.Increment = (decimal)0.05;
                numericUpDownConst.DecimalPlaces = 2;
                numericUpDownConst.Value = 0;
                dataGridView2.Columns[0].HeaderText = "Iб, mA";
            }
        }

        //Метод масштабирования осей графика
        private void Scale(Axis ax, TrackBar tr, int ratio)
        {
            ax.Minimum = 0;
            ax.Maximum = 0;

            if (tr.Value > 0)
            {
                ax.Maximum = tr.Value * ratio;
                return;
            }
            if (tr.Value < 0)
            {
                ax.Minimum = tr.Value * ratio;
                return;
            }

            if (tr.Value == 0)
            {
                ax.Minimum = -10 * ratio;
                ax.Maximum = 10 * ratio;
            }
        }

        //Обработчик события: нажатие кнопки "Сохранить" в группе "Данные"
        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            Exel.Application ExcelApp = new Exel.Application();
            try
            {
                Exel.Workbook ExcelWorkBook = ExcelApp.Workbooks.Add();
                Exel.Worksheet ExcelWorkSheet = (Exel.Worksheet)ExcelWorkBook.Sheets[1];

                ExcelApp.DisplayAlerts = false;
                ExcelWorkSheet.get_Range("A1", "Z2000").Clear();
                ExcelWorkSheet.get_Range("A1", "Z2000").NumberFormat = "@";
                ExcelWorkSheet.Cells[1, 1] = dataGridView1.Columns[0].HeaderText;
                ExcelWorkSheet.Cells[1, 2] = dataGridView1.Columns[1].HeaderText;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        ExcelWorkSheet.Cells[i + 2, j + 1] = dataGridView1[j, i].Value;
                    }
                }
                ExcelWorkSheet.Cells[1, 3] = dataGridView2.Columns[0].HeaderText;
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    ExcelWorkSheet.Cells[i + 2, 3] = dataGridView2[0, i].Value;
                }
                ExcelWorkSheet.get_Range("A1", "Z2000").NumberFormat = "General";
                ExcelWorkSheet.get_Range("A1", "Z2000").EntireColumn.AutoFit();
                ExcelApp.Visible = true;
                ExcelApp.UserControl = true;
            }
            catch
            {
                MessageBox.Show("При создании документа возникла ошибка\nУбедитесь что перед запуском не возникает никаких диалоговых окон.",
                    "При создании файла MS Exel возникла ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ExcelApp.Quit();
            }                  
        }

        //Обработчик события: изменение масштаба "+U"
        private void trackBarPlusU_Scroll(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Maximum = trackBarPlusU.Value;
        }

        //Обработчик события: изменение масштаба "+I"
        private void trackBarPlusI_Scroll(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisY.Maximum = trackBarPlusI.Value * 10;
        }

        //Обработчик события: изменение масштаба "-U"
        private void trackBarMinusU_Scroll(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.Minimum = trackBarMinusU.Value;
        }

        //Обработчик события: изменение масштаба "-I"
        private void trackBarMinusI_Scroll(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisY.Minimum = trackBarMinusI.Value * 10;
        }

        //Обработчик события: заполнение поля "Название графика"
        private void textBoxChart_TextChanged(object sender, EventArgs e)
        {
            chart1.Titles[0].Text = textBoxChart.Text;
        }

        //Обработчик события: изменение статуса подключения
        private void checkBoxStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStatus.Checked)
            {
                ShowForConnect();
            }
            else 
            {
                ShowForDisconnect();
            }
        }

        //Метод отображения компонентов при подключении
        private void ShowForConnect() 
        {
            groupBoxData.Enabled = true;
            groupBoxGraf.Enabled = true;
            groupBoxScale.Enabled = true;
            panel1.Enabled = true;
            dataGridView1.Enabled = true;
            dataGridView2.Enabled = true;
            buttonDisconnect.Enabled = true;
        }

        //Метод отображения компонентов при отключении
        private void ShowForDisconnect()
        {
            groupBoxData.Enabled = false;
            groupBoxGraf.Enabled = false;
            groupBoxScale.Enabled = false;
            panel1.Enabled = false;
            dataGridView1.Enabled = false;
            dataGridView2.Enabled = false;
            buttonDisconnect.Enabled = false;
        }

        //Обработчик события: нажатие кнопки "О программе" 
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа AutoRunLab предназначена для управления процессом снатия статических характеристик полупроводниковых приборов\n"
                + "Разработчик: Котченко Виктор Николаевич 2014г.\nКонтактная информация:\nтел.: +375259994711"
                 + "\ne-mail: ckopnuoh_victor@mail.ru","О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
