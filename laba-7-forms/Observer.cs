using System;

namespace laba_7_forms
{
    public class Observer
    {
        public string Name { get; }
        
        /// <summary>
        /// Событие для указания способа вывода информации 
        /// </summary>
        public event Action<string> Display;

        public Observer(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Обработчик добавления объекта в коллекцию.
        /// Выводит сообщение от отправителя с помощью
        /// события Display
        /// </summary>
        /// <param name="sender">Отправитель</param>
        /// <param name="str">Данные от отправителя</param>
        public void OnAddCollection(object sender, string str)
        {
            Display?.Invoke($"[{Name}] - {str}");
        }

        /// <summary>
        /// Обработчик удаления объекта из коллекции.
        /// Выводит сообщение от отправителя с помощью
        /// события Display
        /// </summary>
        /// <param name="sender">Отправитель</param>
        /// <param name="str">Данные от отправителя</param>
        public void OnRemoveCollection(object sender, string str)
        {
            Display?.Invoke($"[{Name}] - {str}");
        }

        public override string ToString()
        {
            return $"[{Name}]";
        }
    }
}
