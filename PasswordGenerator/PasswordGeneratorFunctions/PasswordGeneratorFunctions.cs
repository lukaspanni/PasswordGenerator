using System;

namespace PasswordGeneratorFunctions
{
    public static class PasswordGeneratorFunctions
    {
        public static string generatePassword(int length=8) {
            if (length < 1)
                return null;
            char[] passArr = new char[length];
            Random rnd = new Random();
            for (int i = 0; i < length; i++) {
                passArr[i] = (char)rnd.Next(33, 126);
            }
            return new string(passArr);
        }

    }
}
