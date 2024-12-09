import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable()
export class EmployeeService{
    constructor(private http: HttpClient){
    }
    getEmployees(){
        return this.http.get('http://localhost:5131/api/Employee');

    }
}