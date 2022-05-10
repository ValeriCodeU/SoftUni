function solve(obj){

    if(obj.dizziness){

        let needWater = obj.experience * obj.weight * 0.1;
        obj.levelOfHydrated += needWater;
        obj.dizziness = false;
    }

    return obj;
}


let printResult = solve({ weight: 80,
    experience: 1,
    levelOfHydrated: 0,
    dizziness: true });

    console.log(printResult);