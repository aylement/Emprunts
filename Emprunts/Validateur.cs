using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;


namespace ClassLibraryVerificateur
{
    public class Validateur
    {
        public static bool VerifierNom(string _texteAVerifier)
        {
          return  Regex.IsMatch(_texteAVerifier, @"^[a-zA-Z]{2,30}$");
        }
        public static bool VerifierDate(string _dateAVerifier)
        {
            DateTime date;
            return DateTime.TryParseExact(_dateAVerifier, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
        }
        public static bool VerifierMontant(string _montantAVerifier)
        {
            return Regex.IsMatch(_montantAVerifier, @"^[0-9]*(?:d\d)?$");
        }
        public static bool VerifierCP(string _CPAVerifier)
        {
            return Regex.IsMatch(_CPAVerifier, @"^[0-9]{5}$");
        }
    }
}
