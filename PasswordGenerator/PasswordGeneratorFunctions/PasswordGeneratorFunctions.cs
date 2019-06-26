using System;

namespace PasswordGeneratorFunctions{
    public static class PasswordGeneratorFunctions{


        private static readonly int minAll = 0x21;
        private static readonly int maxAll = 0x7E;

        private static readonly int minOnlyLetters= 0x41;
        private static readonly int maxOnlyLetters = 0x5A;

        public static string generatePassword(int length = 8, bool onlyLetters = false) {
            if (length < 1) {
                return null;
            }
            char[] passArr = new char[length];
            Random rnd = new Random();
            for (int i = 0; i < length; i++) {
                if (onlyLetters) {
                    int code = rnd.Next(minOnlyLetters, maxOnlyLetters);
                    code += rnd.Next(0, 2) == 1 ? 32 : 0;   //random lowercase
                    passArr[i] = (char) code;
                }
                else {
                    passArr[i] = (char)rnd.Next(minAll, maxAll);
                }
                
            }
            return new string(passArr);
        }
       

    }
}
