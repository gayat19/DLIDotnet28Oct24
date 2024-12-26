import { Component } from '@angular/core';
import { NavigationEnd, Router,Event } from '@angular/router';
import { filter } from 'rxjs/operators';
import { Breadcrumb } from '../models/breadcrumb';
import { NgClass, NgFor, NgIf } from '@angular/common';


@Component({
  selector: 'app-breadcrumb',
  imports: [NgFor,NgIf,NgClass],
  templateUrl: './breadcrumb.component.html',
  styleUrl: './breadcrumb.component.css'
})
export class BreadcrumbComponent {
  routeName:string ="";
  breadcrumbs:Breadcrumb[]=[]
  constructor(private router:Router){
    this.router.events
    .pipe(
      filter(
        (event:Event):event is NavigationEnd =>
          event instanceof NavigationEnd
      )
    ).subscribe((event:NavigationEnd)=>{
      this.setBreadcrumb(event.urlAfterRedirects)
       // console.log(event.urlAfterRedirects)

    });
    }
    setBreadcrumb(url:string){
      this.breadcrumbs=[];
      let cleanedUrl = url.startsWith("/")?url.substring(1):url;
      switch (cleanedUrl) {
        case 'login':
            this.breadcrumbs.push(new Breadcrumb('Home/Login','/'+cleanedUrl))
            break;
        case 'department':
            this.breadcrumbs.push(new Breadcrumb('Home/Department','/'+cleanedUrl))
            break;
        case 'addemp':
          this.breadcrumbs.push(new Breadcrumb('Home/Add Employee','/'+cleanedUrl))
          break;
        case 'list':
          this.breadcrumbs.push(new Breadcrumb('Home/List Employee','/'+cleanedUrl))
          break;
        default:
          this.breadcrumbs.push(new Breadcrumb('Home','/'+cleanedUrl))
          break;
      }
    }
    navigateTo(url:string){
        this.router.navigate([url])
    }
}
