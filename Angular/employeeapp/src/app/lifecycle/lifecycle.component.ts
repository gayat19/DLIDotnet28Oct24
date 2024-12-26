import { Component, Input, SimpleChange } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-lifecycle',
  imports: [FormsModule],
  templateUrl: './lifecycle.component.html',
  styleUrl: './lifecycle.component.css'
})
export class LifecycleComponent {
  @Input() name:string=''
  ngAfterContentInit(){
    console.log('ngAfterContentInit');
  }
  ngDoCheck(){
    console.log('ngDoCheck');
  }
  ngOnInit() {
    console.log('ngOnInit');
  }
  ngOnChanges(change:SimpleChange){
    console.log('ngOnChanges');
    console.log(change);
  }
  constructor() {
    console.log('constructor');
  }
  ngOnDestroy() {
    console.log('ngOnDestroy');
  }
}
