import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainContentComponent } from './middle-section/main-content/main-content.component';
import { LoginDetailComponent } from './middle-section/main-content/login-detail/login-detail.component';

@NgModule({
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule {}

export const routes: Routes = [
  { path: '', redirectTo: 'content', pathMatch: 'full' },
  { path: 'content', component: MainContentComponent, children: [
      {
        path: 'login-detail',
        component: LoginDetailComponent
      },

    ] }
];
