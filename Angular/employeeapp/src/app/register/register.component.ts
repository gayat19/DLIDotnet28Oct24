import { Component } from '@angular/core';
import { User } from '../models/user';
import { AbstractControl, FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { NgIf } from '@angular/common';

@Component({
  selector: 'app-register',
  imports: [ReactiveFormsModule,NgIf],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {
  user:User= new User();
  userForm=new FormGroup({
    username:new FormControl(null,[Validators.required,Validators.pattern("[a-z0-9]+@[a-z]+\\.[a-z]{2,3}")]),
    password: new FormControl(null,[Validators.required])
  })
  
  public get un() : any {
    return this.userForm.get("username")
  }
  public get pass() : any {
    return this.userForm.get("password")
  }
  addUser(){
    if(this.userForm.valid)
      alert("Register initiated")
    else
      alert("Validation check")
    this.user.username = this.un.value;
    this.user.password = this.pass.value;
    console.log(this.user)
  }
}
