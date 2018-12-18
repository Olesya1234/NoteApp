using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class AddEdit : Form
    {
        //Поле для временного хранения переданных данных 
        public Note _note;       
        
        public AddEdit()
        {
            InitializeComponent();
            this.Text = "Add/Edit Note";
            CategoryComboBox.Items.Add(NoteCategory.Work);
            CategoryComboBox.Items.Add(NoteCategory.Home);
            CategoryComboBox.Items.Add(NoteCategory.HealthAndSport);
            CategoryComboBox.Items.Add(NoteCategory.People);
            CategoryComboBox.Items.Add(NoteCategory.Documents);
            CategoryComboBox.Items.Add(NoteCategory.Finance);
            CategoryComboBox.Items.Add(NoteCategory.Other);
        }

        //Свойство, через которое будут передаваться данные извне 
        public Note Note
        {
           get 
            {
               return _note;
            }
           set
            {
               _note = value;
               titleTextBox.Text = _note.Name;
               noteTextBox.Text = _note.Text;
               CreatedDateTimePicker.Value = _note.TimeCreated;
               UpdatedDateTimePicker.Value = _note.LastChangeTime;
               CategoryComboBox.SelectedIndex = (int)_note.NoteCategory;

            }
         }

        /// <summary>
        /// Добавление заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ok_Click(object sender, EventArgs e)
        {
            Note note = new Note();
            note.Name = titleTextBox.Text;
            note.NoteCategory = (NoteCategory)CategoryComboBox.SelectedIndex;
            note.Text = noteTextBox.Text;

            note.TimeCreated = CreatedDateTimePicker.Value;
            note.LastChangeTime = DateTime.Now;

            _note = note;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {                               

            if (titleTextBox.Text.Length > 50)
            {
                titleTextBox.BackColor = Color.LightSalmon;
            }
            else
            {
                titleTextBox.BackColor = Color.White;
            }   
        }


        private void Form2_Load(object sender, EventArgs e)
        {
                   
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
          private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
          {
            try
            {
                _note.NoteCategory = (NoteCategory)CategoryComboBox.SelectedIndex;
                CategoryComboBox.BackColor = Color.White;
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
                CategoryComboBox.BackColor = Color.LightSalmon;
             }
          }

        private void noteTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
