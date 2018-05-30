using System;
using System.Net;
using ConsoleApp1.CardServiceClient;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CardV1Client cl = new CardV1Client();

            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

            var ptsRequest = new createCardHolderCardAccountV1R8Request
            {
                createCardHolderCardAccountV1R8Request1 = new CreateCardHolderCardAccountV1R8RequestType
                {
                    processingCompany = "164",
                    processingRelationshipCode = "164,BS001",
                    programSolicitationCode = "RVVBV1YA",
                    cardHolderDetails = new CardHolderDetailsType(),
                    activateCard = true,
                    activateCardSpecified = true,
                    returnCVC2 = true,
                    returnCVC2Specified = true
                },
                simpleSecurityAssertion = new CsrSimpleSecurityAssertionType
                {
                    authenticationStrength = CsrAuthenticationStrengthType.LAST_MILE_TWO_FACTOR,
                    channel = "WAP_WS",
                    servicingCenter = "901933", //old: 901831 new: 901933
                    role = "900956.GreenDot-MSR",
                    userId = "900956.GreenDot-MSR"
                }
            };
            ptsRequest.createCardHolderCardAccountV1R8Request1.cardHolderDetails.addressList = new[]
            {
                new CardHolderAddressType
                {
                    postalAddress = new PostalAddressWithDateRangeType
                    {
                        addressLine = new []{ "80812 ggilgchikcvbxgx" },
                        city = "gtqhlqqjvl",
                        countrySubdivision = "CA",
                        country = null,
                        postalCode = "75950",
                        county = null
                    }
                }
            };
            ptsRequest.createCardHolderCardAccountV1R8Request1.cardHolderDetails.cardHolderName = new CardHolderNameType
            {
                firstName = "loytigppfn",
                middleInitial = null,
                lastName = "iyguziwhjb"
            };

            ptsRequest.createCardHolderCardAccountV1R8Request1.cardHolderDetails.dateOfBirthSpecified = false;

            ptsRequest.createCardHolderCardAccountV1R8Request1.cardHolderDetails.taxId = null;

            ptsRequest.createCardHolderCardAccountV1R8Request1.cardHolderDetails.phoneNumbers =
                new[]
                {
                    new PhoneNumberWithDateRangeInfoType
                    {
                        endDate = new DateTime(2099, 12, 31),
                        endDateSpecified = true,
                        phoneKey = "01",
                        startDate = DateTime.Now,
                        startDateSpecified = true,
                        typeCode = "MOB",
                        Value = "9879879877"
                    }
                };
            var rs = cl.createCardHolderCardAccountV1R8(ptsRequest.simpleSecurityAssertion,
                ptsRequest.createCardHolderCardAccountV1R8Request1);


            Console.WriteLine(JsonConvert.SerializeObject(rs));

            Console.ReadKey();
        }
    }
}
