import { ApplicationConfig, provideZoneChangeDetection } from '@angular/core';
import { provideRouter } from '@angular/router';

import { routes } from './app.routes';
import { provideClientHydration, withEventReplay } from '@angular/platform-browser';
import { EmployeeService } from '../Services/Employee.service';
import { provideHttpClient, withInterceptors } from '@angular/common/http';
import { EmployeeCurdService } from '../Services/employeeCURD.service';
import { ProductService } from '../Services/product.service';
import { LoginService } from '../Services/Login.service';
import { DepartmentService } from '../Services/department.service';
import { AuthInterceptor } from '../http-interceptors/auth-interceptor';
import { SharedService } from '../Services/shared.service';

export const appConfig: ApplicationConfig = {
  providers: [SharedService, DepartmentService, LoginService, EmployeeService, EmployeeCurdService,ProductService,

    provideZoneChangeDetection({ eventCoalescing: true }),
     provideRouter(routes), provideClientHydration(withEventReplay())
    ,provideHttpClient(withInterceptors([AuthInterceptor]))]
};
