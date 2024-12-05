import { Component } from '@angular/core';
import { Employee } from '../models/employee';
import { EmployeeCurdService } from '../../Services/employeeCURD.service';
import { FormsModule } from '@angular/forms';
import { NgFor } from '@angular/common';
import { EmployeeDetailComponent } from '../employee-detail/employee-detail.component';

@Component({
  selector: 'app-edit-employee',
  imports: [FormsModule,NgFor,EmployeeDetailComponent],
  templateUrl: './edit-employee.component.html',
  styleUrl: './edit-employee.component.css'
})
export class EditEmployeeComponent {
  employees:Employee[]
  employee:Employee = new Employee();
constructor(private employeeService: EmployeeCurdService){
    this.employees = this.employeeService.getEmployees();
    console.log(this.employees);
}
selectEmployee(eid:any){
  this.employee = this.employeeService.getEmployee(eid);
}
changeEmployee(employee:Employee){
    this.employee.name = employee.name;
    this.employee.age = employee.age;
}
updateEmployee(){
    this.employeeService.updateEmployee(this.employee);
    this.employee = new Employee();
}
}
