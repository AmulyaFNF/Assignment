import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class Restaurant {
   getRestaurants() {
    return [
      {
        name: 'Pizza Palace',
        foods: [
          { name: 'Margherita', price: 200 },
          { name: 'Pepperoni', price: 250 }
        ]
      },
      {
        name: 'Burger Barn',
        foods: [
          { name: 'Cheeseburger', price: 150 },
          { name: 'Veggie Burger', price: 130 }
        ]
      }
    ];
  }
}


