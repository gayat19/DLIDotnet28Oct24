import { Component } from '@angular/core';
import { error } from 'console';
import { copyFileSync } from 'fs';
import { Observable, Subscription } from 'rxjs';

@Component({
  selector: 'app-observableexample',
  imports: [],
  templateUrl: './observableexample.component.html',
  styleUrl: './observableexample.component.css'
})
export class ObservableexampleComponent {
  mySubscription:Subscription;
 customObservable = new Observable((observer)=>{
    observer.next('Hello from Observable');
    observer.next("Lets start")
    let counter = 100;
    const interval = setInterval(()=>{
      counter = counter+ Math.random();
      observer.next(counter)
      if(counter >110)
      {
        observer.complete();
        clearInterval(interval);
      }
    },1000)
  
  })
  constructor(){
  
    this.mySubscription= this.customObservable.subscribe(
      {
        next:(data)=>console.log(data),
        error:(err)=>alert("Something went wrong"),
        complete:()=>console.log("Observable has doen its work")
      })
  }
  stopCounter(){
    this.mySubscription.unsubscribe();
  }
  ngOnDestroy(){
    this.mySubscription.unsubscribe();
  }
}
