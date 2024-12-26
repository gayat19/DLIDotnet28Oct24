import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ProductService } from '../../Services/product.service';
import { Product } from '../models/product';
import { error } from 'console';

@Component({
  selector: 'app-child',
  imports: [],
  templateUrl: './child.component.html',
  styleUrl: './child.component.css'
})
export class ChildComponent {
pid:number=0;
pname:string="";
  constructor(private router:Router,private route:ActivatedRoute,
              private productService:ProductService
  ) 
  {
    //this.pid = route.snapshot.params['pid'];
    this.route.params.subscribe(params=>{
      this.pid = params['pid'];
      this.productService.getProductsById(this.pid).subscribe(
        {
          next:(data)=>this.pname = (data as Product).title,
          error:(err)=>alert("Something went wrong")
        }
      )
     
    })
   
  }
}
