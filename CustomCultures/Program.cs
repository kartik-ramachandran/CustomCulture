using System;
using System.Collections.Generic;
using System.Globalization;


namespace CustomCultures
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter baseculture followed by space and new culture to be created");
            Console.WriteLine(Environment.NewLine);

            var userinput = Console.ReadLine();

            var inputSplit = userinput.Split(' ');

            CreateCultures(inputSplit[0].ToString(), inputSplit[1].ToString());
        }

        public static void CreateCultures(string baseCulture, string newCulture)
        {
            //Code copied from Microsoft website

            CultureAndRegionInfoBuilder cib = null;

            try
            {
                // Create a CultureAndRegionInfoBuilder object named after new culture
                Console.WriteLine("Create and explore the CultureAndRegionInfoBuilder...\n");
                cib = new CultureAndRegionInfoBuilder(newCulture, CultureAndRegionModifiers.None);

                // Populate the new CultureAndRegionInfoBuilder object with culture information.
                CultureInfo ci = new CultureInfo(baseCulture);
                cib.LoadDataFromCultureInfo(ci);

                // Populate the new CultureAndRegionInfoBuilder object with region information.
                RegionInfo ri = new RegionInfo(baseCulture);
                cib.LoadDataFromRegionInfo(ri);

                // Display some of the properties of the CultureAndRegionInfoBuilder object.
                Console.WriteLine("CultureName:. . . . . . . . . . {0}", cib.CultureName);
                Console.WriteLine("CultureEnglishName: . . . . . . {0}", cib.CultureEnglishName);
                Console.WriteLine("CultureNativeName:. . . . . . . {0}", cib.CultureNativeName);
                Console.WriteLine("GeoId:. . . . . . . . . . . . . {0}", cib.GeoId);
                Console.WriteLine("IsMetric: . . . . . . . . . . . {0}", cib.IsMetric);
                Console.WriteLine("ISOCurrencySymbol:. . . . . . . {0}", cib.ISOCurrencySymbol);
                Console.WriteLine("RegionEnglishName:. . . . . . . {0}", cib.RegionEnglishName);
                Console.WriteLine("RegionName: . . . . . . . . . . {0}", cib.RegionName);
                Console.WriteLine("RegionNativeName: . . . . . . . {0}", cib.RegionNativeName);
                Console.WriteLine("ThreeLetterISOLanguageName: . . {0}", cib.ThreeLetterISOLanguageName);
                Console.WriteLine("ThreeLetterISORegionName: . . . {0}", cib.ThreeLetterISORegionName);
                Console.WriteLine("ThreeLetterWindowsLanguageName: {0}", cib.ThreeLetterWindowsLanguageName);
                Console.WriteLine("ThreeLetterWindowsRegionName: . {0}", cib.ThreeLetterWindowsRegionName);
                Console.WriteLine("TwoLetterISOLanguageName: . . . {0}", cib.TwoLetterISOLanguageName);
                Console.WriteLine("TwoLetterISORegionName: . . . . {0}", cib.TwoLetterISORegionName);
                Console.WriteLine();

                // Register the custom culture.
                Console.WriteLine("Register the custom culture...");
                cib.Register();

                // Display some of the properties of the custom culture.
                Console.WriteLine("Create and explore the custom culture...\n");
                ci = new CultureInfo(newCulture);

                Console.WriteLine("Name: . . . . . . . . . . . . . {0}", ci.Name);
                Console.WriteLine("EnglishName:. . . . . . . . . . {0}", ci.EnglishName);
                Console.WriteLine("NativeName: . . . . . . . . . . {0}", ci.NativeName);
                Console.WriteLine("TwoLetterISOLanguageName: . . . {0}", ci.TwoLetterISOLanguageName);
                Console.WriteLine("ThreeLetterISOLanguageName: . . {0}", ci.ThreeLetterISOLanguageName);
                Console.WriteLine("ThreeLetterWindowsLanguageName: {0}", ci.ThreeLetterWindowsLanguageName);

                Console.WriteLine("\nNote:\n" +
                    "Use the example in the Unregister method topic to remove the custom culture.");

                Console.Read();
            }
            catch (Exception)
            {
                Console.WriteLine("New culture could not be created... please try again !!!!!!!!!!!!!!!!!!");
                Console.Read();
            }
        }
    }
}

