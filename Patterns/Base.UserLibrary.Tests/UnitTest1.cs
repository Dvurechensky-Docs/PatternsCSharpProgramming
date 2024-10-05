namespace Base.UserLibrary.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private TestContext testContextInstance;
        public TestContext TestContextInstance
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        private UserManagerMsTest manager = new UserManagerMsTest();

        /// <summary>
        /// DataSource - определение источника данных
        /// 1 параметр - имя провайдера
        /// 2 параметр - строка подключения или путь к файлу
        /// 3 параметр - имя таблицы или элемента XML
        /// 4 параметр - как происходит доступ к записям из источника данных
        /// </summary>
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "TestData.xml",
            "User",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void AddDataTest()
        {
            string userId = Convert.ToString(TestContextInstance.DataRow["Row1"]);
        }
    }
}