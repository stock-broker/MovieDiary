import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ReviewsListingComponent } from './reviews-listing/reviews-listing.component';
import { AddUpdateReviewsComponent } from './add-update-reviews/add-update-reviews.component';
import { ReviewService } from './Services/review.service';
import { CommonModule } from '@angular/common';
import { RegistrationComponent } from './registration/registration.component';
import { LoginComponent } from './login/login.component';


@NgModule({
  declarations: [
    AppComponent,
    ReviewsListingComponent,
    AddUpdateReviewsComponent,
    RegistrationComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    CommonModule
  ],
  providers: [ReviewService],
  bootstrap: [AppComponent]
})
export class AppModule { }
