namespace asset_store
{
    public class Asset
    {
        private string _assetName = "";
        private decimal _assetPrice;

        private string _assetType="";

        public string AssetName {
            get {return _assetName;}
            set {_assetName = value;}
        }

        public decimal AssetPrice {
            get{return _assetPrice;}
            set{_assetPrice=value;}
        }

        public string AssetType {
            get {return _assetType;}
            set {_assetType = value;}
        }

        public void verifyAssetType (){
            if (_assetType=="music piece" || _assetType=="music pack" || 
            _assetType=="sfx item" || _assetType=="sfx pack"){
                Console.WriteLine ("Valid asset.");
            }
            else {
                Console.WriteLine ("Invalid asset.");
            }
        }
    }
}