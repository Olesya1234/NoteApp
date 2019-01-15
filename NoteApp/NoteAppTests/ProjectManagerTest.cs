using System;
using NUnit.Framework;
using NoteApp;

namespace NoteAppTests
{
    [TestFixture]
    public class ProjectManagerTest
    {           
                  
        [Test(Description = "Сохранение в неверный путь.")]
        public void TestProjectManagerSave_NotCorrectPath()
        {
            var project = new Project();
            Assert.Throws<System.IO.IOException>(() => { ProjectManager.Save(project, "c:\\distribution\\"); },
                "Должно возникать исключение, если путь неверен.");
        }

        [Test(Description = "Загрузка из неверного пути.")]
        public void TestProjectManagerLoad_NotCorrectPath()
        {
            Assert.Throws<System.IO.FileNotFoundException>(() => { var project = ProjectManager.Load("c:\\distribution\\"); }, "Должно возникать исключение, если путь неверен.");
        }
    }
}
