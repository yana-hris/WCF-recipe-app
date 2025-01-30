namespace RecipeWcfHost
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Description;

    using RecipeWcfService;

    class Program
    {
        static void Main()
        {
            Uri baseAddress = new Uri("http://localhost:9000/RecipeService");

            using (ServiceHost host = new ServiceHost(typeof(RecipeService), baseAddress))
            {
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true; // Enable WSDL metadata
                smb.HttpGetUrl = baseAddress;
                host.Description.Behaviors.Add(smb);

                host.AddServiceEndpoint(
                    ServiceMetadataBehavior.MexContractName,
                    MetadataExchangeBindings.CreateMexHttpBinding(), 
                    "mex");

                host.AddServiceEndpoint(typeof(IRecipeService), new BasicHttpBinding(), "");

                host.Open();
                Console.WriteLine("WCF SOAP сървисът е стартиран на:" + baseAddress);
                Console.WriteLine("Натиснете Enter за спиране...");
                Console.ReadLine();

                host.Close();
            }

        }
    }
}
