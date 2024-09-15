Stock stockcontrol = new Stock();

stockcontrol.QuantityAvaliable = 30
stockcontrol.QuantityWished = 20
stockcontrol.Verify();

stockcontrol.QuantityAvaliable = 30
stockcontrol.QuantityWished = 30
stockcontrol.Verify();

stockcontrol.QuantityAvaliable = 30
stockcontrol.QuantityWished = 40
stockcontrol.Verify();
