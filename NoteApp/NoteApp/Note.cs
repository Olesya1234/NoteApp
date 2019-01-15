using System;
using System.Data;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Класс заметки с полями Название, Категория заметки, Текст заметки,
    /// Время создания, Время последнего изменения. 
    /// </summary>
    public class Note :ICloneable
    {
        //[JsonProperty]
        //public readonly DateTime TimeCreated;
        /// <summary>
        /// Время последнего изменения
        /// </summary>
        private string _name = "Без названия";
        private string _text ;
        private DateTime _timeCreated;
        /// <summary>
        /// Категория заметки
        /// </summary>
        private NoteCategory _noteCategory; 
        private DateTime _lastChangeTime;
        
        /// <summary>
        /// Создание заметки
        /// </summary>
        /// <param name="CreationTime">Дата создания заметки</param>
        public Note(DateTime CreationTime)
        {
            TimeCreated = CreationTime;
            LastChangeTime = CreationTime;
                        
        }

        public Note()
        {
        }

        /// <summary>
        /// Имя записи.Должно быть меньше 50 символов.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length >0 && value.Length < 50)
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Имя заметки должна быть больше 0 символов и меньше 50");
                }                
            }
        }

        /// <summary>
        /// Возвращает категорию заметки
        /// </summary>
        public NoteCategory NoteCategory
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
                if (value.Length > 0)
                {
                    _text = value;                    
                }
                else
                {
                    if (value.Length <= 0)
                    {
                        throw new ArgumentException("Текст заметки пуст.");
                    }
                }
            }
        }

        /// <summary>
        /// Время создания заметки
        /// </summary>
        public DateTime TimeCreated
        {
            get
            {
                return _timeCreated;
            }
            set
            {
                if (value <= DateTime.Now)
                {
                    _timeCreated = value;
                }
                else
                {
                    if (value > DateTime.Now)

                    {
                        throw new ArgumentException("Дата создания заметки не должна быть позже реального времени.");
                    }
                }
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
                if (value <= DateTime.Now && value >= TimeCreated)
                {
                    _lastChangeTime = value;
                }
                else
                {
                    if (value > DateTime.Now || value < TimeCreated)

                    {
                        throw new ArgumentException("Время последнего изменения заметки не должна быть позже реального времени.");
                    }
                }
            }
        }

        
        /// <summary>
        /// Клонирование(для дублирования заметки).
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            var newNote = new Note(TimeCreated);
            newNote.Name = _name;
            newNote.NoteCategory = _noteCategory;
            newNote.Text = _text;
            newNote.TimeCreated = _timeCreated;
            newNote.LastChangeTime = _lastChangeTime;
            return newNote;
        }

    }
}
