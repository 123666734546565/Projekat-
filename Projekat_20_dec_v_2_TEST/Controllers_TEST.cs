using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Projekat_20_dec_v_2;
using Projekat_20_dec_v_2.Controllers;
using Projekat_20_dec_v_2.Models;

namespace Projekat_20_dec_v_2_TEST
{
    [TestClass]
    public class Controllers_TEST
    {
        [TestMethod]
        public void Index_HomeController_TEST()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ViewResult result = controller.Index() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About_HomeController_TEST()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ViewResult result = controller.About() as ViewResult;

            //Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact_HomeController_TEST()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ViewResult result = controller.Contact() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void SignInManager_AccountController_TEST()
        {
            //Arrange

            //Act

            //Assert

        }

        [TestMethod]
        public void UserManager_AccountController_TEST()
        {
            //Arrange

            //Act

            //Assert

        }

        [TestMethod]
        public void Login_AccountController_TEST()
        {
            //Arrange
            AccountController controller = new AccountController();

            //Act
            ViewResult result = controller.Login("Nesto") as ViewResult;

            //Assert
            Assert.AreEqual("Nesto", result.ViewBag.Message);

        }

        [TestMethod]
        public void Login_AccountController_TEST_2()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void VerifyCode_AccountController_TEST()
        {
            //Arrange

            //Act

            //Assert

        }

        [TestMethod]
        public void VerifyCode_AccountController_TEST_2()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void Register_AccountController_TEST()
        {
            //Arrange
            AccountController controller = new AccountController();

            //Act
            ViewResult result = controller.Register() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Register_AccountController_TEST_2()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void ConfirmEmail_AccountController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void ForgotPassword_AccountController_TEST()
        {
            //Arrange
            AccountController controller = new AccountController();

            //Act
            ViewResult result = controller.ForgotPassword() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ForgotPassword_AccountController_TEST_2()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void ForgotPasswordConfirmation_AccountController_TEST()
        {
            //Arrange
            AccountController controller = new AccountController();

            //Act
            ViewResult result = controller.ForgotPasswordConfirmation() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ResetPassword_AccountController_TEST()
        {
            //Arrange

            //Act

            //Assert

        }

        [TestMethod]
        public void ResetPassword_AccountController_TEST_2()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void ResetPasswordConfirmation_AccountController_TEST()
        {
            //Arrange
            AccountController controller = new AccountController();

            //Act
            ViewResult result = controller.ResetPasswordConfirmation() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ExternalLogin_AccountController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void SendCode_AccountController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void SendCode_AccountController_TEST_2()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void ExternalLoginCallback_AccountController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void ExternalLoginConfirmation_AccountController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void LogOff_AccountController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void ExternalLoginFailure_AccountController_TEST()
        {
            //Arrange
            AccountController controller = new AccountController();

            //Act
            ViewResult result = controller.ExternalLoginFailure() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Dispose_AccountController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void Index_ManageController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void SignInManager_ManageController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void UserManager_ManageController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void RemoveLogin_ManageController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void AddPhoneNumber_ManageController_TEST()
        {
            //Arrange
            ManageController controller = new ManageController();

            //Act
            ViewResult result = controller.AddPhoneNumber() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void AddPhoneNumber_ManageController_TEST_2()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void EnableTwoFactorAuthentication_ManageController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void DisableTwoFactorAuthentication_ManageController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void VerifyPhoneNumber_ManageController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void VerifyPhoneNumber_ManageController_TEST_2()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void RemovePhoneNumber_ManageController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void ChangePassword_ManageController_TEST()
        {
            //Arrange
            ManageController controller = new ManageController();

            //Act
            ViewResult result = controller.ChangePassword() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ChangePassword_ManageController_TEST_2()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void SetPassword_ManageController_TEST()
        {
            //Arrange
            ManageController controller = new ManageController();

            //Act
            ViewResult result = controller.SetPassword() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void SetPassword_ManageController_TEST_2()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void ManageLogins_ManageController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void LinkLogin_ManageController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void LinkLoginCallback_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void Dispose_ManageController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void Index_ObrazacController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void Details_ObrazacController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void Create_ObrazacController_TEST()
        {
            //Arrange
            ObrazacsController controller = new ObrazacsController();

            //Act
            ViewResult result = controller.Create() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Create_ObrazacController_TEST_2()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void Edit_ObrazacController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void Edit_ObrazacController_TEST_2()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void Delete_ObrazacController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void DeleteConfirmed_ObrazacController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void Dispose_ObrazacController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void RoleManager_PravaPristupaController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void Index_PravaPristupaController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void Create_PravaPristupaController_TEST()
        {
            //Arrange
            PravaPristupaController controller = new PravaPristupaController();

            //Act
            ViewResult result = controller.Create() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Create_PravaPristupaController_TEST_2()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void Edit_PravaPristupaController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void Edit_PravaPristupaController_TEST_2()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void Details_PravaPristupaController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void Delete_PravaPristupaController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void DeleteConfirmed_PravaPristupaController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void UserManager_UserRoleController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void RoleManager_UserRoleController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void SignInManager_UserRoleController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void GetMD5Hash_UserRoleController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void Index_UserRoleController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void Create_UserRoleController_TEST()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
