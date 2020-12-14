import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from './../Services/user.service';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {

  constructor(private userService: UserService, private route: Router) { }

  ngOnInit(): void {
  }

  register(data: JSON){
    const route: string = "http://localhost:5000/api/authenticate/register";
    console.log('data here!')
    console.log(data);
    this.userService.registerUser(route, data).subscribe((result) => { 
      console.log("success!");
      //this.route.navigate(['/login']);
    },
    (error) => {console.error(error)
    });
  }
}
