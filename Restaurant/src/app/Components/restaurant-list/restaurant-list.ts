import { Component } from '@angular/core';
import { Restaurant } from '../../Services/restaurant';
import { Cart } from '../../Services/cart';


@Component({
  selector: 'app-restaurant-list',
  standalone: false,
  templateUrl: './restaurant-list.html',
  styleUrl: './restaurant-list.css'
})
export class RestaurantList {
restaurants: any[] = [];
  searchTerm = '';

  constructor(private restaurantService: Restaurant, private cartService: Cart) {}

  ngOnInit() {
    this.restaurants = this.restaurantService.getRestaurants();
  }

  addToCart(food: any, restaurantName: string) {
    this.cartService.addItem({ ...food, restaurantName });
  }
}



