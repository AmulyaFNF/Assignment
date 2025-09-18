import { Component, OnInit } from '@angular/core';  
import { CartItem } from '../../Models/cart-item';  
import { Cart } from '../../Services/cart'; 

@Component({
  selector: 'app-cart',
  standalone:false,
  templateUrl: './cart.html',
  styleUrls: ['./cart.css']
})
export class CartComponent implements OnInit { 
  cartItems: CartItem[] = []; 
  total: number = 0; 

  constructor(private cartService: Cart) {} 

  ngOnInit(): void { 
    this.cartItems = this.cartService.getItems();
    this.total = this.cartService.getTotal();
  }

  checkout(): void { 
      this.cartService.checkout(this.cartItems).subscribe(response => {
      alert('Order placed successfully!');
     
    });
  }
}
