using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Сериализация для класса Note
    /// </summary>
    public class ProjectManager
    {
        public static string PathToDocuments = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\NoteApp.notes";

        /// <summary>
        /// Сохранение объекта "Проект" в файл и метод загрузки проекта из файла
        /// </summary>
        /// <param name="listNotes">Список заметок</param>
        /// <param name="fileName">Имя файла</param>
        public static void Save(Project ListNotes, string fileName)
        {
            JsonSerializer serializer = new JsonSerializer();

            //Открытие потока для записи в файл с указанием пути
            using (StreamWriter sw = new StreamWriter(fileName))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                //Вызываем сериализацию и передаём объект для сериализации
                serializer.Serialize(writer, ListNotes);
                
            }
        }
        
        public static Project Load(string fileName)
        {
            Project notes = new Project();

            //Создаём экземпляр сериализатора.
            JsonSerializer serializer = new JsonSerializer();

            //Открываем поток для чтения из файла с указанием пути.
            using (StreamReader sr = new StreamReader(fileName))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                var noteList = (Project)serializer.Deserialize<Project>(reader);
                 notes = noteList;
            }
            return notes;
        }
    }
}
