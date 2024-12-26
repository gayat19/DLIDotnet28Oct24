import { Component } from '@angular/core';
import { CanComponentDeactivate } from '../CanComponentDeactivate';

import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-unsaved-change',
  imports: [FormsModule],
  templateUrl: './unsaved-change.component.html',
  styleUrl: './unsaved-change.component.css'
})
export class UnsavedChangeComponent implements CanComponentDeactivate{
  isSaved: boolean = false;
  data:string ='';
  canDeactivate():  boolean {
    if(!this.isSaved && this.data.length > 0){
      return confirm('Do you want to discard the changes?');
    }
    return true;
  }
  onSave(){
    this.isSaved = true;
  }

}
