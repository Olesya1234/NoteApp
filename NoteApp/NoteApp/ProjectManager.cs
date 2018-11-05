using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    public class ProjectManager
    {
        /// <summary>
        /// Сохранение объекта "Проект" в файл и метод загрузки проекта из файла
        /// </summary>
        public static void Save(Project NotesList, string fileName)
        {
            JsonSerializer serializer = new JsonSerializer();
            //Открытие потока
            using (StreamWriter sw = new StreamWriter(fileName))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                //Вызываем сериализацию и передаём объек для сериализации
                serializer.Serialize(writer, (Project) NotesList);
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
                //Вызываем десериализацию 
                 var noteList = (Project)serializer.Deserialize<Project>(reader);
                 notes = noteList;
            }

            return notes;
        }
    }
}
