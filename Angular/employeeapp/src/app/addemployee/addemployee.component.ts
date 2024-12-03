import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-addemployee',
  imports: [FormsModule],
  templateUrl: './addemployee.component.html',
  styleUrl: './addemployee.component.css'
})
export class AddemployeeComponent {
  empname:string = "";
  className:string = "normal";
  favClass:string = "bi bi-heart";
  changeName(ename:string){
    this.empname = ename;
  }
  changeClass(choice:string){
    if(choice == "err")
      this.className = "danger";
      else if(choice == "good")
        this.className = "success";
      else
        this.className = "normal";
  }
  toggle(){
    if(this.favClass == "bi bi-heart")
      this.favClass = "bi bi-heart-fill";
    else
      this.favClass = "bi bi-heart";
  }
}
