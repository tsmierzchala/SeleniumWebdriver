## Selenium Webdriver

#### Zadanie 1
1. Wyszukaj Selenium WebDriver w wersji 4.1.0 i zaci¹gnij je do projektu
2. Skorzystaj z gotowego kodu do uruchomienia. SprawdŸ czy u Ciebie dzia³a:
```csharp
driver = new ChromeDriver();
driver.Url = "https://www.bing.com";
driver.FindElement(By.Name("q")).Click();
driver.FindElement(By.Name("q")).SendKeys("MojaFirma");
driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
driver.Quit();
```

3. Czy pojawi³ siê jakiœ b³¹d? Co on oznacza? Jak go naprawiæ?
4. Napraw b³¹d i sprawdŸ jeszcze raz czy dzia³a







#### Snippets
W cmd.exe odpal ubicie procesów chromedriver.exe
```shell
taskkill /f /im chromedriver.exe
```