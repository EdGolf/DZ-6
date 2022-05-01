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

Console.Write("Введите числа через запятую: ");
int[] _numbers = StrToArray(Console.ReadLine());

int _count = 0;
for (var i = 0; i < _numbers.Length; i++)
{
    Console.Write(_numbers[i] + " ");
    if(_numbers[i] > 0)
    {
        _count++;
    }
}

Console.WriteLine("-> " + _count);
