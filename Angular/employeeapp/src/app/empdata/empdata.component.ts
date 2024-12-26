import { Component } from '@angular/core';
import { PermanentempComponent } from '../permanentemp/permanentemp.component';
import { ConsultantempComponent } from '../consultantemp/consultantemp.component';
import { NgFor, NgSwitch,NgSwitchCase,NgSwitchDefault } from '@angular/common';
import { Employee } from '../models/employee';
import { FormsModule } from '@angular/forms';
import { HeighlightDirective } from '../heighlight.directive';
import { CardnumberDirective } from '../cardnumber.directive';

@Component({
  selector: 'app-empdata',
  imports: [PermanentempComponent,ConsultantempComponent,NgSwitch,
  NgSwitchCase,NgSwitchDefault,NgFor,FormsModule,HeighlightDirective,CardnumberDirective
  ],
  templateUrl: './empdata.component.html',
  styleUrl: './empdata.component.css'
})
export class EmpdataComponent {
empType:string=''
changedName:string=''
selectId:number=0
employees:Employee[] = [
  new Employee(1,'John',25,'','John@abc.com'),
  new Employee(2,'Smith',30,'','Smith@abc.com'),
  new Employee(3,'Mike',35,'','Mile@abc.com')
]
selectChange(id:any){
  this.selectId=id as number;
}
changeName(){
  for(let emp of this.employees){
    if(emp.id==this.selectId){
      emp.name=this.changedName;
      break;
    } 
  }
}
selectType(type:string){
  this.empType=type;
}
trackById(index:number,emp:Employee){
  return emp.id;
}
}
