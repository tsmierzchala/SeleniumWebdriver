## Selenium zadania wstępne

#### Zadanie 1 - pierwszy test w Selenium
1. Wyszukaj Selenium WebDriver w wersji 4.1.0 i zaciągnij je do projektu
2. Skorzystaj z gotowego kodu do uruchomienia. Wklej go do klasy `FirstSeleniumTest.cs` odpowiednio rozdzielając na metody:
* `public void Setup()`
* `public void SearchForMyCompanyShouldReturnSomeResults()`
* `public void TearDown()`

Kod do podzielenia
```csharp
driver = new ChromeDriver();
driver.Url = "https://www.bing.com";
driver.FindElement(By.Name("q")).Click();
driver.FindElement(By.Name("q")).SendKeys("MojaFirma");
driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
driver.Quit();
```

3. Uruchom testy. Czy pojawił się jakiś błąd? Co on oznacza? Jak go naprawić?
4. Napraw błąd i sprawdź jeszcze raz czy działa


#### Zadanie 2 - Wyszukiwanie elementów różnymi metodami
Napisz logowanie do panelu SWAGLABS https://www.saucedemo.com/

#### Zadanie 3 - Wyszukiwanie list elementów różnymi metodami
Po zalogowaniu do panelu dopisz kod który znajdzie nazwy przedmiotów na stronie i wypisze je w konsoli.


#### Zadanie 4 - selecty
Posegreguj rzeczy w sklepie od najdroższego do najtańszego.



#### Zadanie 6 - asercje
Po posegregowaniu od najdroższego do najtańszego

Sprawdź czy pierwsze dwa elementy z najwyższą ceną to:
* Sauce Labs Fleece Jacket
* Sauce Labs Backpack

Zmień segregowanie. Ustaw je po nazwie od Z do A.
Sprawdź pierwsze dwa elementy czy są posegregowane prawidłowo.