import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Product } from '../models/product';
import { CartItem } from '../models/cartItem';
import { CurrencyPipe, DatePipe, UpperCasePipe } from '@angular/common';
import { TestPipe } from '../test.pipe';

@Component({
  selector: 'app-product',
  imports: [UpperCasePipe,CurrencyPipe,DatePipe,TestPipe],
  templateUrl: './product.component.html',
  styleUrl: './product.component.css'
})
export class ProductComponent {
@Input() product:Product = new Product();
currentDate = new Date();
@Output() addToCart: EventEmitter<CartItem> = new EventEmitter<CartItem>();

handleButtonClick(){
  var cartItem = new CartItem(this.product.id,this.product.title,this.product.price,1,this.product.thumbnail);
  this,this.addToCart.emit(cartItem);
}
}
