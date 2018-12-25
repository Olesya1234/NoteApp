using System;
using NUnit.Framework;
using NoteApp;

namespace NoteAppTests
{
    [TestFixture]
    public class ProjectManagerTest
    {
        [Test(Description = "")]
        public void TestProjectManagerSaveToFile()
        {
            Note note = new Note();
            note.Text = "Смирнов";
            var project = new Project();
            project.Notes.Add(note);
            ProjectManager.Save(project, "c:\\Users\\User\\Desktop\\111.json");

            var actual = ProjectManager.Load("c:\\Users\\User\\Desktop\\111.json");

            var expected = project;

            Assert.AreEqual(expected.Notes.Count, actual.Notes.Count, "Different count of notes in project");

            Assert.AreEqual(expected.Notes[0].Text, actual.Notes[0].Text, "Сериализация работает неверно!");

        }
    }
}
