import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { NavbarComponent } from './navbar/navbar.component';
import { BreadcrumbComponent } from './breadcrumb/breadcrumb.component';
import { WelcomeComponent } from './welcome/welcome.component';


@Component({
  selector: 'app-root',
  imports: [WelcomeComponent, RouterOutlet,NavbarComponent,BreadcrumbComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'employeeapp';
}
