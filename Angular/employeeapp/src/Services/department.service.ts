import { Injectable } from "@angular/core";
import BASE_URL from "../config";
import { HttpClient, HttpHeaders } from "@angular/common/http";

@Injectable()
export class DepartmentService{

    constructor(private http:HttpClient) {
        
    }

    getDepartmnertWithEmployees(){
        // let token= sessionStorage.getItem('token')??'';
        // let httpHeader = new HttpHeaders({
        //     'Content-Type':'application/json',
        //     'Authorization':"Bearer "+(token??"")
        // });
        return this.http.get(BASE_URL+"/api/Department");
    }

}