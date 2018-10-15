import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginDetailComponent } from './middle-section/main-content/login-detail/login-detail.component';
import { SelectGroupComponent } from './middle-section/main-content/select-group/select-group.component';

@NgModule({
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule {}

export const routes: Routes = [
  { path: '', redirectTo: 'login-detail', pathMatch: 'full' },
  {
        path: 'login-detail',
        component: LoginDetailComponent
      },
      {
        path: 'select-group',
        component: SelectGroupComponent
      }
];
