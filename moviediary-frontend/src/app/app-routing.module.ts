import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddUpdateReviewsComponent } from './add-update-reviews/add-update-reviews.component';
import { LoginComponent } from './login/login.component';
import { RegistrationComponent } from './registration/registration.component';
import { ReviewsListingComponent } from './reviews-listing/reviews-listing.component';

const routes: Routes = [
  {path: 'reviewEntries', component: ReviewsListingComponent },
  {path: 'addEntry', component: AddUpdateReviewsComponent},
  {path: 'registration', component: RegistrationComponent},
  {path: 'login', component: LoginComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
