import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from '../interfaces/product';

@Injectable({
  providedIn: 'root'
})
export class ApiServiceService {

  baseUrl:string="http://localhost:5085/api/Address/";
  baseUrlBranch:string="http://localhost:5085/api/Branch/";
  baseUrlCategory:string="http://localhost:5085/api/Category/";
  baseUrlComment:string="http://localhost:5085/api/Comment/"
  baseUrlLike:string="http://localhost:5085/api/Like/";
  baseUrlOrder:string="http://localhost:5085/api/Order/";
  baseUrlPartfolio:string="http://localhost:5085/api/Parfolio/";
  baseUrlPhoto:string="http://localhost:5085/api/Photo/";
  baseUrlProduct:string="http://localhost:5085/api/Product/"
  baseUrlUser:string="http://localhost:5085/api/User/";

  constructor(private http:HttpClient) { }


  
  postAddress(data:any)
  {
    return this.http.post<any>(this.baseUrl+"CreateAddress",data)
  }
  getAllAddress()
  {
    return this.http.get<any>(this.baseUrl+"GetAllAddress");    
  }
  putAddress(data:any,id:number){
    return this.http.put<any>(this.baseUrl+"UpdateAddress?Id="+id,data)
  }
  deleteAddress(id:any){
    return this.http.delete<any>(this.baseUrl+"DeleteById?Id="+id)
  }
  getById(id:any){
    return this.http.get<any>(this.baseUrl+"GetAddressById?Id="+id)
  }


  postBranch(data:any)
  {
    return this.http.post<any>(this.baseUrlBranch+"CreateBranch",data)
  }
  getAllBranch()
  {
    return this.http.get<any>(this.baseUrlBranch+"GetAllBranch");    
  }
  putBrach(data:any,id:number){
    return this.http.put<any>(this.baseUrl+"UpdateBranchs?Id="+id,data)
  }
  deleteBranch(id:any){
    return this.http.delete<any>(this.baseUrl+"DeleteById?Id="+id)
  }
  getByIdBranch(id:any){
    return this.http.get<any>(this.baseUrl+"GetBranchById?Id="+id)
  }




  postCategory(data:any)
  {
    return this.http.post<any>(this.baseUrlBranch+"CreateCategory",data)
  }
  getAllCategory()
  {
    return this.http.get<any>(this.baseUrlBranch+"GetAllCategory");    
  }
  putCategory(data:any,id:number){
    return this.http.put<any>(this.baseUrl+"UpdateCategory?Id="+id,data)
  }
  deleteCategory(id:any){
    return this.http.delete<any>(this.baseUrl+"DeleteById?Id="+id)
  }
  getByIdCategory(id:any){
    return this.http.get<any>(this.baseUrl+"GetCategoryById?Id="+id)
  }




  postComment(data:any)
  {
    return this.http.post<any>(this.baseUrlComment+"CreateComment",data)
  }
  getAllComment()
  {
    return this.http.get<any>(this.baseUrlComment+"GetAllComment");    
  }




  postLike(data:any)
  {
    return this.http.post<any>(this.baseUrlLike+"CreateComment",data)
  }
  getAllLike()
  {
    return this.http.get<any>(this.baseUrlLike+"GetAllComment");    
  }

  


  postPartfolio(data:any)
  {
    return this.http.post<any>(this.baseUrlPartfolio+"CreatePartfolio",data)
  }
  getAllPartfolio()
  {
    return this.http.get<any>(this.baseUrlPartfolio+"GetAllPartfolio");    
  }


  postPhoto(data:any)
  {
    return this.http.post<any>(this.baseUrlPhoto+"CreatePhoto",data)
  }
  getAllPhoto()
  {
    return this.http.get<any>(this.baseUrlPhoto+"GetAllPhoto");    
  }



  postProduct(data:any)
  {
    return this.http.post<any>(this.baseUrlProduct+"CreateProduct",data)
  }
  getAllProduct():Observable<Product[]>
  {
    return this.http.get<Product[]>(this.baseUrlProduct+"GetAllProduct");   
  }

  
  postUser(data:any)
  {
    return this.http.post<any>(this.baseUrlUser+"CreateUser",data)
  }
  getAllUser()
  {
    return this.http.get<any>(this.baseUrlUser+"GetAllUser");    
  }
  putUser(data:any,id:number){
    return this.http.put<any>(this.baseUrlUser+"UpdateUser?Id="+id,data)
  }
  deleteUser(id:any){
    return this.http.delete<any>(this.baseUrlUser+"DeleteById?Id="+id)
  }
  getByIdUser(id:any){
    return this.http.get<any>(this.baseUrlUser+"GetUserById?Id="+id)
  }

}
