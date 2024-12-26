import { Directive, ElementRef, HostListener, Input } from '@angular/core';

@Directive({
  selector: '[appHeighlight]'
})
export class HeighlightDirective {
  @Input() hColor:string = 'yellow'
@HostListener('mouseenter') onMouseEnter(){
  this.heightlight(this.hColor);
}
@HostListener('mouseleave') onMouseLeave(){
  this.heightlight('');
}
  constructor(private ef:ElementRef) {
   
   }
   heightlight(color:string){
    this.ef.nativeElement.style.backgroundColor = color;
   }
}
