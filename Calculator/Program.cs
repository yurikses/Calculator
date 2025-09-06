
(double, double) RequestNums() {
    Console.WriteLine("Введите первое число:");
    double firstNum = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    double secondNum = Convert.ToDouble(Console.ReadLine());

    return (firstNum, secondNum);
}
double RequestNum()
{
    Console.WriteLine("Введите число:");
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}

(double a, double b) = (0,0);
double memoryNum = 0; 
double prevResult = 0;

while (true) 
{
    double result = 0;
    Console.Clear();
    if (prevResult != 0) {
        a = prevResult;
    }
    
    Console.WriteLine($"Текущее число: {a}. Память: {memoryNum}");
    Console.WriteLine("Введите операцию:");
    string operation = Console.ReadLine();
    switch (operation) {
        case "+":
            if (a != 0)
            {
                b = RequestNum();
            }
            else { (a, b) = RequestNums(); }

            result = a + b;

            break;
        case "-":
            if (a != 0)
            {
                b = RequestNum();
            }
            else { (a, b) = RequestNums(); }
            result = a - b;

            break;
        case "*":
            if (a != 0)
            {
                b = RequestNum();
            }
            else { (a, b) = RequestNums(); }
            result = a * b;

            break;
        case "/":
            if (a != 0)
            {
                b = RequestNum();
            }
            else { (a, b) = RequestNums(); }
            if (b == 0) {
                goto default;
            }
            result = a / b;

            break;
        case "%":
            if (a != 0)
            {
                b = RequestNum();
            }
            else { (a, b) = RequestNums(); }
            if (b == 0)
            {
                goto default;
            }
            result = a % b;
            break;
        case "1/x":
            if (a == 0) {
                (a) = RequestNum();
            }
            result = 1 / a;

            break;
        case "^":
            if (a != 0)
            {
                b = RequestNum();
            }
            else { (a, b) = RequestNums(); }
            result = Math.Pow(a, b);

            break;
        case "sqrt":
            if (a == 0)
            {
                a = RequestNum();
            }
            result = Math.Sqrt(a);
            break;
        case "M+":
            memoryNum += a;
            break;
        case "M-":
            memoryNum -= a;
            break;
        case "MS":
            memoryNum = a;
            break;
        case "MC":
            memoryNum = 0;
            break;
        case "MR":
            a = memoryNum;
            break;
        default:
            break;
    }
    prevResult = result;
        
}
