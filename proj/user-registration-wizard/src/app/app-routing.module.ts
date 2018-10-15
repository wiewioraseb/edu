import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { SideMenuComponent } from './side-menu/side-menu.component';

@NgModule({
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule {}

export const routes: Routes = [
  { path: '', component: AppComponent },
  { path: 'test', component: SideMenuComponent }
];
