using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevSpaceR.Helpers
{
    public static class UserEntityConstants
    {
        public const int NameMaxLength = 30;

        public const int PhoneNumberMaxLength = 20;

        public const int AddressMaxLength = 40;

        public const int CountryMaxLength = 25;

        public const int DescriptionMaxLength = 150;

        public const int GitHubMaxLength = 45;

        public const int LinkedInMaxLength = 45;

        public const int EmailMaxLength = 40;

        public const bool NameRequired = true;

        public const bool PhoneNumberRequired = true;

        public const bool AddressRequired = true;

        public const bool CountryRequired = true;

        public const bool DescriptionRequired = true;

        public const bool GitHubRequired = false;

        public const bool LinkedInRequired = false;

        public const bool EmailRequired = true;
    }
}
