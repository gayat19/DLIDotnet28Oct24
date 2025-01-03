import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable()
export class ProductService{
    constructor(private http: HttpClient) {
        
    }
    getProducts(){
        return this.http.get("https://dummyjson.com/products");
    }
    getProductsById(id:number){
        console.log('calling api with id '+id);
        return this.http.get("https://dummyjson.com/products/"+id);
    }

}