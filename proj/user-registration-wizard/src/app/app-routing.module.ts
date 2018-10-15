import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginDetailComponent } from './middle-section/main-content/login-detail/login-detail.component';
import { SelectGroupComponent } from './middle-section/main-content/select-group/select-group.component';
import { AddAvatarComponent } from './middle-section/main-content/add-avatar/add-avatar.component';
import { FormSubmitComponent } from './middle-section/main-content/form-submit/form-submit.component';

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
  },
  {
    path: 'add-avatar',
    component: AddAvatarComponent
  },
  {
    path: 'form-submit',
    component: FormSubmitComponent
  }
];
