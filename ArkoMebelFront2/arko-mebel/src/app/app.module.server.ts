import { ApplicationRef, Injectable, NgModule } from '@angular/core';
 import { PlatformState, ServerModule } from '@angular/platform-server';

import { AppModule } from './app.module';
import { AppComponent } from './app.component';
import { CommonModule } from '@angular/common';
import { KuhinniComponent } from './components/kuhinni/kuhinni.component';
import { FooterComponent } from './components/footer/footer.component';
import { RouterOutlet } from '@angular/router';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser';
import { ApiServiceService } from './service/api.service.service';
import { AppRoutingModule } from './app-routing.module';

@NgModule({
    declarations: [],
    bootstrap: [AppComponent],
    providers: [KuhinniComponent,AppModule,ApiServiceService,RouterOutlet,CommonModule,provideClientHydration()],
    imports: [BrowserModule, AppRoutingModule, ServerModule]
})
export class AppServerModule {}



  
  
