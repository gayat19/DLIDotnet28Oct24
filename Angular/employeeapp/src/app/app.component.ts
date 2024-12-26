import { Component, ViewChild } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { NavbarComponent } from './navbar/navbar.component';
import { BreadcrumbComponent } from './breadcrumb/breadcrumb.component';
import { WelcomeComponent } from './welcome/welcome.component';
import { EmpdataComponent } from './empdata/empdata.component';
import { VchildComponent } from './vchild/vchild.component';


@Component({
  selector: 'app-root',
  imports: [VchildComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'A';

  @ViewChild(VchildComponent) vchild!: VchildComponent;

  changeChildContent(){
      if(this.vchild){
        this.vchild.changeContent();
      }
      if(this.title=='A')
        this.title = 'B';
      else
        this.title = 'A';
  }
}
//EmpdataComponent, WelcomeComponent, RouterOutlet,NavbarComponent,BreadcrumbComponent