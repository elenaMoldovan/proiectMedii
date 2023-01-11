using System;

namespace IbanGeneratorLibrary

{
    public class Generator
    {
        // 22 digits
        public static string getEuroIban()
        {
            string iban = "RO";

            iban += randomNumber() + randomNumber();
            iban += "BTRLEURCRT";

            for (int i = 0; i < 10; i++)
            { 
                iban += randomNumber();
            }

            return iban;
        }

        public static string getRonIban()
        {
            string iban = "RO";

            iban += randomNumber() + randomNumber();
            iban += "BTRLRONCRT";

            for (int i = 0; i < 10; i++)
            {
                iban += randomNumber();
            }

            return iban;
        }

        private static int randomNumber()
        {
            Random random = new Random();

            return random.Next(0, 9);
        }

    }
}