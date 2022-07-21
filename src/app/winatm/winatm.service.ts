import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { SomeModel } from './SomeModel';

@Injectable({
  providedIn: 'root'
})
export class WinatmService {

  private httpHeaders=new HttpHeaders({'Content-Type':'application/json'})
<<<<<<< Updated upstream
  private UrlEndPoint:string='https://10.7.8.114:8080/api/winatm';
=======
  private UrlEndPoint:string='http://10.7.8.114:8089/api/winatm';
>>>>>>> Stashed changes


  constructor(private http:HttpClient) {

  }

  getSomeModels():Observable< SomeModel[]>{
    return this.http.get<SomeModel[]>(this.UrlEndPoint);
  }
  getSomeModelsFiltrado(value:string):Observable< SomeModel[]>{
    return this.http.get<SomeModel[]>(`${this.UrlEndPoint}/recursoFiltrado/${value}`)

  }


}
