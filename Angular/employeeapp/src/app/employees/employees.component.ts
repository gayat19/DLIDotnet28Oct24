import { Component } from '@angular/core';
import { EmployeeService } from '../../Services/Employee.service';
import { NgFor, NgIf } from '@angular/common';
import { Employee } from '../models/employee';
;

@Component({
  selector: 'app-employees',
  imports: [NgFor,NgIf],
  templateUrl: './employees.component.html',
  styleUrl: './employees.component.css'
})
export class EmployeesComponent {

  employees:Employee[]=[];
  constructor(private employeeService: EmployeeService){
    

  }
  getEmployees(){
    this.employeeService.getEmployees()
    .subscribe((data: any)=>{
      this.employees = data;
    });
  }
}
