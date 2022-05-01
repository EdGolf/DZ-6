int[] StrToArray(string inptStr = "")
{
    int _countNumbers = 1;

    for(int i = 0; i < inptStr.Length; i++){
        if(inptStr[i] == ','){
            _countNumbers++;
        }
    }

    int[] numersArr = new int[_countNumbers];
    int _index = 0;

    for(int i = 0; i < inptStr.Length; i++){
        string tempString = "";
        
        while(inptStr[i] != ','){
            if(i != inptStr.Length - 1){
                tempString += inptStr[i].ToString();
                i++;
            }
            else{
                tempString += inptStr[i].ToString();
                break;
            }
        }
        numersArr[_index] = Convert.ToInt32(tempString);
        _index++;
    }
    return numersArr;
}

Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = -(b1 - b2)/(k1 - k2);
double y = k2 * x + b2;

Console.WriteLine("x = " + x + "; y = " + y);
