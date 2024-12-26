import {  Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { DepartmentComponent } from './department/department.component';
import { AddemployeeComponent } from './addemployee/addemployee.component';
import { ListEmployeeComponent } from './list-employee/list-employee.component';
import { ObservableexampleComponent } from './observableexample/observableexample.component';
import { ChildComponent } from './child/child.component';
import { ProductsComponent } from './products/products.component';
import { ErrorpageComponent } from './errorpage/errorpage.component';
import { ParentComponent } from './parent/parent.component';
import { SectionaComponent } from './sectiona/sectiona.component';
import { SectionbComponent } from './sectionb/sectionb.component';
import { authGuard } from './auth.guard';
import { UnsavedChangeComponent } from './unsaved-change/unsaved-change.component';
import { CanDeactivateGuard } from './dguard.guard';
import { LifecycleComponent } from './lifecycle/lifecycle.component';


export const routes: Routes = [
    {path:'login',component:LoginComponent},
    {path:'lifecycle',component:LifecycleComponent},
    {path:'department', component:DepartmentComponent,canActivate:[authGuard]},   
    {path:'addemp',component:AddemployeeComponent},
    {path:'list',component:ListEmployeeComponent},
    {path:'learn',component:ObservableexampleComponent,
        children:[
            {path:'child/:pid',component:ChildComponent}
        ]
    },
    {path:'parent',component:ParentComponent,children:[
        {path:'child1',component:SectionaComponent,outlet:'seca'},
        {path:'child2',component:SectionbComponent,outlet:'secb'}
    ]},
    {path:'save',component:UnsavedChangeComponent,
        canDeactivate:[CanDeactivateGuard]
    },
    {path:'**',component:ErrorpageComponent}
];
