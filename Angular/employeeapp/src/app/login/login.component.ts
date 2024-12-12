import { JsonPipe, NgFor, NgIf } from '@angular/common';
import { Component } from '@angular/core';
import { CheckboxControlValueAccessor, FormsModule } from '@angular/forms';
import { User } from '../models/user';
import { LoginService } from '../../Services/Login.service';
import { Router } from '@angular/router';
import { SharedService } from '../../Services/shared.service';

@Component({
  selector: 'app-login',
  imports: [FormsModule,NgIf,NgFor],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  user:User= new User();
  toasts:{id:number,message:string}[] =[];
  toastId =0;
  showToast(message:string){
    const toast={id :++this.toastId,message};
    this.toasts.push(toast);
    setTimeout(()=>{
      this.removeToast(toast)
      if(message=="Login success")
        this.router.navigate(['/department'])
    },2000)
  }
  removeToast(toast:{id:number,message:string})
  {
    this.toasts = this.toasts.filter(t=>t.id != toast.id)
  }
  constructor(private sharedService:SharedService,
    private loginService:LoginService,private router:Router){

  }
  login(un:any,pwd:any){
   if(un.valid && pwd.valid){
     
      this.loginService.login(this.user).subscribe(
        {
          next:(data:any)=>{
           // alert("Login success");
            this.showToast("Login success");
          this.sharedService.setUser(data.username);
           this.router.navigate(['/department'])
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
