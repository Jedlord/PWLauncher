using Amazon;
using Amazon.CognitoIdentity;
using Amazon.Lambda;
using Amazon.Lambda.Model;
using Amazon.Runtime.Internal.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWLauncher.Code
{
    public static class AWSRequests
    {
        static AmazonLambdaClient LambdaClient;
        private static CognitoAWSCredentials credentials;

        public static LoginInfo loginInfo;

        private static readonly string IdentityPoolId = "us-east-1:b9d5be2b-8fae-4bc6-8a4b-e35fab411d76";

        public static void Start()
        {
            UpdateLambda();
        }

        public static void UpdateLambda()
        {
            AmazonLambdaConfig cfg = new AmazonLambdaConfig();
            cfg.RegionEndpoint = RegionEndpoint.USEast1;
            LambdaClient = new AmazonLambdaClient(credentials, cfg);
        }

        public static void ConnectCognito()
        {
            Console.WriteLine("Connecting to Cognito and getting new ID");
            credentials = new CognitoAWSCredentials(IdentityPoolId, RegionEndpoint.USEast1);
            credentials.GetIdentityIdAsync();
            Console.WriteLine($"CogConnect: " + credentials.GetIdentityId());

            string coid = credentials.GetIdentityIdAsync().ToString();

            loginInfo = new LoginInfo()
            {
                identityId = coid,
                logintoken = coid
            };
        }

        public static async Task<LoginInfo> LoginWithUsernameAndPassword(string username, string password, bool loginAfterRegistration = false)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                Console.WriteLine($"LOGIN U/P FAILED, Incorrect user/pass {username}:{password}");
                return null;
            }

            username = username.ToUpper();
            InvokeRequest invokeRequest = new InvokeRequest();
            invokeRequest.FunctionName = "TinyWorlds_LoginWithUserNameAndPassword" + ":prod";
            invokeRequest.Payload = string.Concat(new string[]
            {
                 "{\"username\" : \"",
                 username,
                 "\", \"password\" : \"",
                 password,
                 "\"}"
            });
            Console.WriteLine($"Sending login U/P request:\n{invokeRequest.Payload}");
            invokeRequest.InvocationType = InvocationType.RequestResponse;
            UpdateLambda();

            try
            {
                var responseObject = await LambdaClient.InvokeAsync(invokeRequest);

                using (var responseStream = responseObject.Payload)
                using (var reader = new StreamReader(responseStream))
                {
                    string responseString = await reader.ReadToEndAsync();
                    Console.WriteLine(responseString);

                    if (responseString.Contains("{\"login\":false}"))
                    {
                        Console.WriteLine($"LOGIN U/P FAILED, Incorrect user/pass {username}:{password}");
                        return null;
                    }

                    loginInfo = JsonConvert.DeserializeObject<LoginInfo>(responseString);
                    return loginInfo;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("LOGIN U/P FAILED, EXCEPTION ON InvokeRequest");
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public class LoginInfo
        {
            public string login { get; set; }
            public string identityId { get; set; }
            public string token { get; set; }
            public string logintoken { get; set; }

            public string GetLoginInfo()
            {
                return $"{identityId};{logintoken}";
            }
        }
    }
}
