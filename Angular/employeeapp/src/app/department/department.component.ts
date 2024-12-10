import { Component } from '@angular/core';
import { DepartmentService } from '../../Services/department.service';
import { EmployeeDepartmnet } from '../models/employeeDepartmnet';
import { NgFor, NgIf } from '@angular/common';

@Component({
  selector: 'app-department',
  imports: [NgIf,NgFor],
  templateUrl: './department.component.html',
  styleUrl: './department.component.css'
})
export class DepartmentComponent {
    employeeDepartments:EmployeeDepartmnet[];
    constructor(private departmentService:DepartmentService){
     this.employeeDepartments =[];
    }
    getData(){
      this.departmentService.getDepartmnertWithEmployees().subscribe({
        next:(data)=>{
          this.employeeDepartments = data as EmployeeDepartmnet[]
          //console.log(this.employeeDepartments);
        },
        error:(err)=>{
          console.log(err)
        }
      })
    }
}
