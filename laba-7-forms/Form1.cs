using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace laba_7_forms
{
    public partial class Form1 : Form
    {
        private BindingList<Observer> observers = new BindingList<Observer>();
        private StationObservableCollection collection = new StationObservableCollection();

        public Form1()
        {
            InitializeComponent();
            listObservers.DataSource = observers;
        }

        /// <summary>
        /// Обработчик кнопки на добавление нового слушателя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddObserver_Click(object sender, EventArgs e)
        {
            var text = tbNameObserver.Text;
            if (string.IsNullOrEmpty(text)) return;

            var findObserver = observers.FirstOrDefault(el => el.Name == text);
            if (findObserver != null) return;

            Observer observer = new Observer(text);
            observer.Display += (str) =>
            {
                richTextBox1.AppendText($"{str}\n");
            };

            collection.AfterAdd += observer.OnAddCollection;
            collection.AfterRemove += observer.OnRemoveCollection;
            observers.Add(observer);
        }

        /// <summary>
        /// Обработчик кнопки на удаление слушателя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteObserver_Click(object sender, EventArgs e)
        {
            var countObserver = observers.Count;
            if (countObserver == 0) return;

            var observer = observers[countObserver - 1];
            collection.AfterAdd -= observer.OnAddCollection;
            collection.AfterRemove -= observer.OnRemoveCollection;
            observers.Remove(observer);
        }

        /// <summary>
        /// Обработчик кнопки на добавление новой станции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddStation_Click(object sender, EventArgs e)
        {
            Station station = Station.GenerateStation();
            collection.Add(station);
            listStations.Items.Add(station);
        }

        /// <summary>
        /// Обработчик кнопки на удаление станции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteStation_Click(object sender, EventArgs e)
        {
            var countStation = listStations.Items.Count;
            if (countStation == 0) return;

            collection.RemoveAt(countStation - 1);
            listStations.Items.RemoveAt(countStation - 1);
        }

        /// <summary>
        /// Очищение логов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearLogs_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }
    }
}
