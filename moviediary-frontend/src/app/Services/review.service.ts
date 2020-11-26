import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ReviewService {
  
  constructor(private http: HttpClient){ }

  public getReviewData = (route: string) => {
    return this.http.get(route);
  }
  
  public postReviewData = (route: string, reviewData: JSON) => {
    return this.http.post(route, reviewData);
  }
}
