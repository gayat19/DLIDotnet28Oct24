import { JsonPipe, NgIf } from '@angular/common';
import { Component } from '@angular/core';
import { CheckboxControlValueAccessor, FormsModule } from '@angular/forms';
import { User } from '../models/user';
import { LoginService } from '../../Services/Login.service';

@Component({
  selector: 'app-login',
  imports: [FormsModule,NgIf],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  user:User= new User();
  constructor(private loginService:LoginService){

  }
  login(un:any,pwd:any){
   if(un.valid && pwd.valid){
     
      this.loginService.login(this.user).subscribe(
        {
          next:(data:any)=>{
            alert("Login success");
            sessionStorage.setItem("token",data.token);
          },
          error:(err)=>{
              let msg="";
              // console.log(err)
            if(err.error.errorCode==500)
              msg = err.error.message;
            else
            {
              if(err.error??["errors"]??["Username"])
                msg = err.error??["errors"]??["Username"]??[0]??""
              if(err.error??["errors"]??["Password"])
                  msg += err.error.errors.Password??""
            }
            alert(msg);
            }
        })
      }
  }
  reset(){
    
  }
}
