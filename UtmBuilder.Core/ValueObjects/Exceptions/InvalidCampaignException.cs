using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtmBuilder.Core.ValueObjects.Exceptions
{
    public class InvalidCampaignException : Exception
    {
        private const string DefaultErrorMessage = "Invalid UTM parameteres";

        public InvalidCampaignException(string message = DefaultErrorMessage)
            : base(message)
        {
        }

        public static void TrhowIfInvalid(
            string address,
            string message = DefaultErrorMessage)
        {
            if (string.IsNullOrEmpty(address))
                throw new InvalidCampaignException(message);
        }
    }
}
