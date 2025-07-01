double trainingfee = double.Parse(Console.ReadLine());
double sneakers = trainingfee * 0.60;
double uniform = sneakers * 0.80;
double priceBall = uniform / 4;
double priceBallAccessories = priceBall / 5;
double TotalPriceEquipment = trainingfee + sneakers + uniform + priceBall + priceBallAccessories;

Console.WriteLine(TotalPriceEquipment);
