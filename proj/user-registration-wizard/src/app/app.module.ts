import { BrowserModule } from '@angular/platform-browser';
import {CUSTOM_ELEMENTS_SCHEMA, NgModule} from '@angular/core';

import { AppComponent } from './app.component';
import { TopBarModule } from './top-bar/top-bar.module';
import { SideMenuModule } from './side-menu/side-menu.module';
import { MainContentModule } from './main-content/main-content.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    TopBarModule,
    SideMenuModule,
    MainContentModule
  ],
  providers: [],
  bootstrap: [AppComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class AppModule { }
