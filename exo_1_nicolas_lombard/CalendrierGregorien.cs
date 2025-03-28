﻿namespace NombresRomains;

public static class NombresRomainsExtensions
{
    public const string ErrorMessage = "Votre nombre n'est pas pris en charge.";

    public static string ToRomanNumbers(this int number)
    {
        switch (number)
        {
            case <= 3:
                return new string('I', number);
            case 4:
                return "IV";
            case 5:
                return "V";
            case 6:
                return "VI";
            case 7:
                return "VII";
            case 8:
                return "VIII";
            case 9:
                return "IX";
            case 10:
                return "X";
            case 11:
                return "XI";
            case 12:
                return "XII";
            case 13:
                return "XIII";
            case 14:
                return "XIV";
            case 15:
                return "XV";
            case 16:
                return "XVI";
            case 17:
                return "XVII";
            case 18:
                return "XVIII";
            case 19:
                return "XIX";
            case 20:
                return "XX";
            default:
                return ErrorMessage;
        }
    }
}