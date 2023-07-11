using DIP;

IEngine petrolEngine = new PetrolEngine();
Car car1 =  new Car(petrolEngine);
car1.StartEngine();

IEngine electricEngine = new ElectricEngine();
Car car2 = new Car(electricEngine);
car2.StartEngine();