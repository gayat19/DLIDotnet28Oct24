import { Component } from '@angular/core';
import { EmployeeCurdService } from '../../Services/employeeCURD.service';
import { Employee } from '../models/employee';
import { NgFor, NgIf } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-list-employee',
  imports: [NgFor,NgIf,FormsModule],
  templateUrl: './list-employee.component.html',
  styleUrl: './list-employee.component.css'
})
export class ListEmployeeComponent {
  employees:Employee[];
  editClicked:boolean = false;
  constructor(private employeeService: EmployeeCurdService){
    this.employees = this.employeeService.getEmployees(); 
  }
  editPrep(eid:any){
    this.editClicked=true;

    var employee = this.employeeService.getEmployee(eid);

  }
  editEmployee(eid:any){
    var employee = this.employeeService.getEmployee(eid);
    this.employeeService.updateEmployee(employee);
    this.employees = this.employeeService.getEmployees(); 
    this.editClicked=false;
  }
  deleteEmployee(eid:any){
    this.employeeService.deleteEmployee(eid);
    this.employees = this.employeeService.getEmployees(); 
  }

}
