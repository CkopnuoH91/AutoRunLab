using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using AutoRunLab;

namespace WindowsFormsApplication1
{
    public partial class FormCOM : Form
    {
        //Конструктор класса
        public FormCOM()
        {
            InitializeComponent();           
        }

        //Метод проверки доступных портов при загрузке формы FormCOM
        private void FormCOM_Load(object sender, EventArgs e)
        {
            if (AvailablePort())
            {
                comboBoxCOM.SelectedIndex = 0;
                buttonOk.Enabled = true;
            }
            else
            {
                MessageBox.Show("Нет доступных COM портов", "Наличие доступных портов", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                buttonOk.Enabled = false;
            }
            DefaultCOM();
        }

        //Обработчик события: нажатие кнопки "По умолчанию"
        private void buttonDefault_Click(object sender, EventArgs e)
        {
            DefaultCOM();
        }
        
        //Обработчик события: нажатие кнопки "Отмена"
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        //Обработчик события: нажатие кнопки "Ок"
        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCOM.SelectedItem.ToString().IndexOf("(занят)") == -1)
                {
                    ((Form1)Owner).serialPort1.PortName = comboBoxCOM.SelectedItem.ToString();
                    ((Form1)Owner).serialPort1.BaudRate = Convert.ToInt32(comboBoxBaudRate.SelectedItem);
                    ((Form1)Owner).serialPort1.DataBits = Convert.ToInt32(comboBoxDataBits.SelectedItem);
                    switch (comboBoxParity.SelectedItem.ToString())
                    {
                        case "Чёт": ((Form1)Owner).serialPort1.Parity = Parity.Even;     
                            break;
                        case "Нечёт": ((Form1)Owner).serialPort1.Parity = Parity.Odd;   
                            break;
                        case "Нет": ((Form1)Owner).serialPort1.Parity = Parity.None; 
                            break;
                        case "Маркер": ((Form1)Owner).serialPort1.Parity = Parity.Mark; 
                            break;
                        case "Пробел": ((Form1)Owner).serialPort1.Parity = Parity.Space; 
                            break;
                        default:
                            MessageBox.Show("Невозможно установить выбранную четность", "Выбор четности",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }

                    switch (comboBoxStopBits.SelectedItem.ToString())
                    {
                        case "1": ((Form1)Owner).serialPort1.StopBits = StopBits.One;   
                            break;
                        case "1.5": ((Form1)Owner).serialPort1.StopBits = StopBits.OnePointFive;    
                            break;
                        case "2": ((Form1)Owner).serialPort1.StopBits = StopBits.Two;   
                            break;
                        default:
                            MessageBox.Show("Невозможно установить выбранное количество стоповых битов", "Выбор стоповых битов",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }

                    switch (comboBoxHandshake.SelectedItem.ToString())
                    {
                        case "Нет": ((Form1)Owner).serialPort1.Handshake = Handshake.None;   
                            break;
                        case "Аппаратное": ((Form1)Owner).serialPort1.Handshake = Handshake.RequestToSend;    
                            break;
                        case "Xon/Xoff": ((Form1)Owner).serialPort1.Handshake = Handshake.XOnXOff;  
                            break;
                        case "Аппаратное и Xon/Xoff": ((Form1)Owner).serialPort1.Handshake = Handshake.RequestToSendXOnXOff;   
                            break;
                        default:
                            MessageBox.Show("Невозможно установить выбранное управление потоком передачи", "Выбор управления потоком передачи",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }           
                }
                else
                {
                    MessageBox.Show("Невозможно подключиться к " + comboBoxCOM.SelectedItem.ToString() + 
                        " т.к. данный порт используется другим приложением и помечен как (занят)",
                        "Подключение к COM порту", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ((Form1)Owner).serialPort1.Open();
                SetOfConnect();
                ((Form1)Owner).buttonConnect.Enabled = false;
            }
            catch 
            {
                MessageBox.Show("Не удалось подключиться к " + comboBoxCOM.SelectedItem.ToString() + 
                    "\nПроверьте наличие физического соединения ПК с устройством и правильность параметров подключения",
                    "Подключение к СОМ порту", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetOfDisconnect();
            }
            Close();
        }

        private void DefaultCOM()
        {
            comboBoxBaudRate.SelectedIndex = 11;
            comboBoxDataBits.SelectedIndex = 4;
            comboBoxParity.SelectedIndex = 2;
            comboBoxStopBits.SelectedIndex = 0;
            comboBoxHandshake.SelectedIndex = 0;
        }

        //Метод отображения статуса подключения при успешном соединении
        private void SetOfConnect() 
        {
            ((Form1)Owner).checkBoxStatus.Checked = true;
            ((Form1)Owner).checkBoxStatus.Text = "Подключен";
            ((Form1)Owner).checkBoxStatus.ForeColor = Color.LimeGreen;       
        }

        //Метод отображения статуса подключения при неуспешном соединении
        private void SetOfDisconnect()
        {
            ((Form1)Owner).checkBoxStatus.Checked = false;
            ((Form1)Owner).checkBoxStatus.Text = "Отключен";
            ((Form1)Owner).checkBoxStatus.ForeColor = Color.Red;           
        }

        /// <summary>
        ///Метод проверки доступности COM портов
        /// </summary>
        /// <returns>Возвращает true если найден хотя бы один доступный порт, иначе false</returns>
        public bool AvailablePort()
        {
            //Переменная состояния доступных портов
            //true в случае успешного получения 
            //false если порты не найдены
            bool available = false;

            //Производим проверку массива имен последовательных портов на возможность доступа
            //Функция SerialPort.GetPortNames() возвращает массив имен
            foreach (string str in SerialPort.GetPortNames())
            {
                try
                {
                    SerialPort Port = new SerialPort(str);
  
                    //Открываем новое соединение последовательного порта
                    Port.Open();

                    //Выполняем проверку полученного порта
                    //true, если последовательный порт открыт, в противном случае — false.
                    //Значение по умолчанию — false.
                    if (Port.IsOpen)
                    {
                        //Если порт открыт то добавляем его в comboBox
                        comboBoxCOM.Items.Add(str);

                        //Закрываем соединение порта, присваиваем свойству 
                        //System.IO.Ports.SerialPort.IsOpen значение false и уничтожаем 
                        //внутренний объект System.IO.Stream.
                        Port.Close();

                        //возвращаем true для состояния получения портов
                        available = true;
                    }
                }

                //Если не удалось открыть порт, то он уже занят и при добавлении будет помечен как COMX(занят)     
                catch (UnauthorizedAccessException)
                {
                    comboBoxCOM.Items.Add(str + "(занят)");
                }

                //Ловим все ошибки и отображаем, что открытых портов не найдено  
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Error - No Ports available",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //возвращаем состояние получения портов
            return available;
        }
        
    }
}
