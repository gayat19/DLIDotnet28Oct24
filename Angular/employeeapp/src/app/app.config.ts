import { ApplicationConfig, provideZoneChangeDetection } from '@angular/core';
import { provideRouter } from '@angular/router';

import { routes } from './app.routes';
import { provideClientHydration, withEventReplay } from '@angular/platform-browser';
import { EmployeeService } from '../Services/Employee.service';
import { provideHttpClient } from '@angular/common/http';

export const appConfig: ApplicationConfig = {
  providers: [EmployeeService, 
    provideZoneChangeDetection({ eventCoalescing: true }),
     provideRouter(routes), provideClientHydration(withEventReplay())
    ,provideHttpClient()]
};
