import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MainContentComponent } from './main-content.component';
import { RouterModule } from '@angular/router';
import { routes } from '../../app-routing.module';
import { LoginDetailComponent } from './login-detail/login-detail.component';
import { SelectGroupComponent } from './select-group/select-group.component';

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  declarations: [MainContentComponent, LoginDetailComponent, SelectGroupComponent],
  exports: [
    MainContentComponent
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class MainContentModule { }
