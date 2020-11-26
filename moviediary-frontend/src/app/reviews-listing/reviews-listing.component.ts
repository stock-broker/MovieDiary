import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ReviewModel } from './../Models/reviewModel.model';
import { ReviewService } from './../Services/review.service';

@Component({
  selector: 'app-reviews-listing',
  templateUrl: './reviews-listing.component.html',
  styleUrls: ['./reviews-listing.component.css'],
})
export class ReviewsListingComponent implements OnInit {
  public reviews!: ReviewModel[];

  constructor(private reviewService: ReviewService) {
    // this.http
    //   .get('http://localhost:5000/api/reviews')
    //   .toPromise()
    //   .then((data) => {
    //     console.log(data);
    //   });
    this.getReviews();
  }
  public getReviews = () => {
    const route: string = 'http://localhost:5000/api/reviews';
    this.reviewService.getReviewData(route).subscribe((result) => {
      this.reviews = result as ReviewModel[];
    },
    (error) => { console.error(error)
    });
  }


  ngOnInit(): void {}
}
