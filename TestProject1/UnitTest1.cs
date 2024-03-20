using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    public class Tests
    {
        private IWebDriver _driver;
        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
        }

       // Create Product
        [Test]
        public void CreateProduct()
        {
            _driver.Navigate().GoToUrl("http://localhost:5120/Products/Create");
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("ProductName")).SendKeys("Prime");
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("Price")).SendKeys("59");
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("Qty")).SendKeys("2000");
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("Save")).Click();
            Thread.Sleep(2000);
            Assert.Pass();
        }
        
        // Update Product
        [Test]
        public void UpdateProduct()
        {
            _driver.Navigate().GoToUrl("http://localhost:5120/Products/Edit/089905c6-2319-4874-9124-10942f8fb7df");
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("ProductName")).Clear();
            _driver.FindElement(By.Id("ProductName")).SendKeys("Angkor Bear");
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("Price")).Clear();
            _driver.FindElement(By.Id("Price")).SendKeys("5");
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("Qty")).Clear();
            _driver.FindElement(By.Id("Qty")).SendKeys("30");
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("Save")).Click();
            Assert.Pass();
        }

        // Delete Product
        [Test]
        public void DeleteProduct()
        {
            _driver.Navigate().GoToUrl("http://localhost:5120/Products/Delete/f10e1528-fefd-40f9-bf35-3559cb74c55e");
    
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("Delete")).Click();

            Assert.Pass();

        }

        //Select Product
        [Test]
        public void SelectProduct()
        {
            _driver.Navigate().GoToUrl("http://localhost:5120/Products/Details/089905c6-2319-4874-9124-10942f8fb7df");
            
            Thread.Sleep(5000);
            Assert.Pass();

        }

        [TearDown]
        public void TearDown()
        {
            _driver.Dispose();
            _driver.Quit();
        }
    }
}