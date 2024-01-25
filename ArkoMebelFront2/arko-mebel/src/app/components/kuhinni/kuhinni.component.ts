import { Component, OnInit } from '@angular/core';
import { Product } from '../../interfaces/product';
import { KatalogService } from '../../katalogs/product-catalog/katalogServices/catalog.service';
import { Catalog } from '../../interfaces/catalog';

@Component({
  selector: 'app-kuhinni',
  templateUrl: './kuhinni.component.html',
  styleUrl: './kuhinni.component.css'
})
export class KuhinniComponent implements OnInit {

  // constructor(private api:ApiServiceService){}
  constructor(private catalogService:KatalogService) {
  }
  products:Catalog[]=[]
  
  ngOnInit(): void {    
    this.catalogService.getAllKataloglar().subscribe(
      {
        next:(responce)=>{
          alert("malumot keldi")
          this.products=responce
        },
        error:()=>{
          alert("malumot kelmadi");
        }
      }
  
    )
    
  }

}
