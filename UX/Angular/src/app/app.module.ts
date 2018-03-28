import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule} from '@angular/forms';


import { AppComponent } from './app.component';
import { AlertComponent } from './app/alert/alert.component';
import { HeaderComponent } from './app/header/header.component';


@NgModule({
  declarations: [
    AppComponent,
    AlertComponent,
    HeaderComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
