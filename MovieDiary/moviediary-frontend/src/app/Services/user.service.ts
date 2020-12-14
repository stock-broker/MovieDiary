import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaderResponse, HttpHeaders } from '@angular/common/http'; 
import { Observable, throwError } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  public registerUser = (route: string, userData: JSON) => {
    return this.http.post(route, userData);
  }
 
  public loginUser = (route: string, userData: JSON) => {

    return this.http.post(route, userData, {observe: 'response'}).subscribe(response =>{
      var bodyText = response.body;
      var jwtToken = bodyText.token;
      localStorage.setItem('jwt', jwtToken);
      console.log(jwtToken);
      console.log(bodyText);
    });
  }

  
}
