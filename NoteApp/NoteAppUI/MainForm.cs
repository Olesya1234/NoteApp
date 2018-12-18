using NoteApp;
using System;
using System.Windows.Forms;


namespace NoteAppUI
{
    public partial class MainForm : Form
	{
        //public Project list;   
        //Данные которые будут передаваться
         private Project _project = new Project();

        //private readonly string _address = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\txt.json";
        //
        public MainForm()
		{
			InitializeComponent();

           categoryComboBox.Items.Add("All");
           categoryComboBox.SelectedIndex = 0;
           foreach (var e in Enum.GetValues(typeof(NoteCategory)))
           {
            categoryComboBox.Items.Add(e);
           }
            //_project = ProjectManager.Load(_address);
            AllNotes();
        }
        private void AllNotes()
        {
            ListNotes.Items.Clear();
            _project.Sort();

            foreach (var note in _project.Notes)
            {
                ListNotes.Items.Add(note.Name);
            }
            UpdateCurrentNote();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }  
        
        /// <summary>
        /// Добавить заметку 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Click(object sender, EventArgs e)
        {
            var notes = new AddEdit();          //Создаем форму
            notes.Note = new Note(DateTime.Now);//Передаем ему данные
            if (notes.ShowDialog() == DialogResult.OK)//отображаем форму для редактирования (если )
            {
                var note = notes.Note;  //забираем изменненные данные
                _project.Notes.Add(note);//
                ListNotes.Items.Add(note.Name);
                //ProjectManager.Save(_project, _address);
                AllNotes();
            }
        }  
        
        
        /// <summary>
        /// Редактировать заметку 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Edit_Click(object sender, EventArgs e)
        {
            var notes = new AddEdit();                      //Создаем форму
            notes.Note = _project.Notes[ListNotes.SelectedIndex];//Передаем ему данные
            if (notes.ShowDialog() == DialogResult.OK)          //отображаем форму для редактирования (если )
            {
                _project.Notes[ListNotes.SelectedIndex] = notes.Note;
                //ProjectManager.Save(_project, _address);
                AllNotes();
            }
            else
            {
               AllNotes();
            }            
        }
        
        /// <summary>
        /// Удалить заметку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Remove_Click(object sender, EventArgs e)
        {

           if (MessageBox.Show("Удалить заметку?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
           { 
               _project.Notes.Remove(_project.Notes[ListNotes.SelectedIndex]);
               ListNotes.Items.Remove(ListNotes.SelectedIndex);

                //ProjectManager.Save(_project, _address);
                ListNotes.Items.Clear();
                AllNotes();
            }            
        }
        
        /// <summary>
        /// Предварительный просмотр выбранной заметки 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCurrentNote();
        }

        private void UpdateCurrentNote()
        {
            if (ListNotes.SelectedIndex == -1)
                return;
            TitleLabel.Text = _project.Notes[ListNotes.SelectedIndex].Name;
            headderCategoryLabel.Text = _project.Notes[ListNotes.SelectedIndex].NoteCategory.ToString();
            createdDateTimePicker.Value = _project.Notes[ListNotes.SelectedIndex].TimeCreated;
            updatedDateTimePicker.Value = _project.Notes[ListNotes.SelectedIndex].LastChangeTime;
            noteTextBox.Text = _project.Notes[ListNotes.SelectedIndex].Text;
        }


        private void EditNote()
        {

            if (ListNotes.SelectedItem != null)
            {
                AddEdit form = new AddEdit();
                var temp = (Note)ListNotes.SelectedItem;
                form.Note = (Note)temp.Clone();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    temp = form.Note;
                }
            }
        }

        /// <summary>
        /// Сортировка категорий
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedItem.ToString() == "All")
            {
                AllNotes();
            }
            else
            {
                NoteCategory selectedNoteType;
                selectedNoteType = (NoteCategory)categoryComboBox.SelectedItem;
                var findedNotes = _project.Sort(selectedNoteType);
                ListNotes.Items.Clear();
                foreach (Note note in findedNotes)
                {
                    ListNotes.Items.Add(note.Name);
                }
            }
        }          
                              
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NoteApp v.1.0.0\n\n Author: Olesya\n\n Github: Olesya1234/NoteApp ", "About");
        }

        private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Edit_Click(sender, e);                
        }

        private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove_Click(sender, e);
                      
        }

           
        private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Click(sender, e);
        }
    }
}

