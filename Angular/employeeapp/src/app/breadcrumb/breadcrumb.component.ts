import { Component } from '@angular/core';
import { NavigationEnd, Router,Event } from '@angular/router';
import { filter } from 'rxjs/operators';


@Component({
  selector: 'app-breadcrumb',
  imports: [],
  templateUrl: './breadcrumb.component.html',
  styleUrl: './breadcrumb.component.css'
})
export class BreadcrumbComponent {
constructor(private router:Router){
  this.router.events
  .pipe(
    filter(
      (event:Event):event is NavigationEnd =>
        event instanceof NavigationEnd
    )
  ).subscribe((event:Event)=>{
      console.log(event.toString())
  });
}
}
