using System;
namespace NoteApp
{
    public enum Category_note
    {
        Job,
        Home,
        Health_and_sport,
        People,
        Document,
        Finance,
        Another
    }

    public class Note
    {
	    private string name;
        private string category_note;
        private string text_note;
        private string time_create;
        private string time_last_change;
    }

}

