import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { SomeModel } from './SomeModel';

@Injectable({
  providedIn: 'root'
})
export class WinatmService {

  private httpHeaders=new HttpHeaders({'Content-Type':'application/json'})
  private UrlEndPoint:string='https://10.7.8.114:8080/api/winatm';


  constructor(private http:HttpClient) { 

  }
 
  getSomeModels():Observable< SomeModel[]>{
    return this.http.get<SomeModel[]>(this.UrlEndPoint);
  } 
  getSomeModelsFiltrado(value:string):Observable< SomeModel[]>{
    return this.http.get<SomeModel[]>(`${this.UrlEndPoint}/recursoFiltrado/${value}`)

  } 


}