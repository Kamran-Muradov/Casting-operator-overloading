//boxing-unboxing

//int a = 5;

//object b = a;

//int a = 6;

//object b = a;

//int c = (int)b;


//byte num = 50;

//int num2 = num;


//int a = 10;

//byte b = (byte)a;

//Console.WriteLine(b);


using Casting;

Fish fish = new Fish();
Animal animal1 = fish;

//Animal animal1 = new Fish();

//Animal animal2 = new Animal();

//Fish fish1 = (Fish)animal1;

Animal animal3 = new Dog();

Animal animal4 = new Fish();

Animal animal = new();

//Fish fish1 = (Fish)animal;

Dog dog = new Dog();



//object[] datas = { 1, 2, true, "salam" };

//object[] animals = { animal1, animal3, animal4, dog, "name" };

//foreach (var item in animals)
//{
//Console.WriteLine(item is Animal);

//if (item is Animal a)
//{
//    //Console.WriteLine("yes");

//    //var result = (Animal)item;

//    a.Name = "Toplan";

//    Console.WriteLine(a.Name);
//}

//Animal data = item as Animal;

//if (data is not null)
//{
//    data.Name = "Akula";
//    Console.WriteLine(data.Name);
//}

//Console.WriteLine(data);

//}


//DataList dataList = new DataList();

//dataList[0] = "salam";
//dataList[1] = "sagol";

//Console.WriteLine(dataList[0]);

Employee employee1 = new();
employee1.Id = 1;
employee1.Age = 25;

Employee employee2 = new();
employee2.Id = 2;
employee2.Age = 30;

//Console.WriteLine(employee1 > employee2);
