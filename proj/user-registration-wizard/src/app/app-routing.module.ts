import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginDetailComponent } from './middle-section/main-content/login-detail/login-detail.component';
import { SelectGroupComponent } from './middle-section/main-content/select-group/select-group.component';
import { AddAvatarComponent } from './middle-section/main-content/add-avatar/add-avatar.component';
import { FormSubmitComponent } from './middle-section/main-content/form-submit/form-submit.component';
import { NavigationStateGuard } from './guard/navigation-state/navigation-state.guard';

@NgModule({
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule {}

export const routes: Routes = [
  { path: '',
    redirectTo: 'login-detail',
    pathMatch: 'full'
  },
  {
    path: 'login-detail',
    component: LoginDetailComponent,
    canActivate: [NavigationStateGuard]
  },
  {
    path: 'select-group',
    component: SelectGroupComponent,
    canActivate: [NavigationStateGuard]
  },
  {
    path: 'add-avatar',
    component: AddAvatarComponent,
    canActivate: [NavigationStateGuard]
  },
  {
    path: 'form-submit',
    component: FormSubmitComponent,
    canActivate: [NavigationStateGuard]
  }
];
