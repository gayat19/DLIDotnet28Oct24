import { Component } from '@angular/core';
import { EmployeeCurdService } from '../../Services/employeeCURD.service';
import { Employee } from '../models/employee';
import { FormsModule } from '@angular/forms';


@Component({
  selector: 'app-add-employee',
  imports: [FormsModule],
  templateUrl: './add-employee.component.html',
  styleUrl: './add-employee.component.css'
})
export class AddEmployeeComponent {
    employee:Employee;
    constructor(private employeeService: EmployeeCurdService){
        this.employee = new Employee();
    }
    addEmployee(){
        this.employeeService.addEmlpoyee(this.employee);
        this.employee = new Employee();
    }
}
