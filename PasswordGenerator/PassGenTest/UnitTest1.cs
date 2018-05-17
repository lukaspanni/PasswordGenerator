using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordGeneratorFunctions;
using System;

namespace PassGenTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCorrectLength(){
            string[] res = new string[10];
            int[] len = { 5, 8, 6, 3, 7, 8, 5, 1, 2, 3 };
            for (int i = 0; i < 10; i++) {
                res[i] = PasswordGeneratorFunctions.PasswordGeneratorFunctions.generatePassword(len[i]);
                if(Assert.Equals(res[i], len[i])) {
                    Console.WriteLine("true");
                }
                else {
                    Console.WriteLine("false");
                }
            }
        }

        [TestMethod]
        public void TestNull() {
            int[] len = { 0, -1, -8, -9 };
            for(int i = 0; i < 4; i++) {
                Assert.IsNull(PasswordGeneratorFunctions.PasswordGeneratorFunctions.generatePassword(len[i]), "failed");
            }
        }
    }
}
