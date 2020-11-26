import { Component, OnInit, EventEmitter, Input, Output } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ReviewModel } from './../Models/reviewModel.model';
import { ReviewService } from './../Services/review.service';

@Component({
  selector: 'app-add-update-reviews',
  templateUrl: './add-update-reviews.component.html',
  styleUrls: ['./add-update-reviews.component.css']
})
export class AddUpdateReviewsComponent implements OnInit {
  private reviewModel! : ReviewModel;

  constructor(private reviewService: ReviewService, private route: Router) {
    

   }

  ngOnInit(): void {
   }
  
   addReview(data: JSON){
     const route: string = "http://localhost:5000/api/reviews";
    console.log(data)
    this.reviewService.postReviewData(route, data).subscribe((result) =>{
      console.log("success!");
      this.route.navigate(['/reviewEntries']);

    },
    (error) => {console.error(error)
    });
    
   }
 

  
}
