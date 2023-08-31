using System.Collections.Specialized;
using System.Numerics;

namespace VIN_CALLED_YHIS_SMTH
{
    public class boolean_check_vin
    {
        public Boolean check_vin(string a) 
        {
            string RRR = "0123456789ABCDEFGHJKLMNPRSTUVWXYZ";
            int number = 0;
            for (int i = 0; i < a.Length ; i++) 
            {
                if (RRR.Contains(a[i])) 
                { 
                    number += 1;
                }
            }
            if (number == a.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public String get_country(string a)
        {
            string first_vin = a.Substring(11, 1);
            string second_vin = a.Substring(12, 1);
            string Africa = "ABCDEFGH";
            string Asia = "JKLMNPR";
            string Europe = "STUVWXYZ";
            string North_America = "12345";
            string Oceania = "67";
            string South_America = "89";
            string Country = "";

            if (Africa.Contains(first_vin))
            {
                if (second_vin == "H")
                {
                    Country = "ЮАР";
                }

                else if (second_vin == "J")
                {
                    Country = "Кот-'дИвуар";
                }

                else if (second_vin == "P")
                {
                    Country = "Не используется";
                }
            }
            else if (Asia.Contains(first_vin))
            {
                if (second_vin == "A")
                {
                    Country = "Япония";
                }
            }
            else if (Europe.Contains(first_vin))
            {
                if (second_vin == "A")
                {
                    Country = "Великобритания";
                }

                else if (second_vin == "N")
                {
                    Country = "Германия";
                }

                else if (second_vin == "U")
                {
                    Country = "Польша";
                }
            }
            else if (North_America.Contains(first_vin))
            {
                if (second_vin == "A")
                {
                    Country = "США";
                }
            }
            else if (Oceania.Contains(first_vin))
            {
                if (second_vin == "W")
                {
                    Country = "Австралия";
                }
                else if (second_vin == "X")
                {
                    Country = "Не используется";
                }
            }
            else if (South_America.Contains(first_vin))
            {
                if (second_vin == "A")
                {
                    Country = "Аргентина";
                }
                else if (second_vin == "F")
                {
                    Country = "Чили";
                }
                else if (second_vin == "3")
                {
                    Country = "Не используется";
                }
            }
            return Country;


        }
        public int get_year(string a)
        {

            Dictionary<string, int> VVV = new Dictionary<string, int>();

            VVV.Add("A", 1980);
            VVV.Add("B", 1981);
            VVV.Add("C", 1982);
            VVV.Add("D", 1983);
            VVV.Add("E", 1984);
            VVV.Add("F", 1985);
            VVV.Add("G", 1986);
            VVV.Add("H", 1987);
            VVV.Add("J", 1988);
            VVV.Add("K", 1989);
            VVV.Add("L", 1990);
            VVV.Add("M", 1991);
            VVV.Add("N", 1992);
            VVV.Add("P", 1993);
            VVV.Add("R", 1994);
            VVV.Add("S", 1995);
            VVV.Add("T", 1996);
            VVV.Add("V", 1997);
            VVV.Add("W", 1998);
            VVV.Add("X", 1999);
            VVV.Add("Y", 2000);
            VVV.Add("1", 2001);
            VVV.Add("2", 2002);
            VVV.Add("3", 2003);
            VVV.Add("4", 2004);
            VVV.Add("5", 2005);
            VVV.Add("6", 2006);
            VVV.Add("7", 2007);
            VVV.Add("8", 2008);
            VVV.Add("9", 2009);

            string index = a.Substring(9, 1);
            int resault = VVV[index];
            return resault;
        }
    }
}