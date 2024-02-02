using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Affine;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void AffineEncrypt_ShouldEncryptTextCorrectly()
        {
            // Arrange
            cipherForm cipherForm = new cipherForm();
            string plainText = "mama";
            int keyA = 3;
            int keyB = 5;

            // Act
            string encryptedText = cipherForm.AffineEncrypt(plainText, keyA, keyB);

            // Assert
            Assert.AreEqual("pfpf", encryptedText);
        }

        [TestMethod]
        public void AffineDecrypt_ShouldDecryptTextCorrectly()
        {
            // Arrange
            cipherForm cipherForm = new cipherForm();
            string cipherText = "pfpf";
            int keyA = 3;
            int keyB = 5;

            // Act
            string decryptedText = cipherForm.AffineDecrypt(cipherText, keyA, keyB);

            // Assert
            Assert.AreEqual("mama", decryptedText);
        }

        [TestMethod]
        public void MultiplicativeInverse_ShouldReturnCorrectValue()
        {
            // Arrange
            cipherForm cipherForm = new cipherForm();
            int a = 3;

            // Act
            int inverse = cipherForm.MultiplicativeInverse(a);

            // Assert
            Assert.AreEqual(9, inverse);
        }

        [TestMethod]
        public void IsCoprime_ShouldReturnTrueForCoprimeNumbers()
        {
            // Arrange
            cipherForm cipherForm = new cipherForm();
            int a = 3;
            int b = 26;

            // Act
            bool result = cipherForm.IsCoprime(a, b);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsCoprime_ShouldReturnFalseForNonCoprimeNumbers()
        {
            // Arrange
            cipherForm cipherForm = new cipherForm();
            int a = 2;
            int b = 4;

            // Act
            bool result = cipherForm.IsCoprime(a, b);

            // Assert
            Assert.IsFalse(result);
        }
        
            [TestMethod]
            public void TestUserExistenceInDatabase()
            {
                // Arrange
                loginForm loginForm = new loginForm();
                string existingUser = "100";
                string existingPassword = "100";

                // Act
                bool userExists = loginForm.CheckUserExistsInDatabase(existingUser, existingPassword);

                // Assert
                Assert.IsTrue(userExists, "User should exist in the database.");
            }

            [TestMethod]
            public void TestUserNonExistenceInDatabase()
            {
                // Arrange
                loginForm loginForm = new loginForm();
                string nonExistingUser = "чужак";
                string invalidPassword = "чужакович";

                // Act
                bool userExists = loginForm.CheckUserExistsInDatabase(nonExistingUser, invalidPassword);

                // Assert
                Assert.IsFalse(userExists, "User should not exist in the database.");
            }
        }
    }
