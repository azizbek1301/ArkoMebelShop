import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Product } from "../../../interfaces/product";
import { Catalog } from "../../../interfaces/catalog";

@Injectable({
  providedIn: 'root'
})

export class KatalogService{
  constructor(private http:HttpClient){}
  baseUrl = 'http://localhost:5085/api/Category/GetAllCategory';

getAllKataloglar(){ 
    return this.http.get<Catalog[]>(this.baseUrl)
}

}