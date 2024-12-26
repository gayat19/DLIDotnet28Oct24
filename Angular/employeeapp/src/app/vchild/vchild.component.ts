import { Component, Input } from '@angular/core';
import { SectionaComponent } from '../sectiona/sectiona.component';
import { SectionbComponent } from '../sectionb/sectionb.component';
import { NgComponentOutlet } from '@angular/common';

@Component({
  selector: 'app-vchild',
  imports: [NgComponentOutlet],
  templateUrl: './vchild.component.html',
  styleUrl: './vchild.component.css'
})
export class VchildComponent {
 message: string = 'Hello from child component';
 @Input() session: string = 'A';
 
 changeContent(){
    this.message = 'Content changed from child component';
 }
  getSection(){
    if(this.session == 'A'){
      return SectionaComponent;
  }else {
      return SectionbComponent;
  }
  }
}
