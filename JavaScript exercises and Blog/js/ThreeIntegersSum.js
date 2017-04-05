function solve(args) {
    let a = args[0];
    let b = args[1];
    let c = args[1];

    a = Number(a);
    b = Number(b);
    c = Number(c);

    if(a + b == c){
        console.log('a'+' + '+'b'+' = '+'c');
    }else if(c + b == a){
        console.log('a'+' + '+'b'+' = '+'c');
    }else if(c + a == b){
        console.log('a'+' + '+'b'+' = '+'c');
    }else {
        console.log('No');
    }
    
    function checkForSum(first, second, sum) {

        if(first + second != sum){
            return 'No';
        }

        if (first > second){

            return  'a'+' + '+'b'+' = '+'c';
        }
    }


}

solve(['8', '15', '7'])