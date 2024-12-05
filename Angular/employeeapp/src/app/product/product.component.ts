import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Product } from '../models/product';
import { CartItem } from '../models/cartItem';

@Component({
  selector: 'app-product',
  imports: [],
  templateUrl: './product.component.html',
  styleUrl: './product.component.css'
})
export class ProductComponent {
@Input() product:Product = new Product();
@Output() addToCart: EventEmitter<CartItem> = new EventEmitter<CartItem>();

handleButtonClick(){
  var cartItem = new CartItem(this.product.id,this.product.title,this.product.price,1,this.product.thumbnail);
  this,this.addToCart.emit(cartItem);
}
}
