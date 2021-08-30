using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
//using Microsoft.VisualStudio.TestPlatform.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Franklin_Montenegro
{
    class TestPracticaScrum
    {
        public IWebDriver driver = new ChromeDriver(@"C:\Users\Administrador\Desktop\Curso_Scrum\01_Practica\Franklin_Montenegro\Franklin_Montenegro\bin\Debug\net5.0\");
        public string urlBase = "https://admin-sysnnova.com/OpenFact/Account/Login.aspx?AspxDetectCookieSupport=1";

        [Test]
        public void RegistroTest() 
        {
            ITakesScreenshot ScreenShotDrive = driver as ITakesScreenshot;
            Screenshot screenshot = ScreenShotDrive.GetScreenshot();

            try
            {

                driver.Navigate().GoToUrl(urlBase);

                //Maximizar navegador
                driver.Manage().Window.Maximize();

                //Setear User
                driver.FindElement(By.Id("LoginUser_UserName"));
                driver.FindElement(By.Id("LoginUser_UserName")).Click();
                driver.FindElement(By.Id("LoginUser_UserName")).SendKeys("Demo");

                //Setear Pass
                driver.FindElement(By.Id("LoginUser_Password"));
                driver.FindElement(By.Id("LoginUser_Password")).Click();
                driver.FindElement(By.Id("LoginUser_Password")).SendKeys("0430");

                //Pausa ante de ejecutar siguiente evento
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));

                //Aplicar Click Button 
                driver.FindElement(By.Id("LoginUser_LoginButton")).Click();

                //Grabar Print de Test Login
                screenshot.SaveAsFile(@"C:\Users\Administrador\Desktop\Curso_Scrum\02_Print_TestPractica\TestLogin.png");


                //Pausa ante de ejecutar siguiente evento
                WebDriverWait wait2 = new WebDriverWait(driver, new TimeSpan(0, 0, 10));

                driver.FindElement(By.Id("liClientes")).Click();
                Thread.Sleep(3000);

                //Pausa ante de ejecutar siguiente evento
                WebDriverWait wait3 = new WebDriverWait(driver, new TimeSpan(0, 0, 10));

                //Ejecutar menú opción cliente 
                driver.FindElement(By.Id("MainContent_btnAdd")).Click();
                Thread.Sleep(2000);

                //Pausa ante de ejecutar siguiente evento
                WebDriverWait wait4 = new WebDriverWait(driver, new TimeSpan(0, 0, 10));

                //Asignar valores del formulario
                driver.FindElement(By.Id("MainContent_txtNombreCliente"));
                driver.FindElement(By.Id("MainContent_txtNombreCliente")).Click();
                driver.FindElement(By.Id("MainContent_txtNombreCliente")).SendKeys("Franklin Jose Montenegro");
                Thread.Sleep(2000);

                driver.FindElement(By.Id("MainContent_txtIdentificacion"));
                driver.FindElement(By.Id("MainContent_txtIdentificacion")).Click();
                driver.FindElement(By.Id("MainContent_txtIdentificacion")).SendKeys("0962780699001");
                Thread.Sleep(2000);

                driver.FindElement(By.Id("MainContent_txtTelefonoConvencional"));
                driver.FindElement(By.Id("MainContent_txtTelefonoConvencional")).Click();
                driver.FindElement(By.Id("MainContent_txtTelefonoConvencional")).SendKeys("045067169");
                Thread.Sleep(2000);

                driver.FindElement(By.Id("MainContent_txtDireccion"));
                driver.FindElement(By.Id("MainContent_txtDireccion")).Click();
                driver.FindElement(By.Id("MainContent_txtDireccion")).SendKeys("Sauces 4");
                Thread.Sleep(2000);

                driver.FindElement(By.Id("MainContent_txtMailDefecto"));
                driver.FindElement(By.Id("MainContent_txtMailDefecto")).Click();
                driver.FindElement(By.Id("MainContent_txtMailDefecto")).SendKeys("montenegrofranklin2011@gmail.com");
                Thread.Sleep(2000);

                driver.FindElement(By.Id("MainContent_txtTelefonoCelular"));
                driver.FindElement(By.Id("MainContent_txtTelefonoCelular")).Click();
                driver.FindElement(By.Id("MainContent_txtTelefonoCelular")).SendKeys("0981788280");
                Thread.Sleep(2000);

                var TipoIndent = driver.FindElement(By.Id("MainContent_ddlTipoIdentificacion"));
                var selectElement = new SelectElement(TipoIndent);
                selectElement.SelectByValue("04");
                Thread.Sleep(2000);
                //Fin Asignar Datos 

                //Close Mensaje
                IWebElement Check1 = driver.FindElement(By.Id("MainContent_cbxEnviarBienvenida"));
                Check1.Click();
                Thread.Sleep(2000);

                //Ejecutar evento guardar
                driver.FindElement(By.Id("MainContent_btnGuardarCliente")).Click();
                Thread.Sleep(4000);


                //Grabar Print de grabar
                screenshot.SaveAsFile(@"C:\Users\Administrador\Desktop\Curso_Scrum\02_Print_TestPractica\GrabarOK_" +  DateTime.Now.Ticks.ToString() +".png");


                //Franklin Montenegro 30/08/2021

            }
            catch (Exception ex)
            {

                //Grabar Print de error
                screenshot.SaveAsFile(@"C:\Users\Administrador\Desktop\Curso_Scrum\02_Print_TestPractica\Error_" + DateTime.Now.Ticks.ToString() + ".png");
                driver.Close();
            }

        }

    }
}
