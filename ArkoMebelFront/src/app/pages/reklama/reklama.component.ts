import { Component } from '@angular/core';

@Component({
  selector: 'app-reklama',
  standalone: true,
  imports: [],
  templateUrl: './reklama.component.html',
  styleUrl: './reklama.component.css'
})
export class ReklamaComponent {
  images: string[] = [
    '../../../assets/reklama_carusel_1.jpg',
    '../../../assets/reklama_carusel_2.jpg',
    '../../../assets/reklama_carusel_3.jpg',
   
  ]; 

  
  visibleImages: string[] = [];
  currentIndex = 0;
  itemsPerPage = 3;

  constructor() {}

  ngOnInit(): void {
    this.updateVisibleImages();
  }

  next(): void {
    console.log("salom")
    if(this.itemsPerPage == 9){
      this.currentIndex = 3;
    }
    this.currentIndex += this.itemsPerPage;
    this.updateVisibleImages();
  }

  prev(): void {
    if(this.itemsPerPage == 0){
      this.currentIndex = 6;
    }
    this.currentIndex -= this.itemsPerPage;
    this.updateVisibleImages();
  }

  private updateVisibleImages(): void {
    this.visibleImages = this.images.slice(
      this.currentIndex,
      this.currentIndex + this.itemsPerPage
    );
  }

}
