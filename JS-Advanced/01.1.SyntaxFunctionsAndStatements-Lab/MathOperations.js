function solve(input1, input2, input3){
    let operator = input3;
    let result;
    switch(operator){
        case '*':
            result = input1 * input2;
            break;
                case '/':
                result = input1 / input2;
                break;
                    case '+':
                    result = input1 + input2;
                    break;
                        case '-':
                        result = input1 - input2;
                        break;
                            case '%':
                            result = input1 % input2;
                            break;
                                case '**':
                                result = input1 ** input2;
                                break;
    }
    console.log(result);

}

solve(3, 5.5, '*');