import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[appCardnumber]'
})
export class CardnumberDirective {
  @HostListener('blur') onblur(){
    let value:string = this.ef.nativeElement.value;
    if(value.length == 16)
    {
      let cn = "XXXX-XXXX-XXXX-";
      cn += value.substr(12,4);
      this.ef.nativeElement.value = cn;
    }
  }
  constructor(private ef:ElementRef) { }

}
