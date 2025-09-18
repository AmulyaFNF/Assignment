import { Component } from '@angular/core';
import { Router } from '@angular/router';


@Component({
  selector: 'app-login',
  standalone: false,
  templateUrl: './login.html',
  styleUrl: './login.css'
})
export class Login {
    isNewUser=false;
    username='';
    password='';
    address='';
    users:any[]=[];
    constructor(private router:Router){}
  
    ngOnInit() {
    const storedUsers = localStorage.getItem('users');
    this.users = storedUsers ? JSON.parse(storedUsers) : [];
  }

  toggleUserType() {
    this.isNewUser = !this.isNewUser;
  }

  login() {
    if (this.isNewUser) {
      const newUser = {
        id: Date.now(),
        username: this.username,
        password: this.password,
        address: this.address
      };
      this.users.push(newUser);
      localStorage.setItem('users', JSON.stringify(this.users));
      localStorage.setItem('currentUser', JSON.stringify(newUser));
    } else {
      const user = this.users.find(u => u.username === this.username && u.password === this.password);
      if (user) {
        this.address = user.address;
        localStorage.setItem('currentUser', JSON.stringify(user));
        this.router.navigate(['/restaurants']);
      } else {
        alert('Invalid credentials');
      }
    }

  }

  changeAddress(newAddress: string) {
    const user = this.users.find(u => u.username === this.username);
    if (user) {
      user.address = newAddress;
      localStorage.setItem('users', JSON.stringify(this.users));
      localStorage.setItem('currentUser', JSON.stringify(user));
    }
  }
  
changeAddressPrompt(): void {
  const newAddress = window.prompt('Enter new address');
  if (newAddress) {
    this.changeAddress(newAddress);
  }
}





}


  


