import { JsonPipe, NgIf } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { User } from '../models/user';

@Component({
  selector: 'app-login',
  imports: [FormsModule,NgIf,JsonPipe],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  user:User= new User();
  login(un:any,pwd:any){
   if(un.valid && pwd.valid){
      alert("Sending data to server");
   }
   
  }
  reset(){
    
  }
}
