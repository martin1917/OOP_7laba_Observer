using System.Collections.Generic;
using System.Linq;

namespace laba_7_forms
{
    /// <summary>
    /// Делегат, для создания события
    /// </summary>
    /// <param name="sender">Отправитель</param>
    /// <param name="str">Данные в виде строки</param>
    public delegate void MyDelegate(object sender, string str);

    public class StationObservableCollection
    {
        public event MyDelegate AfterAdd;
        public event MyDelegate AfterRemove;
        public List<Station> stations;

        public StationObservableCollection()
        {
            stations = new List<Station>();
        }

        public int Count => stations.Count;

        /// <summary>
        /// Добавление нового объекта и оповещение слушателей
        /// </summary>
        /// <param name="station">Добавляемый объект</param>
        public void Add(Station station)
        {
            stations.Add(station);
            AfterAdd?.Invoke(this, "В коллекцию был добавлен элемент");
        }

        /// <summary>
        /// Удаление объекта и оповещение слушателей
        /// </summary>
        /// <param name="station">Удаляемый объект</param>
        /// <returns></returns>
        public bool Remove(Station station)
        {
            bool res = stations.Remove(station);
            AfterRemove?.Invoke(this, "Из коллекции был удален элемент");
            return res;
        }

        /// <summary>
        /// Удаление объекта по индексу и оповещение слушателей
        /// </summary>
        /// <param name="index">индекс удаляемого объекта</param>
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= stations.Count) return;
            stations.RemoveAt(index);
            AfterRemove?.Invoke(this, "Из коллекции был удален элемент");
        }

        /// <summary>
        /// получение объекта по индексу
        /// </summary>
        /// <param name="index">индекс объекта в коллекции</param>
        /// <returns></returns>
        public Station Get(int index)
        {
            if (index < 0 || index >= stations.Count) return null;
            return stations[index];
        }

        /// <summary>
        /// получить перечисление объектов
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Station> GetEnumerable()
        {
            return stations.AsEnumerable();
        }
    }
}
