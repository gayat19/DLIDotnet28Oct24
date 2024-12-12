import { Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { DepartmentComponent } from './department/department.component';
import { AddemployeeComponent } from './addemployee/addemployee.component';
import { ListEmployeeComponent } from './list-employee/list-employee.component';
import { ObservableexampleComponent } from './observableexample/observableexample.component';

export const routes: Routes = [
    {path:'login',component:LoginComponent},
    {path:'department', component:DepartmentComponent},
    {path:'addemp',component:AddemployeeComponent},
    {path:'list',component:ListEmployeeComponent},
    {path:'learn',component:ObservableexampleComponent}
];
