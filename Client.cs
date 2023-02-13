using System.Globalization;
namespace asset_store
{
    public class Client
    {
        private string _name = "";
        private string _password ="";
        private decimal _income;
        private List<Asset> _clientAssets = new List<Asset> { };


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public decimal Income
        {
            get { return _income; }
            set { _income = value; }
        }

        public List<Asset> ClientAssets
        {
            get { return _clientAssets; }
            set { _clientAssets = value; }

        }

        public void Login()
        {

            Console.Write("Insert your user name: ");
            string name = Console.ReadLine() ?? "";
            Console.Write("Insert yout password: ");
            string password = Console.ReadLine() ?? "";
            if (name == _name && password == _password)
            {
                Console.WriteLine($"Welcome {_name} !");
            }
            else
            {
                Console.WriteLine("Invalid login.");
            }
        }

        public void ConsultCredits()
        {
            Console.WriteLine("Credits: $ " + _income.ToString("F2", CultureInfo.InvariantCulture));
        }

        public void BuyAsset(Asset product)
        {

            if (_clientAssets.Any(item => item.AssetName == product.AssetName))
            {
                Console.WriteLine("You alredy have this item in your library.");
            }
            else if (_income < product.AssetPrice){
                Console.WriteLine ("You need to insert credit to buy this asset.");
            }
            else
            {
                _income -= product.AssetPrice;
                _clientAssets.Add(product);
            }


        }
        public void ConsultAssetList()
        {
            int assetsNumber = 0;
            Console.Write ("Assets in your library: ");
            foreach (Asset x in _clientAssets)
            {
                Console.Write($"{x.AssetName}; ");
                assetsNumber++;
            }
            Console.WriteLine();

            Console.WriteLine ($"You have {assetsNumber} assets in your library.");
        }
    }
}