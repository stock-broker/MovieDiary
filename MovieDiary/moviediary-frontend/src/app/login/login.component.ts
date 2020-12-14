import { HttpResponse } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from '../Services/user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private userService: UserService, private route: Router) { }

  ngOnInit(): void {
  }

  login(data: JSON){
    const route: string = 'http://localhost:5000/api/authenticate/login';
    console.log(data);
    this.userService.loginUser(route, data);
    // };
    // (error) => { console.error(error)
    // });
  }

}