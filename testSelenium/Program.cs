using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.Extensions;

namespace testSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "XXX";//You should write your instagram account mail orr username
            string password = "XXX";//You should write your instagram password
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.instagram.com/";
            Thread.Sleep(5000);
            IWebElement userBar = driver.FindElement(By.Name("username"));
            IWebElement passBar = driver.FindElement(By.Name("password"));                  
            userBar.SendKeys(username);
            passBar.SendKeys(password);

            IWebElement button2 = driver.FindElements(By.TagName("button"))[1];
            button2.Click();
            Thread.Sleep(6000);

            IWebElement button3 = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[3]/button[2]"));
            button3.Click();

            driver.Url = "XXX";//You must paste the URL the person you want. With https
            Thread.Sleep(1000);

            IWebElement button4 = driver.FindElement(By.XPath("/html/body/div[1]/section/main/div/header/section/ul/li[2]/a"));
            button4.Click();
            Thread.Sleep(1000);

            driver.ExecuteJavaScript("function scpDt_stb2pp3(lastEntity, loadCount = -1) {     if(loadCount != -1)     {        var willFail = parseInt(document.evaluate(' / html / body / div[1] / section / main / div / header / section / ul" +
                " / li[2] / a / span', document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue.title.replace(',','').replace('.','')) < loadCount;        if(willFail)         {            console.log('NAIS');    " +
                "        return;        }    }        var target = loadCount == -1 ? parseInt(document.evaluate(' / html / body / div[1] / section / main / div / header / section / ul / li[2] / a / span', document, null, XPathResult" +
                ".FIRST_ORDERED_NODE_TYPE, null).singleNodeValue.title.replace(',','').replace('.','')) : loadCount;    if(document.getElementsByClassName('PZuss')[0] == null || (document.getElementsByClassName('PZuss')[0].childEleme" +
                "ntCount+30) == lastEntity)     {         setTimeout(() => {            if(loadCount == -1)             {                scpDt_stb2pp3(lastEntity);            }            else scpDt_stb2pp3(lastEntity, l" +
                "oadCount);        }, 50);         return;     }     var targetRange = document.getElementsByClassName('PZuss')[0].childElementCount+30<target;    console.log(target);     console.log(targetRange);     if(targetRange)     {    " +
                "     setTimeout(() => {             document.getElementsByClassName('isgrP')[0].scrollTo(0,document.getElementsByClassName('isgrP')[0].scrollHeight);             if(loadCount == -1)             {             " +
                "   scpDt_stb2pp3(lastEntity);            }            else scpDt_stb2pp3(lastEntity, loadCount);        }, 50);     } } scpDt_stb2pp3(-1,35);");// NOTE: You can follow 35 people per hour. 35 is LIMIT. If you change the 35 number you could get banned for 12hr,24hr,36hr,48hr,60hr,72hr or PERMA.

            Thread.Sleep(15000);

            Console.WriteLine("For Loop Starting");

            for (int i = 1; i < 35 ; i++) 
            {                
                IWebElement button5 = driver.FindElement(By.XPath("/ html / body / div[4] / div / div[2] / ul / div / li[" + i + "] / div / div[2] / button"));
                if (button5.Text.Contains("Takip Et"))
                {
                    Console.WriteLine("Button will be pressed");
                    button5.Click();
                    while (!button5.Text.Contains("İstek Gönderildi") && !button5.Text.Contains("Takiptesin"))//Change these according to your own language
                    {
                        Thread.Sleep(8000);//NOTE: 8 sec is a limit please dont change 
                        Console.WriteLine("Waiting " + button5.Text);
                    }
                }
                else
                {
                    Console.WriteLine("Skipped");
                }           
                
            }

            Console.ReadLine();
            driver.Quit();

        }
    }
}