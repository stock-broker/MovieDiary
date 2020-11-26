import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http'; 
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
    return this.http.post(route, userData);
  }
}
