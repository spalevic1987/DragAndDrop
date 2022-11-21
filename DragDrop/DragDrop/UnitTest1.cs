using DragAndDrop.Driver;
using DragAndDrop.Page;

namespace DragDrop
{
    public class Tests
    {
        DragAndDropPage dragAndDrop;
        [SetUp]
        public void Setup()
        {
            WebDriver.Initialize();
            dragAndDrop = new DragAndDropPage();
        }

        [Test]
        public void Test1()
        {
            dragAndDrop.MoveObject();
        }
    }
}