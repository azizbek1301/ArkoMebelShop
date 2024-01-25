import { Component, Input, OnInit } from '@angular/core';
import { Catalog } from '../../interfaces/catalog';

@Component({
  selector: 'app-product-catalog',
  templateUrl: './product-catalog.component.html',
  styleUrl: './product-catalog.component.css'
})
export class ProductCatalogComponent {
 @Input()
 product!:Catalog
}
