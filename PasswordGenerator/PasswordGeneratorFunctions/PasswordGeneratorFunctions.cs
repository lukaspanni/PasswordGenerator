using System;

namespace PasswordGeneratorFunctions{
    public static class PasswordGeneratorFunctions{

        private static int minAll = 33;
        private static int maxAll = 126;

        private static int minOnlyLetters= 65;
        private static int maxOnlyLetters = 122;

        public static string generatePassword(int length = 8, bool onlyLetters = false) {
            if (length < 1) {
                return null;
            }
            char[] passArr = new char[length];
            Random rnd = new Random();
            int min, max;
            if (onlyLetters) {
                min = minOnlyLetters;
                max = maxOnlyLetters;
            }
            else {
                min = minAll;
                max = maxAll;
            }
            for (int i = 0; i < length; i++) {
                passArr[i] = (char)rnd.Next(min, max);
            }
            return new string(passArr);
        }
       

    }
}
