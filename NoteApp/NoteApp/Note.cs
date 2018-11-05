using System;
using System.Data;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс заметки с полями Название, Категория заметки, Текст заметки,
    /// Время создания, Время последнего изменения. 
    /// </summary>
    public class Note :ICloneable
    {
        /// <summary>
        /// Имя заметки
        /// </summary>
        private string _title;
        /// <summary>
        /// Категория заметки
        /// </summary>
        private NoteCategory _noteCategory;
        private string _text = "Без названия";

        /// <summary>
        /// Время создания
        /// </summary>        
        private DateTime _timeCreated;
        /// <summary>
        /// Время последнего изменения
        /// </summary>
        private DateTime _lastChangeTime;
        public readonly DateTime CreatedTime;

        /// <summary>
        /// Имя записи.Должно быть меньше 50 символов.
        /// </summary>
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if(value.Length > 50)
                {
                    throw new ArgumentException("Название заголовка меньше 50 символов");
                }
                _title = value;
            }
        }

        /// <summary>
        /// Возвращает категорию заметки
        /// </summary>
        public NoteCategory Category
        {
           get
            {
                return _noteCategory;
            }
            set
            {
                if (value >= 0)
                {
                    _noteCategory = value;
                }
                else
                {
                    throw new ArgumentException("Некорректная категория");
                }
            }
        }

        /// <summary>
        /// Дата создания. Должна быть не больше текущей даты.
        /// </summary>
        public DateTime TimeCreated
        {
            get
            {
                return _timeCreated;
            }
            set
            {
                if ((value > (DateTime.Now)))
                {
                    throw new ArgumentException("Неверная дата создания");
                }
                _timeCreated = value;
            }
        }

        /// <summary>
        /// Конструктор времени.
        /// </summary>
        public Note(DateTime createTime)
        {
            if (createTime <= DateTime.Now)
            {
                _lastChangeTime = createTime;
                CreatedTime = createTime;
            }

            else
            {
                throw new ArgumentException("Неверная дата.");
            }
        }

        /// <summary>
        /// Дата последнего изменения. Должна быть не больше текущей даты и не меньше времени создания.
        /// </summary>
        public DateTime LastChangeTime
        {
            get
            {
                return _lastChangeTime;
            }
            set
            {
                if ((value > (DateTime.Now) & (value < TimeCreated)))
                {
                    throw new ArgumentException("Неверное время последнего изменения");
                }
                _lastChangeTime = value;
            }
        }
        /// <summary>
        /// Возвращает текст заметки
        /// </summary>
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                                               
            }
        }
        /// <summary>
        /// Клонирование(для дублирования заметки).
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            var newNote = new Note(CreatedTime);
            newNote.Title = _title;
            newNote.Text = _text;
            newNote.Category = _noteCategory;
            newNote.LastChangeTime = _lastChangeTime;
            return newNote;
        }
    }
}
