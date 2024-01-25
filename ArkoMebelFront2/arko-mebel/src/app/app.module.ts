import { NgModule, importProvidersFrom } from '@angular/core';
import {
  BrowserModule,
  provideClientHydration,
} from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FooterComponent } from './components/footer/footer.component';
import { KatalogComponent } from './components/katalog/katalog.component';
import { KommentariyaComponent } from './components/kommentariya/kommentariya.component';
import { KuhinniComponent } from './components/kuhinni/kuhinni.component';
import { HeaderComponent } from './components/header/header.component';
import { ProfilComponent } from './components/profil/profil.component';
import { RegistratsiyaComponent } from './components/registratsiya/registratsiya.component';
import { ReklamaComponent } from './components/reklama/reklama.component';
import { ReklamaOstiComponent } from './components/reklama-osti/reklama-osti.component';
import { VxodComponent } from './components/vxod/vxod.component';
import { ZakazComponent } from './components/zakaz/zakaz.component';
import { MehmonxonaComponent } from './components/mehmonxona/mehmonxona.component';
import { YotoqxonaComponent } from './components/yotoqxona/yotoqxona.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ProductCatalogComponent } from './katalogs/product-catalog/product-catalog.component';
import { MatCardModule } from '@angular/material/card';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { RouterOutlet } from '@angular/router';
import { AppServerModule } from './app.module.server';
import { ReactiveFormsModule } from '@angular/forms';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    KatalogComponent,
    KommentariyaComponent,
    KuhinniComponent,
    HeaderComponent,
    ProfilComponent,
    RegistratsiyaComponent,
    ReklamaComponent,
    ReklamaOstiComponent,
    VxodComponent,
    ZakazComponent,
    MehmonxonaComponent,
    YotoqxonaComponent,
    ProductCatalogComponent,
    HeaderComponent,
    ReklamaComponent,
  ],
  imports: [
    AppRoutingModule,
    BrowserAnimationsModule,
    BrowserModule,
    MatCardModule,
    CommonModule,
    HttpClientModule,
    RouterOutlet,
    //AppServerModule,
    ReactiveFormsModule,
    FormsModule
  ],
  exports: [],

  providers: [ provideClientHydration(), importProvidersFrom(HttpClientModule)],
  bootstrap: [AppComponent],
})
export class AppModule {}
