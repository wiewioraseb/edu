import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MiddleSectionComponent } from './middle-section.component';
import { MainContentModule } from './main-content/main-content.module';
import { SideMenuModule } from './side-menu/side-menu.module';
import { RouterModule } from '@angular/router';
import { routes } from '../app-routing.module';
import { RedirectStateService } from '../redirect-state/redirect-state.service';

@NgModule({
  imports: [
    CommonModule,
    MainContentModule,
    SideMenuModule,
  ],
  exports: [
    MiddleSectionComponent
  ],
  declarations: [MiddleSectionComponent],
  providers: [
    RedirectStateService
  ]
})
export class MiddleSectionModule { }
