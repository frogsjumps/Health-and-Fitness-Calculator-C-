using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;

int userInputNum;
int weight;
int userSex;
int age;
double height;
double BMI;
double bodyFatPercentage = 0;
double RMR = 0;
string TDEE;
int actlvl;
double TDEEnum = 0;
bool programloop = true;
int mainmenu;


while (programloop != false)
{
    Console.WriteLine("Welcome to the Health and Fitness Information program, please press the number corresponding to what you would like to \nlearn about.\n\n1. BMI calculator\n2. Body fat percentage calculator(approximate)\n3. RMR(resting metabolic rate) Calculator\n4. Credits");
userInputNum = Convert.ToInt32(Console.ReadLine());

Console.Clear();

if (userInputNum == 1)
{
    Console.WriteLine("BMI CALCULATOR\n");
    Console.WriteLine("Please input your weight and height\n");
    Console.Write("Weight(in kilos): ");
    weight = Convert.ToInt32(Console.ReadLine());
    Console.Write("Height(in cm): ");
    height = Convert.ToInt32(Console.ReadLine());
    height /=100;
    height = height*height;
    BMI = weight/height;
    if (BMI <= 18.5)
    {
        Console.WriteLine("Your BMI is " + BMI + ". You are underweight");
    } else if (BMI<=24.9)
    {
       Console.WriteLine("Your BMI is " + BMI + ". You are normal weight"); 
    } else if (BMI <= 29.9)
    {
        Console.WriteLine("Your BMI is " + BMI + ". You are overweight");
    } else 
    {
        Console.WriteLine("Your BMI is " + BMI + ". You are obese");
    }
} else if (userInputNum == 2)
{
    Console.WriteLine("Please input your weight and height\n");
    Console.Write("Weight(in kilos): ");
    weight = Convert.ToInt32(Console.ReadLine());
    Console.Write("Height(in cm): ");
    height = Convert.ToInt32(Console.ReadLine());
    height /=100;
    height = height*height;
    BMI = weight/height;
    Console.WriteLine("Are you male(1) or female(2)? (enter the corresponding number)");
    userSex = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("How old are you?");
    age = Convert.ToInt32(Console.ReadLine());

    if (userSex == 1)
    {
        bodyFatPercentage = (1.20*BMI)+(.23*age)-16.2;
    } else if (userSex == 2)
    {
        bodyFatPercentage = (1.20*BMI)+(.23*age)-5.4;
    }

    if (bodyFatPercentage <= 5 && userSex == 1 || bodyFatPercentage <= 13 && userSex == 2)
    {
        Console.WriteLine("Your body fat percentage is: " + bodyFatPercentage + " which is in the 'Essential' range.");
    } 
    else if (bodyFatPercentage <= 13 && userSex == 1 || bodyFatPercentage <= 20 && userSex == 2)
    {
        Console.WriteLine("Your body fat percentage is: " + bodyFatPercentage + " which is in the 'Athletic' range.");
    } 
    else if (bodyFatPercentage <= 17 && userSex == 1 || bodyFatPercentage <= 24 && userSex == 2)
    {
        Console.WriteLine("Your body fat percentage is: " + bodyFatPercentage + " which is in the 'Fitness' range.");
    } 
    else if (bodyFatPercentage <= 24 && userSex == 1 || bodyFatPercentage <= 31 && userSex == 2)
    {
        Console.WriteLine("Your body fat percentage is: " + bodyFatPercentage + " which is in the 'Average' range.");
    } 
    else if (bodyFatPercentage >= 25 && userSex == 1 || bodyFatPercentage >= 32 && userSex == 2)
    {
        Console.WriteLine("Your body fat percentage is: " + bodyFatPercentage + " which is in the 'Obese' range.");
    }
} else if (userInputNum == 3)
{
    Console.WriteLine("Please input your weight and height\n");
    Console.Write("Weight(in kilos): ");
    weight = Convert.ToInt32(Console.ReadLine());
    Console.Write("Height(in cm): ");
    height = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("How old are you?");
    age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Are you male(1) or female(2)? (enter the corresponding number)");
    userSex = Convert.ToInt32(Console.ReadLine());
    if (userSex == 1)
    {
        RMR = 66.5 + (13.75 * weight) + (5.003 * height) - (6.75 * age);
        Console.WriteLine("Your RMR(resting metabolic rate) is " + RMR);
    } else if (userSex == 2)
    {
        RMR = 655.1 + (9.563 * weight) + (1.850 * height) - (4.676 * age);
        Console.WriteLine("Your RMR(resting metabolic rate) is " + RMR);
    } else 
    {
        Console.WriteLine("You did not input a valid number");
    }
    Console.WriteLine("\nWould you also like to figure out your Total Daily Energy Expenditure(TDEE)? It is a measure of how many calories you \nburn in a day, please type yes if so.");
    TDEE = Console.ReadLine();

    Console.Clear();

    if (TDEE == "yes" || TDEE == "Yes")
    {
        Console.WriteLine("Please input the corresponding number to your activity level:\n1) Sedentary(little or no exercise)\n2) Lightly active(light exercise/sports 1-3 days/week)\n3) Moderately active(moderate exercise/sports 3-5 days/week)\n4) Very active(hard exercise/sports 6-7 days a week)\n5) If you are extra active(very hard exercise/sports & a physical job)");
        actlvl = Convert.ToInt32(Console.ReadLine());
        if (actlvl == 1)
        {
            TDEEnum = RMR * 1.2;
            Console.WriteLine("Your Total Daily Energy Expenditure(TDEE) is " + TDEEnum);
        } else if (actlvl == 2)
        {
            TDEEnum = RMR * 1.375;
            Console.WriteLine("Your Total Daily Energy Expenditure(TDEE) is " + TDEEnum);
        } else if (actlvl == 3)
        {
            TDEEnum = RMR * 1.55;
            Console.WriteLine("Your Total Daily Energy Expenditure(TDEE) is " + TDEEnum);
        } else if (actlvl == 4)
        {
            TDEEnum = RMR * 1.725;
            Console.WriteLine("Your Total Daily Energy Expenditure(TDEE) is " + TDEEnum);
        } else if (actlvl == 5)
        {
            TDEEnum = RMR * 1.9;
            Console.WriteLine("Your Total Daily Energy Expenditure(TDEE) is " + TDEEnum);
        }
    }
}else if (userInputNum == 4) 
{
    Console.WriteLine("Thank you to these websites for research and numbers\n Omni Calculator\n CDC Centers for Disease Control and Prevention\n National Institutes of Health\n NHS ");
}
Console.WriteLine("To end the program, press 1. To go back to the main menu press 2.");
mainmenu = Convert.ToInt32(Console.ReadLine());
if (mainmenu == 1)
{
    programloop = false;
    Console.Clear();
} else 
{
    Console.Clear();
}
}

Console.ReadKey();

































