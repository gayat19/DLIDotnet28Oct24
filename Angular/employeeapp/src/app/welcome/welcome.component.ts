import { Component } from '@angular/core';
import { SharedService } from '../../Services/shared.service';

@Component({
  selector: 'app-welcome',
  imports: [],
  templateUrl: './welcome.component.html',
  styleUrl: './welcome.component.css'
})
export class WelcomeComponent {
user:string = "Guest"
constructor(private sharedService:SharedService){
  this.sharedService.currentUser.subscribe({
    next:(un)=>{this.user = un}
  })
}
}
