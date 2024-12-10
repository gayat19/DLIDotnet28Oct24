import { Employee } from "./employee";

export class EmployeeDepartmnet{
    constructor( public departmentId:number=0,
                public departmentName:string="",
                public employees:Employee[]=[]){

    }
}