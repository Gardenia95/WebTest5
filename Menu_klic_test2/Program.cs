using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


    class Program
    {


    static IWebDriver driver = new ChromeDriver();
    static IWebElement dropDownMenu;
    static IWebElement elementFromTheDropDownMenu;

    static void Main()
        {
        
        String menu = "#ck-menu-desktop > a > svg";
        String URL = "https://cinepolisklic.com/";
        

        driver.Navigate().GoToUrl(URL);

        //seleccion de menu 

        IWebElement element = driver.FindElement(By.Id("ck-menu-desktop"));

        if (element.Displayed)
        {
            GreenMessage("MENU");
            element.Click();

        }
        else
        {
            RedMessage("Elemento no encontrado");
        }

    }
    public static void RedMessage(String message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
    public static void GreenMessage(String message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
    public static void BlueMessage(String message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    }
