// export class Employee{
//    public id: number;
//    public name: string;
//    public  age: number;
//    constructor(id: number=0, name: string="", age: number=0){
//        this.id = id;
//        this.name = name;
//        this.age = age;
//    }
// }

export class Employee{

    constructor(public id: number=0, 
        public name: string="", 
        public age: number=0,
        public image:string="",
        public email:string=""){

    }
 }