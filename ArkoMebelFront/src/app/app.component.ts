import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { NavbarComponent } from './pages/navbar/navbar.component';
import { KuhnniComponent } from './pages/kuhnni/kuhnni.component';
import { ReklamaComponent } from './pages/reklama/reklama.component';
import { ReklamaOstiComponent } from './pages/reklama-osti/reklama-osti.component';
import { KatalogComponent } from './pages/katalog/katalog.component';
import { FooterComponent } from './pages/footer/footer.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet,NavbarComponent,KuhnniComponent,ReklamaComponent,ReklamaOstiComponent,
    KatalogComponent,
    FooterComponent
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'ArkoMebelFront';
}
