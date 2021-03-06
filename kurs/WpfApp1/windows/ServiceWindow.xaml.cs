using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1.windows
{
    /// <summary>
    /// Логика взаимодействия для ServiceWindow.xaml
    /// </summary>
    public partial class ServiceWindow : Window, INotifyPropertyChanged
    {
        public  ServiceWindow(Userman userman)
        {
            InitializeComponent();
            this.DataContext = this;
            CurrentService = userman;
            
        }
        public Userman CurrentService { get; set; }
        public string WindowName
        {
            get
            {
                return CurrentService.Id == 0 ? "Новая услуга" : "Редоктирование улсгуи";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void GetImageButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog GetImageDialog = new OpenFileDialog();
            // задаем фильтр для выбираемых файлов
            // до символа "|" идет произвольный текст, а после него шаблоны файлов раздеренные точкой с запятой
            GetImageDialog.Filter = "Файлы изображений: (*.png, *.jpg)|*.png;*.jpg";
            // чтобы не искать по всему диску задаем начальный каталог
            GetImageDialog.InitialDirectory = Environment.CurrentDirectory;
            if (GetImageDialog.ShowDialog() == true)
            {
                // перед присвоением пути к картинке обрезаем начало строки, т.к. диалог возвращает полный путь
                // (тут конечно еще надо проверить есть ли в начале Environment.CurrentDirectory)
                CurrentService.photo = GetImageDialog.FileName.Substring(Environment.CurrentDirectory.Length + 1);
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("CurrentService"));
                }
            }
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentService.Salary <= 0||CurrentService.Salary>1000000)
            {
                MessageBox.Show("Зарплата не может быть меньше или равно нулю или больше 1000000");
                return;
            }

            if (CurrentService.Rate < 0 || CurrentService.Rate > 10)
            {
                MessageBox.Show("Рейтинг долджен быть от 1 до 10");
                return;
            }
            
            

            CurrentService.Roleid = 6;
            // если запись новая, то добавляем ее в список
            if (CurrentService.Id == 0)
                Core.DB.Userman.Add(CurrentService);

            // сохранение в БД
            try
            {
                Core.DB.SaveChanges();
            }
            catch
            {
            }
            DialogResult = true;
        }
        public string NewProduct
        {
            get
            {
                if (CurrentService.Id == 0) return "collapsed";
                return "visible";



            }
        }
    }
}
