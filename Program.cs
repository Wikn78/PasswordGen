


Console.WriteLine(Password(8));

String Password(int passwordSize)
{
    
    String lowerCase = "abcdefghijklmnopqrstuvwxz";
    String upperCase = "abcdefghijklmnopqrstuvwxz".ToUpper();
    String numbers = "0123456789";
    String symbols = "!@#$%^&*(),./;'[]-=<>?:{}|_+";
    
    String password = "";
    Random random = new Random();

    

    for (int i = 0; i < passwordSize; i++) 
    { 
        switch (random.Next(0, 4)) 
        { 
            case 0:
                password += lowerCase[random.Next(0, lowerCase.Length)];
                break;
            case 1:
                password += upperCase[random.Next(0, upperCase.Length)]; 
                break;
            case 2: 
                password += numbers[random.Next(0, numbers.Length)]; 
                break;
            case 3: 
                password += symbols[random.Next(0, symbols.Length)]; 
                break;
            default: 
                Console.WriteLine("Outside of range"); 
                break;
        }
    }

    return password;

}