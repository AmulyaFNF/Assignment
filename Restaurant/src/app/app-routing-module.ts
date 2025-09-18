import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Login } from './Components/login/login';
import { RestaurantList } from './Components/restaurant-list/restaurant-list';
import { CartComponent } from './Components/cart/cart';


const routes: Routes = [
  
{ path: '', component: Login },
  { path: 'restaurants', component: RestaurantList },
  { path: 'cart', component: CartComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
