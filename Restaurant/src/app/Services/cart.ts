import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CartItem } from '../Models/cart-item';

@Injectable({
  providedIn: 'root'
})
export class Cart {
  private apiUrl='http://localhost:5005/api/Cart'
  items: CartItem[] = [];

    constructor(private http: HttpClient) {}

    getItems():CartItem[]{
      return this.items
    }

  addItem(item: CartItem) {
    const user = JSON.parse(localStorage.getItem('currentUser')!);
    const existing = this.items.find(i => i.foodName === item.foodName && i.restaurantName === item.restaurantName);
    if (existing) {
      existing.quantity += 1;
    } else {
      this.items.push({
        foodName: item.foodName,
        restaurantName: item.restaurantName,
        price: item.price,
        quantity: 1,
        userId: user.id,
        orderDate: new Date().toISOString()
      });
    }
    console.log(item);
    this.items.push({
      foodName:item.foodName,
      restaurantName:item.restaurantName,
      price:Number(item.price.toString().replace(/[^0-9.]/g,'')),
      quantity:Number(item.quantity)||1,
      userId:1,
      orderDate:new Date().toISOString()
    });

  }


  getTotal() {
    return this.items.reduce((sum, item) => sum + item.price * item.quantity, 0);
  }

  checkout(cartItems: CartItem[]) {
    // Send to backend
    return this.http.post('http://localhost:5005/api/Cart', this.items);
  }
}







