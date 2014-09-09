using System;
using EdFi.Rest.Sdk;
using RestSharp;
using EdFi.Rest.Client.Sdk.Models;

namespace EdFi.Rest.Sample.UnitTests
{
    public abstract class BaseFixture
    {
        private static readonly Random Rand = new Random(DateTime.Now.Second);

        #region App Setting Values
        protected static int LocalEducationAgencyId
        {
            get { return int.Parse(System.Configuration.ConfigurationManager.AppSettings["LocalEducationAgencyId"]); }
        }

        protected static int StateEducationAgencyId
        {
            get { return int.Parse(System.Configuration.ConfigurationManager.AppSettings["StateEducationAgencyId"]); }
        }

        protected static int SchoolId
        {
            get { return int.Parse(System.Configuration.ConfigurationManager.AppSettings["SchoolId"]); }
        }

        protected static int SchoolIdInDifferentDistrict
        {
            get { return int.Parse(System.Configuration.ConfigurationManager.AppSettings["SchoolIdInDifferentDistrict"]); }
        }

        protected static string GradeLevelDescriptor
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["GradeLevelDescriptor"]; }
        }

        protected static string GradingPeriodDescriptor
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["GradingPeriodDescriptor"]; }
        }

        protected static string CalendarEventDescriptor
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["CalendarEventDescriptor"]; }
        }

        protected static string StaffClassificationDescriptor
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["StaffClassificationDescriptor"]; }
        }

        protected static string TermType
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["TermType"]; }
        }

        protected static string CourseCode
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["CourseCode"]; }
        }

        protected static string GraduationPlanTypeDescriptor
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["GraduationPlanTypeDescriptor"]; }
        }

        protected static string AttendanceEventCategoryDescriptor
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["AttendanceEventCategoryDescriptor"]; }
        }

        protected static string ProgramName
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["ProgramName"]; }
        }

        protected static string ProgramType
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["ProgramType"]; }
        }

        protected static string SpecialEducationSettingDescriptor
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["SpecialEducationSettingDescriptor"]; }
        }

        protected static short CurrentSchoolYear
        {
            get { return short.Parse(System.Configuration.ConfigurationManager.AppSettings["CurrentSchoolYear"]); }
        }

        protected static string ProgramAssignmentDescriptor
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["ProgramAssignmentDescriptor"]; }
        }
        #endregion

        protected  static TokenRetriever GetTokenRetriever()
        {
            // Trust all SSL certs -- needed for now until signed SSL certificates are configured.
            System.Net.ServicePointManager.ServerCertificateValidationCallback =
                ((sender, certificate, chain, sslPolicyErrors) => true);

            // Oauth configuration
            var oauthUrl = System.Configuration.ConfigurationManager.AppSettings["Admin"];
            var clientKey = System.Configuration.ConfigurationManager.AppSettings["Key"];
            var clientSecret = System.Configuration.ConfigurationManager.AppSettings["Secret"];

            // TokenRetriever makes the oauth  calls
            return new TokenRetriever(oauthUrl, clientKey, clientSecret);
        }

        protected static RestClient GetClientWithSchoolYear()
        {
            var client = new RestClient(System.Configuration.ConfigurationManager.AppSettings["Api"] + "/" + CurrentSchoolYear);

            client.Authenticator = new BearerTokenAuthenticator(GetTokenRetriever());

            return client;
        }

        protected static RestClient GetClientWithoutSchoolYear()
        {
            var client = new RestClient(System.Configuration.ConfigurationManager.AppSettings["Api"]);

            client.Authenticator = new BearerTokenAuthenticator(GetTokenRetriever());

            return client;
        }

        protected Identity NewRandomIdentity()
        {
            var maleNames = new[] { "Frans", "Rustin", "Benito", "Arnold", "Haven", "Kerr", "Donal", "Russell", "Alaric", "Obadiah", "Germain", "Mitchael", "Rhys", "Tobias", "Pepillo", "Quent", "Virgilio", "Constantin", "Patin", "Warner", "Trumann", "Ruddie", "Khalil", "Gaelan" };
            var femaleNames = new[] { "Violetta", "Cindy", "Konstanze", "Kerrin", "Regan", "Ashil", "Marty", "Aubine", "Morganica", "Magdalene", "Nancee", "Kessia", "Carolann", "Dotti", "Melonie", "Malory", "Abby", "Angele", "Chelsy" };
            var lastNames = new[] { "Brugnara", "Todorovic", "Byerly", "Lucretius", "Merighi", "Jendrock", "Michael", "Nesson", "Biddle", "Wankaner", "Miccoli", "Lorsch", "Aitken", "Yost", "Bilotta", "Golub", "Dodge", "Higbie", "Mishkin" };

            string[] firstNames;
            string gender;

            if (Rand.Next(1, 2) == 1)
            {
                gender = "Male";
                firstNames = maleNames;
            }
            else
            {
                gender = "Female";
                firstNames = femaleNames;
            }

            return new Identity
            {
                givenNames = firstNames[Rand.Next(0, firstNames.Length - 1)],
                familyNames = lastNames[Rand.Next(0, lastNames.Length - 1)],
                birthGender = gender,
                birthDate = NewRandomDate().ToString("MM/dd/yyyy"),
            };
        }

        protected static DateTime NewRandomDate()
        {
            return new DateTime(Rand.Next(1990, 2008), Rand.Next(1, 12), Rand.Next(1, 28));
        }
    }
}
