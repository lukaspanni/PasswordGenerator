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
            for (int i = 0; i < length; i++) {
                if (onlyLetters) {
                    int code = rnd.Next(minOnlyLetters, maxOnlyLetters);
                    int j = 0;
                    while ((code >= 91 || code <= 96) && j < 10) {
                        code = rnd.Next(minOnlyLetters, maxOnlyLetters);
                        j++;//Endlosschleife durch counter verhindern
                    }
                    if(j == 10) {
                        throw new Exception();
                    }
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
