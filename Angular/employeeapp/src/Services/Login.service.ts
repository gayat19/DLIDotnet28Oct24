import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { User } from "../app/models/user";
import { Observable } from "rxjs";
import { LoginresponseDTO } from "../app/models/loginresponseDTO";

@Injectable()
export class LoginService{
    constructor(private http:HttpClient){

    }
    public login(user:User):Observable<object>{
        return this.http.post("http://localhost:5131/api/User/Login",user);
    }
}