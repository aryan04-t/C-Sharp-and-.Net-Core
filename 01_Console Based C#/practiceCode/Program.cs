// See https://aka.ms/new-console-template for more information

int age = 20; 
float randomNum = 100.234F; 
string name = "Aryan Tomar"; 
char gender = 'M'; 

Console.WriteLine(); 
Console.WriteLine("Name: " + name + ", Age: " + age);

if(gender == 'M'){
    Console.WriteLine(name + " is a Male");
}
else if(gender == 'F'){
    Console.WriteLine(name + "is a Female");
} 

Console.WriteLine("This is a random number: " + randomNum);
Console.WriteLine(); 