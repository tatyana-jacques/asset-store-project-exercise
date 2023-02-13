using asset_store;

Asset horrorPack = new Asset();
horrorPack.AssetName = "Horror Pack";
horrorPack.AssetPrice = 301.098m;
horrorPack.AssetType = "music pack";

Asset peacefulMusic = new Asset();
peacefulMusic.AssetName = "Peaceful Music";
peacefulMusic.AssetPrice = 200.093m;
peacefulMusic.AssetType = "music pack";

Asset uiSfx = new Asset();
uiSfx.AssetName = "UI SFX";
uiSfx.AssetPrice = 11.77m;
uiSfx.AssetType = "sfx pack";

Asset pianoPiece01 = new Asset();
pianoPiece01.AssetName = "Piano Piece 01";
pianoPiece01.AssetPrice = 11.77m;
pianoPiece01.AssetType = "music piece";

Client firstClient = new ();
firstClient.Name = "Thurston Moore";
firstClient.Password = "sonicyouth";
firstClient.Income = 300.055m;

firstClient.Login();
horrorPack.verifyAssetType();
firstClient.ConsultAssetList();
firstClient.ConsultCredits();
firstClient.BuyAsset(pianoPiece01);
firstClient.ConsultAssetList();
firstClient.ConsultCredits();
firstClient.BuyAsset(horrorPack);
firstClient.ConsultAssetList();
firstClient.ConsultCredits();
firstClient.BuyAsset(pianoPiece01);



