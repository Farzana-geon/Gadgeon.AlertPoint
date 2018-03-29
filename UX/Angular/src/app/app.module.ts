import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule} from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { AlertComponent } from './app/alert/alert.component';
import { HeaderComponent } from './app/header/header.component';
import { Alert } from 'selenium-webdriver';
import { AboutComponent } from './app/about/about.component';
import { ToolsComponent } from './app/tools/tools.component';
import { PageNotFoundComponent } from './app/page-not-found/page-not-found.component';
import { LoginComponent } from './app/login/login.component';

const appRoutes: Routes = [
  { path: 'alert', component: AlertComponent },
  { path: 'tools', component: ToolsComponent },
  { path: 'about', component: AboutComponent },
  { path: 'login', component: LoginComponent },
  { path: '',
    redirectTo: '/alert',
    pathMatch: 'full'
  },
  { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    AlertComponent,
    HeaderComponent,
    AboutComponent,
    ToolsComponent,
    PageNotFoundComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
