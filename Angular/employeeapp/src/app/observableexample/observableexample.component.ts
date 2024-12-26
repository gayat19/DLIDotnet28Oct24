import { NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { ActivatedRoute, Router, RouterOutlet } from '@angular/router';
import { error } from 'console';
import { copyFileSync } from 'fs';
import { Observable, Subscription } from 'rxjs';

@Component({
  selector: 'app-observableexample',
  imports: [RouterOutlet,NgFor],
  templateUrl: './observableexample.component.html',
  styleUrl: './observableexample.component.css'
})
export class ObservableexampleComponent {
  pids = [1,2,3,4,5];
  loadChild(id:number){
    this.router.navigate(['child/'+id],{relativeTo:this.route})
  }
//   mySubscription:Subscription;
//  customObservable = new Observable((observer)=>{
//     observer.next('Hello from Observable');
//     observer.next("Lets start")
//     let counter = 100;
//     const interval = setInterval(()=>{
//       counter = counter+ Math.random();
//       observer.next(counter)
//       if(counter >110)
//       {
//         observer.complete();
//         clearInterval(interval);
//       }
//     },1000)
  
//   })



  constructor(private router:Router,private route:ActivatedRoute) 
  {
    // this.mySubscription= this.customObservable.subscribe(
    //   {
    //     next:(data)=>console.log(data),
    //     error:(err)=>alert("Something went wrong"),
    //     complete:()=>console.log("Observable has doen its work")
    //   })
  }
  stopCounter(){
    //this.mySubscription.unsubscribe();
  }
  ngOnDestroy(){
    //this.mySubscription.unsubscribe();
  }
}
