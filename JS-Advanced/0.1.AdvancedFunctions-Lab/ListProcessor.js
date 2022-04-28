function solve(input){

    let innerCollection = [];

    let obj = {

        add(str) {

            innerCollection.push(str);
        },
        remove(str){

            innerCollection.filter(x => x !== str);
        },
        print(){
            return console.log(innerCollection.join(','));
        }
    }



    for (const data  of input) {

        let [command, str] = data.split(' ');

        if(command === 'add'){
            obj.add(str);
        } else if(command === 'remove'){

            obj.remove(str)

        } else if (command === 'print'){
            obj.print();
        }
        
    }

}


solve(['add hello', 'add again', 'remove hello', 'add again', 'print']);
solve(['add pesho', 'add george', 'add peter', 'remove peter','print']);