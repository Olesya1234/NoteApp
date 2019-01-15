using System;
using NUnit.Framework;
using NoteApp;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTest
    {

        [Test(Description = " тест  Note")]
        public void NoteTestNote()
        {
            var note = new Note();
        }


        [Test(Description = "Позитивный тест геттера Name")] 
        public void TestNameGet_CorrectValue()
        {
            var expected = "Смирнов";//?
            var note = new Note();
            note.Name = expected;
            var actual = note.Name;

            NUnit.Framework.Assert.AreEqual(expected, actual, "Геттер Name возвращает неправильное название");
        }


        [Test(Description = "Присвоение неправильного названия больше 50 символов")]
        public void TestNameSet_Longer50Symbols()
        {
            var wrongName = "Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов";
            var note = new Note();

            Assert.Throws<ArgumentException>(
                () => { note.Name = wrongName; }, 
                "Должно возникать исключение, если название длиннее 50 символов");
        }


        [Test(Description = "Присвоение пустой строки в качестве названия")]
        public void TestNameSet_EmptyString()
        {
            var wrongName = string.Empty;
            var note = new Note();
            Assert.Throws<ArgumentException>(
                () => { note.Name = wrongName; }, 
                "Должно возникать исключение, если название - пустая строка");
        }

        [Test(Description = "Позитивный тест геттера NoteCategory")]
        public void TestNoteCategoryGet_CorrectValue()
        {
            var expected = NoteCategory.Documents;
            var note = new Note();
            note.NoteCategory = expected;
            var actual = note.NoteCategory;

            NUnit.Framework.Assert.AreEqual(expected, actual, "Геттер NoteCategory возвращает неправильную категорию заметки");
        }

        [Test(Description = "Позитивный тест cеттера Category")]
        public void TestNoteCategorySet_CorrectValue()
        {
            var category = NoteCategory.Home;
            var note = new Note(DateTime.Now);
            note.NoteCategory = category;

            var newCategory = NoteCategory.Home;
            var actual = note.NoteCategory;
            Assert.AreEqual(newCategory, actual, "Сеттер NoteCategory задает неверное значение");
        }

        [Test(Description = "Присвоение неправильного NoteCategory больше 0 символов")]
        public void TestNoteCategorySet_Longer0Symbols()
        {
            var wrongNoteCategory = -4;
            var note = new Note();
            Assert.Throws<ArgumentException>(
                () => { note.NoteCategory = (NoteCategory)wrongNoteCategory; },
                "Должно возникать исключение, если название длиннее 0 символов");
        }

        [Test(Description = "Позитивный тест геттера Text")]
        public void TestTextGet_CorrectValue()
        {
            var note = new Note();
            var expected = "Смирнов";//?            
            expected = note.Text;
            var actual = note.Text;
            NUnit.Framework.Assert.AreEqual(expected, actual, "Геттер Text возвращает неправильный Text");
        }

        [Test(Description = "Позитивный тест cеттера Text")]
        public void TestTextSet_CorrectValue()
        {
            var text = "Смирнов";
            var note = new Note(DateTime.Now);
            note.Text = text;

            var NewText = "Смирнов";
            var actual = note.Text;
            Assert.AreEqual(NewText, actual, "Сеттер Text задает неверное значение");
        }

        [Test(Description = "Присвоение неправильного Text больше 0 символов")]
        public void TestTextSet_Longer0Symbols()
        {
            var wrongText = string.Empty;
            var note = new Note();
            Assert.Throws<ArgumentException>(() => { note.Text = wrongText; },
                "Должно возникать исключение, если Text длиннее 0 символов");
        }


        [Test(Description = "Позитивный тест клонирования Clone")]
        public void TestClone_CorrectValue()
        {
            var expected = new Note();//?
            expected.Name = "Смирнов";
            expected.NoteCategory = NoteCategory.Documents;
            expected.Text = "Смирнов";
            Note clone = (Note)expected.Clone();
            var actual = clone;

            NUnit.Framework.Assert.AreEqual(expected.Name, actual.Name, "Геттер Text возвращает неправильное название");
            NUnit.Framework.Assert.AreEqual(expected.NoteCategory, actual.NoteCategory, "Геттер Text возвращает неправильное название");
            NUnit.Framework.Assert.AreEqual(expected.Text, actual.Text, "Геттер Text возвращает неправильное название");
        }       

        [Test(Description = "Позитивный тест геттера TimeCreated")]
        public void TestTimeCreatedGet_CorrectValue()
        {
            var expected = DateTime.Now;
            var note = new Note();
            note.TimeCreated = expected;
            var actual = note.TimeCreated;

            NUnit.Framework.Assert.AreEqual(expected, actual, "Геттер TimeCreated возвращает неправильное значение");
        }



        [Test(Description = "Дата создания не должна быть больше текущей даты")]
        public void TestTimeCreatedSet_LongerCurrentDate()
        {
            var time = DateTime.Now;
            var note = new Note(DateTime.Now);
            time = time.AddYears(100);
            Assert.Throws<ArgumentException>(
                () => { note.TimeCreated = time; }, 
                "Должно возникать исключение,если дата создания больше текущей");
        }
               


        [Test(Description = "Позитивный тест геттера LastChangeTime")]
        public void TestLastChangeTimeGet_CorrectValue()
        {
            var expected = DateTime.Now;//?
            var note = new Note();
            note.LastChangeTime = expected;
            var actual = note.LastChangeTime;

            NUnit.Framework.Assert.AreEqual(expected, actual, "Геттер TimeCreated возвращает неправильное значение");
        }

        [Test(Description = "Дата изменения не должна быть позже текущей даты")]
        public void TestLastChangeTimeSet_LongerCurrentDate()
        {
            var time = DateTime.Now;
            var note = new Note(DateTime.Now);
            time = time.AddDays(-100);
            Assert.Throws<ArgumentException>(
                () => { note.LastChangeTime = time; },
                "Должно возникать исключение, если дата изменения позже текущей");
        }

        [Test(Description = "Дата последнего изменения должна быть позже даты создания")]
        public void TestLastChangeTimeSet_LongerCreated()
        {
            var time = DateTime.Now;
            var note = new Note(time);
            time = time.AddDays(100);
            Assert.Throws<ArgumentException>(
                () => { note.LastChangeTime = time; },
                "Должно возникать исключение, если дата последнего изменения  не позже даты создания");
        }

    }
}
    

