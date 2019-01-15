using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс - список всех заметок
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список всех заметок
        /// </summary>       
        public List<Note> Notes = new List<Note>();
        
        public Note LastSelectedNote = null;
       

        public void Sort()
        {
            Notes.Sort((y, x) => x.LastChangeTime.CompareTo(y.LastChangeTime));
        }

        public List<Note> Sort(NoteCategory type)
        {
            var findedNotes = Notes.FindAll(a => a.NoteCategory == type);
            findedNotes.Sort((y, x) => x.LastChangeTime.CompareTo(y.LastChangeTime));
            return findedNotes;
            
        }
    }
}
