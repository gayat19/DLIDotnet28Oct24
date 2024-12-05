import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Employee } from '../models/employee';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-employee-detail',
  imports: [FormsModule],
  templateUrl: './employee-detail.component.html',
  styleUrl: './employee-detail.component.css'
})
export class EmployeeDetailComponent {
 @Input() employee:Employee = new Employee();
 @Input() enabled:boolean = false;
 @Output() saveEmployee = new EventEmitter<Employee>();
 changeEventEmit(){
    this.saveEmployee.emit(this.employee);
 }


}
