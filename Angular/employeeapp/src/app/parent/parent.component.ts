import { Component } from '@angular/core';
import { ActivatedRoute, Router, RouterLink, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-parent',
  imports: [RouterOutlet,RouterLink],
  templateUrl: './parent.component.html',
  styleUrl: './parent.component.css'
})
export class ParentComponent {

  constructor(private router:Router,private route:ActivatedRoute) 
  {
  } 
}
