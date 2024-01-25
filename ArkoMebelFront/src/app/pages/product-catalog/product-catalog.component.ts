import { Component, Input } from '@angular/core';
import { Products } from '../../Asosiy/Interfaces/Products/products';

@Component({
  selector: 'app-product-catalog',
  standalone: true,
  imports: [],
  templateUrl: './product-catalog.component.html',
  styleUrl: './product-catalog.component.css'
})
export class ProductCatalogComponent {

  /**
   *
   */
  constructor() {    
  }

  @Input() product!:Products

}
