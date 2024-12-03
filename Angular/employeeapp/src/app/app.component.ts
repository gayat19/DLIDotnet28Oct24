import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { FirstComponent } from './first/first.component';
import { AddemployeeComponent } from './addemployee/addemployee.component';

import { EmployeesComponent } from './employees/employees.component';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet,FirstComponent,AddemployeeComponent,EmployeesComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'employeeapp';
}
