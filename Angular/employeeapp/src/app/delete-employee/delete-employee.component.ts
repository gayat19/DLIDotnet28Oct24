import { NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Employee } from '../models/employee';
import { EmployeeCurdService } from '../../Services/employeeCURD.service';
import { EmployeeDetailComponent } from '../employee-detail/employee-detail.component';

@Component({
  selector: 'app-delete-employee',
  imports: [FormsModule,NgFor,EmployeeDetailComponent],
  templateUrl: './delete-employee.component.html',
  styleUrl: './delete-employee.component.css'
})
export class DeleteEmployeeComponent {
  employees:Employee[]
  employee:Employee = new Employee();
constructor(private employeeService: EmployeeCurdService){
    this.employees = this.employeeService.getEmployees();
    console.log(this.employees);
}
selectEmployee(eid:any){
  this.employee = this.employeeService.getEmployee(eid);
}
deleteEmployee(){
  var res = confirm("Are you sure you want to delete this employee?");
  if(res){
    this.employeeService.deleteEmployee(this.employee.id);
    this.employees = this.employeeService.getEmployees();
    this.employee = new Employee();
  }
  else{
    this.employee = new Employee();
}
}
}
