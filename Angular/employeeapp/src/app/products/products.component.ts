import { Component } from '@angular/core';
import { ProductService } from '../../Services/product.service';
import { Product } from '../models/product';
import { NgFor, NgIf } from '@angular/common';
import { ProductComponent } from '../product/product.component';
import { CartItem } from '../models/cartItem';

@Component({
  selector: 'app-products',
  imports: [NgFor,NgIf,ProductComponent],
  templateUrl: './products.component.html',
  styleUrl: './products.component.css'
})
export class ProductsComponent {
  products:Product[]=[];
  total:number=0;
  cart:CartItem[]=[];
  constructor(private productService:ProductService) {
    this.productService.getProducts()
                    .subscribe((prods:any)=>{
                      this.products=prods["products"];
                      console.log(this.products);
                    });
  }
  handleAddToCart(ci:any){

   
     let index=this.cart.findIndex((c)=>c.id===ci.id);
     if(index===-1){
       this.cart.push(ci);
     }else{
       this.cart[index].quantity+=ci.quantity;
     }  
     for(let c of this.cart){
       this.total+=c.price*c.quantity;
     }
  
}
}
