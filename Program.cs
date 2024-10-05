// See https://aka.ms/new-console-template for more information
using System;

const string USERNAME = "Aon";
const string PASSWORD = "123";

Console.WriteLine("*******************  Login System  *******************");

Console.WriteLine("Enter your username");
string inputUserName = Console.ReadLine();
if (string.IsNullOrEmpty(inputUserName)){
   Console.WriteLine("Invalid username!");
   return;
}

Console.WriteLine("Enter your password");
string inputPassword = Console.ReadLine();
if (string.IsNullOrEmpty(inputPassword)){
   Console.WriteLine("Invalid password!");
   return;
}

if(inputUserName != USERNAME || inputPassword != PASSWORD){
   Console.WriteLine("Your username or password is incorrect");
   return;
}

Random rnd = new Random();
string otp = rnd.Next(100000, 999999).ToString();

Console.WriteLine($"This is your 6-digit OTP number {otp}");
Console.WriteLine("Enter the the 6-digit OTP number that we send it to you");

string inputOtp = Console.ReadLine();

if(string.IsNullOrEmpty(inputOtp)){
   Console.WriteLine("Invalid OTP!");
   return;
}

if(inputOtp != otp){
   Console.WriteLine("Incorrect OTP!");
   return;
}

Console.WriteLine("Success! You are logged in.");

		
